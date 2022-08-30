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
    public partial class Forms_EditarPagamentoAReceber : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private List<DadosFinanceiro> dadosFinanceiro = new List<DadosFinanceiro>();

        private Forms_PesquisarContasAReceber forms_PesquisarContasAReceber;

        private decimal multaAtraso;
        private decimal jurosAtraso;
        private int QuantidadeDiasAtraso;
        private string numeroNotaFiscal = string.Empty;
        private string CpfCnpjCliente = string.Empty;
        private string nomeCliente = string.Empty;
        private string dataEmeissao = string.Empty;
        private string quantidadeParcelas = string.Empty;
        private string valorTotal = string.Empty;
        private string vencimento = string.Empty;
        private string statusPagamento = string.Empty;
        private string valorParcela = string.Empty;

        public Forms_EditarPagamentoAReceber()
        {
            InitializeComponent();
        }

        public Forms_EditarPagamentoAReceber(Forms_PesquisarContasAReceber _forms_PesquisarContasAReceber)
        {
            InitializeComponent();

            forms_PesquisarContasAReceber = _forms_PesquisarContasAReceber;

            PegarDadosGridView();

            txtDataPagamento.Text = DateTime.Today.ToShortDateString();
        }

        private void dtpPagamento_ValueChanged(object sender, EventArgs e)
        {
            txtDataPagamento.Text = dtpPagamento.Value.ToShortDateString();
        }

        private void btnConfirmarPagamento_Click(object sender, EventArgs e)
        {
            ConfirmarRecebimentoPagamento();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void chbPago_CheckedChanged(object sender, EventArgs e)
        {
            if (lblStatusPagamento.Text == "Nao Pago")
            {
                if (chbPago.Checked == true)
                {
                    CalcularValorAReceber();

                    btnConfirmarPagamento.Enabled = true;
                }
                else
                {
                    btnConfirmarPagamento.Enabled = false;
                }
            }
            else
            {
                btnConfirmarPagamento.Enabled = false;

                txtValorAPagar.Text = valorParcela;
            }
        }

        private void PegarDadosGridView()
        {
            try
            {
                numeroNotaFiscal = forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[1].Value.ToString();
                CpfCnpjCliente = forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[2].Value.ToString();
                nomeCliente = forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[3].Value.ToString();
                dataEmeissao = Convert.ToDateTime(forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[4].Value).ToShortDateString();
                quantidadeParcelas = forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[6].Value.ToString();
                valorTotal = string.Format("{0:C}", forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[9].Value);
                vencimento = Convert.ToDateTime(forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[10].Value).ToShortDateString();
                statusPagamento = forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[12].Value.ToString();
                valorParcela = string.Format("{0:C}", forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[13].Value);

                txtNumeroNotaFiscal.Text = numeroNotaFiscal;
                txtCpfCnpj.Text = CpfCnpjCliente;
                txtNomeCliente.Text = nomeCliente;
                txtEmissao.Text = dataEmeissao;
                txtQuantParcelas.Text = quantidadeParcelas;
                txtValorTotal.Text = valorTotal;
                txtVencimento.Text = vencimento;
                lblStatusPagamento.Text = statusPagamento;
                txtValorParcela.Text = valorParcela;
            }
            catch (Exception ex)
            {
                Erro.ErroAoPegarDadosDoGridView(ex);
            }
        }

        private void PreencherJurosMultaAtraso()
        {
            dadosFinanceiro = Buscar.BuscarListaDadosFinanceiro();

            txtJurosAtraso.Text = string.Format("{0:P}", dadosFinanceiro[0].jurosAtrasoCarne / 100);

            txtMultaAtraso.Text = string.Format("{0:P}", dadosFinanceiro[0].multaAtrasoCarne / 100);
        }

        private void FecharTela()
        {
            if (lblStatusPagamento.Text == "Nao Pago")
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Cancelar o Pagamento?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void Forms_EditarPagamentoAReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Classes.FecharTela.DesejaFecharTela(this, e);
            }
            else if (e.KeyCode == Keys.F10)
            {
                ConfirmarRecebimentoPagamento();
            }
        }

        private void ConfirmarRecebimentoPagamento()
        {
            lblStatusPagamento.Text = "Pago";

            Atualizar.AtualizarStatusPagamentoCarne(pcbStatusPagamento.Image, lblStatusPagamento.Text,
                Convert.ToInt32(txtNumeroNotaFiscal.Text), txtQuantParcelas.Text, jurosAtraso,
                Convert.ToDecimal(txtValorAPagar.Text.Replace("R$", "")));


            Atualizar.AtualizarSaldoClienteParcelaPagamentoParcelaCarne(Convert.ToDecimal(valorParcela.Replace("R$","")), CpfCnpjCliente);


            AvisoCantoInferiorDireito.Confirmacao();

            btnConfirmarPagamento.Enabled = false;
        }

        private void CalcularValorAReceber()
        {
            QuantidadeDiasAtraso = Convert.ToInt32((DateTime.Now - Convert.ToDateTime(txtVencimento.Text)).TotalDays);

            if (QuantidadeDiasAtraso > 0)
            {
                PreencherJurosMultaAtraso();

                CalcularJurosAtraso();

                CalcularMultaAtraso();

                txtValorAPagar.Text = string.Format("{0:c}", (multaAtraso + jurosAtraso + Convert.ToDecimal(valorParcela.Replace("R$ ", ""))));
            }
            else
            {
                txtMultaAtraso.Text = "0,00%";

                txtJurosAtraso.Text = "0,00%";

                txtValorAPagar.Text = valorParcela;
            }
        }

        private void CalcularMultaAtraso()
        {
            decimal valorMultaAtrasoPagamentoCarne = Convert.ToDecimal(dadosFinanceiro[0].multaAtrasoCarne);

            multaAtraso = valorMultaAtrasoPagamentoCarne * Convert.ToDecimal(valorParcela.Replace("R$ ", "")) / 100;
        }

        private void CalcularJurosAtraso()
        {
            decimal valorJurosAtrasoPagamentoCarne = Convert.ToDecimal(dadosFinanceiro[0].jurosAtrasoCarne);

            jurosAtraso = (valorJurosAtrasoPagamentoCarne * Convert.ToDecimal(valorParcela.Replace("R$ ", "")) / 100) * Convert.ToDecimal(QuantidadeDiasAtraso);
        }
    }
}