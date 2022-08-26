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
    public partial class Forms_ConfiguracaoGerencialDescontoPorPagamentoAvista : Form
    {
        private AtualizacaoNoBanco Atualizacao = new AtualizacaoNoBanco();

        public Forms_ConfiguracaoGerencialDescontoPorPagamentoAvista()
        {
            InitializeComponent();
        }

        private void btnConfirmarAvista_Click(object sender, EventArgs e)
        {
            AtualizacaoPorcentagemAvista();
        }

        private void AtualizacaoPorcentagemAvista()
        {
            if (txtDescontoAvista.Text != String.Empty)
            {
                Atualizacao.AtualizarPagamentoDescontoAvista(Convert.ToDecimal(txtDescontoAvista.Text.Replace("%", "")));

                txtDescontoAvista.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Por Favor Preencha Todos Campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtDescontoAvista.Focus();
            }
        }

        private void txtDescontoAvista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtDescontoAvista.Text.Replace("%", ""), sender);
            }
        }

        private void Forms_ConfiguracaoGerencialDescontoPorPagamentoAvista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
        }
    }
}