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
            }
            else if (cmbTipo.Text == "Pess. Juridica")
            {
                Global.tipoDeCliente = "Pess. Juridica";

                lblTipoDeCliente.Text = "CNPJ";

                //txtRG.Text = "------------";
                //cmbEmissor.Text = "casa";
                //cmbEmissor.Text = "casa";
                //txtDataEmissao.Text = "---------";
                //cmbIns_Est.Text = "casa";

                //testando.Items = "adca";
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

        #endregion TextBox Tel. Residencial

        private void txtCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                //"R$ 1.000,00"
                //        "R$ 200,00"
                //        "R$ 20,00"

                if (txtCredito.TextLength == 11)
                {
                    switch (txtCredito.TextLength)
                    {
                        case 0:
                            txtCredito.Text = "R$ ";
                            txtCredito.SelectionStart = 3;
                            break;

                        case 5:
                            txtCredito.Text = txtCredito.Text + ".";
                            txtCredito.SelectionStart = 6;
                            break;

                        case 9:
                            txtCredito.Text = txtCredito.Text + ",";
                            txtCredito.SelectionStart = 10;
                            break;
                    }
                }
                else if (txtCredito.TextLength >= 7)
                {
                    switch (txtCredito.TextLength)
                    {
                        case 0:
                            txtCredito.Text = "R$ ";
                            txtCredito.SelectionStart = 3;
                            break;

                        //case 5:
                        //    txtCredito.Text = txtCredito.Text + ".";
                        //    txtCredito.SelectionStart = 6;
                        //    break;

                        case 4:
                            txtCredito.Text = txtCredito.Text + ",";
                            txtCredito.SelectionStart = 5;
                            break;
                    }
                }
            }
        }
    }
}