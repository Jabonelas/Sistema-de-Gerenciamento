﻿using Bunifu.UI.WinForms;
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
using Sistema_de_Gerenciamento.Properties;

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

        private bool IsCpfCnpjExiste = false;

        public Forms_CadastroCliente()
        {
            InitializeComponent();

            txtDataCadastro.Text = DateTime.Today.ToShortDateString();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
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
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            ExclucirCadastroCliente();
        }

        #region Excluir Cadastro Cliente

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

        #endregion Excluir Cadastro Cliente

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserirImagemCliente_Click(object sender, EventArgs e)
        {
            InserirImagemCliente();
        }

        #region Inserir Imagem Cliente

        private void InserirImagemCliente()
        {
            OpenFileDialog abrirPesquisa = new OpenFileDialog();

            abrirPesquisa.Filter = "Abrir Imagem (*.jpg; *.png; *.gif) |*.jpg; *.png; *.gif ";
            if (abrirPesquisa.ShowDialog() == DialogResult.OK)
            {
                pcbCliente.Image = Image.FromFile(abrirPesquisa.FileName);
            }
        }

        #endregion Inserir Imagem Cliente

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetarFormatoTextBoxCPF_CPNJ();
        }

        #region Setar Formato do TextBox CPF e CNPJ

        private void SetarFormatoTextBoxCPF_CPNJ()
        {
            cmbTipo.BorderColor = Color.Silver;

            if (cmbTipo.Text == "Pess. Fisica")
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
            else if (cmbTipo.Text == "Pess. Juridica")
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
        }

        #endregion Setar Formato do TextBox CPF e CNPJ

        private void txtCPF_CNPJ_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            FormatarCPF_CNPJ(e);
        }

        #region Formatar CPF/CNPJ

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

        #endregion Formatar CPF/CNPJ

        private void txtCPF_CNPJ_Enter(object sender, EventArgs e)
        {
            VerificacaoPreenchimentoTipoCliente();
        }

        #region Verificar se o Campo Tipo de Cliente Foi Preenchido Primeiramente

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

        #endregion Verificar se o Campo Tipo de Cliente Foi Preenchido Primeiramente

        private void txtCPF_CNPJ_Leave(object sender, EventArgs e)
        {
            ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtCPF_CNPJ);
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
                if (txtDataNascimento.Text != "----------")
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

        private async void txtCEP_Leave(object sender, EventArgs e)
        {
            PreenchimentoPorCEP(txtCEP);
        }

        #region Buscar de Endereco por CEP

        private async void PreenchimentoPorCEP(BunifuTextBox _textBox)
        {
            try
            {
                if (ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtDataNascimento) == true)
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

        #region Verificacao de Preenchimento Completo Telefone

        private bool VerificarcaoPreencimentoCompletoTelefone(GunaTextBox _textBox)
        {
            if (_textBox.Text.Length != _textBox.MaxLength && _textBox.Text.Length != 0)
            {
                _textBox.BorderColor = Color.Red;

                _textBox.Focus();

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (_textBox.Text.Length == _textBox.MaxLength || _textBox.Text.Length == 0)
            {
                _textBox.BorderColor = Color.DodgerBlue;

                return true;
            }

            return false;
        }

        #endregion Verificacao de Preenchimento Completo Telefone

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
    }
}