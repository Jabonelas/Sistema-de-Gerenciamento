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

namespace Sistema_de_Gerenciamento
{
    public partial class CadastroProduto : Form
    {
        private ManipulacaoTextBox TextBox = new ManipulacaoTextBox();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        private ExcluirNoBanco Excluir = new ExcluirNoBanco();

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        public CadastroProduto()
        {
            InitializeComponent();
        }

        #region Botao Buscar

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            PesquisarProduto buscarProduto = new PesquisarProduto();
            buscarProduto.ShowDialog();
        }

        #endregion Botao Buscar

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
        }

        #endregion Botao Novo

        #region Botao Inserir Imagem

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirPesquisa = new OpenFileDialog();

            abrirPesquisa.Filter = "Abrir Imagem (*.jpg; *.png; *.gif) |*.jpg; *.png; *.gif ";
            if (abrirPesquisa.ShowDialog() == DialogResult.OK)
            {
                pcbProduto.Image = Image.FromFile(abrirPesquisa.FileName);
            }
        }

        #endregion Botao Inserir Imagem

        #region TextBox Valor de Custo

        private void txtValorDeCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                txtValorDeCusto.MaxLength = 10;

                if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    if (txtValorDeCusto.Text.Length <= 13 || e.KeyChar.Equals((char)Keys.Back))
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

        #endregion TextBox Valor de Custo

        #region TextBox Procentagem

        private void txtPorcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            try
            {
                if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    if (txtPorcentagem.Text.Length <= 7 || e.KeyChar.Equals((char)Keys.Back))
                    {
                        TextBox textbox = (TextBox)sender;
                        string testoDoTextBox = Regex.Replace(textbox.Text, "[^0-9]", string.Empty);
                        if (testoDoTextBox == string.Empty)
                        {
                            testoDoTextBox = "0";
                        }

                        testoDoTextBox += e.KeyChar;
                        textbox.Text = String.Format("{0:#,##0.00} %", double.Parse(testoDoTextBox) / 100);
                        textbox.Select(textbox.Text.Length, 0);
                    }
                }
                e.Handled = true;
            }
            catch (Exception)
            {
            }
        }

        #endregion TextBox Procentagem

        #region TextBox Preco aPrazo e Atacado

        private void txtPrecoAPrazoAtacado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Preco aPrazo e Atacado

        #region TextBox Comissao

        private void txtComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            try
            {
                if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    if (txtComissao.Text.Length <= 7 || e.KeyChar.Equals((char)Keys.Back))
                    {
                        TextBox textbox = (TextBox)sender;
                        string testoDoTextBox = Regex.Replace(textbox.Text, "[^0-9]", string.Empty);
                        if (testoDoTextBox == string.Empty)
                        {
                            testoDoTextBox = "0";
                        }

                        testoDoTextBox += e.KeyChar;
                        textbox.Text = String.Format("{0:#,##0.00} %", double.Parse(testoDoTextBox) / 100);
                        textbox.Select(textbox.Text.Length, 0);
                    }
                }
                e.Handled = true;
            }
            catch (Exception)
            {
            }
        }

        #endregion TextBox Comissao

        #region TextBox Validade

        private void txtValidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtValidade.TextLength)
                {
                    case 0:
                        txtValidade.Text = "";
                        break;

                    case 2:
                        txtValidade.Text = txtValidade.Text + "/";
                        txtValidade.SelectionStart = 3;
                        break;

                    case 5:
                        txtValidade.Text = txtValidade.Text + "/";
                        txtValidade.SelectionStart = 6;
                        break;
                }
            }
        }

        private void txtValidade_Leave(object sender, EventArgs e)
        {
            //Verificação se o campo do totalmente preenchido
            if (txtValidade.Text.Length != txtValidade.MaxLength && txtValidade.Text.Length != 0)
            {
                txtValidade.BorderColorActive = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtValidade.Focus();
            }
            else if (txtValidade.Text.Length == txtValidade.MaxLength || txtValidade.Text.Length == 0)
            {
                txtValidade.BorderColorActive = Color.DodgerBlue;
            }
            //Verificação se o campo foi preenchido com um formato valido
            if (txtValidade.Text.Length == txtValidade.MaxLength)
            {
                DateTime time;
                if (DateTime.TryParse(txtValidade.Text, out time))
                {
                    txtValidade.BorderColorActive = Color.DodgerBlue;
                }
                else
                {
                    txtValidade.BorderColorActive = Color.Red;
                    MessageBox.Show($"Data Errada: {txtValidade.Text}", "Atencao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValidade.Focus();
                }
            }
        }

        #endregion TextBox Validade

        #region TextBox Estoque Minimo

        private void txtEstoqueMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            try
            {
                if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    if (txtEstoqueMinimo.Text.Length <= 7 || e.KeyChar.Equals((char)Keys.Back))
                    {
                        TextBox textbox = (TextBox)sender;
                        string testoDoTextBox = Regex.Replace(textbox.Text, "[^0-9]", string.Empty);
                        if (testoDoTextBox == string.Empty)
                        {
                            testoDoTextBox = "0";
                        }

                        testoDoTextBox += e.KeyChar;
                        textbox.Text = String.Format("{0:#,##0.00}", double.Parse(testoDoTextBox) / 100);
                        textbox.Select(textbox.Text.Length, 0);
                    }
                }
                e.Handled = true;
            }
            catch (Exception)
            {
            }
        }

        #endregion TextBox Estoque Minimo

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeCPF_CNPJ_Cliente(txtCPF_CNPJ.Text) == false)
                    {
                        Salvar.InserirImagemNoCadastroCliente(pcbCliente.Image);

                        Salvar.InserirCadastroCliente(
                       txtDescricao.Text,
                       cmbUn.Text,
                       txtValorDeCusto.Text,
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

                        txtCodigo.Text = Buscar.BuscarCodigoCliente(txtCPF_CNPJ.Text).ToString();

                        //Chamar o forms de alerta de inclusao com sucesso
                        Global.tipoDoAlerta = "Inclusao";

                        Aviso buscarCliente = new Aviso();
                        buscarCliente.Show();
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeCPF_CNPJ_Cliente(txtDescricao.Text) == true)
                    {
                        MessageBox.Show("Produto Já Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCadastroProduto(ex);
            }
        }
    }
}