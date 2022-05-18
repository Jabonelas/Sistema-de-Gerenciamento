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
    public partial class CadastroEmpresa : Form
    {
        private MensagensErro Erro = new MensagensErro();

        private ManipulacaoTextBox TextBox = new ManipulacaoTextBox();

        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        private ApiCorreios Api = new ApiCorreios();

        public CadastroEmpresa()
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

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        #region TextBox Numero

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Numero

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaEmpresa(txtCNPJ.Text) == false)
                    {
                        Salvar.InserirCadastroCliente(
                       Convert.ToDateTime(

                       pcbEmpresa.Image);

                        //Chamar o forms de alerta de inclusao com sucesso
                        Global.tipoDoAlerta = "Inclusao";

                        Aviso buscarCliente = new Aviso();
                        buscarCliente.Show();
                    }
                    else if (VerificarExistencia.VerificarExistenciaEmpresa(txtCNPJ.Text) == true)
                    {
                        MessageBox.Show("Empresa Já Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCadastroEmpresa(ex);
            }
        }
    }
}