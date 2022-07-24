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

        public List<DadosNotaFiscalSaida> listaDadosNotaFiscalSaidaCompleta = new List<DadosNotaFiscalSaida>();

        //private DadosNotaFiscalSaida DadosNotaFiscalSaida;

        private DadosProduto produto = null;

        private decimal valorBruto = 0;

        private decimal memoriaQuantidade = 1;

        public int quantidadeItens = 0;

        private int cont = 0;

        public Forms_Venda()
        {
            InitializeComponent();

            txtData.Text = DateTime.Today.ToShortDateString();

            txtVendedor.Text = Global.NomeDeUsuario;

            CarregarDadosBanco();

            layoutTelaPagamento();

            cmbCliente.Text = "CLIENTE";
        }

        private void CarregarDadosBanco()
        {
            listaProduto = Buscar.BuscarListaProdutos();

            listaFinanceiro = Buscar.BuscarListaFinanceiro();

            txtNumeroNF.Text = Buscar.BuscarNumeroNotaFiscalSaida();

            //listaDadosFinanceiro.ForEach(finac => financeiro = finac);
        }

        private void layoutTelaPagamento()
        {
            grupoBoxAvista.Visible = false;
            grupboxCredito.Visible = false;

            lblNomeValorTotal.Location = new Point(318, 571);
            lblValorTotal.Location = new Point(329, 594);
            lblNomeValorTotalItens.Location = new Point(568, 571);
            lblTotalItens.Location = new Point(600, 594);
            gdvVenda.Size = new Size(923, 328);
            this.Size = new Size(967, 686);
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

        private void PreencherListaNotaFiscalSaida()
        {
            for (int i = 0; i < gdvVenda.Rows.Count; i++)
            {
                listaDadosNotaFiscalSaidaCompleta.Add(new DadosNotaFiscalSaida(0, Convert.ToInt32(lblNFEntrada.Text), txtCpfCnpjCliente.Text, cmbCliente.Text,
                    Convert.ToInt32(gdvVenda.Rows[i].Cells[0].Value), gdvVenda.Rows[i].Cells[1].Value.ToString(),
                    DateTime.Today, Convert.ToInt32(gdvVenda.Rows[i].Cells[7].Value), Global.NomeDeUsuario,
                    DateTime.Today.AddDays(30), Convert.ToDecimal(gdvVenda.Rows[i].Cells[6].Value.ToString().Replace("R$ ", "")),
                    Convert.ToDecimal(gdvVenda.Rows[i].Cells[2].Value), gdvVenda.Rows[i].Cells[3].Value.ToString(), "-", 0, 0, 0,
                     Convert.ToDecimal(gdvVenda.Rows[i].Cells[6].Value.ToString().Replace("R$ ", "")), "Status Venda",
                     "Troca Vendedor", "Motivo Troca", false,
                     Convert.ToInt32(lblNFEntrada.Text)));
            }
        }

        private void AdicionarProduto()
        {
            try
            {
                //txtQuantidade.ReadOnly = true;

                if (txtCodBarras.Text != string.Empty && cmbProduto.Text != string.Empty && chbVenda.Checked == true)
                {
                    //Checkbox Venda

                    bool isCadastroExiste = Buscar.BuscarEstoqueProdutoPorCodigo(txtCodBarras.Text);

                    if (isCadastroExiste == true)
                    {
                        produto = null;

                        try
                        {
                            produto = listaProduto.First(prod => prod.codigoBarras == Convert.ToInt32(txtCodBarras.Text) &&
                            prod.quantidade >= Convert.ToDecimal(txtQuantidade.Text));
                        }
                        catch (Exception ex)
                        {
                        }

                        if (produto == null)
                        {
                            MessageBox.Show($"Quantidade Solicitada Maior Que A Quantidade Disponivel!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return;
                        }

                        lblNFEntrada.Text = produto.nfEntrada.ToString();

                        produto.quantidade -= Convert.ToDecimal(txtQuantidade.Text);

                        PreenchendoGridView();

                        ValorTotal();

                        ApagandoTextbox();
                    }
                    else if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Codigo de Barras Não Encontrado! ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            lblValorTotal.Text = string.Format("{0:C}", valorBruto);

            lblTotalItens.Text = gdvVenda.RowCount.ToString();
        }

        private void PreenchendoGridView()
        {
            var rows = new List<string[]>();
            string[] row1 = new string[] { txtCodProduto.Text, cmbProduto.Text, txtQuantidade.Text,
                txtUnidade.Text, txtDescontoPorItem.Text, txtPrecoSemDesconto.Text,txtPrecoComDesconto.Text,
                txtCodBarras.Text};
            rows.Add(row1);

            foreach (string[] item in rows)
            {
                gdvVenda.Rows.Add(item);
            }
        }

        private void btnGerarBoleto_Click(object sender, EventArgs e)
        {
            if (gdvVenda.Rows.Count > 0)
            {
                PreencherListaNotaFiscalSaida();

                if (Buscar.SaldoDisponivelCliente(txtCpfCnpjCliente.Text) >= Convert.ToDecimal(lblValorTotal.Text.Replace("R$", "")))
                {
                    Forms_GerarCarne gerarBoleto = new Forms_GerarCarne(this);
                    gerarBoleto.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cliente Sem Saldo!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtQuantidade.ReadOnly = false;

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
                        produto = listaProduto.First(prod => prod.codigoBarras.ToString().StartsWith(txtCodBarras.Text));

                        //DadosProduto produto = null;

                        //try
                        //{
                        //    produto = listaProduto.Find(prod => prod.codigoProduto == Convert.ToInt32(txtCodBarras.Text) &&
                        //    produto.quantidade >= Convert.ToDecimal(txtQuantidade.Text));
                        //}
                        //catch (Exception)
                        //{
                        //}

                        //if (produto == null)
                        //{
                        //    MessageBox.Show($"Saldo Insuficiênte!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        //    return;
                        //}

                        if (produto.quantidade > 0)
                        {
                            PreencherTextBoxDadosProduto(produto);
                            //txtCodBarras.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Saldo Indisponivel Para O Produto Solicitado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Codigo de Barras Não Encontrado!", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarEstoqueProduto(ex);
            }
        }

        private void PreencherTextBoxDadosProduto(DadosProduto produto)
        {
            cmbProduto.Text = produto.descricaoProduto;
            txtCodProduto.Text = produto.codigoProduto.ToString();
            txtQuantidade.Text = "1";
            //txtQuantidade.Text = produto.quantidade.ToString();
            txtUnidade.Text = produto.unidade;
            txtPrecoSemDesconto.Text = string.Format("{0:C}", produto.preco);
            txtDescontoPorItem.Text = string.Format("{0:P}", (produto.desconto) / 100);
            txtPrecoComDesconto.Text = string.Format("{0:C}", ((produto.preco - (produto.preco * produto.desconto) / 100)));
            lblNFEntrada.Text = produto.nfEntrada.ToString();

            memoriaQuantidade = produto.quantidade;

            //produto.quantidade -= Convert.ToDecimal(txtQuantidade.Text);
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            RemoverProduto();
        }

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

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            CancelarCompra();
        }

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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
        }

        private void btnNovoVenda_Click(object sender, EventArgs e)
        {
            NovaVenda();
        }

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
                btnGerarBoleto.Visible = true;
                btnImprimir.Visible = false;
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
                btnAdicionar.Location = new Point(901, 162);
                btnSair.Location = new Point(580, 41);
                btnImprimir.Location = new Point(392, 41);

                grupoBoxAvista.Visible = false;
                grupboxCredito.Visible = false;

                lblNomeValorTotal.Location = new Point(318, 571);
                lblValorTotal.Location = new Point(329, 594);
                lblNomeValorTotalItens.Location = new Point(568, 571);
                lblTotalItens.Location = new Point(600, 594);
                gdvVenda.Size = new Size(923, 328);
                this.Size = new Size(967, 686);

                lblCpfCnpjCliente.Visible = true;
                txtCpfCnpjCliente.Visible = true;

                listaDadosNotaFiscalSaidaCompleta.Clear();
                valorBruto = 0;
                memoriaQuantidade = 1;
                quantidadeItens = 0;

                gdvVenda.Rows.Clear();

                ManipulacaoTextBox.ApagandoTextBox(this);
            }
        }

        private void chbOrcamento_Click(object sender, EventArgs e)
        {
            OrcamentoSelecionado();
        }

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
                btnGerarBoleto.Visible = false;
                btnImprimir.Visible = true;
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
                btnAdicionar.Location = new Point(814, 162);
                btnImprimir.Location = new Point(202, 41);
                btnSair.Location = new Point(297, 41);

                grupoBoxAvista.Visible = true;
                grupboxCredito.Visible = true;

                lblNomeValorTotal.Location = new Point(318, 420);
                lblValorTotal.Location = new Point(329, 443);
                lblNomeValorTotalItens.Location = new Point(568, 422);
                lblTotalItens.Location = new Point(598, 445);
                gdvVenda.Size = new Size(923, 190);
                this.Size = new Size(967, 727);

                lblCpfCnpjCliente.Visible = false;
                txtCpfCnpjCliente.Visible = false;

                listaDadosNotaFiscalSaidaCompleta.Clear();
                valorBruto = 0;
                memoriaQuantidade = 1;
                quantidadeItens = 0;

                gdvVenda.Rows.Clear();

                ManipulacaoTextBox.ApagandoTextBox(this);

                cmbProduto.Items.Clear();

                foreach (DadosProduto item in listaProduto)
                {
                    cmbProduto.Items.Add(item.descricaoProduto);
                }
            }
        }

        private void cmbParcelaCredito_SelectedValueChanged(object sender, EventArgs e)
        {
            ValorJuros();
        }

        private void ValorJuros()
        {
            if (cmbParcelaCredito.Text != String.Empty)
            {
                if (Convert.ToInt32(cmbParcelaCredito.Text.Replace("x", "")) > listaFinanceiro[0].parcelasCredito)
                {
                    txtJurosCredito.Text = string.Format("{0:P}", listaFinanceiro[0].jurosCredito / 100);

                    txtValorParcelaCredito.Text = string.Format("{0:C}", ((Convert.ToDecimal(lblValorTotal.Text.Replace("R$ ", "")) +
                                                                         (Convert.ToDecimal(txtJurosCredito.Text.Replace("%", "")) *
                                                                             Convert.ToDecimal(lblValorTotal.Text.Replace("R$ ", "")) / 100))
                                                                        / Convert.ToDecimal(cmbParcelaCredito.Text.Replace("x", "")))).ToString();

                    txtValorTotalCredito.Text = string.Format("{0:C}",
                        ((Convert.ToDecimal(lblValorTotal.Text.Replace("R$ ", "")) +
                          (Convert.ToDecimal(txtJurosCredito.Text.Replace("%", "")) *
                              Convert.ToDecimal(lblValorTotal.Text.Replace("R$ ", "")) / 100)))).ToString();
                }
                else
                {
                    txtJurosCredito.Text = string.Format("{0:P}", "0,00%");

                    txtValorParcelaCredito.Text = string.Format("{0:C}", ((Convert.ToDecimal(lblValorTotal.Text.Replace("R$ ", "")) +
                                                                           (Convert.ToDecimal(txtJurosCredito.Text.Replace("%", "")) *
                                                                               Convert.ToDecimal(lblValorTotal.Text.Replace("R$ ", "")) / 100))
                                                                          / Convert.ToDecimal(cmbParcelaCredito.Text.Replace("x", "")))).ToString();

                    txtValorTotalCredito.Text = string.Format("{0:C}",
                        ((Convert.ToDecimal(lblValorTotal.Text.Replace("R$ ", "")) +
                          (Convert.ToDecimal(txtJurosCredito.Text.Replace("%", "")) *
                              Convert.ToDecimal(lblValorTotal.Text.Replace("R$ ", "")) / 100)))).ToString();
                }
            }
        }

        private void cmbCliente_Enter(object sender, EventArgs e)
        {
            PreencherListaClientes();
        }

        private void PreencherListaClientes()
        {
            cmbCliente.MaxLength = 50;

            cmbCliente.Items.Clear();

            foreach (string item in Buscar.BuscarListaCliente())
            {
                cmbCliente.Items.Add(item);
            }
        }

        private void cmbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetras(e);
        }

        private void cmbCliente_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarDadosCliente();
        }

        private void BuscarDadosCliente()
        {
            List<DadosCliente> listaCliente = Buscar.BuscarClientePorPesquisa(cmbCliente.Text);

            if (listaCliente.Count != 0)
            {
                foreach (DadosCliente variable in listaCliente)
                {
                    txtCodigoCliente.Text = variable.id.ToString();
                    txtCpfCnpjCliente.Text = variable.cpfCpnjCliente;
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

        private void cmbProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            MostrarListaComProdutos(e);
        }

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
                memoriaQuantidade = produto.quantidade;
                txtQuantidade.Text = "1";
                //txtQuantidade.Text = produto.quantidade.ToString();
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
            PreencherTextBoxPorProduto();
        }

        private void PreencherTextBoxPorProduto()
        {
            if (cmbProduto.Text != string.Empty)
            {
                produto = listaProduto.FindLast(prod => prod.descricaoProduto.ToLower().StartsWith(cmbProduto.Text.ToLower()));

                txtCodProduto.Text = produto.codigoProduto.ToString();
                memoriaQuantidade = produto.quantidade;
                txtQuantidade.Text = "1";
                //txtQuantidade.Text = produto.quantidade.ToString();
                txtUnidade.Text = produto.unidade.ToString();
                txtPrecoSemDesconto.Text = string.Format("{0:C}", produto.preco).ToString();

                txtQuantidade.ReadOnly = false;
            }
        }

        private void ApagandoTextbox()
        {
            txtCodBarras.Text = string.Empty;
            txtCodProduto.Text = string.Empty;
            cmbProduto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtUnidade.Text = string.Empty;
            txtPrecoSemDesconto.Text = string.Empty;
        }

        private void Forms_Venda_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                //listaDadosProduto = Buscar.BuscarListaProdutos();

                //ListaFinanceiro = Buscar.BuscarListaFinanceiro();
            });

            //ListaFinanceiro.ForEach(finac => financeiro = finac);
        }

        private void btnConfirmarVenda_Click_1(object sender, EventArgs e)
        {
            if (gdvVenda.Rows.Count > 0)
            {
                PreencherListaNotaFiscalSaida();

                quantidadeItens = Convert.ToInt32(lblTotalItens.Text);

                Forms_Pagamento pagamento = new Forms_Pagamento(this, "Venda");
                pagamento.ShowDialog();
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void cmbProduto_Leave(object sender, EventArgs e)
        {
            gdvVenda.Focus();
        }

        private void lblValorTotal_Click(object sender, EventArgs e)
        {
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}