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

        private List<DadosFinanceiro> dadosFinanceiro = new List<DadosFinanceiro>();

        private Forms_PesquisarContasAReceber forms_PesquisarContasAReceber;

        private decimal multaAtraso;

        private decimal jurosAtraso;

        private int QuantidadeDiasAtraso;

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

                txtValorAPagar.Text = string.Format("{0:C}", forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[14].Value);
            }
        }

        private void PegarDadosGridView()
        {
            txtNumeroNotaFiscal.Text = forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[1].Value.ToString();
            txtCpfCnpj.Text = forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[2].Value.ToString();
            txtNomeCliente.Text = forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[3].Value.ToString();
            txtEmissao.Text = Convert.ToDateTime(forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[4].Value).ToShortDateString();
            txtVencimento.Text = Convert.ToDateTime(forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[5].Value).ToShortDateString();
            txtQuantParcelas.Text = forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[7].Value.ToString();
            txtValor.Text = string.Format("{0:C}", forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[10].Value);
            txtValorParcela.Text = string.Format("{0:C}", forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[11].Value);
            lblStatusPagamento.Text = forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[16].Value.ToString();
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
                FecharTela();
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

                txtValorAPagar.Text = string.Format("{0:c}", (multaAtraso + jurosAtraso + Convert.ToDecimal(forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[11].Value)));
            }
            else
            {
                txtMultaAtraso.Text = "0,00%";

                txtJurosAtraso.Text = "0,00%";

                txtValorAPagar.Text = String.Format("{0:c}", forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[11].Value);
            }
        }

        private void CalcularMultaAtraso()
        {
            multaAtraso = Convert.ToDecimal(dadosFinanceiro[0].multaAtrasoCarne *
            Convert.ToDecimal(forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[10].Value) / 100);
        }

        private void CalcularJurosAtraso()
        {
            jurosAtraso = Convert.ToDecimal(dadosFinanceiro[0].jurosAtrasoCarne *
            Convert.ToDecimal(forms_PesquisarContasAReceber.gdvContarReceber.SelectedCells[10].Value) / 100)
            * Convert.ToDecimal(QuantidadeDiasAtraso);
        }
    }
}