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
    public partial class Forms_ConfiguracaoGerencialComissaoPorProduto : Form
    {
        private AtualizacaoNoBanco Atualizacao = new AtualizacaoNoBanco();

        public Forms_ConfiguracaoGerencialComissaoPorProduto()
        {
            InitializeComponent();
        }

        private void btnConfirmarComissao_Click(object sender, EventArgs e)
        {
            AtualziacaoPorcentagemComissao();
        }

        private void txtComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtComissao.Text.Replace("%", ""), sender);
            }
        }

        private void AtualziacaoPorcentagemComissao()
        {
            if (txtComissao.Text != String.Empty)
            {
                Atualizacao.AtualizarComissao(Convert.ToDecimal(txtComissao.Text.Replace("%", "")));

                txtComissao.Text = String.Empty;
                ;
            }
            else
            {
                MessageBox.Show("Por Favor Preencha O Campo!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtComissao.Focus();
            }
        }

        private void Forms_ConfiguracaoGerencialComissãoPorProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
        }
    }
}