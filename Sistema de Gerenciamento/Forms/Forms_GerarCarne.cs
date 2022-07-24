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

        public Forms_Venda forms;

        public Forms_GerarCarne(Forms_Venda _forms)
        {
            InitializeComponent();

            listaFinanceiro = Buscar.BuscarListaFinanceiro();

            DadosDoCarneParaPreenchimentoTextBox();

            forms = _forms;

            cmbParcelaCarne.SelectedIndex = 0;
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

        #region Preencher GridView

        private void PreencherGridview()
        {
            gdvGerarCarne.Rows.Clear();

            int dias = 30;

            for (int quantParcelas = 1; quantParcelas <= Convert.ToInt32(cmbParcelaCarne.Text.Replace("x", "")); quantParcelas++)
            {
                gdvGerarCarne.ColumnCount = 4;

                var rows = new List<string[]>();
                string[] row1 = new string[] { forms.txtNumeroNF.Text,
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

        #endregion Preencher GridView

        private void CalcularJuros()
        {
            try
            {
                if (Convert.ToInt32(cmbParcelaCarne.Text.Replace("x", "")) > Convert.ToInt32(txtParcelasQueGeramJuros.Text))
                {
                    txtJurosCarne.Text = string.Format("{0:P}", listaFinanceiro[0].jurosCarne / 100).ToString();

                    txtValorTotalCarne.Text = string.Format("{0:C}", (Convert.ToDecimal(txtJurosCarne.Text.Replace("%", "")) *
                                                                         Convert.ToDecimal(forms.lblValorTotal.Text.Replace("R$ ", "")) / 100) +
                                                                     Convert.ToDecimal(forms.lblValorTotal.Text.Replace("R$ ", ""))).ToString();

                    txtValorParcelaCarne.Text = string.Format("{0:C}",
                        (Convert.ToDecimal(txtValorTotalCarne.Text.Replace("R$ ", "")) /
                         Convert.ToDecimal(cmbParcelaCarne.Text.Replace("x", "")))).ToString();
                }
                else
                {
                    txtJurosCarne.Text = string.Format("{0:P}", "0,00%");

                    txtValorTotalCarne.Text = string.Format("{0:C}", (Convert.ToDecimal(txtJurosCarne.Text.Replace("%", "")) *
                                                                         Convert.ToDecimal(forms.lblValorTotal.Text.Replace("R$ ", "")) / 100) +
                                                                     Convert.ToDecimal(forms.lblValorTotal.Text.Replace("R$ ", ""))).ToString();

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
            decimal saldo = Buscar.SaldoDisponivelCliente(forms.txtCpfCnpjCliente.Text);

            saldo -= Convert.ToDecimal(txtValorTotalCarne.Text.Replace("R$", ""));

            Atualizar.AtualizarSaldoCliente(saldo, forms.txtCpfCnpjCliente.Text);

            int NumermoNotaFiscal = Convert.ToInt32(Buscar.BuscarNumeroNotaFiscalSaida());

            foreach (DadosNotaFiscalSaida item in forms.listaDadosNotaFiscalSaidaCompleta)
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
        }
    }
}