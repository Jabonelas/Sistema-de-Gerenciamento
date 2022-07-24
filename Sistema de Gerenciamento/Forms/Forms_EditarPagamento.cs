using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Sistema_de_Gerenciamento.Classes;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_EditarPagamento : Form
    {
        public Forms_PesquisarContasAPagar contasAPagar;

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        public Forms_EditarPagamento(Forms_PesquisarContasAPagar _contasAPagar)
        {
            InitializeComponent();

            contasAPagar = _contasAPagar;

            PreencherDatePicker();

            //txtDataPagamento.Text = DateTime.Today.ToShortDateString();

            dtpPagamento.Text = DateTime.Today.ToShortDateString();
        }

        #region Preencher DatePicker

        private void PreencherDatePicker()
        {
            dtpPagamento.Value = DateTime.Today;
        }

        #endregion Preencher DatePicker

        private void chbPago_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPago.Checked == false)
            {
                txtDataPagamento.Enabled = false;
                dtpPagamento.Enabled = false;
                txtDescontoTaxas.Enabled = false;
                txtJurosMulta.Enabled = false;
                txtValorPago.Enabled = false;
                btnConfirmarPagamento.Enabled = false;
            }
            else if (chbPago.Checked == true)
            {
                txtDataPagamento.Enabled = true;
                dtpPagamento.Enabled = true;
                txtDescontoTaxas.Enabled = true;
                txtJurosMulta.Enabled = true;
                btnConfirmarPagamento.Enabled = true;
                btnCancelar.Enabled = true;

                if (lblVerificacaoPagamento.Text == "Pago")
                {
                    txtDataPagamento.Enabled = false;
                    dtpPagamento.Enabled = false;
                    txtDescontoTaxas.Enabled = false;
                    txtJurosMulta.Enabled = false;
                    btnConfirmarPagamento.Enabled = false;
                    btnCancelar.Enabled = false;
                }
            }
        }

        private void txtDataPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoData(txtDataPagamento);
            }
        }

        private void txtDataPagamento_Leave(object sender, EventArgs e)
        {
            int cont = 0;

            if (ManipulacaoTextBox.ValidacaoData(txtDataPagamento) == false)
            {
                txtDataPagamento.Focus();
            }

            if (VerificarDataPagamentoMaiorQueEmissao() == false && cont <= 0)
            {
                txtDataPagamento.Focus();
                cont++;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult OpcaoDoUsuario = new DialogResult();
            OpcaoDoUsuario = MessageBox.Show("Deseja Cancelar o Pagamento?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (OpcaoDoUsuario == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConfirmarPagamento_Click(object sender, EventArgs e)
        {
            if (txtDataPagamento.Text != String.Empty)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Confirmar Pagamento?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    Atualizar.AtualizarPagamento(Convert.ToDateTime(txtDataPagamento.Text),
                        Convert.ToDecimal(txtDescontoTaxas.Text.Replace(" %", "")), Convert.ToDecimal(txtJurosMulta.Text.Replace(" %", "")),
                        Convert.ToDecimal(txtValorPago.Text.Replace("R$ ", "")), Convert.ToInt32(txtCodigo.Text), txtQuantParcelas.Text,
                        lblStatusPagamento.Text, pcbStatusPagamento.Image, Convert.ToDateTime(txtVencimento.Text));

                    lblVerificacaoPagamento.Text = "Pago";

                    txtDataPagamento.Enabled = false;
                    dtpPagamento.Enabled = false;
                    txtDescontoTaxas.Enabled = false;
                    txtJurosMulta.Enabled = false;
                    btnConfirmarPagamento.Enabled = false;
                    btnCancelar.Enabled = false;
                    chbPago.Checked = true;
                }
            }
        }

        private void dtpPagamento_Leave(object sender, EventArgs e)
        {
            int cont = 0;

            if (VerificarDataPagamentoMaiorQueEmissao() == false && cont <= 0)
            {
                txtDataPagamento.Focus();
            }
        }

        #region Verificar Se Data de Pagamento é Maior Que a Data de  Emissao

        private bool VerificarDataPagamentoMaiorQueEmissao()

        {
            if (txtDataPagamento.Text != String.Empty)
            {
                if (Convert.ToDateTime(txtEmissao.Text) > Convert.ToDateTime(txtDataPagamento.Text))
                {
                    MessageBox.Show("A Data de Pagamento Não Pode Ser Menor que a Data De Emissão!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
            }

            return true;
        }

        #endregion Verificar Se Data de Pagamento é Maior Que a Data de  Emissao

        private void dtpPagamento_ValueChanged(object sender, EventArgs e)
        {
            txtDataPagamento.Text = dtpPagamento.Value.ToShortDateString();
        }

        private void txtDescontoTaxas_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtDescontoTaxas.Text, sender);
        }

        private void txtValorPago_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoDinheiro(e, sender, txtValorPago);
        }

        private void txtJurosMulta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtJurosMulta.Text, sender);
        }

        private void txtDescontoTaxas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtValorPago.Text = String.Format("{0:C}", Convert.ToDecimal(txtValorParcela.Text.Replace("R$ ", "")) -
                                                           (Convert.ToDecimal(txtDescontoTaxas.Text.Replace("%", "")) *
                                                               Convert.ToDecimal(txtValorParcela.Text.Replace("R$ ", "")) / 100));
            }
            catch (Exception exception)
            {
            }
        }

        private void txtJurosMulta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtValorPago.Text = String.Format("{0:C}", Convert.ToDecimal(txtValorParcela.Text.Replace("R$ ", "")) +
                                                           (Convert.ToDecimal(txtJurosMulta.Text.Replace("%", "")) *
                                                               Convert.ToDecimal(txtValorParcela.Text.Replace("R$ ", "")) / 100));
            }
            catch (Exception exception)
            {
            }
        }

        private void txtDescontoTaxas_Leave(object sender, EventArgs e)
        {
            if (txtDescontoTaxas.Text == String.Empty)
            {
                txtDescontoTaxas.Text = "0,00 %";
            }
        }

        private void txtJurosMulta_Leave(object sender, EventArgs e)
        {
            if (txtJurosMulta.Text == String.Empty)
            {
                txtJurosMulta.Text = "0,00 %";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (lblVerificacaoPagamento.Text == "Nao Pago")
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
    }
}