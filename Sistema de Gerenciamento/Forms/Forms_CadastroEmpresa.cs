using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using QRCoder;
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

        private ApiCorreios Api = new ApiCorreios();

        public Forms_CadastroEmpresa()
        {
            InitializeComponent();

            PreenchimentoDosTextBox();
        }

        //private void Imagem()
        //{
        //    QRCodeGenerator qrGenerator = new QRCodeGenerator();
        //    QRCodeData qrCodeData = qrGenerator.CreateQrCode(txtTextoQR.Text, QRCodeGenerator.ECCLevel.Q);
        //    QRCode qrCode = new QRCode(qrCodeData);
        //    Bitmap qrCodeImage = qrCode.GetGraphic(20);
        //    pcbImagemQR.Image = qrCodeImage;
        //}

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCadastroEmpresa();
        }

        private void SalvarCadastroEmpresa()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    bool isExisteDadosCadastrados = Buscar.BuscarExistenciaCadastroEmpresa();

                    if (isExisteDadosCadastrados == true)
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
                            pcbEmpresa.Image,
                            txtCodigoQRCodePix.Text,
                            txtChavePix.Text,
                            pcbQRCodePix.Image);
                    }
                    else
                    {
                        MessageBox.Show("Empresa Já Cadastrada! \nSe Deseja Realizar Alteração Click Em Altera!", "Atenção!", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCadastroEmpresa(ex);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AtualziarCadastroEmpresa();
        }

        private void AtualziarCadastroEmpresa()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
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
                            txtCodigoQRCodePix.Text,
                            txtChavePix.Text,
                            Convert.ToInt32(lblce_id.Text));

                        Atualizar.AtualizarImagemNoCadastroEmpresa(pcbEmpresa.Image, pcbQRCodePix.Image, Convert.ToInt32(lblce_id.Text));
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCadastroEmpresa(ex);
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
            InserirImagemEmpresa();
        }

        #region Inserir Imagem Empresa

        private void InserirImagemEmpresa()
        {
            OpenFileDialog abrirPesquisa = new OpenFileDialog();

            abrirPesquisa.Filter = "Abrir Imagem (*.jpg; *.png; *.gif) |*.jpg; *.png; *.gif ";
            if (abrirPesquisa.ShowDialog() == DialogResult.OK)
            {
                pcbEmpresa.Image = Image.FromFile(abrirPesquisa.FileName);
            }
        }

        #endregion Inserir Imagem Empresa

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

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoCEP(txtCEP);
            }
        }

        private async void txtCEP_Leave(object sender, EventArgs e)
        {
            PreenchimentoPorCEP(txtCEP);
        }

        #region Buscar de Endereco por CEP

        private async void PreenchimentoPorCEP(BunifuTextBox _textBox)
        {
            try
            {
                if (ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtCEP) == true)
                {
                    await Api.APICorreios((_textBox.Text).Replace("-", ""));

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

                            _textBox.BorderColorActive = Color.DodgerBlue;
                        }
                        else
                        {
                            _textBox.Focus();
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

        #endregion Buscar de Endereco por CEP

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        #region Preechimento dos TextBox Com Buscar e Pelo Gridview

        private void PreenchimentoDosTextBox()
        {
            try
            {
                bool isCadastroExiste = Buscar.BuscarCadastroEmpresa(Convert.ToInt32(lblce_id.Text), gdvPesquisarEmpresa);

                if (gdvPesquisarEmpresa.RowCount >= 1)
                {
                    txtCNPJ.Text = gdvPesquisarEmpresa.SelectedCells[2].Value.ToString();
                    txtRazaoSocial.Text = gdvPesquisarEmpresa.SelectedCells[5].Value.ToString();
                    txtChavePix.Text = gdvPesquisarEmpresa.SelectedCells[6].Value.ToString();
                    txtNomeFantasia.Text = gdvPesquisarEmpresa.SelectedCells[7].Value.ToString();
                    txtCEP.Text = gdvPesquisarEmpresa.SelectedCells[8].Value.ToString();
                    txtEndereco.Text = gdvPesquisarEmpresa.SelectedCells[9].Value.ToString();
                    txtComplemento.Text = gdvPesquisarEmpresa.SelectedCells[10].Value.ToString();
                    txtBairro.Text = gdvPesquisarEmpresa.SelectedCells[11].Value.ToString();
                    txtCidade.Text = gdvPesquisarEmpresa.SelectedCells[12].Value.ToString();
                    cmbUF.Text = gdvPesquisarEmpresa.SelectedCells[13].Value.ToString();
                    txtNumero.Text = gdvPesquisarEmpresa.SelectedCells[14].Value.ToString();
                    txtTelefone.Text = gdvPesquisarEmpresa.SelectedCells[15].Value.ToString();
                    txtEmail.Text = gdvPesquisarEmpresa.SelectedCells[16].Value.ToString();
                    txtTextPadrao.Text = gdvPesquisarEmpresa.SelectedCells[17].Value.ToString();
                    txtCodigoQRCodePix.Text = gdvPesquisarEmpresa.SelectedCells[18].Value.ToString();

                    pcbEmpresa.Image = Buscar.BuscarLogoEmpresa(Convert.ToInt32(lblce_id.Text));

                    pcbQRCodePix.Image = Buscar.BuscarQrCodePix(Convert.ToInt32(lblce_id.Text));
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCarregarDadosEmpresa(ex);
            }
        }

        #endregion Preechimento dos TextBox Com Buscar e Pelo Gridview

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

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetras(e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoValidoParaEmail(e);
        }

        private void txtTextPadrao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtChavePix_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoValidoParaChavePix(e);
        }

        private void txtCodigoQRCodePix_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoValidoParaEmail(e);
        }

        private void txtCodigoQRCodePix_Leave(object sender, EventArgs e)
        {
            QRCodeImagem();
        }

        private void QRCodeImagem()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(txtCodigoQRCodePix.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pcbQRCodePix.Image = qrCodeImage;
        }
    }
}