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
    public partial class Forms_Login : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private Forms_Sair telaSair;

        private Forms_TelaAdministrador telaAdministrador;

        public Forms_Login()
        {
            InitializeComponent();

            telaSair = new Forms_Sair(this);

            txtUsuario.Text = "ADMIN";
            txtSenha.Text = "123";
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
                        Global.tipoDeUsuario = "ADMIN";
                    }
                    else
                    {
                        Global.tipoDeUsuario = txtUsuario.Text;
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

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUsuario.CharacterCasing = CharacterCasing.Upper;

            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;

            ManipulacaoTextBox.DigitoValidoParaSenha(e);
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

                btnMostraSenha_Login.BackgroundImage = Image.FromFile(@"C:\Users\israe\source\repos\Sistema de Gerenciamento\Sistema de Gerenciamento\Resources\eye_50px.png");
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;

                btnMostraSenha_Login.BackgroundImage = Image.FromFile(@"C:\Users\israe\source\repos\Sistema de Gerenciamento\Sistema de Gerenciamento\Resources\invisible_50px.png");
            }
        }

        #endregion Mostra ou Esconder Senha
    }
}