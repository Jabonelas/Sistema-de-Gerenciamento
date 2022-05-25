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
using Microsoft.Office.Interop.Excel;
using Sistema_de_Gerenciamento.Classes;
using TextBox = System.Windows.Forms.TextBox;

//using TextBox = System.Windows.Forms.TextBox;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Venda : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private decimal valorBruto = 0;

        private ManipulacaoTextBox TextBox = new ManipulacaoTextBox();

        public Venda()
        {
            InitializeComponent();

            txtData.Text = DateTime.Today.ToShortDateString();

            cmbCliente.Items.Clear();
            foreach (var item in Buscar.BuscarListaCliente())
            {
                cmbCliente.Items.Add(item);
            }

            txtVendedor.Text = Global.tipoDeUsuario;
        }

        #region Botao Abrir Cadastro Cliente

        private void btnAbriCadastroCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente buscarCliente = new CadastroCliente();
            buscarCliente.ShowDialog();
        }

        #endregion Botao Abrir Cadastro Cliente

        #region Botao Sair

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Sair

        #region ComboBox Cliente

        private void cmbCliente_Leave(object sender, EventArgs e)
        {
            if (cmbCliente.Text != string.Empty)
            {
                txtCodigoCliente.Text = Buscar.BuscarIdClientePorNome(cmbCliente.Text).ToString();
            }
        }

        #endregion ComboBox Cliente

        #region Botao Adcionar

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodBarras.Text != string.Empty && txtProduto.Text != string.Empty)
                {
                    bool isCadastroExiste = Buscar.BuscarEstoqueProdutoPorCodigo(txtCodBarras.Text);

                    if (isCadastroExiste == true)
                    {
                        gdvVenda.ColumnCount = 5;

                        var rows = new List<string[]>();
                        string[] row1 = new string[] { txtCodProduto.Text, txtProduto.Text, txtQuantidade.Text, txtUnidade.Text, txtPrecoVenda.Text };
                        rows.Add(row1);

                        foreach (string[] item in rows)
                        {
                            gdvVenda.Rows.Add(item);
                        }

                        //setando o valor para o textbox preco bruto
                        valorBruto = 0;

                        for (int i = 0; i < gdvVenda.RowCount; i++)
                        {
                            valorBruto += Convert.ToDecimal(gdvVenda.Rows[i].Cells[4].Value.ToString().Replace("R$ ", ""));
                        }

                        txtValorBruto.Text = string.Format("{0:C}", valorBruto);

                        txtDesconto.Text = string.Format("{0:P}", Buscar.BuscarPorcentagemGeralEstoqueProdutoPorCodigo(txtCodBarras.Text) / 100);

                        txtTotalLiquido.Text = string.Format("{0:C}", (valorBruto - (Buscar.BuscarPorcentagemGeralEstoqueProdutoPorCodigo(txtCodBarras.Text)) * valorBruto / 100));

                        txtTotalItens.Text = gdvVenda.RowCount.ToString();

                        txtValorAvista.Text = string.Format("{0:C}", (valorBruto - (Buscar.BuscarPorcentagemAvistaEstoqueProdutoPorCodigo(txtCodBarras.Text)) * valorBruto / 100));

                        //txtTroco.Text = string.Format("{0:C}", Convert.ToDecimal(txtTotalPago.Text) - Convert.ToDecimal(txtTotalLiquido.Text));

                        txtCodBarras.Text = string.Empty;
                        txtCodProduto.Text = string.Empty;
                        txtProduto.Text = string.Empty;
                        txtQuantidade.Text = string.Empty;
                        txtUnidade.Text = string.Empty;
                        txtPrecoVenda.Text = string.Empty;
                    }
                    else if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Codigo de Barras Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarEstoqueProduto(ex);
            }
        }

        #endregion Botao Adcionar

        #region TextBox Codigo de Barras

        private void txtCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Codigo de Barras

        #region Botão Buscar

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodBarras.Text != string.Empty)
                {
                    bool isCadastroExiste = Buscar.BuscarEstoqueProdutoPorCodigo(txtCodBarras.Text);

                    if (isCadastroExiste == true)
                    {
                        txtCodProduto.Text = Buscar.BuscarEstoqueProdutoCodigoProdutoPorCodigoDeBarras(Convert.ToInt32(txtCodBarras.Text)).ToString();

                        txtProduto.Text = Buscar.BuscarEstoqueProdutoDescricaoProdutoPorCodigoDeBarras(Convert.ToInt32(txtCodBarras.Text));

                        txtUnidade.Text = Buscar.BuscarEstoqueProdutoUnidadeProdutoPorCodigoDeBarras(Convert.ToInt32(txtCodBarras.Text));

                        txtQuantidade.Text = Buscar.BuscarEstoqueProdutoQuantidadeProdutoPorCodigoDeBarras(Convert.ToInt32(txtCodBarras.Text)).ToString();

                        txtPrecoVenda.Text = ("R$ " + Buscar.BuscarEstoqueProdutoPrecoProdutoPorCodigoDeBarras(Convert.ToInt32(txtCodBarras.Text)).ToString("N2"));
                    }
                    else if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Codigo de Barras Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarEstoqueProduto(ex);
            }
        }

        #endregion Botão Buscar

        #region Botao Remover Item

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            DialogResult OpcaoDoUsuario = new DialogResult();
            OpcaoDoUsuario = MessageBox.Show("Deseja Remover O Item?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (OpcaoDoUsuario == DialogResult.Yes)
            {
                gdvVenda.Rows.RemoveAt(gdvVenda.CurrentRow.Index);
            }
        }

        #endregion Botao Remover Item

        #region Botao Cancelar Venda

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            DialogResult OpcaoDoUsuario = new DialogResult();
            OpcaoDoUsuario = MessageBox.Show("Deseja Cancelar a Compra?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (OpcaoDoUsuario == DialogResult.Yes)
            {
                gdvVenda.Rows.Clear();
            }
        }

        #endregion Botao Cancelar Venda

        #region Botao Imprimir

        private void btnImprimir_Click(object sender, EventArgs e)
        {
        }

        #endregion Botao Imprimir

        #region Botao Novo Cliente

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            TextBox.ApagandoTextBox(this);
        }

        #endregion Botao Novo Cliente

        private void Venda_Load(object sender, EventArgs e)
        {
        }

        #region TextBox Total Pago

        private void txtTotalPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                txtTotalPago.MaxLength = 10;

                if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    if (txtTotalPago.Text.Length <= 13 || e.KeyChar.Equals((char)Keys.Back))
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

        private void txtTotalPago_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                decimal troco = (Convert.ToDecimal(txtTotalPago.Text.Replace("R$ ", "")) - Convert.ToDecimal(txtTotalLiquido.Text.Replace("R$ ", "")));

                if (troco > 0)
                {
                    txtTroco.Text = string.Format("{0:C}", troco);
                    txtTroco.BackColor = Color.Black;
                    txtTroco.ForeColor = Color.Black;

                    //txtValorAvista.Text = (string.Format("{0:C}", (Convert.ToDecimal(txtValorBruto.Text) - (Buscar.BuscarPorcentagemAvistaEstoqueProdutoPorCodigo(txtCodBarras.Text) * Convert.ToDecimal(txtValorBruto.Text) / 100)))).ToString();
                    //txtValorAvista.BackColor = Color.Black;
                    //txtValorAvista.ForeColor = Color.Black;
                }
                else
                {
                    txtTroco.Text = string.Format("{0:C}", troco);
                    txtTroco.BackColor = Color.Red;
                    txtTroco.ForeColor = Color.Red;

                    //txtValorAvista.Text = (string.Format("{0:C}", (Convert.ToDecimal(txtValorBruto.Text) - (Buscar.BuscarPorcentagemAvistaEstoqueProdutoPorCodigo(txtCodBarras.Text) * Convert.ToDecimal(txtValorBruto.Text) / 100)))).ToString();
                    //txtValorAvista.BackColor = Color.Red;
                    //txtValorAvista.ForeColor = Color.Red;
                }

                //txtTroco.Text = string.Format("{0:C}", Convert.ToDecimal(txtTotalPago.Text.Replace("R$ ", "")) - Convert.ToDecimal(txtTotalLiquido.Text.Replace("R$ ", "")));
            }
            catch (Exception exception)
            {
            }
        }

        #endregion TextBox Total Pago
    }
}