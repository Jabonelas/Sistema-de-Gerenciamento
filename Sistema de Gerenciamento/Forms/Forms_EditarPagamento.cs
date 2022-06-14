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
    public partial class Forms_EditarPagamento : Form
    {
        public Forms_PesquisarContasAPagar contasAPagar;

        public Forms_EditarPagamento(Forms_PesquisarContasAPagar _contasAPagar)
        {
            InitializeComponent();

            contasAPagar = _contasAPagar;
        }

        private void chbPago_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPago.Checked == false)
            {
                txtDataPagamento.Enabled = false;
                dtpVencimento.Enabled = false;
                txtDescontoTaxas.Enabled = false;
                txtJurosMulta.Enabled = false;
                txtValorPago.Enabled = false;
                btnConfirmarPagamento.Enabled = false;
            }
            else if (chbPago.Checked == true)
            {
                txtDataPagamento.Enabled = true;
                txtDataPagamento.Text = String.Empty;
                dtpVencimento.Enabled = true;
                txtDescontoTaxas.Enabled = true;
                txtDescontoTaxas.Text = String.Empty;
                txtJurosMulta.Enabled = true;
                txtJurosMulta.Text = String.Empty;
                txtValorPago.Enabled = true;
                txtValorPago.Text = String.Empty;
                btnConfirmarPagamento.Enabled = true;
            }
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoDinheiro(e, sender, txtValorPago);
        }

        private void txtJurosMulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtJurosMulta.Text, sender);
        }

        private void txtDescontoTaxas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtDescontoTaxas.Text, sender);
        }

        private void txtDataPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoData(txtDataPagamento);
        }

        private void txtDataPagamento_Leave(object sender, EventArgs e)
        {
            if (ManipulacaoTextBox.ValidacaoData(txtDataPagamento) == false)
            {
                txtDataPagamento.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarPagamento_Click(object sender, EventArgs e)
        {
        }
    }
}