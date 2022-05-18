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

            // Preencher o combobox de grupo
            cmbGrupo.Items.Clear();

            foreach (var item in Buscar.BuscarGrupoProduto())
            {
                cmbGrupo.Items.Add(item);
            }

            // Preencher o combobox de sub-grupo
            cmbSubGrupo.Items.Clear();

            foreach (var item in Buscar.BuscarSubGrupoProduto())
            {
                cmbSubGrupo.Items.Add(item);
            }

            // Preencher o combobox de fornecedor
            cmbFornecedor.Items.Clear();

            foreach (var item in Buscar.BuscarListaForcedor())
            {
                cmbFornecedor.Items.Add(item);
            }
        }

        #region Botao Novo

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            TextBox.ApagandoTextBox(this);

            pcbProduto.Image = Image.FromFile(@"C:\Users\israe\source\repos\Sistema de Gerenciamento\Sistema de Gerenciamento\Resources\camera3.png");

            // Preencher o combobox de grupo
            cmbGrupo.Items.Clear();

            foreach (var item in Buscar.BuscarGrupoProduto())
            {
                cmbGrupo.Items.Add(item);
            }

            // Preencher o combobox de sub-grupo
            cmbSubGrupo.Items.Clear();

            foreach (var item in Buscar.BuscarSubGrupoProduto())
            {
                cmbSubGrupo.Items.Add(item);
            }

            // Preencher o combobox de fornecedor
            cmbFornecedor.Items.Clear();

            foreach (var item in Buscar.BuscarListaForcedor())
            {
                cmbFornecedor.Items.Add(item);
            }
        }

        #endregion Botao Novo

        #region Botao Salvar

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeDescricaoProduto(txtDescricao.Text) == false)
                    {
                        Salvar.InserirImagemNoCadastroProduto(pcbProduto.Image);

                        Salvar.InserirCadastroProduto(txtDescricao.Text,
                        cmbUn.Text,
                        Convert.ToDecimal(txtValorDeCusto.Text.Replace("R$ ", string.Empty)),
                        Convert.ToDecimal(txtPorcentagem.Text.Replace(" %", string.Empty)),
                        Convert.ToDecimal(txtValorVenda.Text.Replace("R$ ", string.Empty)),
                        Convert.ToDecimal(txtLucro.Text.Replace("R$ ", string.Empty)),
                        Convert.ToDecimal(txtPrecoAtacado.Text.Replace("R$ ", string.Empty)),
                        cmbGrupo.Text,
                        cmbSubGrupo.Text,
                        cmbFornecedor.Text,
                        Convert.ToDecimal(txtEstoqueMinimo.Text),
                        txtGarantia.Text,
                        txtMarca.Text,
                        txtReferencia.Text,
                        Convert.ToDateTime(txtValidade.Text),
                        Convert.ToDecimal(txtComissao.Text.Replace(" %", string.Empty)),
                        txtObservacoes.Text);

                        txtCodigo.Text = Buscar.BuscarCodigoProduto(txtDescricao.Text).ToString();

                        //Chamar o forms de alerta de inclusao com sucesso
                        Global.tipoDoAlerta = "Inclusao";

                        Aviso buscarCliente = new Aviso();
                        buscarCliente.Show();
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeDescricaoProduto(txtDescricao.Text) == true)
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

        #endregion Botao Salvar

        #region Botao Atualizar

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeDescricaoProduto(txtDescricao.Text) == true)
                    {
                        Atualizar.AtualizarCadastroProduto(txtDescricao.Text,
                        cmbUn.Text,
                        Convert.ToDecimal(txtValorDeCusto.Text.Replace("R$ ", string.Empty)),
                        Convert.ToDecimal(txtPorcentagem.Text.Replace(" %", string.Empty)),
                        Convert.ToDecimal(txtValorVenda.Text.Replace("R$ ", string.Empty)),
                        Convert.ToDecimal(txtLucro.Text.Replace("R$ ", string.Empty)),
                        Convert.ToDecimal(txtPrecoAtacado.Text.Replace("R$ ", string.Empty)),
                        cmbGrupo.Text,
                        cmbSubGrupo.Text,
                        cmbFornecedor.Text,
                        Convert.ToDecimal(txtEstoqueMinimo.Text),
                        txtGarantia.Text,
                        txtMarca.Text,
                        txtReferencia.Text,
                        Convert.ToDateTime(txtValidade.Text),
                        Convert.ToDecimal(txtComissao.Text.Replace(" %", string.Empty)),
                        txtObservacoes.Text);

                        Atualizar.AtualizarImagemNoCadastroProduto(pcbProduto.Image, Convert.ToInt32(txtCodigo.Text));

                        //Chamar o forms de alerta de atualizacao com sucesso
                        Global.tipoDoAlerta = "Atualizacao";

                        Aviso buscarCliente = new Aviso();
                        buscarCliente.Show();
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeDescricaoProduto(txtDescricao.Text) == false)
                    {
                        MessageBox.Show("Produto Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Preenchimento Dos Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCadastroProduto(ex);
            }
        }

        #endregion Botao Atualizar

        #region Botao Buscar

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            PesquisarProduto buscarProduto = new PesquisarProduto(this);
            buscarProduto.ShowDialog();
        }

        #endregion Botao Buscar

        #region Botao Excluir

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeDescricaoProduto(txtDescricao.Text) == true)
                    {
                        Excluir.ExcluirCadastroProduto(txtDescricao.Text);

                        Excluir.ExcluirImagemProduto(Convert.ToInt32(txtCodigo.Text));

                        //Chamar o forms de alerta de exclusao com sucesso
                        Global.tipoDoAlerta = "Exclusao";

                        Aviso buscarCliente = new Aviso();
                        buscarCliente.Show();
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeDescricaoProduto(txtDescricao.Text) == false)
                    {
                        MessageBox.Show("Produto Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirCadastroProduto(ex);
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

        #region TextBox Porcentagem

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

        private void txtPorcentagem_Leave(object sender, EventArgs e)
        {
            if (txtValorDeCusto.Text != String.Empty)
            {
                decimal valorDeCusto = Convert.ToDecimal(txtValorDeCusto.Text.Replace("R$ ", string.Empty));
                decimal porcentagem = Convert.ToDecimal(txtPorcentagem.Text.Replace(" %", string.Empty));
                decimal lucro = (valorDeCusto * porcentagem / 100);

                txtValorVenda.Text = ($"R$ {(valorDeCusto + lucro).ToString("N2")}");

                txtLucro.Text = ($"R$ {(lucro).ToString("N2")}");
            }
        }

        #endregion TextBox Porcentagem

        #region TextBox Preco aPrazo e Atacado

        private void txtPrecoAPrazoAtacado_KeyPress(object sender, KeyPressEventArgs e)
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

        
    }
}