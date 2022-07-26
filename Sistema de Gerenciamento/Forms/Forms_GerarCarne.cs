using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gerenciamento.Classes;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_GerarCarne : Form
    {
        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private List<DadosFinanceiro> listaFinanceiro = new List<DadosFinanceiro>();

        private List<DadosNotaFiscalSaida> listaDadosNotaFiscalSaidaCompleta = new List<DadosNotaFiscalSaida>();

        private decimal valorBruto = 0;

        public Forms_Venda forms;

        private List<DadosCliente> listaDadosCliente = new List<DadosCliente>();

        public Forms_GerarCarne(Forms_Venda _forms)
        {
            InitializeComponent();

            listaFinanceiro = Buscar.BuscarListaFinanceiro();

            DadosDoCarneParaPreenchimentoTextBox();

            forms = _forms;

            cmbParcelaCarne.SelectedIndex = 0;
        }

        public Forms_GerarCarne(List<DadosNotaFiscalSaida> _listaNotaFiscalSaida, decimal _valorBruto,
            int _indexCmbParcela)
        {
            InitializeComponent();

            listaDadosNotaFiscalSaidaCompleta = _listaNotaFiscalSaida;

            valorBruto = _valorBruto;

            listaFinanceiro = Buscar.BuscarListaFinanceiro();

            DadosDoCarneParaPreenchimentoTextBox();

            cmbParcelaCarne.SelectedIndex = _indexCmbParcela;

            cmbCliente.Text = listaDadosNotaFiscalSaidaCompleta[0].nomeCliente;

            PreencherListaDadosClientes();
        }

        private void PreencherListaDadosClientes()
        {
            listaDadosCliente = Buscar.BuscarListaDadosCleinte();
        }

        private void DadosDoCarneParaPreenchimentoTextBox()
        {
            try
            {
                txtPrazo.Text = listaFinanceiro[0].prazoCarne.ToString();

                txtParcelasQueGeramJuros.Text = listaFinanceiro[0].parcelasCarne.ToString();

                txtPrimeiraParcela.Text = DateTime.Today.AddDays(Convert.ToDouble(txtPrazo.Text)).ToShortDateString();
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarDadosParaPreencherTextBox(ex);
            }
        }

        public Forms_GerarCarne()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbParcelaCarne_SelectedValueChanged(object sender, EventArgs e)
        {
            CalcularJuros();

            PreencherGridview();
        }

        private void PreencherGridview()
        {
            gdvGerarCarne.Rows.Clear();

            int dias = 30;

            int numeroNFSaida = Buscar.BuscarNumeroNotaFiscalSaida();

            for (int quantParcelas = 1; quantParcelas <= Convert.ToInt32(cmbParcelaCarne.Text.Replace("x", "")); quantParcelas++)
            {
                gdvGerarCarne.ColumnCount = 4;

                var rows = new List<string[]>();
                string[] row1 = new string[] { numeroNFSaida.ToString(),
                    (cmbParcelaCarne.Text.Replace("x","") +"/" + quantParcelas),
                    txtValorParcelaCarne.Text,
                    (Convert.ToDateTime(txtPrimeiraParcela.Text).AddDays(dias * quantParcelas)).ToShortDateString()};
                rows.Add(row1);

                foreach (string[] item in rows)
                {
                    gdvGerarCarne.Rows.Add(item);
                }
            }
        }

        private void CalcularJuros()
        {
            try
            {
                if (Convert.ToInt32(cmbParcelaCarne.Text.Replace("x", "")) > Convert.ToInt32(txtParcelasQueGeramJuros.Text))
                {
                    txtJurosCarne.Text = string.Format("{0:P}", listaFinanceiro[0].jurosCarne / 100).ToString();

                    txtValorTotalCarne.Text = string.Format("{0:C}", (Convert.ToDecimal(txtJurosCarne.Text.Replace("%", "")) *
                                                                        valorBruto / 100) +
                                                                     valorBruto).ToString();

                    txtValorParcelaCarne.Text = string.Format("{0:C}",
                        (Convert.ToDecimal(txtValorTotalCarne.Text.Replace("R$ ", "")) /
                         Convert.ToDecimal(cmbParcelaCarne.Text.Replace("x", "")))).ToString();
                }
                else
                {
                    txtJurosCarne.Text = string.Format("{0:P}", "0,00%");

                    txtValorTotalCarne.Text = string.Format("{0:C}", (Convert.ToDecimal(txtJurosCarne.Text.Replace("%", "")) *
                                                                        valorBruto / 100) +
                                                                     valorBruto).ToString();

                    txtValorParcelaCarne.Text = string.Format("{0:C}",
                        (Convert.ToDecimal(txtValorTotalCarne.Text.Replace("R$ ", "")) /
                         Convert.ToDecimal(cmbParcelaCarne.Text.Replace("x", "")))).ToString();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarJurosGerarCarne(ex);
            }
        }

        private void btnGerarCarne_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtSaldo.Text.Replace("R$", "")) > Convert.ToDecimal(txtValorTotalCarne.Text.Replace("R$", ""))
                && txtStatus.Text == "Liberado")
            {
                decimal saldo = Buscar.SaldoDisponivelCliente(listaDadosNotaFiscalSaidaCompleta[0].cpf);

                saldo -= Convert.ToDecimal(txtValorTotalCarne.Text.Replace("R$", ""));

                Atualizar.AtualizarSaldoCliente(saldo, listaDadosNotaFiscalSaidaCompleta[0].cpf);

                int NumermoNotaFiscal = Convert.ToInt32(Buscar.BuscarNumeroNotaFiscalSaida());

                foreach (DadosNotaFiscalSaida item in listaDadosNotaFiscalSaidaCompleta)
                {
                    if (txtJurosCarne.Text == "0,00%")
                    {
                        //Pagamento normal
                        Salvar.NotaFiscalSaida(item.cpf, NumermoNotaFiscal, item.codigoProduto,
                        item.descricao, item.quantidade, item.valorUnitario, item.emissao, item.codigoBarras, item.vendedor,
                        item.validadeTroca, item.nomeCliente, "CARNÊ", item.valorDesconto,
                        Convert.ToInt32(cmbParcelaCarne.Text.Replace("x", "")), item.valorJuros, item.valorPago, item.unidade, item.status, item.trocarVendedor,
                        item.motivoTroca, item.nfEntrada);

                        Atualizar.AtualizarQuantidadeEstoquePosVenda(item.quantidade, item.codigoBarras, item.numeroNF);
                    }
                    else if (txtJurosCarne.Text != "0,00%")
                    {
                        //Pagamento com Juros
                        Salvar.NotaFiscalSaida(item.cpf, NumermoNotaFiscal, item.codigoProduto,
                        item.descricao, item.quantidade, item.valorUnitario + (item.valorUnitario * listaFinanceiro[0].jurosCredito / 100),
                        item.emissao, item.codigoBarras, item.vendedor, item.validadeTroca, item.nomeCliente, "CARNÊ",
                        item.valorDesconto, Convert.ToInt32(cmbParcelaCarne.Text.Replace("x", "")),
                        Convert.ToDecimal(txtValorTotalCarne.Text.Replace("R$", "")) - item.valorUnitario,
                        Convert.ToDecimal(txtValorTotalCarne.Text.Replace("R$", "")), item.unidade, item.status,
                        item.trocarVendedor, item.motivoTroca, item.nfEntrada);

                        Atualizar.AtualizarQuantidadeEstoquePosVenda(item.quantidade, item.codigoBarras, item.numeroNF);
                    }
                }
                for (int i = 1; i <= Convert.ToInt32(cmbParcelaCarne.Text.Replace("x", "")); i++)
                {
                    Salvar.AdicionarPagamentoCarner(NumermoNotaFiscal, txtCpfCnpjCliente.Text, cmbCliente.Text,
                    DateTime.Now, Global.NomeDeUsuario, ($"{cmbParcelaCarne.Text.Replace("x", "")}/{i}"), 0,
                    (Convert.ToDecimal(txtValorTotalCarne.Text.Replace("R$", "")) - valorBruto) / Convert.ToInt32(cmbParcelaCarne.Text.Replace("x", "")),
                    Convert.ToDecimal(txtValorTotalCarne.Text.Replace("R$", "")),
                    DateTime.Today.AddDays((listaFinanceiro[0].prazoCarne) * i), "-", "Nao Pago",
                    Convert.ToDecimal(txtValorParcelaCarne.Text.Replace("R$", "")));
                }

                AvisoCantoInferiorDireito.Confirmao();

                btnGerarCarne.Enabled = false;
            }
            else
            {
                MessageBox.Show("Saldo Disponivel Inferior Ao Solicitado/Cliente Com Pendencia Financeira!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarDadosCliente()
        {
            List<DadosCliente> listaCliente = Buscar.BuscarClientePorPesquisaCompleta(cmbCliente.Text);

            if (listaCliente.Count != 0)
            {
                foreach (DadosCliente variable in listaCliente)
                {
                    txtCodigoCliente.Text = variable.id.ToString();
                    txtCpfCnpjCliente.Text = variable.cpfCpnjCliente;
                    txtCredito.Text = string.Format("{0:c}", variable.credito);
                    txtSaldo.Text = string.Format("{0:c}", variable.saldo);
                    txtStatus.Text = variable.status;
                }
            }
            else
            {
                txtCodigoCliente.Text = string.Empty;
            }

            if (cmbCliente.Text == string.Empty)
            {
                txtCodigoCliente.Text = string.Empty;
            }
        }

        private void cmbCliente_KeyUp(object sender, KeyEventArgs e)
        {
            //BuscarDadosCliente();
        }

        private void cmbCliente_Enter(object sender, EventArgs e)
        {
            PreencherListaClientes();
        }

        private void PreencherListaClientes()
        {
            cmbCliente.MaxLength = 50;

            cmbCliente.Items.Clear();

            foreach (string item in Buscar.BuscarListaCliente())
            {
                cmbCliente.Items.Add(item);
            }
        }

        private void cmbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetras(e);
        }

        private void cmbCliente_TextChanged(object sender, EventArgs e)
        {
            BuscarDadosCliente();
        }
    }
}