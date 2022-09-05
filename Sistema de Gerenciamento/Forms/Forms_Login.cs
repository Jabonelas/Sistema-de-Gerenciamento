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
using Sistema_de_Gerenciamento.Properties;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_Login : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private Forms_TelaAdministrador telaAdministrador;

        public Forms_Login()
        {
            InitializeComponent();

            PreencherTextBox();
        }

        private void PreencherTextBox()
        {
            txtSenha.UseSystemPasswordChar = true;

            txtUsuario.Text = "ADMIN";
            txtSenha.Text = "123";

            //txtUsuario.Text = "VENDEDOR2";
            //txtSenha.Text = "12345";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logar();
        }

        #region Logar

        private void Logar()
        {
            try
            {
                if (Buscar.BuscarUsuario(txtUsuario.Text, txtSenha.Text) == true)
                {
                    if (txtUsuario.Text == "ADMIN")
                    {
                        Global.NomeDeUsuario = "ADMIN";
                    }
                    else
                    {
                        Global.NomeDeUsuario = txtUsuario.Text;
                    }

                    this.Hide();
                    telaAdministrador = new Forms_TelaAdministrador(this);
                    telaAdministrador.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Incorreto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarCadastroUsuario(ex);
            }
        }

        #endregion Logar

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostraSenha_Login_Click(object sender, EventArgs e)
        {
            MostraOuEsconderSenha();
        }

        #region Mostra ou Esconder Senha

        private void MostraOuEsconderSenha()
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;

                btnMostraSenha_Login.BackgroundImage = Resources.eye_50px;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;

                btnMostraSenha_Login.BackgroundImage = Resources.invisible_50px;
            }
        }

        #endregion Mostra ou Esconder Senha

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoValidoParaSenha(e);
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void Forms_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
            else if (e.KeyCode == Keys.F10)
            {
                Logar();
            }
        }
    }
}