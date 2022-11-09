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
using System.IO;
using DevExpress.CodeParser;

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

        private List<DadosCliente> listaDadosCliente = new List<DadosCliente>();

        public Forms_PDV forms_PDV;

        private int NumermoNotaFiscal;

        private decimal valorBruto = 0;

        private decimal comissaoPorProduto;

        private DateTime dataVencimento;

        public Forms_GerarCarne(List<DadosNotaFiscalSaida> _listaNotaFiscalSaida, decimal _valorBruto, int _indexCmbParcela)
        {
            InitializeComponent();

            PreencherDados(_listaNotaFiscalSaida, _valorBruto);
            DadosParaPreenchimentoTextBox();

            cmbParcelaCarne.SelectedIndex = _indexCmbParcela;
            HabilitarBotaoConfirmarVenda();
        }

        public Forms_GerarCarne(List<DadosNotaFiscalSaida> _listaNotaFiscalSaida, decimal _valorBruto, int _indexCmbParcela, Forms_PDV _forms_PDV)
        {
            InitializeComponent();

            PreencherDados(_listaNotaFiscalSaida, _valorBruto);
            DadosParaPreenchimentoTextBox();
            forms_PDV = _forms_PDV;
            cmbParcelaCarne.SelectedIndex = _indexCmbParcela;
            HabilitarBotaoConfirmarVenda();
        }

        private void Forms_GerarCarne_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10 && btnGerarCarne.Enabled == true)
            {
                ConfirmarVenda();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
        }

        private void btnGerarCarne_Click(object sender, EventArgs e)
        {
            ConfirmarVenda();
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

        private void cmbCliente_Enter(object sender, EventArgs e)
        {
            PreencherListaClientes();
        }

        private void cmbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetras(e);
        }

        private void cmbCliente_TextChanged(object sender, EventArgs e)
        {
            BuscarDadosCliente();

            if (cmbCliente.Text == string.Empty)
            {
                txtCodigoCliente.Text = string.Empty;
            }
        }

        private void PreencherDados(List<DadosNotaFiscalSaida> _listaNotaFiscalSaida, decimal _valorBruto)
        {
            listaDadosCliente = Buscar.BuscarListaDadosCleinte();
            listaFinanceiro = Buscar.BuscarListaDadosFinanceiro();
            listaDadosNotaFiscalSaidaCompleta = _listaNotaFiscalSaida;
            valorBruto = _valorBruto;
        }

        private string BuscandoNomeCliente()
        {
            string NomeCliente = string.Empty;

            for (int i = 0; i < listaDadosNotaFiscalSaidaCompleta.Count; i++)
            {
                if (listaDadosNotaFiscalSaidaCompleta[i].nomeCliente != "CLIENTE")
                {
                    NomeCliente = listaDadosNotaFiscalSaidaCompleta[i].nomeCliente;

                    return NomeCliente;
                }
            }

            NomeCliente = "CLIENTE";

            return NomeCliente;
        }

        private void HabilitarBotaoConfirmarVenda()
        {
            if (cmbCliente.Text == "CLIENTE" || cmbCliente.Text == "")
            {
                btnGerarCarne.Enabled = false;
            }
            else
            {
                btnGerarCarne.Enabled = true;
            }
        }

        private void DadosParaPreenchimentoTextBox()
        {
            try
            {
                string prazo = listaFinanceiro[0].prazoCarne.ToString();
                DateTime dataPrimeiraParcela = DateTime.Today.AddDays(listaFinanceiro[0].prazoCarne);

                dataVencimento = dataPrimeiraParcela;

                dataPrimeiraParcela = VerificarDiaPagamento(dataPrimeiraParcela);

                txtPrimeiraParcela.Text = dataPrimeiraParcela.ToShortDateString();

                txtPrazo.Text = prazo;

                NumermoNotaFiscal = Convert.ToInt32(Buscar.BuscarNumeroNotaFiscalSaida());

                cmbCliente.Text = BuscandoNomeCliente();
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarDadosParaPreencherTextBox(ex);
            }
        }

        private void PreencherGridview()
        {
            try
            {
                int dias = 30;
                int numeroNFSaida = Buscar.BuscarNumeroNotaFiscalSaida();
                string valorParcelaCarne = txtValorParcelaCarne.Text;
                int qtdParcelasTotal = Convert.ToInt32(cmbParcelaCarne.Text.Replace("x", ""));
                dataVencimento = DateTime.Today.AddDays(listaFinanceiro[0].prazoCarne);

                gdvGerarCarne.Rows.Clear();

                for (int quantParcelas = 1; quantParcelas <= qtdParcelasTotal; quantParcelas++)
                {
                    dataVencimento = VerificarDiaPagamento(dataVencimento);

                    gdvGerarCarne.ColumnCount = 4;

                    var rows = new List<string[]>();
                    string[] row1 = new string[] { numeroNFSaida.ToString(), (qtdParcelasTotal + "/" + quantParcelas), valorParcelaCarne, dataVencimento.ToShortDateString() };

                    gdvGerarCarne.Rows.Add(row1);

                    dataVencimento = dataVencimento.AddDays(dias);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoPreencherGridGerarCarne(ex);
            }
        }

        private void CalcularJuros()
        {
            try
            {
                int qtdParcelas = Convert.ToInt32(cmbParcelaCarne.Text.Replace("x", ""));
                int qtdParcelasQueGeramJuros = listaFinanceiro[0].parcelasCarne;

                if (qtdParcelas > qtdParcelasQueGeramJuros)
                {
                    ComJuros();
                }
                else
                {
                    SemJuros();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarJurosGerarCarne(ex);
            }
        }

        private void ComJuros()
        {
            decimal valorJuros = listaFinanceiro[0].jurosCarne / 100;

            txtJurosCarne.Text = string.Format("{0:P}", valorJuros);
            txtValorTotalCarne.Text = string.Format("{0:C}", CalcularValorCarne());
            txtValorParcelaCarne.Text = string.Format("{0:C}", CalcularValorParcela());
        }

        private void SemJuros()
        {
            txtJurosCarne.Text = "0,00%";
            txtValorTotalCarne.Text = string.Format("{0:C}", CalcularValorCarne());
            txtValorParcelaCarne.Text = string.Format("{0:C}", CalcularValorParcela());
        }

        private decimal CalcularValorCarne()
        {
            decimal JurosCarne = Convert.ToDecimal(txtJurosCarne.Text.Replace("%", ""));
            decimal valorTotalCarne = (JurosCarne * valorBruto / 100) + valorBruto;

            return valorTotalCarne;
        }

        private decimal CalcularValorParcela()
        {
            decimal valorTotalCarne = Convert.ToDecimal(txtValorTotalCarne.Text.Replace("R$ ", ""));
            decimal parcelaCarne = Convert.ToDecimal(cmbParcelaCarne.Text.Replace("x", ""));
            decimal valorParcela = valorTotalCarne / parcelaCarne;

            return valorParcela;
        }

        private void ConfirmarVenda()
        {
            try
            {
                decimal valorTotalCarne = Convert.ToDecimal(txtValorTotalCarne.Text.Replace("R$", ""));
                decimal valorSaldo = Convert.ToDecimal(txtSaldo.Text.Replace("R$", ""));
                int qtdParcelasCarne = Convert.ToInt32(cmbParcelaCarne.Text.Replace("x", ""));
                string cpf = listaDadosNotaFiscalSaidaCompleta[0].cpf;

                if (valorSaldo >= valorTotalCarne && txtStatus.Text == "Liberado")
                {
                    SaldoCliente(cpf, valorTotalCarne);

                    foreach (DadosNotaFiscalSaida item in listaDadosNotaFiscalSaidaCompleta)
                    {
                        InserindoJuros(item);

                        Atualizar.AtualizarQuantidadeEstoquePosVenda(item.quantidade, item.codigoBarras, item.numeroNF);

                        CalcularComissaoPorProduto(item.codigoProduto, item.valorUnitario);
                    }

                    AdicinandoPagamento(qtdParcelasCarne);

                    InserirComissao();

                    ComponentesFormsPDV();

                    btnGerarCarne.Enabled = false;

                    AvisoCantoInferiorDireito.Confirmacao();
                }
                else
                {
                    MessageBox.Show("SaldoCliente Disponivel Inferior Ao Solicitado/Cliente Com Pendencia Financeira!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoConfirmarVendaGerarCarne(ex);
            }
        }

        private void InserindoJuros(DadosNotaFiscalSaida _item)
        {
            if (txtJurosCarne.Text == "0,00%")
            {
                AdicionarNaTabelaNotaFiscalSaidaPagamentoSemJuros(_item);
            }
            else
            {
                AdicionarNaTabelaNotaFiscalSaidaPagamentoComJuros(_item);
            }
        }

        private void AdicinandoPagamento(int _qtdParcelasCarne)
        {
            for (int i = 1; i <= _qtdParcelasCarne; i++)
            {
                AdicinandoPagamentoCarner(i, dataVencimento);

                dataVencimento = dataVencimento.AddDays((30 * i));

                VerificarDiaPagamento(dataVencimento);

                AtualizarImagemStatusPagamentoCarne(i);
            }
        }

        private void SaldoCliente(string _cpf, decimal _valorTotalCarne)
        {
            decimal saldo = Buscar.SaldoDisponivelCliente(_cpf);

            saldo -= _valorTotalCarne;

            Atualizar.AtualizarSaldoCliente(saldo, _cpf);
        }

        private void InserirComissao()
        {
            if (btnGerarCarne.Enabled == false)
            {
                decimal valorComissao = CalcularComissaoGeral() + comissaoPorProduto;

                Atualizar.AtualizarComissaoDiariamente(valorComissao, Global.NomeDeUsuario);

                comissaoPorProduto = 0;
            }
        }

        private void CalcularComissaoPorProduto(int _codigoProduto, decimal _valorProduto)
        {
            decimal porcentagemComissaoPorproduto = Buscar.BuscarValorComissaoPorProduto(_codigoProduto);

            comissaoPorProduto += porcentagemComissaoPorproduto * _valorProduto / 100;
        }

        private decimal CalcularComissaoGeral()
        {
            decimal porcentagemComissaoGeral = Buscar.BuscarPorcentagemComissao();

            decimal comissaoGeral = porcentagemComissaoGeral * valorBruto / 100;

            return comissaoGeral;
        }

        private void AdicionarNaTabelaNotaFiscalSaidaPagamentoSemJuros(DadosNotaFiscalSaida item)
        {
            decimal valorPago = item.valorPago;
            int qtdParcelas = item.quantidadeParcelas;

            SalvarNotaFiscal(item, valorPago, qtdParcelas);
        }

        private void AdicionarNaTabelaNotaFiscalSaidaPagamentoComJuros(DadosNotaFiscalSaida item)
        {
            decimal valorPago = item.valorUnitario + item.valorJuros;
            int qtdParcelas = Convert.ToInt32(cmbParcelaCarne.Text.Replace("x", ""));

            SalvarNotaFiscal(item, valorPago, qtdParcelas);
        }

        private void SalvarNotaFiscal(DadosNotaFiscalSaida item, decimal _valorPago, int _qtdParcelas)
        {
            Salvar.NotaFiscalSaida(item.cpf, NumermoNotaFiscal, item.codigoProduto, item.descricao, item.quantidade, item.valorUnitario,
                item.emissao, item.codigoBarras, item.vendedor, item.validadeTroca, item.nomeCliente, "CARNÊ",
                item.valorDesconto, _qtdParcelas, item.valorJuros, _valorPago, item.unidade, item.status, item.trocarVendedor,
                item.motivoTroca, item.nfEntrada);
        }

        private void AdicinandoPagamentoCarner(int i, DateTime _dataVencimento)
        {
            int numeroNotaFiscal = NumermoNotaFiscal;
            string qtdParcela = cmbParcelaCarne.Text.Replace("x", "");
            string cliente = cmbCliente.Text;
            string CpfCnpj = txtCpfCnpjCliente.Text;
            string nomeVendedor = Global.NomeDeUsuario;
            string pagamentoVendedor = "-";
            string status = "Nao Pago";
            decimal valorDesconto = 0;
            decimal valorTotalCarne = Convert.ToDecimal(txtValorTotalCarne.Text.Replace("R$", ""));
            decimal valorJuros = (valorTotalCarne - valorBruto) / Convert.ToInt32(qtdParcela);
            decimal valorParcela = Convert.ToDecimal(txtValorParcelaCarne.Text.Replace("R$", ""));
            DateTime emissao = DateTime.Now;

            Salvar.AdicionarPagamentoCarner(numeroNotaFiscal, CpfCnpj, cliente, emissao, nomeVendedor, ($"{qtdParcela}/{i}"), valorDesconto,
                valorJuros, valorTotalCarne, _dataVencimento, pagamentoVendedor, status, valorParcela);
        }

        private DateTime VerificarDiaPagamento(DateTime _dataVencimento)
        {
            DateTime data = _dataVencimento;

            if (data.DayOfWeek == DayOfWeek.Saturday)
            {
                _dataVencimento = _dataVencimento.AddDays(2);
            }
            else if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                _dataVencimento = _dataVencimento.AddDays(1);
            }

            _dataVencimento = VerificarDiasFeriados(_dataVencimento);

            return _dataVencimento;
        }

        private DateTime VerificarDiasFeriados(DateTime _dataParcela)
        {
            const string filePath = @"C:\Users\israe\Documents\@GitHub Projetos\Sistema-de-Gerenciamento\FeriadosNacionais.txt";

            string[] data = File.ReadAllLines(filePath);

            foreach (var item in data)
            {
                if (item == _dataParcela.ToShortDateString())
                {
                    _dataParcela = _dataParcela.AddDays(1);

                    return _dataParcela;
                }
            }

            return _dataParcela;
        }

        private void AtualizarImagemStatusPagamentoCarne(int i)
        {
            string qtdParcelas = cmbParcelaCarne.Text.Replace("x", "");

            Atualizar.AtualizarImagemStatusPagamentoNotaFiscalSaida(pcbStatusPagamento.Image, NumermoNotaFiscal, ($"{qtdParcelas}/{i}"));
        }

        private void ComponentesFormsPDV()
        {
            if (forms_PDV != null)
            {
                forms_PDV.pnlVendaFinalizada.Visible = true;
                forms_PDV.vendaFinalizada = true;
                forms_PDV.lblDescricaoItem.Text = "Nº NOTA FISCAL:";
                forms_PDV.lblNumeroNotaFiscalSaida.Text = NumermoNotaFiscal.ToString();
                forms_PDV.lblNumeroNotaFiscalSaida.Visible = true;
            }
        }

        private void BuscarDadosCliente()
        {
            List<DadosCliente> listaCliente = Buscar.BuscarClientePorPesquisaCompleta(cmbCliente.Text);

            if (listaCliente.Count != 0)
            {
                foreach (DadosCliente item in listaCliente)
                {
                    txtCodigoCliente.Text = item.id.ToString();
                    txtCpfCnpjCliente.Text = item.cpfCpnjCliente;
                    txtCredito.Text = string.Format("{0:c}", item.credito);
                    txtSaldo.Text = string.Format("{0:c}", item.saldo);
                    txtStatus.Text = item.status;

                    HabilitarBotaoConfirmarVenda();
                }
            }
            else
            {
                txtCodigoCliente.Text = string.Empty;
            }
        }

        private void PreencherListaClientes()
        {
            cmbCliente.Items.Clear();

            foreach (string item in Buscar.BuscarListaCliente())
            {
                cmbCliente.Items.Add(item);
            }
        }

      
    }
}