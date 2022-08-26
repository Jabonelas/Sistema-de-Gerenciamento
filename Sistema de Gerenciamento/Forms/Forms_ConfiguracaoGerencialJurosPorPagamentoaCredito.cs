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
    public partial class Forms_ConfiguracaoGerencialJurosPorPagamentoaCredito : Form
    {
        private AtualizacaoNoBanco Atualizacao = new AtualizacaoNoBanco();


        public Forms_ConfiguracaoGerencialJurosPorPagamentoaCredito()
        {
            InitializeComponent();
        }

        private void Forms_JurosPorPagamentoaCredito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
        }

        private void txtJurosCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtJurosCredito.Text.Replace("%", ""), sender);
            }
        }

        private void btnConfirmarCredito_Click(object sender, EventArgs e)
        {
            AtualziacaoPorcentagemJurosCredito();
        }


        private void AtualziacaoPorcentagemJurosCredito()
        {
            if (txtJurosCredito.Text != String.Empty && cmbParcelasCredito.Text != String.Empty)
            {
                Atualizacao.JurosCredito(Convert.ToDecimal(txtJurosCredito.Text.Replace("%", "")),
                    Convert.ToInt32(cmbParcelasCredito.Text.Replace("x", "")));

                cmbParcelasCredito.Text = String.Empty;
                txtJurosCredito.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Por Favor Preencha Todos Campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmbParcelasCredito.Focus();
            }
        }
    }
}