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
using Sistema_de_Gerenciamento.Classes.QuickType;
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

        private int qntCEPexecutado = 0;

        public Forms_CadastroEmpresa()
        {
            InitializeComponent();

            PreenchimentoDosTextBox();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCadastroEmpresa();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AtualziarCadastroEmpresa();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
            InserirImagemEmpresa();
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

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            PreenchimentoPorCEP(txtCEP);
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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void PreenchimentoPorCEP(BunifuTextBox _txtCEP)
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
                        var tareefa = Api.APICorreios((_txtCEP.Text).Replace("-", ""));
                        var esperador = tareefa.GetAwaiter();

                        esperador.OnCompleted(() =>
                        {
                            var item = Api.RetornoApi();

                            if (item.Uf != null)
                            {
                                PreenchendoCamposCEP(item);

                                _txtCEP.BorderColorActive = Color.DodgerBlue;
                            }
                            else
                            {
                                _txtCEP.Focus();

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

        private DadosCadastroEmpresa preencherDadosCadastroEmpresa()
        {
            DadosCadastroEmpresa dadosCadastroEmpresa = new DadosCadastroEmpresa();

            dadosCadastroEmpresa.razaoSocial = txtRazaoSocial.Text;
            dadosCadastroEmpresa.cnpj = txtCNPJ.Text;
            dadosCadastroEmpresa.nomeFantasia = txtNomeFantasia.Text;
            dadosCadastroEmpresa.cep = txtCEP.Text;
            dadosCadastroEmpresa.endereco = txtEndereco.Text;
            dadosCadastroEmpresa.complemento = txtComplemento.Text;
            dadosCadastroEmpresa.bairro = txtBairro.Text;
            dadosCadastroEmpresa.cidade = txtCidade.Text;
            dadosCadastroEmpresa.uf = cmbUF.Text;
            dadosCadastroEmpresa.numero = Convert.ToInt32(txtNumero.Text);
            dadosCadastroEmpresa.telefone = txtTelefone.Text;
            dadosCadastroEmpresa.email = txtEmail.Text;
            dadosCadastroEmpresa.textoPadrao = txtTextoPadrao.Text;
            dadosCadastroEmpresa.codigoQR = txtCodigoQRCodePix.Text;
            dadosCadastroEmpresa.chavePix = txtChavePix.Text;
            dadosCadastroEmpresa.id = Convert.ToInt32(lblce_id.Text);

            return dadosCadastroEmpresa;
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
                        DadosCadastroEmpresa dadosCadastroEmpresa;

                        dadosCadastroEmpresa = preencherDadosCadastroEmpresa();

                        Salvar.InserirCadastroEmpresa(dadosCadastroEmpresa, pcbEmpresa.Image, pcbQRCodePix.Image);
                    }
                    else
                    {
                        MessageBox.Show("Empresa Já Cadastrada! \nSe Deseja Realizar Alteração Click Em Altera!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCadastroEmpresa(ex);
            }
        }

        private void AtualziarCadastroEmpresa()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    if (txtCNPJ.Text != string.Empty)
                    {
                        DadosCadastroEmpresa dadosCadastroEmpresa;

                        dadosCadastroEmpresa = preencherDadosCadastroEmpresa();

                        Atualizar.AtualizarCadastroEmpresa(dadosCadastroEmpresa);

                        Atualizar.AtualizarImagemNoCadastroEmpresa(pcbEmpresa.Image, pcbQRCodePix.Image, Convert.ToInt32(lblce_id.Text));
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCadastroEmpresa(ex);
            }
        }

        private void InserirImagemEmpresa()
        {
            OpenFileDialog abrirPesquisa = new OpenFileDialog();

            abrirPesquisa.Filter = "Abrir Imagem (*.jpg; *.png; *.gif) |*.jpg; *.png; *.gif ";
            if (abrirPesquisa.ShowDialog() == DialogResult.OK)
            {
                pcbEmpresa.Image = Image.FromFile(abrirPesquisa.FileName);
            }
        }

        private void PreenchimentoDosTextBox()
        {
            try
            {
                List<DadosCadastroEmpresa> listaDadosCadastroEmpresas = new List<DadosCadastroEmpresa>();

                listaDadosCadastroEmpresas = Buscar.BuscarCadastroEmpresa(Convert.ToInt32(lblce_id.Text));

                txtCNPJ.Text = listaDadosCadastroEmpresas[0].cnpj;
                txtRazaoSocial.Text = listaDadosCadastroEmpresas[0].razaoSocial;
                txtChavePix.Text = listaDadosCadastroEmpresas[0].chavePix;
                txtNomeFantasia.Text = listaDadosCadastroEmpresas[0].nomeFantasia;
                txtCEP.Text = listaDadosCadastroEmpresas[0].cep;
                txtEndereco.Text = listaDadosCadastroEmpresas[0].endereco;
                txtComplemento.Text = listaDadosCadastroEmpresas[0].complemento;
                txtBairro.Text = listaDadosCadastroEmpresas[0].bairro;
                txtCidade.Text = listaDadosCadastroEmpresas[0].cidade;
                cmbUF.Text = listaDadosCadastroEmpresas[0].uf;
                txtNumero.Text = listaDadosCadastroEmpresas[0].numero.ToString();
                txtTelefone.Text = listaDadosCadastroEmpresas[0].telefone;
                txtEmail.Text = listaDadosCadastroEmpresas[0].email;
                txtTextoPadrao.Text = listaDadosCadastroEmpresas[0].textoPadrao;
                txtCodigoQRCodePix.Text = listaDadosCadastroEmpresas[0].codigoQR;

                pcbEmpresa.Image = Buscar.BuscarLogoEmpresa(Convert.ToInt32(lblce_id.Text));

                pcbQRCodePix.Image = Buscar.BuscarQrCodePix(Convert.ToInt32(lblce_id.Text));
            }
            catch (Exception ex)
            {
                Erro.ErroAoCarregarDadosEmpresa(ex);
            }
        }

        private void QRCodeImagem()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(txtCodigoQRCodePix.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pcbQRCodePix.Image = qrCodeImage;
        }

        private void Forms_CadastroEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
        }
    }
}