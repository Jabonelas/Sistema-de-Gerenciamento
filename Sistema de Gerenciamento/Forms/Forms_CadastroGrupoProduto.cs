using Sistema_de_Gerenciamento.Classes;
using System;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento
{
    public partial class Forms_CadastroGrupoProduto : Form
    {
        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private ExcluirNoBanco Excluir = new ExcluirNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        public Forms_CadastroGrupoProduto()
        {
            InitializeComponent();
        }

        private void bntSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarGrupo_Click(object sender, EventArgs e)
        {
            SalvarGrupoProduto();
        }

        #region Salvar Grupo de Produto

        private void SalvarGrupoProduto()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaSubGrupo(txtSubGrupo.Text) == false)
                    {
                        Salvar.InserirGrupoMaterial(
                            txtGrupoMaterial.Text,
                            txtSubGrupo.Text);

                        txtGrupoMaterial.Text = string.Empty;
                        txtSubGrupo.Text = string.Empty;
                    }
                    else if (VerificarExistencia.VerificarExistenciaSubGrupo(txtSubGrupo.Text) == true)
                    {
                        MessageBox.Show("Sub-Grupo Já Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCadastroGrupoMaterial(ex);
            }
        }

        #endregion Salvar Grupo de Produto

        private void btnExcluirGrupo_Click(object sender, EventArgs e)
        {
            ExcluirGrupoProduto();
        }

        #region Excluir Grupo de Produto

        private void ExcluirGrupoProduto()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaSubGrupo(txtSubGrupo.Text) == true)
                    {
                        Excluir.ExcluirCadastroGrupoMaterial(txtGrupoMaterial.Text, txtSubGrupo.Text);

                        txtGrupoMaterial.Text = string.Empty;
                        txtSubGrupo.Text = string.Empty;
                    }
                    else if (VerificarExistencia.VerificarExistenciaSubGrupo(txtSubGrupo.Text) == false)
                    {
                        MessageBox.Show("Cliente Não Encontrado!", "Atenção!", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirCadastroGrupoMaterialNoBanco(ex);
            }
        }

        #endregion Excluir Grupo de Produto

        private void txtGrupoMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetras(e);
        }

        private void txtSubGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetras(e);
        }

        private void Forms_CadastroGrupoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
        }
    }
}