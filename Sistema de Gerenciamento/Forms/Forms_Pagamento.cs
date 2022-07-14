using Sistema_de_Gerenciamento.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_Pagamento : Form
    {
        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private List<DadosFinanceiro> listaFinanceiro = new List<DadosFinanceiro>();

        private List<DadosNotaFiscalSaida> listaDadosNotaFiscalSaidasParcial = new List<DadosNotaFiscalSaida>();

        private List<DadosNotaFiscalSaida> listaDadosNotaFiscalSaidaCompleta = new List<DadosNotaFiscalSaida>();

        private DadosNotaFiscalSaida dadosNotaFiscalSaida;

        private DadosNotaFiscalSaida dadosNotaFiscalSaidaCompleta;

        private decimal valorBruto = 0;

        public Forms_Pagamento(decimal _valorBruto, int _notaFiscal)
        {
            InitializeComponent();

            listaFinanceiro = Buscar.BuscarListaFinanceiro();

            listaDadosNotaFiscalSaidasParcial = Buscar.BuscarListaNotaFiscalSaidaParcial(_notaFiscal);

            listaDadosNotaFiscalSaidaCompleta = Buscar.BuscarListaNotaFiscalSaidaCompleto(_notaFiscal);

            //listaDadosNotaFiscalSaidasParcial = Buscar.BuscarListaNotaFiscalSaidaParcial(Convert.ToInt32(lblNumeroNotaFiscalSaida.Text));

            valorBruto = _valorBruto;

            lblNumeroNotaFiscalSaida.Text = _notaFiscal.ToString();

            lblValorTotal.Text = string.Format("{0:C}", valorBruto);

            cmbFormaPagamento.SelectedIndex = 0;

            cmbFormaPagamento.Focus();
        }

        private void cmbFormaPagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbFormaPagamento.Text == "CARNÊ")
            {
                PagamentoCarne();
            }
            else if (cmbFormaPagamento.Text == "CRÉDITO")
            {
                PagamentoCredito();
            }
            else if (cmbFormaPagamento.Text == "DÉBITO")
            {
                PagamentoDebito();
            }
            else if (cmbFormaPagamento.Text == "DINHEIRO")
            {
                PagamentoDinheiro();
            }
            else if (cmbFormaPagamento.Text == "PIX")
            {
                PagamentoPIX();
            }
        }

        private void PagamentoCarne()
        {
            LayoutTipoPagamentoCredito(false);

            lblValorDebito.Visible = false;

            lblTituloFormaPagamento.Text = "CARNÊ";

            lblValorDesconto.Text = "R$ 0,00";
        }

        private void PagamentoCredito()
        {
            LayoutTipoPagamentoCredito(true);

            lblValorDebito.Visible = false;

            txtValorDinheiro.Visible = false;

            //lblValorParcela.Text = lblSubtotal.Text;

            lblTituloFormaPagamento.Text = "CRÉDITO";

            lblValorDesconto.Text = "R$ 0,00";

            ///////
            pnlTroco.Visible = false;

            pnlTotalRecebido.Visible = false;

            pnlQRCode.Visible = false;

            pnlChavePix.Visible = false;

            //cmbFormaPagamento.SelectedIndex = 0;

            //lblValorTotal.Text = String.Format("{0:C}", valorBruto);
        }

        private void PagamentoDebito()
        {
            LayoutTipoPagamentoCredito(false);

            lblTituloFormaPagamento.Text = "DÉBITO";

            lblValorDebito.Font = new Font("Calibri", 36);

            lblValorDebito.Font = new Font("Calibri", 36, FontStyle.Bold);

            lblValorDebito.Visible = true;

            //lblValorDebito.Location = new Point(90, 45);

            ///////

            pnlTroco.Visible = false;

            pnlTotalRecebido.Visible = false;

            pnlQRCode.Visible = false;

            pnlChavePix.Visible = false;

            lblValorDebito.Text = lblValorTotal.Text;

            PagamentoComDescontos();

            //lblValorTotal.Text = String.Format("{0:C}", valorBruto - (valorBruto * listaDadosFinanceiro[0].descontoAvista / 100));

            //lblValorDebito.Text = String.Format("{0:C}", valorBruto - (valorBruto * listaDadosFinanceiro[0].descontoAvista / 100));

            //lblValorDesconto.Text = String.Format("{0:C}", (valorBruto * listaDadosFinanceiro[0].descontoAvista / 100));
        }

        private void PagamentoDinheiro()
        {
            LayoutTipoPagamentoCredito(false);

            lblTituloFormaPagamento.Text = "DINHEIRO";

            lblValorDebito.Visible = false;

            txtValorDinheiro.Visible = true;

            ///////
            pnlTroco.Visible = true;

            pnlTotalRecebido.Visible = true;

            pnlQRCode.Visible = false;

            pnlChavePix.Visible = false;

            PagamentoComDescontos();
        }

        private void PagamentoPIX()
        {
            lblTituloFormaPagamento.Text = "PIX";

            //pcbPix.Image = Buscar.BuscarQrCodePix(1);

            lblValorDebito.Visible = true;

            //lblValorDebito.Font = new Font("Calibri", 28, FontStyle.Bold);

            //lblValorDebito.Location = new Point(40, 45);

            //lblValorDebito.Text = Buscar.BuscarChavePix();

            txtValorDinheiro.Visible = false;

            ///////
            ///

            pnlTroco.Visible = false;

            pnlTotalRecebido.Visible = false;

            pnlQRCode.Visible = true;

            pnlQRCode.BackgroundImage = Buscar.BuscarQrCodePix(1);

            pnlChavePix.Visible = true;

            lblChavePix.Text = Buscar.BuscarChavePix();

            PagamentoComDescontos();

            lblValorDebito.Text = lblValorTotal.Text;

            //pcbPix.Visible = true;

            //lblValorDesconto.Text = String.Format("{0:C}", (valorBruto * listaDadosFinanceiro[0].descontoAvista / 100));

            //lblValorTotal.Text = String.Format("{0:C}", valorBruto - (valorBruto * listaDadosFinanceiro[0].descontoAvista / 100));
        }

        private void PagamentoComDescontos()
        {
            lblValorDesconto.Text = String.Format("{0:C}", (valorBruto * listaFinanceiro[0].descontoAvista / 100));

            lblValorTotal.Text = String.Format("{0:C}", valorBruto - (valorBruto * listaFinanceiro[0].descontoAvista / 100));
        }

        private void LayoutTipoPagamentoCredito(bool _ativa)
        {
            //pcbPix.Visible = false;
            lblParcelas.Visible = _ativa;
            cmbParcelas.Visible = _ativa;
            lblTituloJuros.Visible = _ativa;
            lblValorJuros.Visible = _ativa;
            lblTituloValorParcela.Visible = _ativa;
            lblValorParcela.Visible = _ativa;
            txtValorDinheiro.Visible = _ativa;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Forms_Pagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Esc para finalizar
            {
                this.Close();
            }
        }

        private void cmbParcelas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbParcelas.Text.Replace("x", "")) >= listaFinanceiro[0].parcelasCredito)
            {
                lblValorJuros.Text = listaFinanceiro[0].jurosCredito.ToString();

                lblValorTotal.Text = string.Format("{0:C}", listaFinanceiro[0].jurosCredito * valorBruto / 100 + valorBruto);

                lblValorParcela.Text = String.Format("{0:C}", Convert.ToDecimal(lblValorTotal.Text.Replace("R$", "")) / Convert.ToDecimal(cmbParcelas.Text.Replace("x", "")));
            }
            else
            {
                lblValorTotal.Text = string.Format("{0:C}", valorBruto);

                lblValorParcela.Text = String.Format("{0:C}", Convert.ToDecimal(lblValorTotal.Text.Replace("R$", "")) / Convert.ToDecimal(cmbParcelas.Text.Replace("x", "")));

                lblValorJuros.Text = "0,00%";
            }
        }

        private void txtValorDinheiro_TextChange(object sender, EventArgs e)
        {
            lblTotalRecebido.Text = txtValorDinheiro.Text;
            try
            {
                lblTroco.Text = String.Format("{0:C}", (Convert.ToDecimal(txtValorDinheiro.Text.Replace("R$", "")) - Convert.ToDecimal(lblValorTotal.Text.Replace("R$", ""))));
            }
            catch (Exception)
            {
            }
        }

        private void txtValorDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoDinheiro(e, sender, txtValorDinheiro);
            }
        }

        private void Forms_Pagamento_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            dadosNotaFiscalSaidaCompleta = listaDadosNotaFiscalSaidaCompleta.Find(x => x.numeroNF.ToString().StartsWith(lblNumeroNotaFiscalSaida.Text));

            //Salvar.NotaFiscalSaida(dadosNotaFiscalSaidaCompleta.cpf, dadosNotaFiscalSaidaCompleta.numeroNF,
            //    "codigo do produto", dadosNotaFiscalSaidaCompleta.descricao,
            //    dadosNotaFiscalSaidaCompleta.quantidade, dadosNotaFiscalSaidaCompleta.valorUnitario,
            //    dadosNotaFiscalSaidaCompleta.emissao, "codigo de barras", dadosNotaFiscalSaidaCompleta.vendedor,
            //    dadosNotaFiscalSaidaCompleta.validadeTroca, dadosNotaFiscalSaidaCompleta.nomeCliente,
            //    dadosNotaFiscalSaidaCompleta.tipoPagamento, dadosNotaFiscalSaidaCompleta.valorDesconto,
            //    dadosNotaFiscalSaidaCompleta.quantidadeParcelas, dadosNotaFiscalSaidaCompleta.valorJuros,
            //    dadosNotaFiscalSaidaCompleta.valorPago, dadosNotaFiscalSaidaCompleta.unidade, dadosNotaFiscalSaidaCompleta.status,
            //    Global.NomeDeUsuario);
        }
    }
}