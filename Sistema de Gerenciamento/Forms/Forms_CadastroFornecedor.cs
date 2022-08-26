using Newtonsoft.Json;
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
using Sistema_de_Gerenciamento.Classes.QuickType;
using Sistema_de_Gerenciamento.Properties;

namespace Sistema_de_Gerenciamento
{
    public partial class Forms_CadastroFornecedor : Form
    {
        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        private ExcluirNoBanco Excluir = new ExcluirNoBanco();

        private ApiCorreios Api = new ApiCorreios();

        private int qntCEPexecutado = 0;

        public Forms_CadastroFornecedor()
        {
            InitializeComponent();

            txtDataCadastro.Text = DateTime.Today.ToShortDateString();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            ManipulacaoTextBox.ApagandoTextBox(this);

            pcbFornecedor.Image = Resources.imagem_do_usuario_com_fundo_preto;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCadastroFornecedor();
        }

        private void SalvarCadastroFornecedor()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    bool IsCNPJFornecedorExiste = false;

                    IsCNPJFornecedorExiste = VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(txtCNPJ.Text);

                    if (IsCNPJFornecedorExiste == false)
                    {
                        DadosCadastroFornecedor dadosCadastroFornecedor;
                        int codigoFornecedor = 0;
                        int codigoImagemFornecedor = 0;

                        codigoImagemFornecedor = Salvar.InserirImagemNoCadastroFornecedor(pcbFornecedor.Image);
                        lblForeignKey.Text = codigoImagemFornecedor.ToString();
                        dadosCadastroFornecedor = PreencherDadosCadastroFornecedor();
                        codigoFornecedor = Salvar.InserirCadastroFornecedor(dadosCadastroFornecedor);
                    }
                    else if (IsCNPJFornecedorExiste == true)
                    {
                        MessageBox.Show("Fornecedor Já Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCadastroFornecedor(ex);
            }
        }

        private DadosCadastroFornecedor PreencherDadosCadastroFornecedor()
        {
            DadosCadastroFornecedor dadosCadastroFonecedo = new DadosCadastroFornecedor();

            dadosCadastroFonecedo.razaoSocial = txtRazaoSocial.Text;
            dadosCadastroFonecedo.dataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
            dadosCadastroFonecedo.cnpj = txtCNPJ.Text;
            dadosCadastroFonecedo.nomeFantasia = txtNomeFantasia.Text;
            dadosCadastroFonecedo.cep = txtCEP.Text;
            dadosCadastroFonecedo.endereco = txtEndereco.Text;
            dadosCadastroFonecedo.complemento = txtComplemento.Text;
            dadosCadastroFonecedo.numero = Convert.ToInt32(txtNumero.Text);
            dadosCadastroFonecedo.bairro = txtBairro.Text;
            dadosCadastroFonecedo.cidade = txtCidade.Text;
            dadosCadastroFonecedo.uf = cmbUF.Text;
            dadosCadastroFonecedo.telefone = txtTelefone.Text;
            dadosCadastroFonecedo.email = txtEmail.Text;
            dadosCadastroFonecedo.observacao = txtObservacoes.Text;
            dadosCadastroFonecedo.codigoFornecedor = Convert.ToInt32(lblForeignKey.Text);

            return dadosCadastroFonecedo;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AtualizarCadastroFornecedor();
        }

        private void AtualizarCadastroFornecedor()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    bool IsCNPJFornecedorExiste = false;

                    IsCNPJFornecedorExiste = VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(txtCNPJ.Text);

                    if (IsCNPJFornecedorExiste == true)
                    {
                        DadosCadastroFornecedor dadosCadastroFornecedor;

                        dadosCadastroFornecedor = PreencherDadosCadastroFornecedor();

                        Atualizar.AtualizarCadastroFornecedor(dadosCadastroFornecedor);

                        Atualizar.AtualizarImagemNoCadastroFornecedor(pcbFornecedor.Image, Convert.ToInt32(txtCodigo.Text));
                    }
                    else if (IsCNPJFornecedorExiste == false)
                    {
                        MessageBox.Show("Fornecedor Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCadastroFornecedor(ex);
            }
        }

        private void btnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            Forms_PesquisarFornecedor buscarFornecedor = new Forms_PesquisarFornecedor(this);
            buscarFornecedor.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCadastroFornecedor();
        }

        private void ExcluirCadastroFornecedor()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    bool IsCNPJFornecedorExiste = false;

                    IsCNPJFornecedorExiste = VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(txtCNPJ.Text);

                    if (IsCNPJFornecedorExiste == true)
                    {
                        Excluir.ExcluirCadastroFornecedor(txtCNPJ.Text);

                        Excluir.ExcluirImagemFornecedor(Convert.ToInt32(txtCodigo.Text));
                    }
                    else if (IsCNPJFornecedorExiste == false)
                    {
                        MessageBox.Show("Fornecedor Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirCadastroFornecedor(ex);
            }
        }

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
            InserirImagemFornecedor();
        }

        private void InserirImagemFornecedor()
        {
            OpenFileDialog abrirPesquisa = new OpenFileDialog();

            abrirPesquisa.Filter = "Abrir Imagem (*.jpg; *.png; *.gif) |*.jpg; *.png; *.gif ";
            if (abrirPesquisa.ShowDialog() == DialogResult.OK)
            {
                pcbFornecedor.Image = Image.FromFile(abrirPesquisa.FileName);
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoCelular(txtTelefone);
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtTelefone);
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetras(e);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoCEP(txtCEP);
            }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            PreenchimentoPorCEP();
        }

        private void PreenchimentoPorCEP()
        {
            if (qntCEPexecutado == 0)
            {
                qntCEPexecutado++;

                if (txtCEP.Text != string.Empty)
                {
                    bool IsPreenchimentoCorreto;

                    IsPreenchimentoCorreto = ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtCEP);

                    if (IsPreenchimentoCorreto == true)
                    {
                        var tarefa = Api.APICorreios((txtCEP.Text).Replace("-", ""));
                        var esperador = tarefa.GetAwaiter();

                        esperador.OnCompleted(() =>
                           {
                               var item = Api.RetornoApi();

                               if (item.Uf != null)
                               {
                                   PreenchendoCamposCEP(item);

                                   txtCEP.BorderColorActive = Color.DodgerBlue;
                               }
                               else
                               {
                                   txtCEP.Focus();

                                   MessageBox.Show("CEP Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                               }
                           });
                    }
                }
                else
                {
                    ZerandoCamposPreenchidosCEP();
                }
            }
            else
            {
                qntCEPexecutado = 0;
            }
        }

        private void PreenchendoCamposCEP(DadosCEP _item)
        {
            txtEndereco.Text = _item.Logradouro;
            txtComplemento.Text = _item.Complemento;
            txtBairro.Text = _item.Bairro;
            txtCidade.Text = _item.Localidade;
            cmbUF.Text = _item.Uf;
        }

        private void ZerandoCamposPreenchidosCEP()
        {
            txtEndereco.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtBairro.Text = string.Empty;
            cmbUF.Text = string.Empty;
        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoCNPJ(e, txtCNPJ);
            }
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtCNPJ);
        }

        private void txtRazaoSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtNomeFantasia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoValidoParaEmail(e);
        }

        private void txtObservacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void Forms_CadastroFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
        }
    }
}