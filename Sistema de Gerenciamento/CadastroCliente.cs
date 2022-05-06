using Bunifu.UI.WinForms;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento
{
    public partial class CadastroCliente : Form
    {
        private ManipulacaoTextBox TextBox = new ManipulacaoTextBox();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        public CadastroCliente()
        {
            InitializeComponent();
            txtDataCadastro.Text = DateTime.Today.ToShortDateString();
        }

        #region Botao Novo

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            TextBox.ApagandoTextBox(this);
        }

        #endregion Botao Novo

        #region Botao Salvar

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    Salvar.Inseir(Convert.ToInt32(txtCodigo.Text), 
                        Convert.ToDateTime(txtDataCadastro.Text),
                        txtNome.Text, 
                        cmbTipo.Text, 
                        txtCPF_CNPJ.Text,
                        txtRG.Text,
                        cmbEmissor.Text, 
                        Convert.ToDateTime(txtDataEmissao.Text), 
                        cmbIns_Est.Text, 
                        txtCEP.Text, 
                        txtEndereco.Text,
                        txtComplemento.Text,
                        txtBairro.Text,
                        txtCidade.Text,
                        cmbUF.Text, 
                        txtNaturalidade.Text,
                        Convert.ToDateTime(txtDataNascimento.Text),
                        cmbEstadoCivil.Text,
                        Convert.ToDecimal(txtCredito.Text), 
                        Convert.ToDecimal(txtSaldo.Text), 
                        cmbBloqueio.Text, 
                        txtCelular.Text,
                        txtTel_Residencial.Text, 
                        txtEmail.Text, 
                        txtObservacoes.Text
                                                );
                }
                else
                {
                    MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCadastroCliente(ex);
            }
        }

        #endregion Botao Salvar

        #region Botao Alterar

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
        }

        #endregion Botao Alterar

        #region Botao Buscar

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            PesquisarCliente buscarCliente = new PesquisarCliente();
            buscarCliente.ShowDialog();
        }

        #endregion Botao Buscar

        #region Botao Excluir

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
        }

        #endregion Botao Excluir

        #region Botao Sair

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Sair
    }
}