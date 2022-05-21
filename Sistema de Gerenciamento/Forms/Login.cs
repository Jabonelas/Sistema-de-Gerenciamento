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
    public partial class Login : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private Sair telaSair;

        private TelaAdministrador telaAdministrador;

        public Login()
        {
            InitializeComponent();

            telaSair = new Sair(this);

            txtUsuario.Text = "ADMIN";
            txtSenha.Text = "123";
        }

        #region Botao Login

        private void btnLogin_Click(object sender, EventArgs e)
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
                    telaAdministrador = new TelaAdministrador(this);
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

        #endregion Botao Login

        #region Botao Cancelar

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Cancelar

        #region TextBox Usuario

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
        }

        #endregion TextBox Usuario

        #region TextBox Senha

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        #endregion TextBox Senha

        #region Botao Mostrar Senha

        private void btnMostraSenha_Login_Click(object sender, EventArgs e)
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

        #endregion Botao Mostrar Senha
    }
}