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
    public partial class Forms_CadastroEmpresa : Form
    {
        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private ManipulacaoTextBox TextBox = new ManipulacaoTextBox();

        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        private ApiCorreios Api = new ApiCorreios();

        public Forms_CadastroEmpresa()
        {
            InitializeComponent();
        }

        #region Botao Sair

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Sair

        #region Botao Inserir Imagem

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirPesquisa = new OpenFileDialog();

            abrirPesquisa.Filter = "Abrir Imagem (*.jpg; *.png; *.gif) |*.jpg; *.png; *.gif ";
            if (abrirPesquisa.ShowDialog() == DialogResult.OK)
            {
                pcbEmpresa.Image = Image.FromFile(abrirPesquisa.FileName);
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

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTelefone.Focus();
            }
            else if (txtTelefone.Text.Length == txtTelefone.MaxLength || txtTelefone.Text.Length == 0)
            {
                txtTelefone.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox Telefone

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

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCNPJ.Focus();
            }
            else if (txtCNPJ.Text.Length == txtCNPJ.MaxLength || txtCNPJ.Text.Length == 0)
            {
                txtCNPJ.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox CNPJ

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
            try
            {
                if (txtCEP.Text.Length != txtCEP.MaxLength && txtCEP.Text.Length != 0)
                {
                    txtCEP.BorderColorActive = Color.Red;

                    MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCEP.Focus();
                }
                else if (txtCEP.Text.Length == txtCEP.MaxLength || txtCEP.Text.Length == 0)
                {
                    await Api.APICorreios((txtCEP.Text).Replace("-", ""));

                    int cont = 0;

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

                            if (cont == 0)
                            {
                                MessageBox.Show("CEP Não Encontrado!", "Atenção!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                cont++;
                            }

                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        #endregion TextBox CEP

        #region TextBox Numero

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Numero

        #region Botao Salvar

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (txtCNPJ.Text == string.Empty)
                    {
                        Salvar.InserirCadastroEmpresa(
                            txtRazaoSocial.Text,
                            txtCNPJ.Text,
                            txtNomeFantasia.Text,
                            txtCEP.Text,
                            txtEndereco.Text,
                            txtComplemento.Text,
                            txtBairro.Text,
                            txtCidade.Text,
                            cmbUF.Text,
                            Convert.ToInt32(txtNumero.Text),
                            txtTelefone.Text,
                            txtEmail.Text,
                            txtTextPadrao.Text,
                            pcbEmpresa.Image);

                        //Chamar o forms de alerta de inclusao com sucesso
                        Global.tipoDoAlerta = "Inclusao";

                        Forms_Aviso buscarCliente = new Forms_Aviso();
                        buscarCliente.Show();
                    }
                    else
                    {
                        MessageBox.Show("Empresa Já Cadastrada! \nSe Deseja Realizar Alteração Click Em Altera!", "Atenção!", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCadastroEmpresa(ex);
            }
        }

        #endregion Botao Salvar

        #region Load

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {
            try
            {
                bool isCadastroExiste = Buscar.BuscarCadastroEmpresa(Convert.ToInt32(lblce_id.Text), gdvPesquisarEmpresa);

                if (gdvPesquisarEmpresa.RowCount >= 1)
                {
                    int indice = 3;
                    txtRazaoSocial.Text = gdvPesquisarEmpresa.SelectedCells[indice += 1].Value.ToString();
                    txtCNPJ.Text = gdvPesquisarEmpresa.SelectedCells[indice += 1].Value.ToString();
                    txtNomeFantasia.Text = gdvPesquisarEmpresa.SelectedCells[indice += 1].Value.ToString();
                    txtCEP.Text = gdvPesquisarEmpresa.SelectedCells[indice += 1].Value.ToString();
                    txtEndereco.Text = gdvPesquisarEmpresa.SelectedCells[indice += 1].Value.ToString();
                    txtComplemento.Text = gdvPesquisarEmpresa.SelectedCells[indice += 1].Value.ToString();
                    txtBairro.Text = gdvPesquisarEmpresa.SelectedCells[indice += 1].Value.ToString();
                    txtCidade.Text = gdvPesquisarEmpresa.SelectedCells[indice += 1].Value.ToString();
                    cmbUF.Text = gdvPesquisarEmpresa.SelectedCells[indice += 1].Value.ToString();
                    txtNumero.Text = gdvPesquisarEmpresa.SelectedCells[indice += 1].Value.ToString();
                    txtTelefone.Text = gdvPesquisarEmpresa.SelectedCells[indice += 1].Value.ToString();
                    txtEmail.Text = gdvPesquisarEmpresa.SelectedCells[indice += 1].Value.ToString();
                    txtTextPadrao.Text = gdvPesquisarEmpresa.SelectedCells[indice += 1].Value.ToString();

                    pcbEmpresa.Image = Buscar.BuscarImagemEmpresa(Convert.ToInt32(lblce_id.Text));
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCarregarDadosEmpresa(ex);
            }
        }

        #endregion Load

        #region Botao Alterar

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (txtCNPJ.Text != string.Empty)
                    {
                        Atualizar.AtualizarCadastroEmpresa(
                            txtRazaoSocial.Text,
                            txtCNPJ.Text,
                            txtNomeFantasia.Text,
                            txtCEP.Text,
                            txtEndereco.Text,
                            txtComplemento.Text,
                            txtBairro.Text,
                            txtCidade.Text,
                            cmbUF.Text,
                            Convert.ToInt32(txtNumero.Text),
                            txtTelefone.Text,
                            txtEmail.Text,
                            txtTextPadrao.Text,
                            Convert.ToInt32(lblce_id.Text)

                            );

                        Atualizar.AtualizarImagemNoCadastroEmpresa(pcbEmpresa.Image, Convert.ToInt32(lblce_id.Text));

                        //Chamar o forms de alerta de atualizacao com sucesso
                        Global.tipoDoAlerta = "Atualizacao";

                        Forms_Aviso buscarCliente = new Forms_Aviso();
                        buscarCliente.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Preenchimento Dos Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCadastroEmpresa(ex);
            }
        }

        #endregion Botao Alterar
    }
}