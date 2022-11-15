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
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;
using DevExpress.CodeParser;
using Sistema_de_Gerenciamento.Classes.QuickType;
using Sistema_de_Gerenciamento.Properties;
using System.Windows.Documents;

namespace Sistema_de_Gerenciamento
{
    public partial class Forms_CadastroCliente : Form
    {
        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private ExcluirNoBanco Excluir = new ExcluirNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        private ApiCorreios Api = new ApiCorreios();

        private int cont = 0;

        private int qntCEPexecutado = 0;

        private bool IsCpfCnpjExiste = false;

        private decimal ValorSaldo = 0;

        private decimal ValorCredito = 0;

        public Forms_CadastroCliente()
        {
            InitializeComponent();

            txtDataCadastro.Text = DateTime.Today.ToShortDateString();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            NovoCadastroCliente();
        }

        private void NovoCadastroCliente()
        {
            ManipulacaoTextBox.ApagandoTextBox(this);

            lblTipoDeCliente.Text = "CPF / CNPJ";

            pcbCliente.Image = Resources.imagem_do_usuario_com_fundo_preto;
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            SalvarCadastroCliente();
        }

        private void SalvarCadastroCliente()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    IsCpfCnpjExiste = VerificarExistencia.VerificarExistenciaDeCPF_CNPJ_Cliente(txtCPF_CNPJ.Text);

                    if (IsCpfCnpjExiste == false)
                    {
                        DadosCliente dadosCliente;
                        int codigoCliente = 0;
                        int codigoImagemCliente = 0;

                        codigoImagemCliente = Salvar.InserirImagemNoCadastroCliente(pcbCliente.Image);
                        lblCodigoImagem.Text = codigoImagemCliente.ToString();

                        dadosCliente = preencherDadosCliente();
                        codigoCliente = Salvar.InserirCadastroCliente(dadosCliente);
                        txtCodigo.Text = codigoCliente.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cliente Já Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCadastroCliente(ex);
            }
        }

        private DadosCliente preencherDadosCliente()
        {
            DadosCliente dadosCliente = new DadosCliente();

            dadosCliente.dataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
            dadosCliente.nome = txtNome.Text;
            dadosCliente.tipo = cmbTipo.Text;
            dadosCliente.cpfCpnjCliente = txtCPF_CNPJ.Text;
            dadosCliente.rg = txtRG.Text;
            dadosCliente.orgaoEmissor = cmbEmissor.Text;
            dadosCliente.dataEmissao = txtDataEmissao.Text;
            dadosCliente.insEst = cmbIns_Est.Text;
            dadosCliente.cep = txtCEP.Text;
            dadosCliente.endereco = txtEndereco.Text;
            dadosCliente.numero = Convert.ToInt32(txtNumero.Text);
            dadosCliente.complemento = txtComplemento.Text;
            dadosCliente.bairro = txtBairro.Text;
            dadosCliente.cidade = txtCidade.Text;
            dadosCliente.uf = cmbUF.Text;
            dadosCliente.naturalidade = txtNaturalidade.Text;
            dadosCliente.dataNascimento = txtDataNascimento.Text;
            dadosCliente.estadoCivil = cmbEstadoCivil.Text;
            dadosCliente.credito = Convert.ToDecimal(txtCredito.Text.Replace("R$ ", string.Empty));
            dadosCliente.saldo = Convert.ToDecimal(txtSaldo.Text.Replace("R$ ", string.Empty));
            dadosCliente.bloqueio = cmbBloqueio.Text;
            dadosCliente.celular = txtCelular.Text;
            dadosCliente.telefone = txtTel_Residencial.Text;
            dadosCliente.email = txtEmail.Text;
            dadosCliente.observacoes = txtObservacoes.Text;
            dadosCliente.codigoCliente = Convert.ToInt32(lblCodigoImagem.Text);

            return dadosCliente;
        }

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            AtualizarCadastroCliente();
        }

        private void AtualizarCadastroCliente()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    IsCpfCnpjExiste = VerificarExistencia.VerificarExistenciaDeCPF_CNPJ_Cliente(txtCPF_CNPJ.Text);

                    if (IsCpfCnpjExiste == true)
                    {
                        DadosCliente dadosCliente;

                        dadosCliente = preencherDadosCliente();

                        Atualizar.AtualizarCadastroCliente(dadosCliente);

                        Atualizar.AtualizarImagemNoCadastroCliente(pcbCliente.Image, Convert.ToInt32(txtCodigo.Text));
                    }
                    else
                    {
                        MessageBox.Show("Cliente Não Cadastrado!", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCadastroCliente(ex);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Forms_PesquisarCliente buscarCliente = new Forms_PesquisarCliente(this);
            buscarCliente.ShowDialog();

            if (txtSaldo.Text != string.Empty)
            {
                ValorSaldo = Convert.ToDecimal(txtSaldo.Text.Replace("R$ ", ""));
                ValorCredito = Convert.ToDecimal(txtCredito.Text.Replace("R$ ", ""));
            }
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            ExclucirCadastroCliente();
        }

        private void ExclucirCadastroCliente()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeCPF_CNPJ_Cliente(txtCPF_CNPJ.Text) == true)
                    {
                        Excluir.ExcluirCadastroCliente(txtCPF_CNPJ.Text);

                        Excluir.ExcluirImagemCliente(Convert.ToInt32(txtCodigo.Text));
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirCadastroCliente(ex);
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserirImagemCliente_Click(object sender, EventArgs e)
        {
            InserirImagemCliente();
        }

        private void InserirImagemCliente()
        {
            OpenFileDialog abrirPesquisa = new OpenFileDialog();

            abrirPesquisa.Filter = "Abrir Imagem (*.jpg; *.png; *.gif) |*.jpg; *.png; *.gif ";
            if (abrirPesquisa.ShowDialog() == DialogResult.OK)
            {
                pcbCliente.Image = Image.FromFile(abrirPesquisa.FileName);
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetarFormatoTextBoxCPF_CPNJ();
        }

        private void SetarFormatoTextBoxCPF_CPNJ()
        {
            cmbTipo.BorderColor = Color.Silver;

            if (cmbTipo.Text == "Pess. Fisica")
            {
                LayoutPessoaFisica();
            }
            else if (cmbTipo.Text == "Pess. Juridica")
            {
                LayoutPessoaJuridica();
            }
        }

        private void LayoutPessoaFisica()
        {
            Global.tipoDeCliente = "Pess. Fisica";

            lblTipoDeCliente.Text = "CPF";
            txtRG.Text = string.Empty;
            txtRG.Enabled = true;
            txtRG.ReadOnly = false;
            cmbEmissor.Text = string.Empty;
            cmbEmissor.Enabled = true;
            txtDataEmissao.Text = string.Empty;
            txtDataEmissao.Enabled = true;
            txtDataEmissao.ReadOnly = false;
            cmbIns_Est.Text = string.Empty;
            cmbIns_Est.Enabled = true;
            txtNaturalidade.Text = string.Empty;
            txtNaturalidade.Visible = true;
            txtNaturalidade.ReadOnly = false;
            txtDataNascimento.Text = string.Empty;
            txtDataNascimento.Enabled = true;
            txtDataNascimento.ReadOnly = false;
            cmbEstadoCivil.Text = string.Empty;
            cmbEstadoCivil.Enabled = true;
        }

        private void LayoutPessoaJuridica()
        {
            Global.tipoDeCliente = "Pess. Juridica";

            lblTipoDeCliente.Text = "CNPJ";
            txtRG.Text = "---------------";
            txtRG.Enabled = false;
            txtRG.ReadOnly = true;
            cmbEmissor.Text = "----";
            cmbEmissor.Enabled = false;
            txtDataEmissao.Text = "----------";
            txtDataEmissao.Enabled = false;
            txtDataEmissao.ReadOnly = true;
            cmbIns_Est.Text = "--";
            cmbIns_Est.Enabled = false;
            txtNaturalidade.Text = "----------";
            txtNaturalidade.Enabled = false;
            txtNaturalidade.ReadOnly = true;
            txtDataNascimento.Text = "----------";
            txtDataNascimento.Enabled = false;
            txtDataNascimento.ReadOnly = true;
            cmbEstadoCivil.Text = "--------------";
            cmbEstadoCivil.Enabled = false;
        }

        private void txtCPF_CNPJ_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            FormatarCPF_CNPJ(e);
        }

        private void FormatarCPF_CNPJ(KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                if (cmbTipo.Text == "Pess. Fisica")
                {
                    ManipulacaoTextBox.FormatoCPF(e, txtCPF_CNPJ);
                }
                else if (cmbTipo.Text == "Pess. Juridica")
                {
                    ManipulacaoTextBox.FormatoCNPJ(e, txtCPF_CNPJ);
                }
            }
        }

        private void txtCPF_CNPJ_Enter(object sender, EventArgs e)
        {
            VerificacaoPreenchimentoTipoCliente();
        }

        private void VerificacaoPreenchimentoTipoCliente()
        {
            if (cmbTipo.Text == String.Empty)
            {
                txtCPF_CNPJ.BorderColorActive = Color.Silver;

                cmbTipo.BorderColor = Color.DodgerBlue;

                cmbTipo.Focus();

                MessageBox.Show("Por Favor Preencha Primeiro O Campo Tipo!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCPF_CNPJ_Leave(object sender, EventArgs e)
        {
            if (txtCPF_CNPJ.Text != string.Empty)
            {
                if (cmbTipo.Text == "Pess. Fisica")
                {
                    if (ValidacaoCPF.IsCpf(txtCPF_CNPJ.Text) == false)
                    {
                        ValidacaoCPF.MensagemCPFDigitadoInvalido();

                        txtCPF_CNPJ.Focus();
                    }
                }
                else if (cmbTipo.Text == "Pess. Juridica")
                {
                    if (ValidacaoCNPJ.IsCnpj(txtCPF_CNPJ.Text) == false)
                    {
                        ValidacaoCNPJ.MensagemCNPJDigitadoInvalido();

                        txtCPF_CNPJ.Focus();
                    }
                }
            }
        }

        private void txtRG_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoRG(txtRG);
            }
        }

        private void txtRG_Leave(object sender, EventArgs e)
        {
            ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtRG);
        }

        private void txtDataEmissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoData(txtDataEmissao);
            }
        }

        private void txtDataEmissao_Leave(object sender, EventArgs e)
        {
            if (ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtDataEmissao) == true)
            {
                ManipulacaoTextBox.ValidacaoData(txtDataEmissao);
            }
        }

        private void txtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoData(txtDataNascimento);
            }
        }

        private void txtDataNascimento_Leave(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                if (txtDataNascimento.Text != string.Empty && txtDataNascimento.Text != "----------")
                {
                    if (ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtDataNascimento) == true)
                    {
                        ManipulacaoTextBox.ValidacaoData(txtDataNascimento);
                    }

                    if ((Convert.ToDateTime(txtDataNascimento.Text).AddDays(6570)) > Convert.ToDateTime(DateTime.Today.ToShortDateString()))
                    {
                        MessageBox.Show("É Necessário Que O Cliente Seja Maior De Idade!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cont++;
                }
            }
            else
            {
                cont = 0;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetras(e);
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)

                ManipulacaoTextBox.FormatoCEP(txtCEP);
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            PreenchimentoPorCEP(txtCEP);
        }

        private void PreenchimentoPorCEP(BunifuTextBox _txtCEP_)
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
                        var tarefa = Api.APICorreios((_txtCEP_.Text).Replace("-", ""));
                        var esperador = tarefa.GetAwaiter();

                        esperador.OnCompleted(() =>
                        {
                            var item = Api.RetornoApi();

                            if (item.Uf != null)
                            {
                                PreenchendoCamposCEP(item);

                                _txtCEP_.BorderColorActive = Color.DodgerBlue;
                            }
                            else
                            {
                                _txtCEP_.Focus();

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

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoCelular(txtCelular);
            }
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtCelular);
        }

        private void txtTel_Residencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoTelefone(txtTel_Residencial);
            }
        }

        private void txtTel_Residencial_Leave(object sender, EventArgs e)
        {
            VerificarcaoPreencimentoCompletoTelefone(txtTel_Residencial);
        }

        private bool VerificarcaoPreencimentoCompletoTelefone(GunaTextBox _txtTel_Residencial)
        {
            if (_txtTel_Residencial.Text.Length != _txtTel_Residencial.MaxLength && _txtTel_Residencial.Text.Length != 0)
            {
                _txtTel_Residencial.BorderColor = Color.Red;

                _txtTel_Residencial.Focus();

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (_txtTel_Residencial.Text.Length == _txtTel_Residencial.MaxLength || _txtTel_Residencial.Text.Length == 0)
            {
                _txtTel_Residencial.BorderColor = Color.DodgerBlue;

                return true;
            }

            return false;
        }

        private void txtCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoDinheiro(e, sender, txtCredito);
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoDinheiro(e, sender, txtSaldo);
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetras(e);
        }

        private void txtNaturalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetras(e);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtObservacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoValidoParaEmail(e);
        }

        private void Forms_CadastroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
            else if (e.KeyCode == Keys.F1)
            {
                NovoCadastroCliente();
            }
            else if (e.KeyCode == Keys.F10)
            {
                SalvarCadastroCliente();
            }
            else if (e.KeyCode == Keys.F5)
            {
                AtualizarCadastroCliente();
            }
            else if (e.KeyCode == Keys.F2)
            {
                Forms_PesquisarCliente buscarCliente = new Forms_PesquisarCliente(this);
                buscarCliente.ShowDialog();
            }
            else if (e.KeyCode == Keys.F3)
            {
                ExclucirCadastroCliente();
            }
            else if (e.KeyCode == Keys.D && e.Modifiers == Keys.Control)
            {
                InserirImagemCliente();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty)
            {
                ValidacaoEmail.VerificarPreenchimentoEmail(txtEmail.Text, txtEmail);
            }
        }

        private decimal diferencaCredito = 0;
        private decimal diferencaSaldo = 0;

        private void txtCredito_Leave(object sender, EventArgs e)
        {
            decimal ValorSaldo = 0;

            if (cont == 0 && txtSaldo.Text == String.Empty)
            {
                cont++;

                txtSaldo.Text = txtCredito.Text;
            }
            else if (cont == 0)
            {
                CalculandoValorSaldo();
            }
            else
            {
                cont = 0;
            }
        }

        private void CalculandoValorSaldo()
        {
            diferencaCredito = Convert.ToDecimal(txtCredito.Text.Replace("R$ ", "")) - ValorCredito;
            diferencaSaldo = diferencaCredito + ValorSaldo;

            if (diferencaSaldo > 0)
            {
                txtSaldo.Text = diferencaSaldo.ToString("c");
            }
            else
            {
                MessageBox.Show("Saldo não pode fica negativo!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCredito.Focus();
            }
        }
    }
}