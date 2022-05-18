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
    public partial class CadastroGrupoDeMaterial : Form
    {
        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private ExcluirNoBanco Excluir = new ExcluirNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private ManipulacaoTextBox TextBox = new ManipulacaoTextBox();

        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        public CadastroGrupoDeMaterial()
        {
            InitializeComponent();
        }

        #region Botao Sair

        private void bntSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Sair

        #region Botao Salvar

        private void btnSalvarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaSubGrupo(txtSubGrupo.Text) == false)
                    {
                        Salvar.InserirGrupoMaterial(
                            txtGrupoMaterial.Text,
                            txtSubGrupo.Text);

                        txtGrupoMaterial.Text = string.Empty;
                        txtSubGrupo.Text = string.Empty;

                        //Chamar o forms de alerta de inclusao com sucesso
                        Global.tipoDoAlerta = "Inclusao";

                        Aviso buscarCliente = new Aviso();
                        buscarCliente.Show();
                    }
                    else if (VerificarExistencia.VerificarExistenciaSubGrupo(txtSubGrupo.Text) == true)
                    {
                        MessageBox.Show("Sub-Grupo Já Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCadastroGrupoMaterial(ex);
            }
        }

        #endregion Botao Salvar

        #region Botao Excluir

        private void btnExcluirGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaSubGrupo(txtSubGrupo.Text) == true)
                    {
                        Excluir.ExcluirCadastroGrupoMaterial(txtGrupoMaterial.Text, txtSubGrupo.Text);

                        txtGrupoMaterial.Text = string.Empty;
                        txtSubGrupo.Text = string.Empty;

                        //Chamar o forms de alerta de exclusao com sucesso
                        Global.tipoDoAlerta = "Exclusao";

                        Aviso buscarCliente = new Aviso();
                        buscarCliente.Show();
                    }
                    else if (VerificarExistencia.VerificarExistenciaSubGrupo(txtSubGrupo.Text) == false)
                    {
                        MessageBox.Show("Cliente Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirCadastroCliente(ex);
            }
        }

        #endregion Botao Excluir
    }
}