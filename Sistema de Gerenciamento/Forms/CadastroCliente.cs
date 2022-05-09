using Bunifu.UI.WinForms;
using Guna.UI.WinForms;
using Sistema_de_Gerenciamento.Classes;
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

namespace Sistema_de_Gerenciamento
{
    public partial class CadastroCliente : Form
    {
        private ManipulacaoTextBox TextBox = new ManipulacaoTextBox();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        public CadastroCliente()
        {
            InitializeComponent();
            txtDataCadastro.Text = DateTime.Today.ToShortDateString();
        }

        #region Botao Novo

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            TextBox.ApagandoTextBox(this);

            lblTipoDeCliente.Text = "CPF / CNPJ";
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
                        txtDataEmissao.Text,
                        cmbIns_Est.Text,
                        txtCEP.Text,
                        txtEndereco.Text,
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

                    MessageBox.Show("salvo com sucesso");
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
            Atualizar.Atualizar(Convert.ToInt32(txtCodigo.Text),
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

        #region TextBox Codigo

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Codigo

        #region TextBox Tipo

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

        #endregion TextBox Tipo

        #region TextBox CPF e CNPJ

        private void txtCPF_CNPJ_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

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

        private void txtCPF_CNPJ_Leave(object sender, EventArgs e)
        {
            if (txtCPF_CNPJ.Text.Length != txtCPF_CNPJ.MaxLength && txtCPF_CNPJ.Text.Length != 0)
            {
                txtCPF_CNPJ.BorderColorActive = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente!");
                txtCPF_CNPJ.Focus();
            }
            else if (txtCPF_CNPJ.Text.Length == txtCPF_CNPJ.MaxLength)
            {
                txtCPF_CNPJ.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox CPF e CNPJ

        #region TextBox RG

        private void txtRG_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

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

                MessageBox.Show("Por Favor Preencha o Campo Corretamente!");
                txtRG.Focus();
            }
            else if (txtRG.Text.Length == txtRG.MaxLength)
            {
                txtRG.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox RG

        #region TextBox Data de Emissao

        private void txtDataEmissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

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
            if (txtDataEmissao.Text.Length != txtDataEmissao.MaxLength && txtDataEmissao.Text.Length != 0)
            {
                txtDataEmissao.BorderColorActive = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente!");
                txtDataEmissao.Focus();
            }
            else if (txtDataEmissao.Text.Length == txtDataEmissao.MaxLength)
            {
                txtDataEmissao.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox Data de Emissao

        #region TextBox Data de Nascimento

        private void txtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

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
            if (txtDataNascimento.Text.Length != txtDataNascimento.MaxLength && txtDataNascimento.Text.Length != 0)
            {
                txtDataNascimento.BorderColorActive = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente!");
                txtDataNascimento.Focus();
            }
            else if (txtDataNascimento.Text.Length == txtDataNascimento.MaxLength)
            {
                txtDataNascimento.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox Data de Nascimento

        #region TextBox Nome

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Nome

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

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (txtCEP.Text.Length != txtCEP.MaxLength && txtCEP.Text.Length != 0)
            {
                txtCEP.BorderColorActive = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente!");
                txtCEP.Focus();
            }
            else if (txtCEP.Text.Length == txtCEP.MaxLength)
            {
                txtCEP.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox CEP

        #region TextBox Celular

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

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

                MessageBox.Show("Por Favor Preencha o Campo Corretamente!");
                txtCelular.Focus();
            }
            else if (txtCelular.Text.Length == txtCelular.MaxLength)
            {
                txtCelular.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox Celular

        #region TextBox Tel. Residencial

        private void txtTel_Residencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

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

                MessageBox.Show("Por Favor Preencha o Campo Corretamente!");
                txtTel_Residencial.Focus();
            }
            else if (txtTel_Residencial.Text.Length == txtTel_Residencial.MaxLength)
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
    }
}