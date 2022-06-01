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
using Sistema_de_Gerenciamento.Forms;

namespace Sistema_de_Gerenciamento
{
    public partial class Forms_CadastroUsuario : Form
    {
        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        private ManipulacaoTextBox TextBox = new ManipulacaoTextBox();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        public Forms_CadastroUsuario()
        {
            InitializeComponent();
        }

        #region Botao Sair

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Sair

        #region Botao Salvar

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDoUsuario(txtUsuario.Text) == false)
                    {
                        Salvar.InserirUsuario(
                            txtUsuario.Text,
                            txtSenha.Text);

                        txtUsuario.Text = string.Empty;
                        txtSenha.Text = string.Empty;
                    }
                    else if (VerificarExistencia.VerificarExistenciaDoUsuario(txtUsuario.Text) == true)
                    {
                        MessageBox.Show("Usuario Já Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCadastroUsuario(ex);
            }
        }

        #endregion Botao Salvar

        #region Botao Alterar

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDoUsuario(txtUsuario.Text) == true)
                    {
                        Atualizar.AtualizarCadastroUsuario(
                            txtUsuario.Text,
                            txtSenha.Text);
                    }
                    else if (VerificarExistencia.VerificarExistenciaDoUsuario(txtUsuario.Text) == false)
                    {
                        MessageBox.Show("Usuario Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Preenchimento Dos Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCadastroUsuario(ex);
            }
        }

        #endregion Botao Alterar

        #region TextBox Usuario

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
        }

        #endregion TextBox Usuario
    }
}