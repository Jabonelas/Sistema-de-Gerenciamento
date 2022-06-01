using Bunifu.UI.WinForms;
using Guna.UI.WinForms;
using Sistema_de_Gerenciamento.Classes;
using Sistema_de_Gerenciamento.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;

namespace Sistema_de_Gerenciamento
{
    public partial class Forms_CadastroCliente : Form
    {
        private ManipulacaoTextBox ManipularTextBox = new ManipulacaoTextBox();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        private ExcluirNoBanco Excluir = new ExcluirNoBanco();

        private ApiCorreios Api = new ApiCorreios();

        public Forms_CadastroCliente()
        {
            InitializeComponent();

            txtDataCadastro.Text = DateTime.Today.ToShortDateString();
        }

        #region Botao Novo

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            ManipularTextBox.ApagandoTextBox(this);

            lblTipoDeCliente.Text = "CPF / CNPJ";

            pcbCliente.Image = Image.FromFile(@"C:\Users\israe\source\repos\Sistema de Gerenciamento\Sistema de Gerenciamento\Resources\imagem-do-usuario-com-fundo-preto.png");
        }

        #endregion Botao Novo

        #region Botao Salvar

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ManipularTextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeCPF_CNPJ_Cliente(txtCPF_CNPJ.Text) == false)
                    {
                        lblCodigoCliente.Text = (Salvar.InserirImagemNoCadastroCliente(pcbCliente.Image)).ToString();

                        txtCodigo.Text = ((Salvar.InserirCadastroCliente(
                            Convert.ToDateTime(txtDataCadastro.Text),
                            txtNome.Text,
                            cmbTipo.Text,
                            txtCPF_CNPJ.Text,
                            txtRG.Text,
                            cmbEmissor.Text,
                            txtDataEmissao.Text,
                            cmbIns_Est.Text,
                            txtCEP.Text,
                            txtEndereco.Text,
                            Convert.ToInt32(txtNumero.Text),
                            txtComplemento.Text,
                            txtBairro.Text,
                            txtCidade.Text,
                            cmbUF.Text,
                            txtNaturalidade.Text,
                            txtDataNascimento.Text,
                            cmbEstadoCivil.Text,
                            Convert.ToDecimal(txtCredito.Text.Replace("R$ ", string.Empty)),
                            Convert.ToDecimal(txtSaldo.Text.Replace("R$ ", string.Empty)),
                            cmbBloqueio.Text,
                            txtCelular.Text,
                            txtTel_Residencial.Text,
                            txtEmail.Text,
                            txtObservacoes.Text,
                            Convert.ToInt32(lblCodigoCliente.Text))).ToString());
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeCPF_CNPJ_Cliente(txtCPF_CNPJ.Text) == true)
                    {
                        MessageBox.Show("Cliente Já Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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

        #region Botao Atualizar

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (ManipularTextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeCPF_CNPJ_Cliente(txtCPF_CNPJ.Text) == true)
                    {
                        Atualizar.AtualizarCadastroCliente(
                                    Convert.ToDateTime(txtDataCadastro.Text),
                                    txtNome.Text,
                                    cmbTipo.Text,
                                    txtCPF_CNPJ.Text,
                                    txtRG.Text,
                                    cmbEmissor.Text,
                                    txtDataEmissao.Text,
                                    cmbIns_Est.Text,
                                    txtCEP.Text,
                                    txtEndereco.Text,
                                    Convert.ToInt32(txtNumero.Text),
                                    txtComplemento.Text,
                                    txtBairro.Text,
                                    txtCidade.Text,
                                    cmbUF.Text,
                                    txtNaturalidade.Text,
                                    txtDataNascimento.Text,
                                    cmbEstadoCivil.Text,
                                    Convert.ToDecimal(txtCredito.Text.Replace("R$ ", "")),
                                    Convert.ToDecimal(txtSaldo.Text.Replace("R$ ", "")),
                                    cmbBloqueio.Text,
                                    txtCelular.Text,
                                    txtTel_Residencial.Text,
                                    txtEmail.Text,
                                    txtObservacoes.Text);

                        Atualizar.AtualizarImagemNoCadastroCliente(pcbCliente.Image, Convert.ToInt32(txtCodigo.Text));
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeCPF_CNPJ_Cliente(txtCPF_CNPJ.Text) == false)
                    {
                        MessageBox.Show("Cliente Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        #endregion Botao Atualizar

        #region Botao Buscar

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Forms_PesquisarCliente buscarCliente = new Forms_PesquisarCliente(this);
            buscarCliente.ShowDialog();
        }

        #endregion Botao Buscar

        #region Botao Excluir

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (ManipularTextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeCPF_CNPJ_Cliente(txtCPF_CNPJ.Text) == true)
                    {
                        Excluir.ExcluirCadastroCliente(txtCPF_CNPJ.Text);

                        Excluir.ExcluirImagemCliente(Convert.ToInt32(txtCodigo.Text));
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeCPF_CNPJ_Cliente(txtCPF_CNPJ.Text) == false)
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
                pcbCliente.Image = Image.FromFile(abrirPesquisa.FileName);
            }
        }

        #endregion Botao Inserir Imagem

        #region TextBox Codigo

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipularTextBox.DigitarApenasNumeros(e);
        }

        #endregion TextBox Codigo

        #region ComboBox Tipo

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "Pess. Fisica")
            {
                Global.tipoDeCliente = "Pess. Fisica";

                lblTipoDeCliente.Text = "CPF";

                txtRG.Text = string.Empty;
                cmbEmissor.Text = string.Empty;
                txtDataEmissao.Text = string.Empty;
                cmbIns_Est.Text = string.Empty;
                txtNaturalidade.Text = string.Empty;
                txtDataNascimento.Text = string.Empty;
                cmbEstadoCivil.Text = string.Empty;
            }
            else if (cmbTipo.Text == "Pess. Juridica")
            {
                Global.tipoDeCliente = "Pess. Juridica";

                lblTipoDeCliente.Text = "CNPJ";

                txtRG.Text = "---------------";
                cmbEmissor.Text = "----";
                txtDataEmissao.Text = "----------";
                cmbIns_Est.Text = "--";
                txtNaturalidade.Text = "----------";
                txtDataNascimento.Text = "----------";
                cmbEstadoCivil.Text = "--------------";
            }
        }

        #endregion ComboBox Tipo

        #region TextBox CPF e CNPJ

        private void txtCPF_CNPJ_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ManipularTextBox.DigitarApenasNumeros(e);

            if (cmbTipo.Text == "Pess. Fisica")
            {
                txtCPF_CNPJ.MaxLength = 14;

                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtCPF_CNPJ.TextLength)
                    {
                        case 0:
                            txtCPF_CNPJ.Text = "";
                            break;

                        case 3:
                            txtCPF_CNPJ.Text = txtCPF_CNPJ.Text + ".";
                            txtCPF_CNPJ.SelectionStart = 4;
                            break;

                        case 7:
                            txtCPF_CNPJ.Text = txtCPF_CNPJ.Text + ".";
                            txtCPF_CNPJ.SelectionStart = 8;
                            break;

                        case 11:
                            txtCPF_CNPJ.Text = txtCPF_CNPJ.Text + "-";
                            txtCPF_CNPJ.SelectionStart = 12;
                            break;
                    }
                }
            }
            else if (cmbTipo.Text == "Pess. Juridica")
            {
                txtCPF_CNPJ.MaxLength = 18;

                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtCPF_CNPJ.TextLength)
                    {
                        case 0:
                            txtCPF_CNPJ.Text = "";
                            break;

                        case 2:
                            txtCPF_CNPJ.Text = txtCPF_CNPJ.Text + ".";
                            txtCPF_CNPJ.SelectionStart = 3;
                            break;

                        case 6:
                            txtCPF_CNPJ.Text = txtCPF_CNPJ.Text + ".";
                            txtCPF_CNPJ.SelectionStart = 7;
                            break;

                        case 10:
                            txtCPF_CNPJ.Text = txtCPF_CNPJ.Text + "/";
                            txtCPF_CNPJ.SelectionStart = 11;
                            break;

                        case 15:
                            txtCPF_CNPJ.Text = txtCPF_CNPJ.Text + "-";
                            txtCPF_CNPJ.SelectionStart = 16;
                            break;
                    }
                }
            }
        }

        private void txtCPF_CNPJ_Enter(object sender, EventArgs e)
        {
            if (cmbTipo.Text == String.Empty)
            {
                MessageBox.Show("Por Favor Preencha Primeiro O Campo Tipo!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbTipo.Focus();
            }
        }

        private void txtCPF_CNPJ_Leave(object sender, EventArgs e)
        {
            if (txtCPF_CNPJ.Text.Length != txtCPF_CNPJ.MaxLength && txtCPF_CNPJ.Text.Length != 0)
            {
                txtCPF_CNPJ.BorderColorActive = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCPF_CNPJ.Focus();
            }
            else if (txtCPF_CNPJ.Text.Length == txtCPF_CNPJ.MaxLength || txtCPF_CNPJ.Text.Length == 0)
            {
                txtCPF_CNPJ.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox CPF e CNPJ

        #region TextBox RG

        private void txtRG_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ManipularTextBox.DigitarApenasNumeros(e);

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtRG.TextLength)
                {
                    case 0:
                        txtRG.Text = "";
                        break;

                    case 2:
                        txtRG.Text = txtRG.Text + ".";
                        txtRG.SelectionStart = 3;
                        break;

                    case 6:
                        txtRG.Text = txtRG.Text + ".";
                        txtRG.SelectionStart = 7;
                        break;

                    case 10:
                        txtRG.Text = txtRG.Text + "-";
                        txtRG.SelectionStart = 11;
                        break;
                }
            }
        }

        private void txtRG_Leave(object sender, EventArgs e)
        {
            if (txtRG.Text.Length != txtRG.MaxLength && txtRG.Text.Length != 0)
            {
                txtRG.BorderColorActive = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtRG.Focus();
            }
            else if (txtRG.Text.Length == txtRG.MaxLength || txtRG.Text.Length == 0)
            {
                txtRG.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox RG

        #region TextBox Data de Emissao

        private void txtDataEmissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipularTextBox.DigitarApenasNumeros(e);

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtDataEmissao.TextLength)
                {
                    case 0:
                        txtDataEmissao.Text = "";
                        break;

                    case 2:
                        txtDataEmissao.Text = txtDataEmissao.Text + "/";
                        txtDataEmissao.SelectionStart = 3;
                        break;

                    case 5:
                        txtDataEmissao.Text = txtDataEmissao.Text + "/";
                        txtDataEmissao.SelectionStart = 6;
                        break;
                }
            }
        }

        private void txtDataEmissao_Leave(object sender, EventArgs e)
        {
            //Verificação se o campo do totalmente preenchido
            if (txtDataEmissao.Text.Length != txtDataEmissao.MaxLength && txtDataEmissao.Text.Length != 0)
            {
                txtDataEmissao.BorderColorActive = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente!", "Atencao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtDataEmissao.Focus();
            }
            else if (txtDataEmissao.Text.Length == txtDataEmissao.MaxLength || txtDataEmissao.Text.Length == 0)
            {
                txtDataEmissao.BorderColorActive = Color.DodgerBlue;
            }
            //Verificação se o campo foi preenchido com um formato valido
            if (txtDataEmissao.Text.Length == txtDataEmissao.MaxLength)
            {
                DateTime time;
                if (DateTime.TryParse(txtDataEmissao.Text, out time))
                {
                    txtDataEmissao.BorderColorActive = Color.DodgerBlue;
                }
                else
                {
                    txtDataEmissao.BorderColorActive = Color.Red;

                    MessageBox.Show($"Data Errada: {txtDataEmissao.Text}", "Atencao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtDataEmissao.Focus();
                }
            }
        }

        #endregion TextBox Data de Emissao

        #region TextBox Data de Nascimento

        private void txtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipularTextBox.DigitarApenasNumeros(e);

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtDataNascimento.TextLength)
                {
                    case 0:
                        txtDataNascimento.Text = "";
                        break;

                    case 2:
                        txtDataNascimento.Text = txtDataNascimento.Text + "/";
                        txtDataNascimento.SelectionStart = 3;
                        break;

                    case 5:
                        txtDataNascimento.Text = txtDataNascimento.Text + "/";
                        txtDataNascimento.SelectionStart = 6;
                        break;
                }
            }
        }

        private void txtDataNascimento_Leave(object sender, EventArgs e)
        {
            //Verificação se o campo do totalmente preenchido
            if (txtDataNascimento.Text.Length != txtDataNascimento.MaxLength && txtDataNascimento.Text.Length != 0)
            {
                txtDataNascimento.BorderColorActive = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtDataNascimento.Focus();
            }
            else if (txtDataNascimento.Text.Length == txtDataNascimento.MaxLength || txtDataNascimento.Text.Length == 0)
            {
                txtDataNascimento.BorderColorActive = Color.DodgerBlue;
            }
            //Verificação se o campo foi preenchido com um formato valido
            if (txtDataNascimento.Text.Length == txtDataNascimento.MaxLength)
            {
                DateTime time;
                if (DateTime.TryParse(txtDataNascimento.Text, out time))
                {
                    txtDataNascimento.BorderColorActive = Color.DodgerBlue;
                }
                else
                {
                    txtDataNascimento.BorderColorActive = Color.Red;
                    MessageBox.Show($"Data Errada: {txtDataNascimento.Text}", "Atencao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDataNascimento.Focus();
                }
            }
        }

        #endregion TextBox Data de Nascimento

        #region TextBox Nome

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Nome

        #region TextBox CEP

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipularTextBox.DigitarApenasNumeros(e);

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

                    MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                                MessageBox.Show("CEP Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        #region TextBox Celular

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipularTextBox.DigitarApenasNumeros(e);

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCelular.TextLength)
                {
                    case 0:
                        txtCelular.Text = "(";
                        txtCelular.SelectionStart = 1;
                        break;

                    case 3:
                        txtCelular.Text = txtCelular.Text + ") ";
                        txtCelular.SelectionStart = 5;
                        break;

                    case 10:
                        txtCelular.Text = txtCelular.Text + "-";
                        txtCelular.SelectionStart = 11;
                        break;
                }
            }
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            if (txtCelular.Text.Length != txtCelular.MaxLength && txtCelular.Text.Length != 0)
            {
                txtCelular.BorderColorActive = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCelular.Focus();
            }
            else if (txtCelular.Text.Length == txtCelular.MaxLength || txtCelular.Text.Length == 0)
            {
                txtCelular.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox Celular

        #region TextBox Tel. Residencial

        private void txtTel_Residencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipularTextBox.DigitarApenasNumeros(e);

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtTel_Residencial.TextLength)
                {
                    case 0:
                        txtTel_Residencial.Text = "(";
                        txtTel_Residencial.SelectionStart = 1;
                        break;

                    case 3:
                        txtTel_Residencial.Text = txtTel_Residencial.Text + ") ";
                        txtTel_Residencial.SelectionStart = 5;
                        break;

                    case 10:
                        txtTel_Residencial.Text = txtTel_Residencial.Text + "-";
                        txtTel_Residencial.SelectionStart = 11;
                        break;
                }
            }
        }

        private void txtTel_Residencial_Leave(object sender, EventArgs e)
        {
            if (txtTel_Residencial.Text.Length != txtTel_Residencial.MaxLength && txtTel_Residencial.Text.Length != 0)
            {
                txtTel_Residencial.FocusedBorderColor = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTel_Residencial.Focus();
            }
            else if (txtTel_Residencial.Text.Length == txtTel_Residencial.MaxLength || txtTel_Residencial.Text.Length == 0)
            {
                txtTel_Residencial.FocusedBorderColor = Color.DodgerBlue;
            }
        }

        #endregion TextBox Tel. Residencial

        #region TextBox Credito

        private void txtCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                txtCredito.MaxLength = 10;

                if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    if (txtCredito.Text.Length <= 13 || e.KeyChar.Equals((char)Keys.Back))
                    {
                        TextBox textbox = (TextBox)sender;
                        string testoDoTextBox = Regex.Replace(textbox.Text, "[^0-9]", string.Empty);
                        if (testoDoTextBox == string.Empty)
                        {
                            testoDoTextBox = "00";
                        }

                        testoDoTextBox += e.KeyChar;
                        textbox.Text = String.Format("R$ {0:#,##0.00}", double.Parse(testoDoTextBox) / 100);
                        textbox.Select(textbox.Text.Length, 0);
                    }
                }
                e.Handled = true;
            }
            catch (Exception)
            {
            }
        }

        #endregion TextBox Credito

        #region TextBox Saldo

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    if (txtSaldo.Text.Length <= 13 || e.KeyChar.Equals((char)Keys.Back))
                    {
                        TextBox textbox = (TextBox)sender;
                        string textoDoTextBox = Regex.Replace(textbox.Text, "[^0-9]", string.Empty);
                        if (textoDoTextBox == string.Empty)
                        {
                            textoDoTextBox = "00";
                        }

                        textoDoTextBox += e.KeyChar;
                        textbox.Text = String.Format("R$ {0:#,##0.00}", double.Parse(textoDoTextBox) / 100);
                        textbox.Select(textbox.Text.Length, 0);
                    }
                }

                e.Handled = true;
            }
            catch (Exception)
            {
            }
        }

        #endregion TextBox Saldo

        #region TextBox Cidade

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipularTextBox.DigitarApenasNumeros(e);
        }

        #endregion TextBox Cidade

        #region TextBox Naturalidade

        private void txtNaturalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipularTextBox.DigitarApenasNumeros(e);
        }

        #endregion TextBox Naturalidade

        #region TextBox Numero

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipularTextBox.DigitarApenasNumeros(e);
        }

        #endregion TextBox Numero
    }
}