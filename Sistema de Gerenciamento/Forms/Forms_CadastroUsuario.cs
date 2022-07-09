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

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        public Forms_CadastroUsuario()
        {
            InitializeComponent();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarUsuario();
        }

        private void SalvarUsuario()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDoUsuario(txtUsuario.Text) == false)
                    {
                        Salvar.InserirUsuario(
                            txtUsuario.Text,
                            txtSenha.Text,
                            lblExluirItem.Text,
                            lblDevolucaoTroca.Text,
                            lblCancelarVenda.Text,
                            lblCancelarPagamento.Text);

                        txtUsuario.Text = string.Empty;
                        txtSenha.Text = string.Empty;
                    }
                    else if (VerificarExistencia.VerificarExistenciaDoUsuario(txtUsuario.Text) == true)
                    {
                        MessageBox.Show("Usuario Já Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCadastroUsuario(ex);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarUsuario();
        }

        private void AlterarUsuario()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDoUsuario(txtUsuario.Text) == true)
                    {
                        Atualizar.AtualizarCadastroUsuario(
                            txtUsuario.Text,
                            txtSenha.Text,
                             lblExluirItem.Text,
                            lblDevolucaoTroca.Text,
                            lblCancelarVenda.Text,
                            lblCancelarPagamento.Text);
                    }
                    else if (VerificarExistencia.VerificarExistenciaDoUsuario(txtUsuario.Text) == false)
                    {
                        MessageBox.Show("Usuario Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCadastroUsuario(ex);
            }
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoValidoParaSenha(e);
        }

        private void chbExcluirItem_Click(object sender, EventArgs e)
        {
            if (chbExcluirItem.Checked == true)
            {
                lblExluirItem.Text = "true";
            }
            else
            {
                lblExluirItem.Text = "false";
            }
        }

        private void chbDevolucaoTroca_Click(object sender, EventArgs e)
        {
            if (chbDevolucaoTroca.Checked == true)
            {
                lblDevolucaoTroca.Text = "true";
            }
            else
            {
                lblDevolucaoTroca.Text = "false";
            }
        }

        private void chbCancelarVenda_Click(object sender, EventArgs e)
        {
            if (chbCancelarVenda.Checked == true)
            {
                lblCancelarVenda.Text = "true";
            }
            else
            {
                lblCancelarVenda.Text = "false";
            }
        }

        private void chbCancelarPagamento_Click(object sender, EventArgs e)
        {
            if (chbCancelarPagamento.Checked == true)
            {
                lblCancelarPagamento.Text = "true";
            }
            else
            {
                lblCancelarPagamento.Text = "false";
            }
        }
    }
}