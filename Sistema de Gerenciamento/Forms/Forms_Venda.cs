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

        private List<DadosProduto> listaProduto = new List<DadosProduto>();

        private List<DadosFinanceiro> listaFinanceiro = new List<DadosFinanceiro>();

        private DadosProduto produto;

        //private DadosFinanceiro financeiro;

        private decimal valorBruto = 0;

        public Forms_Venda()
        {
            InitializeComponent();

            txtData.Text = DateTime.Today.ToShortDateString();

            txtVendedor.Text = Global.NomeDeUsuario;

            CarregarDadosBanco();
        }

        private void CarregarDadosBanco()
        {
            listaProduto = Buscar.BuscarProdutos();

            listaFinanceiro = Buscar.BuscarFinanceiro();

            //listaFinanceiro.ForEach(finac => financeiro = finac);
        }

        private void btnAbriCadastroCliente_Click(object sender, EventArgs e)
        {
            Forms_CadastroCliente buscarCliente = new Forms_CadastroCliente();
            buscarCliente.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            AdicionarProduto();
        }

        private void AdicionarProduto()
        {
            try
            {
                if (txtCodBarras.Text != string.Empty && cmbProduto.Text != string.Empty && chbVenda.Checked == true)
                {
                    //Checkbox Venda

                    bool isCadastroExiste = Buscar.BuscarEstoqueProdutoPorCodigo(txtCodBarras.Text);

                    if (isCadastroExiste == true)
                    {
                        PreenchendoGridView();

                        ValorTotal();

                        ApagandoTextbox();
                    }
                    else if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Codigo de Barras Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (cmbProduto.Text != string.Empty && chbOrcamento.Checked == true && txtCodProduto.Text != string.Empty)
                {
                    //Checkbox Orcamento

                    txtPrecoComDesconto.Text = string.Format("{0:C}", (Convert.ToDecimal(txtPrecoSemDesconto.Text.Replace("R$ ", "")) -
                                                                       (Convert.ToDecimal(Buscar.BuscarDesontoPorItem(cmbProduto.Text)))
                                                                       * Convert.ToDecimal(txtPrecoSemDesconto.Text.Replace("R$ ", "")) / 100)).ToString();

                    txtDescontoPorItem.Text = string.Format("{0:P}", Convert.ToDecimal(Buscar.BuscarDesontoPorItem(cmbProduto.Text)) / 100);

                    PreenchendoGridView();

                    ValorTotal();

                    ApagandoTextbox();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarEstoqueProduto(ex);
            }
        }

        private void ValorTotal()
        {
            valorBruto = 0;

            for (int i = 0; i < gdvVenda.RowCount; i++)
            {
                valorBruto += Convert.ToDecimal(gdvVenda.Rows[i].Cells[6].Value.ToString().Replace("R$ ", ""));
            }

            txtValorTotal.Text = string.Format("{0:C}", valorBruto);

            txtTotalItens.Text = gdvVenda.RowCount.ToString();
        }

        private void PreenchendoGridView()
        {
            var rows = new List<string[]>();
            string[] row1 = new string[] { txtCodProduto.Text, cmbProduto.Text, txtQuantidade.Text,
                txtUnidade.Text, txtDescontoPorItem.Text, txtPrecoSemDesconto.Text,txtPrecoComDesconto.Text };
            rows.Add(row1);

            foreach (string[] item in rows)
            {
                gdvVenda.Rows.Add(item);
            }
        }

        private void btnGerarBoleto_Click(object sender, EventArgs e)
        {
            if (txtValorTotal.Text != string.Empty)
            {
                Forms_GerarCarne gerarBoleto = new Forms_GerarCarne(this);
                gerarBoleto.ShowDialog();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProduto();
        }

        private void BuscarProduto()
        {
            try
            {
                if (txtCodBarras.Text != string.Empty)
                {
                    bool isCadastroExiste = Buscar.BuscarEstoqueProdutoPorCodigo(txtCodBarras.Text);

                    if (isCadastroExiste == true)
                    {
                        produto = listaProduto.Find(prod => prod.codigoBarras.ToString().StartsWith(txtCodBarras.Text));

                        cmbProduto.Text = produto.descricaoProduto;
                        txtCodProduto.Text = produto.codigoProduto.ToString();
                        txtQuantidade.Text = produto.quantidade.ToString();
                        txtUnidade.Text = produto.unidade;
                        txtPrecoSemDesconto.Text = string.Format("{0:C}", produto.preco);
                        txtDescontoPorItem.Text = string.Format("{0:P}", (produto.desconto) / 100);
                        txtPrecoComDesconto.Text = string.Format("{0:C}", ((produto.preco - (produto.preco * produto.desconto) / 100)));
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

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            RemoverProduto();
        }

        #region Remover Produto do GridView

        private void RemoverProduto()
        {
            if (gdvVenda.RowCount > 0)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Remover O Item?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    gdvVenda.Rows.RemoveAt(gdvVenda.CurrentRow.Index);

                    ValorTotal();

                    ApagandoTextbox();
                }
            }
        }

        #endregion Remover Produto do GridView

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            CancelarCompra();
        }

        #region Cancelar Compra

        private void CancelarCompra()
        {
            if (gdvVenda.RowCount > 0)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Cancelar a Compra?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    gdvVenda.Rows.Clear();

                    ManipulacaoTextBox.ApagandoTextBox(this);
                }
            }
        }

        #endregion Cancelar Compra

        private void btnImprimir_Click(object sender, EventArgs e)
        {
        }

        private void btnNovoVenda_Click(object sender, EventArgs e)
        {
            NovaVenda();
        }

        #region Nova Venda

        private void NovaVenda()
        {
            if (gdvVenda.RowCount > 0)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Cancelar a Compra?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    gdvVenda.Rows.Clear();

                    ManipulacaoTextBox.ApagandoTextBox(this);
                }
            }
            else
            {
                ManipulacaoTextBox.ApagandoTextBox(this);
            }
        }

        #endregion Nova Venda

        private void txtCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtTotalPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoDinheiro(e, sender, txtTotalPagoAvista);
        }

        private void txtTotalPago_KeyUp(object sender, KeyEventArgs e)
        {
            ValorTroco();
        }

        #region Valor Do Troco

        private void ValorTroco()
        {
            try
            {
                decimal troco = (Convert.ToDecimal(txtTotalPagoAvista.Text.Replace("R$ ", "")) - Convert.ToDecimal(txtValorAvista.Text.Replace("R$ ", "")));

                if (troco > 0)
                {
                    txtTrocoAvista.Text = string.Format("{0:C}", troco);
                    txtTrocoAvista.BackColor = Color.Black;
                    txtTrocoAvista.ForeColor = Color.Black;
                }
                else
                {
                    txtTrocoAvista.Text = string.Format("{0:C}", troco);
                    txtTrocoAvista.BackColor = Color.Red;
                    txtTrocoAvista.ForeColor = Color.Red;
                }
            }
            catch (Exception exception)
            {
            }
        }

        #endregion Valor Do Troco

        private void Avista_CheckedChanged(object sender, EventArgs e)
        {
            PagamentoAvistaSelecionado();
        }

        private void PagamentoAvistaSelecionado()
        {
            if (gdvVenda.RowCount > 0)
            {
                if (chbAvista.Checked == true)
                {
                    txtTotalPagoAvista.Enabled = true;

                    txtTotalPagoAvista.ReadOnly = false;

                    txtValorAvista.Text = string.Format("{0:C}", (valorBruto - (listaFinanceiro[0].descontoAvista) * valorBruto / 100));

                    txtDescontoAvista.Text = string.Format("{0:P}", listaFinanceiro[0].descontoAvista / 100);
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

        private void chbCredito_CheckedChanged(object sender, EventArgs e)
        {
            CreditoSelecionado();
        }

        #region Credito Selecionado

        private void CreditoSelecionado()
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

        #endregion Credito Selecionado

        private void chbCredito_Click(object sender, EventArgs e)
        {
            if (chbCredito.Checked == true)
            {
                chbAvista.Checked = false;
            }
        }

        private void chbVenda_Click(object sender, EventArgs e)
        {
            VendaSelecionada();
        }

        private void VendaSelecionada()
        {
            if (chbVenda.Checked == true)
            {
                cmbProduto.Enabled = false;

                chbOrcamento.Checked = false;
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
                btnNovaVenda.Text = "Nova \nVeda";
                btnRemoverItem.Location = new Point(297, 41);
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

                ManipulacaoTextBox.ApagandoTextBox(this);
            }
        }

        private void chbOrcamento_Click(object sender, EventArgs e)
        {
            OrcamentoSelecionado();
        }

        #region Orcamento Selecionado

        private void OrcamentoSelecionado()
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
                btnNovaVenda.Text = "Novo \n Orçamento";
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

                ManipulacaoTextBox.ApagandoTextBox(this);

                cmbProduto.Items.Clear();

                foreach (DadosProduto item in listaProduto)
                {
                    cmbProduto.Items.Add(item.descricaoProduto);
                }
            }
        }

        #endregion Orcamento Selecionado

        private void cmbParcelaCredito_SelectedValueChanged(object sender, EventArgs e)
        {
            ValorJuros();
        }

        #region Valor do Juros Conforme a Quantidade de Parcelas

        private void ValorJuros()
        {
            if (cmbParcelaCredito.Text != String.Empty)
            {
                if (Convert.ToInt32(cmbParcelaCredito.Text.Replace("x", "")) > listaFinanceiro[0].parcelasCredito)
                {
                    txtJurosCredito.Text = string.Format("{0:P}", listaFinanceiro[0].jurosCredito / 100);

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

        #endregion Valor do Juros Conforme a Quantidade de Parcelas

        private void cmbCliente_Enter(object sender, EventArgs e)
        {
            PreencherListaClientes();
        }

        #region Preencher Lista Com Clinetes

        private void PreencherListaClientes()
        {
            cmbCliente.MaxLength = 50;

            cmbCliente.Items.Clear();

            foreach (string item in Buscar.BuscarListaCliente())
            {
                cmbCliente.Items.Add(item);
            }
        }

        #endregion Preencher Lista Com Clinetes

        private void cmbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetras(e);
        }

        private void cmbCliente_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarDadosCliente();
        }

        #region Buscar Dados Cliente

        private void BuscarDadosCliente()
        {
            List<DadosCliente> listaCliente = Buscar.BuscarClientePorPesquisa(cmbCliente.Text);

            if (listaCliente.Count != 0)
            {
                foreach (DadosCliente variable in listaCliente)
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

        #endregion Buscar Dados Cliente

        private void cmbProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            MostrarListaComProdutos(e);
        }

        #region Mostrar Lista Com Produtos

        private void MostrarListaComProdutos(KeyPressEventArgs e)
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
                txtCodProduto.Text = produto.codigoProduto.ToString();
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

        #endregion Mostrar Lista Com Produtos

        private void cmbProduto_SelectedValueChanged(object sender, EventArgs e)
        {
            PreencherTextBoxPorProduto();
        }

        #region Preencher TextBox Por Produto da Busca

        private void PreencherTextBoxPorProduto()
        {
            if (cmbProduto.Text != string.Empty)
            {
                produto = listaProduto.FindLast(prod => prod.descricaoProduto.ToLower().StartsWith(cmbProduto.Text.ToLower()));

                txtCodProduto.Text = produto.codigoProduto.ToString();
                txtQuantidade.Text = produto.quantidade.ToString();
                txtUnidade.Text = produto.unidade.ToString();
                txtPrecoSemDesconto.Text = string.Format("{0:C}", produto.preco).ToString();
            }
        }

        #endregion Preencher TextBox Por Produto da Busca

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

        private void Forms_Venda_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                //listaProduto = Buscar.BuscarProdutos();

                //ListaFinanceiro = Buscar.BuscarFinanceiro();
            });

            //ListaFinanceiro.ForEach(finac => financeiro = finac);
        }
    }
}