using Sistema_de_Gerenciamento.Classes;
using Sistema_de_Gerenciamento.Forms;
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
    public partial class CadastroFornecedor : Form
    {
        private ManipulacaoTextBox TextBox = new ManipulacaoTextBox();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        private ExcluirNoBanco Excluir = new ExcluirNoBanco();

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        public CadastroFornecedor()
        {
            InitializeComponent();

            txtDataCadastro.Text = DateTime.Today.ToShortDateString();
        }

        #region Botao Sair

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Sair

        #region Botao Novo

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            TextBox.ApagandoTextBox(this);

            pcbFornecedor.Image = Image.FromFile(@"C:\Users\israe\source\repos\Sistema de Gerenciamento\Sistema de Gerenciamento\Resources\imagem-do-usuario-com-fundo-preto.png");
        }

        #endregion Botao Novo

        #region Botao Salvar

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (TextBox.VerificarPreenchimentoTextBox(this) == false)
            {
                if (VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(txtCNPJ.Text) == false)
                {
                    Salvar.InserirCadastroForncedor(
                    txtRazaoSocial.Text,
                    Convert.ToDateTime(txtDataCadastro.Text),
                    txtCNPJ.Text,
                    txtNomeFantasia.Text,
                    txtCEP.Text,
                    txtEndereco.Text,
                    txtComplemento.Text,
                    Convert.ToInt32(txtNumero.Text),
                    txtBairro.Text,
                    txtCidade.Text,
                    cmbUF.Text,
                    txtTelefone.Text,
                    txtEmail.Text,
                    txtObservacoes.Text);

                    Salvar.InserirImagemNoCadastroFornecedor(pcbFornecedor.Image);

                    txtCodigo.Text = Buscar.BuscarCodigoFornecedor(txtCNPJ.Text).ToString();

                    //Chamar o forms de alerta de inclusao com sucesso
                    Global.tipoDoAlerta = "Inclusao";

                    Alerta buscarCliente = new Alerta();
                    buscarCliente.Show();
                }
                else if (VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(txtCNPJ.Text) == true)
                {
                    MessageBox.Show("Fornecedor Já Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion Botao Salvar

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(txtCNPJ.Text) == true)
                    {
                        Atualizar.AtualizarCadastroFornecedor(txtRazaoSocial.Text,
                    txtCNPJ.Text,
                    txtNomeFantasia.Text,
                    txtCEP.Text,
                    txtEndereco.Text,
                    txtComplemento.Text,
                    Convert.ToInt32(txtNumero.Text),
                    txtBairro.Text,
                    txtCidade.Text,
                    cmbUF.Text,
                    txtTelefone.Text,
                    txtEmail.Text,
                    txtObservacoes.Text);

                        Atualizar.AtualizarImagemNoCadastroFornecedor(pcbFornecedor.Image, Convert.ToInt32(txtCodigo.Text));

                        //Chamar o forms de alerta de atualizacao com sucesso
                        Global.tipoDoAlerta = "Atualizacao";

                        Alerta buscarCliente = new Alerta();
                        buscarCliente.Show();
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(txtCNPJ.Text) == false)
                    {
                        MessageBox.Show("Fornecedor Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Preenchimento Dos Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCadastroCliente(ex);
            }
        }

        private void btnBuscarFornecedor_Click(object sender, EventArgs e)
        {
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
        }

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
        }
    }
}