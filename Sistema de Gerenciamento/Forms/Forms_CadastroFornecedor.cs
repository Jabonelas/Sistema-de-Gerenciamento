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

namespace Sistema_de_Gerenciamento
{
    public partial class Forms_CadastroFornecedor : Form
    {
        private ManipulacaoTextBox TextBox = new ManipulacaoTextBox();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        private ExcluirNoBanco Excluir = new ExcluirNoBanco();

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private ApiCorreios Api = new ApiCorreios();

        private int qntCEPexecutado = 0;

        public Forms_CadastroFornecedor()
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
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
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

                        //Chamar o forms de alerta de inclusao com sucesso
                        Global.tipoDoAlerta = "Inclusao";

                        Forms_Aviso buscarCliente = new Forms_Aviso();
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
            catch (Exception ex)
            {
                Erro.ErroAoCadastroFornecedor(ex);
            }
        }

        #endregion Botao Salvar

        #region Botao Atualizar

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

                        Forms_Aviso buscarCliente = new Forms_Aviso();
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
                Erro.ErroAoAtualizarCadastroFornecedor(ex);
            }
        }

        #endregion Botao Atualizar

        #region Botao Buscar

        private void btnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            Forms_PesquisarFornecedor buscarFornecedor = new Forms_PesquisarFornecedor(this);
            buscarFornecedor.ShowDialog();
        }

        #endregion Botao Buscar

        #region Botao Excluir

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(txtCNPJ.Text) == true)
                    {
                        Excluir.ExcluirCadastroFornecedor(txtCNPJ.Text);

                        Excluir.ExcluirImagemFornecedor(Convert.ToInt32(txtCodigo.Text));

                        //Chamar o forms de alerta de exclusao com sucesso
                        Global.tipoDoAlerta = "Exclusao";

                        Forms_Aviso buscarCliente = new Forms_Aviso();
                        buscarCliente.Show();
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(txtCNPJ.Text) == false)
                    {
                        MessageBox.Show("Fornecedor Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirCadastroFornecedor(ex);
            }
        }

        #endregion Botao Excluir

        #region Botao Inserir Imagem

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirPesquisa = new OpenFileDialog();

            abrirPesquisa.Filter = "Abrir Imagem (*.jpg; *.png; *.gif) |*.jpg; *.png; *.gif ";
            if (abrirPesquisa.ShowDialog() == DialogResult.OK)
            {
                pcbFornecedor.Image = Image.FromFile(abrirPesquisa.FileName);
            }
        }

        #endregion Botao Inserir Imagem

        #region TextBox Telefone

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtTelefone.TextLength)
                {
                    case 0:
                        txtTelefone.Text = "(";
                        txtTelefone.SelectionStart = 1;
                        break;

                    case 3:
                        txtTelefone.Text = txtTelefone.Text + ") ";
                        txtTelefone.SelectionStart = 5;
                        break;

                    case 10:
                        txtTelefone.Text = txtTelefone.Text + "-";
                        txtTelefone.SelectionStart = 11;
                        break;
                }
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.Text.Length != txtTelefone.MaxLength && txtTelefone.Text.Length != 0)
            {
                txtTelefone.BorderColorActive = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTelefone.Focus();
            }
            else if (txtTelefone.Text.Length == txtTelefone.MaxLength || txtTelefone.Text.Length == 0)
            {
                txtTelefone.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox Telefone

        #region TextBox Cidade

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Cidade

        #region TextBox Numero

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Numero

        #region TextBox CEP

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCEP.TextLength)
                {
                    case 0:
                        txtCEP.Text = "";
                        break;

                    case 5:
                        txtCEP.Text = txtCEP.Text + "-";
                        txtCEP.SelectionStart = 6;
                        break;
                }
            }
        }

        private async void txtCEP_Leave(object sender, EventArgs e)
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

            //txtCEP.Focus();
        }

        #endregion TextBox CEP

        #region TextBox CNPJ

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCNPJ.MaxLength = 18;

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCNPJ.TextLength)
                {
                    case 0:
                        txtCNPJ.Text = "";
                        break;

                    case 2:
                        txtCNPJ.Text = txtCNPJ.Text + ".";
                        txtCNPJ.SelectionStart = 3;
                        break;

                    case 6:
                        txtCNPJ.Text = txtCNPJ.Text + ".";
                        txtCNPJ.SelectionStart = 7;
                        break;

                    case 10:
                        txtCNPJ.Text = txtCNPJ.Text + "/";
                        txtCNPJ.SelectionStart = 11;
                        break;

                    case 15:
                        txtCNPJ.Text = txtCNPJ.Text + "-";
                        txtCNPJ.SelectionStart = 16;
                        break;
                }
            }
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (txtCNPJ.Text.Length != txtCNPJ.MaxLength && txtCNPJ.Text.Length != 0)
            {
                txtCNPJ.BorderColorActive = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCNPJ.Focus();
            }
            else if (txtCNPJ.Text.Length == txtCNPJ.MaxLength || txtCNPJ.Text.Length == 0)
            {
                txtCNPJ.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox CNPJ
    }
}