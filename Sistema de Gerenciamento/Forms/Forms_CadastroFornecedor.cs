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

        #region Salvar Cadastro Fornecedor

        private void SalvarCadastroFornecedor()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(txtCNPJ.Text) == false)
                    {
                        lblForeignKey.Text = (Salvar.InserirImagemNoCadastroFornecedor(pcbFornecedor.Image)).ToString();

                        txtCodigo.Text = (Salvar.InserirCadastroForncedor(
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
                            txtObservacoes.Text,
                            Convert.ToInt32(lblForeignKey.Text))).ToString();
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(txtCNPJ.Text) == true)
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

        #endregion Salvar Cadastro Fornecedor

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AtualizarCadastroFornecedor();
        }

        #region Atualizar Cadastro Fornecedor

        private void AtualizarCadastroFornecedor()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
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
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(txtCNPJ.Text) == false)
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

        #endregion Atualizar Cadastro Fornecedor

        private void btnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            Forms_PesquisarFornecedor buscarFornecedor = new Forms_PesquisarFornecedor(this);
            buscarFornecedor.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCadastroFornecedor();
        }

        #region Excluir Cadastro Fornecedor

        private void ExcluirCadastroFornecedor()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(txtCNPJ.Text) == true)
                    {
                        Excluir.ExcluirCadastroFornecedor(txtCNPJ.Text);

                        Excluir.ExcluirImagemFornecedor(Convert.ToInt32(txtCodigo.Text));
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(txtCNPJ.Text) == false)
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

        #endregion Excluir Cadastro Fornecedor

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
            InserirImagemFornecedor();
        }

        #region Inserir Imagem Fornecedor

        private void InserirImagemFornecedor()
        {
            OpenFileDialog abrirPesquisa = new OpenFileDialog();

            abrirPesquisa.Filter = "Abrir Imagem (*.jpg; *.png; *.gif) |*.jpg; *.png; *.gif ";
            if (abrirPesquisa.ShowDialog() == DialogResult.OK)
            {
                pcbFornecedor.Image = Image.FromFile(abrirPesquisa.FileName);
            }
        }

        #endregion Inserir Imagem Fornecedor

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

        private async void txtCEP_Leave(object sender, EventArgs e)
        {
            PreenchimentoPorCEP();
        }

        #region Preenchimento dos TextBox Por Buscar Com CEP

        private async void PreenchimentoPorCEP()
        {
            if (qntCEPexecutado == 0)
            {
                qntCEPexecutado++;

                try
                {
                    if (txtCEP.Text.Length != txtCEP.MaxLength && txtCEP.Text.Length != 0)
                    {
                        txtCEP.BorderColorActive = Color.Red;

                        MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtCEP.Focus();
                    }
                    else if (txtCEP.Text.Length == txtCEP.MaxLength || txtCEP.Text.Length == 0)
                    {
                        await Api.APICorreios((txtCEP.Text).Replace("-", ""));

                        foreach (var item in Api.RetornoApi())
                        {
                            if (item.Uf != null)
                            {
                                txtEndereco.Text = item.Logradouro;
                                txtComplemento.Text = item.Complemento;
                                txtBairro.Text = item.Bairro;
                                txtCidade.Text = item.Localidade;
                                cmbUF.Text = item.Uf;

                                Api.ZerarLista();

                                txtCEP.BorderColorActive = Color.DodgerBlue;
                            }
                            else
                            {
                                txtCEP.Focus();

                                Api.ZerarLista();

                                MessageBox.Show("CEP Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                break;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
            else
            {
                qntCEPexecutado = 0;
            }
        }

        #endregion Preenchimento dos TextBox Por Buscar Com CEP

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
    }
}