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
    public partial class CadastroUsuario : Form
    {
        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        private ManipulacaoTextBox TextBox = new ManipulacaoTextBox();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        public CadastroUsuario()
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

                        //Chamar o forms de alerta de inclusao com sucesso
                        Global.tipoDoAlerta = "Inclusao";

                        Aviso buscarCliente = new Aviso();
                        buscarCliente.Show();
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

                        //Chamar o forms de alerta de atualizacao com sucesso
                        Global.tipoDoAlerta = "Atualizacao";

                        Aviso buscarCliente = new Aviso();
                        buscarCliente.Show();
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

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Usuario
    }
}