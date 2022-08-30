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
    public partial class Forms_ConfiguracaoGerencialPagamentoCarne : Form
    {
        private AtualizacaoNoBanco Atualizacao = new AtualizacaoNoBanco();

        public Forms_ConfiguracaoGerencialPagamentoCarne()
        {
            InitializeComponent();
        }

        private void btnConfirmarCarne_Click(object sender, EventArgs e)
        {
            ConfimarPagamento();
        }

        private void ConfimarPagamento()
        {
            if (txtPrazoCarne.Text != string.Empty && cmbParcelasCarne.Text != string.Empty && txtJurosCarneParcelas.Text != string.Empty)
            {
                Atualizacao.JurosPorCarne(Convert.ToInt32(txtPrazoCarne.Text), Convert.ToDecimal(txtJurosCarneParcelas.Text.Replace("%", "")),
                    Convert.ToInt32(cmbParcelasCarne.Text.Replace("x", "")), Convert.ToDecimal(txtJurosCarneAtrasoPagamento.Text.Replace("%", "")),
                    Convert.ToDecimal(txtMultaCarneAtrasoPagamento.Text.Replace("%", "")));

                txtPrazoCarne.Text = string.Empty;
                cmbParcelasCarne.Text = string.Empty;
                txtJurosCarneParcelas.Text = string.Empty;
                txtJurosCarneAtrasoPagamento.Text = string.Empty;
                txtMultaCarneAtrasoPagamento.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Por Favor Preencha Todos Campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmbParcelasCarne.Focus();
            }
        }

        private void txtJurosCarneParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtJurosCarneParcelas.Text.Replace("%", ""), sender);
            }
        }

        private void txtJurosCarneAtrasoPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtJurosCarneAtrasoPagamento.Text.Replace("%", ""), sender);
            }
        }

        private void txtPrazoCarne_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtMultaCarneAtrasoPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtMultaCarneAtrasoPagamento.Text.Replace("%", ""), sender);
            }
        }

        private void Forms_ConfiguracaoGerencialPagamentoCarne_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
            else if (e.KeyCode == Keys.F10)
            {
                ConfimarPagamento();
            }
        }
    }
}