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
using Point = System.Drawing.Point;
using TextBox = System.Windows.Forms.TextBox;

//using TextBox = System.Windows.Forms.TextBox;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_Venda : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private decimal valorBruto = 0;

        private ManipulacaoTextBox TextBox = new ManipulacaoTextBox();

        private List<DadosProduto> listaProduto = new List<DadosProduto>();

        private DadosProduto produto;

        public Forms_Venda()
        {
            InitializeComponent();

            txtData.Text = DateTime.Today.ToShortDateString();

            txtVendedor.Text = Global.tipoDeUsuario;
        }

        #region Botao Abrir Cadastro Cliente

        private void btnAbriCadastroCliente_Click(object sender, EventArgs e)
        {
            Forms_CadastroCliente buscarCliente = new Forms_CadastroCliente();
            buscarCliente.ShowDialog();
        }

        #endregion Botao Abrir Cadastro Cliente

        #region Botao Sair

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Sair

        #region Botao Adcionar

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodBarras.Text != string.Empty && cmbProduto.Text != string.Empty && chbVenda.Checked == true)
                {
                    bool isCadastroExiste = Buscar.BuscarEstoqueProdutoPorCodigo(txtCodBarras.Text);

                    if (isCadastroExiste == true)
                    {
                        gdvVenda.ColumnCount = 7;

                        var rows = new List<string[]>();
                        string[] row1 = new string[] { txtCodProduto.Text, cmbProduto.Text, txtQuantidade.Text,
                            txtUnidade.Text, txtDescontoPorItem.Text, txtPrecoSemDesconto.Text,txtPrecoComDesconto.Text };
                        rows.Add(row1);

                        foreach (string[] item in rows)
                        {
                            gdvVenda.Rows.Add(item);
                        }

                        //setando o valor para o textbox preco bruto
                        valorBruto = 0;

                        for (int i = 0; i < gdvVenda.RowCount; i++)
                        {
                            valorBruto += Convert.ToDecimal(gdvVenda.Rows[i].Cells[6].Value.ToString().Replace("R$ ", ""));
                        }

                        txtValorTotal.Text = string.Format("{0:C}", valorBruto);

                        txtTotalItens.Text = gdvVenda.RowCount.ToString();

                        ApagandoTextbox();
                    }
                    else if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Codigo de Barras Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (cmbProduto.Text != string.Empty && chbOrcamento.Checked == true && txtCodProduto.Text != string.Empty)
                {
                    txtPrecoComDesconto.Text = string.Format("{0:C}", (Convert.ToDecimal(txtPrecoSemDesconto.Text.Replace("R$ ", "")) -
                                                                       (Convert.ToDecimal(Buscar.BuscarDesontoPorItem(cmbProduto.Text)))
                                                                       * Convert.ToDecimal(txtPrecoSemDesconto.Text.Replace("R$ ", "")) / 100)).ToString();

                    txtDescontoPorItem.Text = string.Format("{0:P}", Convert.ToDecimal(Buscar.BuscarDesontoPorItem(cmbProduto.Text)) / 100);

                    gdvVenda.ColumnCount = 7;

                    var rows = new List<string[]>();
                    string[] row1 = new string[] { txtCodProduto.Text, cmbProduto.Text, txtQuantidade.Text,
                            txtUnidade.Text, txtDescontoPorItem.Text, txtPrecoSemDesconto.Text,txtPrecoComDesconto.Text };
                    rows.Add(row1);

                    foreach (string[] item in rows)
                    {
                        gdvVenda.Rows.Add(item);
                    }

                    //setando o valor para o textbox preco bruto
                    valorBruto = 0;

                    for (int i = 0; i < gdvVenda.RowCount; i++)
                    {
                        valorBruto += Convert.ToDecimal(gdvVenda.Rows[i].Cells[6].Value.ToString().Replace("R$ ", ""));
                    }

                    txtValorTotal.Text = string.Format("{0:C}", valorBruto);

                    txtTotalItens.Text = gdvVenda.RowCount.ToString();

                    ApagandoTextbox();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarEstoqueProduto(ex);
            }
        }

        #endregion Botao Adcionar

        #region Botao Gerar Boleto

        private void btnGerarBoleto_Click(object sender, EventArgs e)
        {
            if (txtValorTotal.Text != string.Empty)
            {
                Forms_GerarCarne gerarBoleto = new Forms_GerarCarne(this);
                gerarBoleto.ShowDialog();
            }
        }

        #endregion Botao Gerar Boleto

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
                        txtCodProduto.Text = Buscar.BuscarEstoqueProdutoCodigoProdutoPorCodigoDeBarras(txtCodBarras.Text).ToString();

                        cmbProduto.Text = Buscar.BuscarEstoqueProdutoDescricaoProdutoPorCodigoDeBarras(txtCodBarras.Text);

                        txtUnidade.Text = Buscar.BuscarEstoqueProdutoUnidadeProdutoPorCodigoDeBarras(txtCodBarras.Text);

                        txtQuantidade.Text = Buscar.BuscarEstoqueProdutoQuantidadeProdutoPorCodigoDeBarras(txtCodBarras.Text).ToString();

                        txtPrecoSemDesconto.Text = ("R$ " + Buscar.BuscarEstoqueProdutoPrecoProdutoPorCodigoDeBarras(txtCodBarras.Text).ToString("N2"));

                        txtDescontoPorItem.Text = string.Format("{0:P}", Buscar.BuscarPorcentagemGeralEstoqueProdutoPorCodigo(txtCodBarras.Text) / 100);

                        txtPrecoComDesconto.Text = string.Format("{0:C}", (Convert.ToDecimal(txtPrecoSemDesconto.Text.Replace("R$ ", "")) -
                                                                       (Buscar.BuscarPorcentagemGeralEstoqueProdutoPorCodigo(txtCodBarras.Text))
                                                                       * Convert.ToDecimal(txtPrecoSemDesconto.Text.Replace("R$ ", "")) / 100)).ToString();
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
            if (gdvVenda.RowCount > 0)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Remover O Item?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    gdvVenda.Rows.RemoveAt(gdvVenda.CurrentRow.Index);

                    valorBruto = 0;

                    for (int i = 0; i < gdvVenda.RowCount; i++)
                    {
                        valorBruto += Convert.ToDecimal(gdvVenda.Rows[i].Cells[6].Value.ToString().Replace("R$ ", ""));
                    }

                    txtValorTotal.Text = string.Format("{0:C}", valorBruto);

                    txtTotalItens.Text = gdvVenda.RowCount.ToString();

                    ApagandoTextbox();
                }
            }
        }

        #endregion Botao Remover Item

        #region Botao Cancelar Venda

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            if (gdvVenda.RowCount > 0)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Cancelar a Compra?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    gdvVenda.Rows.Clear();
                }
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
            if (gdvVenda.RowCount > 0)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Cancelar a Compra?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    gdvVenda.Rows.Clear();

                    TextBox.ApagandoTextBox(this);
                }
            }
            else
            {
                TextBox.ApagandoTextBox(this);
            }
        }

        #endregion Botao Novo Cliente

        #region TextBox Codigo de Barras

        private void txtCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox.DigitarApenasNumeros(e);
        }

        #endregion TextBox Codigo de Barras

        #region TextBox Total Pago Avista

        private void txtTotalPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                txtTotalPagoAvista.MaxLength = 10;

                if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    if (txtTotalPagoAvista.Text.Length <= 13 || e.KeyChar.Equals((char)Keys.Back))
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
                decimal troco = (Convert.ToDecimal(txtTotalPagoAvista.Text.Replace("R$ ", "")) - Convert.ToDecimal(txtValorAvista.Text.Replace("R$ ", "")));

                if (troco > 0)
                {
                    txtTrocoAvista.Text = string.Format("{0:C}", troco);
                    txtTrocoAvista.BackColor = Color.Black;
                    txtTrocoAvista.ForeColor = Color.Black;

                    //txtValorAvista.Text = (string.Format("{0:C}", (Convert.ToDecimal(txtValorBruto.Text) - (Buscar.BuscarPorcentagemAvistaEstoqueProdutoPorCodigo(txtCodBarras.Text) * Convert.ToDecimal(txtValorBruto.Text) / 100)))).ToString();
                    //txtValorAvista.BackColor = Color.Black;
                    //txtValorAvista.ForeColor = Color.Black;
                }
                else
                {
                    txtTrocoAvista.Text = string.Format("{0:C}", troco);
                    txtTrocoAvista.BackColor = Color.Red;
                    txtTrocoAvista.ForeColor = Color.Red;

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

        #endregion TextBox Total Pago Avista

        #region CheckBox Avista

        private void Avista_CheckedChanged(object sender, EventArgs e)
        {
            if (gdvVenda.RowCount > 0)
            {
                if (chbAvista.Checked == true)
                {
                    txtTotalPagoAvista.Enabled = true;

                    txtTotalPagoAvista.ReadOnly = false;

                    txtValorAvista.Text = string.Format("{0:C}", (valorBruto - (Buscar.BuscarPorcentagemAvistaEstoqueProdutoPorCodigo()) * valorBruto / 100));

                    txtDescontoAvista.Text = string.Format("{0:P}", Buscar.BuscarPorcentagemAvistaEstoqueProdutoPorCodigo() / 100);
                }
                else if (chbAvista.Checked == false)
                {
                    txtTotalPagoAvista.Enabled = false;

                    txtTotalPagoAvista.ReadOnly = true;

                    txtValorAvista.Text = string.Empty;

                    txtDescontoAvista.Text = string.Empty;

                    txtTotalPagoAvista.Text = string.Empty;

                    txtTrocoAvista.Text = string.Empty;
                }
            }
        }

        private void chbAvista_Click(object sender, EventArgs e)
        {
            if (chbAvista.Checked == true)
            {
                chbCredito.Checked = false;
            }
        }

        #endregion CheckBox Avista

        #region CheckBox Credito

        private void chbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (gdvVenda.RowCount > 0)
            {
                if (chbCredito.Checked == true)
                {
                    cmbParcelaCredito.Enabled = true;
                }
                else if (chbCredito.Checked == false)
                {
                    cmbParcelaCredito.Enabled = false;

                    cmbParcelaCredito.Text = string.Empty;

                    txtJurosCredito.Text = string.Empty;

                    txtValorTotalCredito.Text = string.Empty;

                    txtValorParcelaCredito.Text = string.Empty;
                }
            }
        }

        private void chbCredito_Click(object sender, EventArgs e)
        {
            if (chbCredito.Checked == true)
            {
                chbAvista.Checked = false;
            }
        }

        #endregion CheckBox Credito

        #region CheckBox Venda

        private void chbVenda_Click(object sender, EventArgs e)
        {
            if (chbVenda.Checked == true)
            {
                cmbProduto.Enabled = false;

                chbOrcamento.Checked = false;
                //chbVenda.Checked = true;
                //chbAvista.Visible = true;
                //txtTotalPagoAvista.Visible = true;
                //txtDescontoAvista.Visible = true;
                //txtTrocoAvista.Visible = true;
                //txtValorAvista.Visible = true;
                //chbCredito.Visible = true;
                //txtValorTotalCredito.Visible = true;
                //txtValorParcelaCredito.Visible = true;
                //txtJurosCredito.Visible = true;
                //cmbParcelaCredito.Visible = true;
                //lblCredito.Visible = true;
                //lblFormapagamentoAvista.Visible = true;
                //lblFormapagamentoCredito.Visible = true;
                //lblJurosCredito.Visible = true;
                //lblParcelaCredito.Visible = true;
                //lblValorCredito.Visible = true;
                //grupoBoxAvista.Visible = true;
                //grupboxCredito.Visible = true;
                //lblDesconto.Visible = true;
                //lblValorLiquido.Visible = true;
                //label15.Visible = true;
                //label16.Visible = true;

                lblNumeroVenda.Visible = true;
                txtNumeroNF.Visible = true;
                lblData.Visible = true;
                txtData.Visible = true;
                lblCliente.Visible = true;
                cmbCliente.Visible = true;
                lblCodCliente.Visible = true;
                txtCodigoCliente.Visible = true;
                lblVendedor.Visible = true;
                txtVendedor.Visible = true;
                btnGerarBoleto.Visible = true;
                btnImprimir.Visible = true;
                btnConfirmarVenda.Visible = true;
                btnCancelarVenda.Visible = true;
                btnAbriCadastroCliente.Visible = true;

                btnNovoCliente.Text = "Nova \nVeda";

                btnRemoverItem.Location = new Point(297, 41);

                //this.Size = new Size(967, 727);

                lblCodBarras.Visible = true;
                txtCodBarras.Visible = true;
                btnBuscar.Visible = true;

                lblCodProduto.Location = new Point(177, 153);
                txtCodProduto.Location = new Point(180, 171);
                lblProduto.Location = new Point(306, 153);
                cmbProduto.Location = new Point(312, 171);
                lblQuant.Location = new Point(547, 153);
                txtQuantidade.Location = new Point(550, 171);
                lblUnidade.Location = new Point(637, 153);
                txtUnidade.Location = new Point(640, 171);
                lblPreco.Location = new Point(766, 153);
                txtPrecoSemDesconto.Location = new Point(769, 171);
                btnAdcionar.Location = new Point(901, 162);

                gdvVenda.Rows.Clear();
                TextBox.ApagandoTextBox(this);
            }
        }

        #endregion CheckBox Venda

        #region CheckBox Orcamento

        private void chbOrcamento_Click(object sender, EventArgs e)
        {
            if (chbOrcamento.Checked == true)
            {
                cmbProduto.Enabled = true;
                chbVenda.Checked = false;
                lblNumeroVenda.Visible = false;
                txtNumeroNF.Visible = false;
                lblData.Visible = false;
                txtData.Visible = false;
                lblCliente.Visible = false;
                cmbCliente.Visible = false;
                lblCodCliente.Visible = false;
                txtCodigoCliente.Visible = false;
                lblVendedor.Visible = false;
                txtVendedor.Visible = false;
                btnGerarBoleto.Visible = false;
                btnImprimir.Visible = false;
                btnConfirmarVenda.Visible = false;
                btnCancelarVenda.Visible = false;
                btnAbriCadastroCliente.Visible = false;
                btnNovoCliente.Text = "Novo \n Orçamento";
                btnRemoverItem.Location = new Point(107, 41);
                lblCodBarras.Visible = false;
                txtCodBarras.Visible = false;
                btnBuscar.Visible = false;
                lblCodProduto.Location = new Point(90, 153);
                txtCodProduto.Location = new Point(93, 171);
                lblProduto.Location = new Point(219, 153);
                cmbProduto.Location = new Point(222, 171);
                lblQuant.Location = new Point(460, 153);
                txtQuantidade.Location = new Point(463, 171);
                lblUnidade.Location = new Point(550, 153);
                txtUnidade.Location = new Point(553, 171);
                lblPreco.Location = new Point(679, 153);
                txtPrecoSemDesconto.Location = new Point(681, 171);
                btnAdcionar.Location = new Point(814, 162);
                gdvVenda.Rows.Clear();

                TextBox.ApagandoTextBox(this);

                listaProduto = Buscar.BuscarProdutos();

                cmbProduto.Items.Clear();

                foreach (DadosProduto item in listaProduto)
                {
                    cmbProduto.Items.Add(item.descricaoProduto);
                }
            }
        }

        #endregion CheckBox Orcamento

        #region ComboBox Parcela Credito

        private void cmbParcelaCredito_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbParcelaCredito.Text != String.Empty)
            {
                if (Convert.ToInt32(cmbParcelaCredito.Text.Replace("x", "")) > Buscar.BuscarQuantidadeDeParcelasParaGerarJuros())
                {
                    txtJurosCredito.Text = string.Format("{0:P}", Buscar.BuscarPorcentagemJurosCredito() / 100);

                    txtValorParcelaCredito.Text = string.Format("{0:C}", ((Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", "")) +
                                                                         (Convert.ToDecimal(txtJurosCredito.Text.Replace("%", "")) *
                                                                             Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", "")) / 100))
                                                                        / Convert.ToDecimal(cmbParcelaCredito.Text.Replace("x", "")))).ToString();

                    txtValorTotalCredito.Text = string.Format("{0:C}",
                        ((Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", "")) +
                          (Convert.ToDecimal(txtJurosCredito.Text.Replace("%", "")) *
                              Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", "")) / 100)))).ToString();
                }
                else
                {
                    txtJurosCredito.Text = string.Format("{0:P}", "0,00%");

                    txtValorParcelaCredito.Text = string.Format("{0:C}", ((Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", "")) +
                                                                           (Convert.ToDecimal(txtJurosCredito.Text.Replace("%", "")) *
                                                                               Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", "")) / 100))
                                                                          / Convert.ToDecimal(cmbParcelaCredito.Text.Replace("x", "")))).ToString();

                    txtValorTotalCredito.Text = string.Format("{0:C}",
                        ((Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", "")) +
                          (Convert.ToDecimal(txtJurosCredito.Text.Replace("%", "")) *
                              Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", "")) / 100)))).ToString();
                }
            }
        }

        #endregion ComboBox Parcela Credito

        #region ComboBox Cliente

        private void cmbCliente_Enter(object sender, EventArgs e)
        {
            cmbCliente.MaxLength = 50;

            cmbCliente.Items.Clear();

            foreach (var item in Buscar.BuscarListaCliente())
            {
                cmbCliente.Items.Add(item);
            }
        }

        private void cmbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox.DigitarApenasNumeros(e);
        }

        private void cmbCliente_KeyUp(object sender, KeyEventArgs e)
        {
            List<DadosCliente> listaCliente = Buscar.BuscarClientePorPesquisa(cmbCliente.Text);

            if (listaCliente.Count != 0)
            {
                foreach (var variable in listaCliente)
                {
                    txtCodigoCliente.Text = variable.id.ToString();
                }
            }
            else
            {
                txtCodigoCliente.Text = string.Empty;
            }

            if (cmbCliente.Text == string.Empty)
            {
                txtCodigoCliente.Text = string.Empty;
            }
        }

        #endregion ComboBox Cliente

        #region ComboBox Produto

        private void cmbProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmbProduto.MaxLength = 50;

            if (cmbProduto.Text == "")
            {
                KeysConverter kc = new KeysConverter();

                string caracter = kc.ConvertToString(e.KeyChar);

                produto = listaProduto.FindLast(prod => prod.descricaoProduto.ToLower().StartsWith(caracter));
            }
            else
            {
                produto = listaProduto.FindLast(prod => prod.descricaoProduto.ToLower().StartsWith(cmbProduto.Text.ToLower()));
            }

            if (produto != null)
            {
                txtCodProduto.Text = produto.codigo.ToString();
                txtQuantidade.Text = produto.quantidade.ToString();
                txtUnidade.Text = produto.unidade.ToString();
                txtPrecoSemDesconto.Text = string.Format("{0:C}", produto.preco).ToString();
            }
            else
            {
                txtCodBarras.Text = string.Empty;
                txtCodProduto.Text = string.Empty;
                txtQuantidade.Text = string.Empty;
                txtUnidade.Text = string.Empty;
                txtPrecoSemDesconto.Text = string.Empty;
            }
        }

        private void cmbProduto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbProduto.Text != string.Empty)
            {
                produto = listaProduto.FindLast(prod => prod.descricaoProduto.ToLower().StartsWith(cmbProduto.Text.ToLower()));

                txtCodProduto.Text = produto.codigo.ToString();
                txtQuantidade.Text = produto.quantidade.ToString();
                txtUnidade.Text = produto.unidade.ToString();
                txtPrecoSemDesconto.Text = string.Format("{0:C}", produto.preco).ToString();
            }
        }

        #endregion ComboBox Produto

        #region Apagando Dados dos TextBox

        private void ApagandoTextbox()
        {
            txtCodBarras.Text = string.Empty;
            txtCodProduto.Text = string.Empty;
            cmbProduto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtUnidade.Text = string.Empty;
            txtPrecoSemDesconto.Text = string.Empty;
        }

        #endregion Apagando Dados dos TextBox
    }
}