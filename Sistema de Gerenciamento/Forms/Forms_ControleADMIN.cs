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
    public partial class Forms_ControleADMIN : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private Forms_PDV telaPDV;

        private Forms_CadastroCliente cadastroCliente;

        private string tipo = "";

        public Forms_ControleADMIN(Forms_PDV _telaPDV, string _tipo)
        {
            InitializeComponent();

            telaPDV = _telaPDV;

            tipo = _tipo;

            pcbEmpresa.Image = Buscar.BuscarLogoEmpresa(Convert.ToInt32(lblce_id.Text));
        }

        public Forms_ControleADMIN()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RealizarLogin();
        }

        private void RealizarLogin()
        {
            if (tipo == "Remover Produto")
            {
                if (txtUsuario.Text == "ADMIN" && Buscar.BuscarUsuario(txtUsuario.Text, txtSenha.Text))
                {
                    DialogResult OpcaoDoUsuario = new DialogResult();
                    OpcaoDoUsuario = MessageBox.Show("Realmente Deseja Remover o Porduto da Lista?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (OpcaoDoUsuario == DialogResult.Yes)
                    {
                        telaPDV.RemoverProduto();

                        this.Close();
                    }
                }
            }
            else if (tipo == "Troca")
            {
                Forms_Troca telaDevolucaoTroca = new Forms_Troca();
                telaDevolucaoTroca.ShowDialog();

                this.Close();
            }
            else if (tipo == "Cancelar Pagamento")
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Realmente Cancelar a Venda?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    telaPDV.FormatandoParaNovaVenda();

                    this.Close();
                }
            }
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            txtUsuario.CharacterCasing = CharacterCasing.Upper;

            //ManipulacaoTextBox.DigitoFoiLetrasOuNumerosParaUsuario(e);
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;

            //ManipulacaoTextBox.DigitoValidoParaSenha(e);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void Forms_ControleADMIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
            else if (e.KeyCode == Keys.F10)
            {
                RealizarLogin();
            }
        }
    }
}