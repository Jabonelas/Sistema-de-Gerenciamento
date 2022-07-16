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
using Sistema_de_Gerenciamento.Classes;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_PDV : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private List<DadosFinanceiro> listaDadosFinanceiro = new List<DadosFinanceiro>();

        private List<DadosPermissoes> listaDadosPermissao = new List<DadosPermissoes>();

        private List<DadosProduto> listaDadosProduto = new List<DadosProduto>();

        private DadosProduto produto;

        private decimal valorBruto = 0;

        private int cont = 0;

        //private string verificar;

        public Forms_PDV()
        {
            InitializeComponent();

            PreenchimentoDados();

            //FormatoFullScreen();
        }

        private void PreenchimentoDados()
        {
            listaDadosProduto = Buscar.BuscarListaProdutos();

            listaDadosFinanceiro = Buscar.BuscarListaFinanceiro();

            listaDadosPermissao = Buscar.BuscarListaPermissoes(Global.NomeDeUsuario);

            pcbPDV.Image = Buscar.BuscarLogoEmpresa(1);

            txtVendedor.Text = Global.NomeDeUsuario;

            cmbParcelas.SelectedIndex = 0;
        }

        private void FormatoFullScreen()
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            this.Width = Screen.PrimaryScreen.Bounds.Width;

            this.TopMost = true;
        }

        private void Forms_TelaPDV_KeyDown(object sender, KeyEventArgs e)
        {
            AtalhoFecharTela(e);

            AtalhoNovaVenda(e);

            AtalhoExluirItem(e);

            AtalhoInserirCPF(e);

            AtalhoBuscarPorCodigoProduto(e);

            AtalhoTelaPesquisarProduto(e);

            AtalhoInserirQuantidade(e);

            AtalhoPagamento(e);

            AtalhoCancelarVenda(e);

            AtalhoDevolucaoTroca(e);

            AtalhoFinalizarVenda(e);

            AtalhoCancelarPagamento(e);
        }

        private void AtalhoFecharTela(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Finalziar tela Esc
            {
                if (lblDescricaoItem.Text != "PAGAMENTO" || gdvPDV.Rows.Count <= 0 || lblNumeroNotaFiscalSaida.Visible == true)
                {
                    this.Close();
                }
            }
        }

        private void AtalhoNovaVenda(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) // nova venda F1
            {
                //if (gdvPDV.Rows.Count <= 0)
                if (lblFachada.Text == "CAIXA ABERTO" || lblDescricaoItem.Text == "Nº NOTA FISCAL:")
                {
                    FormatandoParaNovaVenda();

                    return;
                }
            }
        }

        private void AtalhoExluirItem(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) // excluir item F2
            {
                if (gdvPDV.Rows.Count > 0 && lblDescricaoItem.Text != "PAGAMENTO")
                {
                    if (Global.NomeDeUsuario == "ADMIN" || listaDadosPermissao[0].excluirItem == "true")
                    {
                        RemoverProduto();

                        return;
                    }
                    else
                    {
                        Forms_ControleADMIN controleADMIN = new Forms_ControleADMIN(this, "Remover Produto");
                        controleADMIN.ShowDialog();

                        return;
                    }
                }
            }
        }

        private void AtalhoInserirCPF(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && lblDescricaoItem.Text != "PAGAMENTO") // inserir cpf F3
            {
                txtCPF.Text = string.Empty;
                txtCPF.ReadOnly = true;
                txtCPF.Enabled = true;
                txtCPF.Focus();

                return;
            }
        }

        private void AtalhoBuscarPorCodigoProduto(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4) // Buscar Por Codigo F4
            {
                txtCodigoProduto.Enabled = true;
                txtCodigoProduto.Visible = true;
                txtCodigoProduto.Text = String.Empty;
                txtCodigoProduto.Focus();

                return;
            }
        }

        private void AtalhoTelaPesquisarProduto(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5 && lblDescricaoItem.Text != "PAGAMENTO") // Pesquisar Produto F5
            {
                Forms_PesquisarProduto pesquisarProduto = new Forms_PesquisarProduto(this, "Tela PDV");
                pesquisarProduto.ShowDialog();

                //Desabilitar o evento DoubleClick do Grid?View
                pesquisarProduto.gdvPesquisarProduto.DoubleClick -= pesquisarProduto.gdvPesquisarProduto_DoubleClick;

                txtCodigoProduto.Focus();

                return;
            }
        }

        private void AtalhoInserirQuantidade(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6 && lblDescricaoItem.Text != "PAGAMENTO") // inserir quantidade F6
            {
                lblTituloCPFQuant.Text = "QUANTIDADE";
                txtCPF.Visible = false;
                txtInserirQuant.Text = String.Empty;
                txtInserirQuant.Visible = true;
                txtInserirQuant.Enabled = true;
                txtInserirQuant.Focus();

                return;
            }
        }

        private void AtalhoPagamento(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7 && lblDescricaoItem.Text != "PAGAMENTO") // Pagamento F7
            {
                if (gdvPDV.Rows.Count > 0)
                {
                    FormatoTelaParaPagamento("Pagamento");

                    txtValorDinheiro.Visible = false;
                    lblTituloValorParcela.Visible = false;
                    cmbFormaPagamento.Focus();
                    lblDescricaoItem.Text = "PAGAMENTO";
                    lblUnidade.Text = String.Empty;
                }
            }
        }

        private void AtalhoCancelarVenda(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8 && lblDescricaoItem.Text != "PAGAMENTO") // Cancelar Venda F8
            {
                if (gdvPDV.Rows.Count > 0)
                {
                    if (Global.NomeDeUsuario == "ADMIN" || listaDadosPermissao[0].cancelarVenda == "true")
                    {
                        FormatandoParaNovaVenda();

                        return;
                    }
                    else
                    {
                        Forms_ControleADMIN controleADMIN = new Forms_ControleADMIN(this, "");
                        controleADMIN.ShowDialog();
                    }
                }
            }
        }

        private void AtalhoDevolucaoTroca(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && lblDescricaoItem.Text != "PAGAMENTO") // Devolução / Troca F9
            {
                if (gdvPDV.Rows.Count <= 0)
                {
                    if (Global.NomeDeUsuario == "ADMIN" || listaDadosPermissao[0].devolucaoTroca == "true")
                    {
                        Forms_Troca telaDevolucaoTroca = new Forms_Troca();
                        telaDevolucaoTroca.ShowDialog();

                        return;
                    }
                    else
                    {
                        Forms_ControleADMIN controleADMIN = new Forms_ControleADMIN(this, "Devolucao/Troca");
                        controleADMIN.ShowDialog();

                        return;
                    }
                }
            }
        }

        private void AtalhoFinalizarVenda(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10 && lblDescricaoItem.Text == "PAGAMENTO") // Finalizar Venda F10
            {
                if (cmbFormaPagamento.Text != "")
                {
                    DialogResult OpcaoDoUsuario = new DialogResult();
                    OpcaoDoUsuario = MessageBox.Show("Deseja Finalzar a Venda?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (OpcaoDoUsuario == DialogResult.Yes)
                    {
                        //lblNumeroNotaFiscalSaida.Text = Buscar.BuscarUltimaNotaFiscalSaida();
                        lblNumeroNotaFiscalSaida.Text = "1";

                        //txtVendedor.Text = "israel";

                        lblDescricaoItem.Text = "Nº NOTA FISCAL:";
                        lblNumeroNotaFiscalSaida.Visible = true;

                        for (int i = 0; i < gdvPDV.RowCount; i++)
                        {
                            //Pagamento Sem Juros - Preenchimento dos valores de desconto, juros e valor pago de cada item
                            if (cmbFormaPagamento.Text == "DÉBITO" ||
                                cmbFormaPagamento.Text == "DINHEIRO" || cmbFormaPagamento.Text == "PIX")
                            {
                                lblValorDescontoCadaItem.Text = (Convert.ToDecimal(gdvPDV.Rows[i].Cells[4].Value.ToString().Replace("R$", ""))
                                    * listaDadosFinanceiro[0].descontoAvista / 100).ToString();

                                lblJurosCadaItem.Text = ((Convert.ToDecimal(lblValorJuros.Text.Replace("%", "")) *
                                    Convert.ToDecimal(gdvPDV.Rows[i].Cells[4].Value.ToString().Replace("R$", ""))) / 100).ToString();

                                lblValorPagoCadaItem.Text = (Convert.ToDecimal(gdvPDV.Rows[i].Cells[4].Value.ToString().Replace("R$", "")) -
                                    Convert.ToDecimal(lblValorDescontoCadaItem.Text)).ToString();
                            }
                            //Pagamento Com Juros - Preenchimento dos valores de desconto, juros e valor pago de cada item
                            else
                            {
                                lblValorDescontoCadaItem.Text = "0";

                                lblJurosCadaItem.Text = ((Convert.ToDecimal(lblValorJuros.Text.Replace("%", "")) *
                                   Convert.ToDecimal(gdvPDV.Rows[i].Cells[4].Value.ToString().Replace("R$", ""))) / 100).ToString();

                                lblValorPagoCadaItem.Text = (Convert.ToDecimal(gdvPDV.Rows[i].Cells[4].Value.ToString().Replace("R$", "")) +
                                    Convert.ToDecimal(lblJurosCadaItem.Text)).ToString();
                            }

                            try
                            {
                                Salvar.NotaFiscalSaida(
                                        txtCPF.Text,
                                        Convert.ToInt32(lblNumeroNotaFiscalSaida.Text),
                                        Convert.ToInt32(gdvPDV.Rows[i].Cells[0].Value),
                                        gdvPDV.Rows[i].Cells[1].Value.ToString(),
                                        Convert.ToDecimal(gdvPDV.Rows[i].Cells[2].Value),
                                        Convert.ToDecimal(gdvPDV.Rows[i].Cells[3].Value.ToString().Replace("R$", "")),
                                        Convert.ToDateTime(DateTime.Now),
                                        Convert.ToInt32(gdvPDV.Rows[i].Cells[6].Value),
                                        txtVendedor.Text,
                                        Convert.ToDateTime(DateTime.Today.AddDays(30).ToShortDateString()),
                                        lblNomeCliente.Text,
                                        cmbFormaPagamento.Text,
                                        Convert.ToDecimal(lblValorDescontoCadaItem.Text),
                                        Convert.ToInt32(cmbParcelas.Text.Replace("x", "")),
                                        Convert.ToDecimal(lblJurosCadaItem.Text),
                                        Convert.ToDecimal(lblValorPagoCadaItem.Text),
                                        gdvPDV.Rows[i].Cells[7].Value.ToString(),
                                        lblStatusVenda.Text,
                                        lblTrocaVendedor.Text,
                                        lblMotivoTroca.Text);

                                Atualizar.AtualizarQuantidadeEstoquePosVenda(Convert.ToDecimal(gdvPDV.Rows[i].Cells[2].Value), Convert.ToInt32(gdvPDV.Rows[i].Cells[6].Value));

                                pnlVendaFinalizada.Visible = true;
                            }
                            catch (Exception ex)
                            {
                                Erro.ErroAoInserirDadosNaNotaFiscalSaidaTelaPDV(ex);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Informe o Tipo de Pagamento!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void AtalhoCancelarPagamento(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12 && lblDescricaoItem.Text == "PAGAMENTO") // Cancelar Pagamento F12
            {
                if (gdvPDV.Rows.Count > 0)
                {
                    if (Global.NomeDeUsuario == "ADMIN" || listaDadosPermissao[0].cancelarPagamento == "true")
                    {
                        FormatandoParaNovaVenda();

                        return;
                    }
                    else
                    {
                        Forms_ControleADMIN controleADMIN = new Forms_ControleADMIN(this, "Cancelar Pagamento");
                        controleADMIN.ShowDialog();

                        return;
                    }
                }
            }
        }

        public void FormatandoParaNovaVenda()
        {
            LayoutTipoPagamentoCredito(false);

            gdvPDV.Rows.Clear();

            FormatoTelaParaPagamento("Cancelamento");

            pnlVendaFinalizada.Visible = false;
            lblNumeroNotaFiscalSaida.Visible = false;
            cmbFormaPagamento.SelectedIndex = -1;
            lblValorDesconto.Text = "R$ 0,00";
            lblTituloFormaPagamento.Text = "PAGAMENTO";
            lblValorDebito.Text = "R$ 0,00";
            txtCPF.Text = "-";
            txtCPF.ReadOnly = false;
            txtCPF.Enabled = false;
            lblValorTotal.Text = "R$ 0,00";
            lblNomeCliente.Text = "CLIENTE";
            lblSubtotal.Text = "R$ 0,00";
            lblTroco.Text = "R$ 0,00";
            lblTotalRecebido.Text = "R$ 0,00";
            txtCodigoProduto.Text = "-";
            lblTotaldoItem.Text = "R$ 0,00";
            lblValorUnitario.Text = "R$ 0,00";
            pnlFachada.BackgroundColor = Color.Lime;
            lblFachada.Location = new Point(97, -9);
            lblFachada.Text = "CAIXA DISPONÍVEL";
            txtCPF.UseSystemPasswordChar = false;
            txtCodigoDeBarras.Focus();
            lblDescricaoItem.Text = "DESCRIÇÃO DO ITEM";
            lblUnidade.Text = "UN";

            pcbPDV.Image = Buscar.BuscarLogoEmpresa(1);
        }

        private void FormatoTelaParaPagamento(string _verificar)
        {
            bool retorno = _verificar == "Pagamento" ? true : false;

            pcbPDV.Visible = !retorno;
            pnlFundoCliente.Visible = retorno;
            lblCliente.Visible = retorno;
            lblNomeCliente.Visible = retorno;

            //painel com forma de pagamento
            lblFormaPamento.Visible = retorno;
            pnlFormaPagamento.Visible = retorno;
            cmbFormaPagamento.Visible = retorno;

            //painel com desconto
            lblDesconto.Visible = retorno;
            lblValorDesconto.Visible = retorno;
            pnlDesconto.Visible = retorno;

            //painel carne
            pnlCarne.Visible = retorno;
            lblTituloFormaPagamento.Visible = retorno;
            lblTituloValorParcela.Visible = retorno;

            //painel Credito
            //pnlCredito.Visible = retorno;
            //lblTituloCredito.Visible = retorno;
            //lblValorCredito.Visible = retorno;

            //painel Debito
            //pnlDebito.Visible = retorno;
            //lblTituloDebito.Visible = retorno;
            //lblValorDebito.Visible = retorno;

            //painel Dinheiro
            pnlDinheiro.Visible = retorno;
            //lblTituloDinheiro.Visible = retorno;
            txtValorDinheiro.Visible = retorno;

            //painel com as teclas
            pnlFinalizarPagamento2.Visible = retorno;
            pnlFinalizarPagamento1.Visible = retorno;
        }

        private void AdicionarProdutoPorCodigoBarras()
        {
            try
            {
                if (txtCodigoDeBarras.Text != string.Empty)
                {
                    bool isCadastroExiste = Buscar.BuscarEstoqueProdutoPorCodigo(txtCodigoDeBarras.Text);

                    if (isCadastroExiste == true)
                    {
                        PreenchendoGridView();

                        ValorTotal();
                    }
                    else if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Codigo de Barras Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoInserirProdutoPorCodigoBarrasTelaPDV(ex);
            }
        }

        public void ValorTotal()
        {
            valorBruto = 0;

            for (int i = 0; i < gdvPDV.RowCount; i++)
            {
                valorBruto += Convert.ToDecimal(gdvPDV.Rows[i].Cells[4].Value.ToString().Replace("R$ ", ""));
            }

            lblSubtotal.Text = string.Format("{0:C}", valorBruto);
        }

        private void PreenchendoGridView()
        {
            var rows = new List<string[]>();
            string[] row1 = new string[] { txtCodigo.Text, txtDescricao.Text, txtInserirQuant.Text,
                lblValorUnitario.Text, lblTotaldoItem.Text,txtDesconto.Text,txtCodigoDeBarras.Text,txtUnidade.Text};
            rows.Add(row1);

            foreach (string[] item in rows)
            {
                gdvPDV.Rows.Add(item);
            }
        }

        private void BuscarProdutoPorCodigoBarras()
        {
            try
            {
                if (txtCodigoDeBarras.Text != string.Empty)
                {
                    bool isCadastroExiste = Buscar.BuscarEstoqueProdutoPorCodigo(txtCodigoDeBarras.Text);

                    if (isCadastroExiste == true)
                    {
                        produto = listaDadosProduto.Find(prod => prod.codigoBarras.ToString().StartsWith(txtCodigoDeBarras.Text));

                        txtCodigo.Text = produto.codigoProduto.ToString();
                        txtDescricao.Text = produto.descricaoProduto;
                        lblDescricaoItem.Text = produto.descricaoProduto;
                        txtCodigoProduto.Text = produto.codigoProduto.ToString();
                        lblUnidade.Text = produto.unidade;
                        lblValorUnitario.Text = string.Format("{0:C}", (produto.preco - (produto.desconto * produto.preco / 100)));
                        lblTotaldoItem.Text = string.Format("{0:C}", Convert.ToDecimal(txtInserirQuant.Text) * (produto.preco - (produto.desconto * produto.preco / 100)));
                        txtUnidade.Text = produto.unidade;

                        string desconto = ((produto.desconto / 100) > 0) ? string.Format("{0:P}", produto.desconto / 100) : "Sem Desconto";

                        txtDesconto.Text = desconto;
                    }
                    else if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Codigo De Barras Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarProdutoPorCodigoBarras(ex);
            }
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            txtCPF.UseSystemPasswordChar = false;
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            txtCPF.ReadOnly = true;

            lblNomeCliente.Text = Buscar.BuscarClienteTelaPDVPorCPF(txtCPF.Text).ToUpper();

            txtCodigoDeBarras.Focus();

            txtCPF.UseSystemPasswordChar = true;
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoCPF(e, txtCPF);
            }
        }

        public void RemoverProduto()
        {
            DialogResult OpcaoDoUsuario = new DialogResult();
            OpcaoDoUsuario = MessageBox.Show("Deseja Remover O Item?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (OpcaoDoUsuario == DialogResult.Yes)
            {
                gdvPDV.Rows.RemoveAt(gdvPDV.CurrentRow.Index);

                ValorTotal();
            }
        }

        private void txtCodigoProduto_TextChange(object sender, EventArgs e)
        {
            if (txtCodigoProduto.Text != string.Empty)
            {
                BuscarProdutoPorCodigoProduto();

                pcbPDV.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodigo.Text));
            }
        }

        private void BuscarProdutoPorCodigoProduto()
        {
            try
            {
                if (txtCodigoProduto.Text != string.Empty && txtCodigoProduto.Text != "-")
                {
                    bool isCadastroExiste = Buscar.BuscarProdutoPorCodigo(Convert.ToInt32(txtCodigoProduto.Text));

                    if (isCadastroExiste == true)
                    {
                        produto = listaDadosProduto.Find(prod => prod.codigoProduto.ToString().StartsWith(txtCodigoProduto.Text));

                        txtCodigo.Text = produto.codigoProduto.ToString();
                        txtDescricao.Text = produto.descricaoProduto;
                        lblDescricaoItem.Text = produto.descricaoProduto;
                        lblUnidade.Text = produto.unidade;
                        lblValorUnitario.Text = string.Format("{0:C}", (produto.preco - (produto.desconto * produto.preco / 100)));
                        lblTotaldoItem.Text = string.Format("{0:C}", Convert.ToDecimal(txtInserirQuant.Text) * (produto.preco - (produto.desconto * produto.preco / 100)));

                        string desconto = ((produto.desconto / 100) > 0) ? string.Format("{0:P}", produto.desconto / 100) : "Sem Desconto";

                        txtDesconto.Text = desconto;
                    }
                    else if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Codigo do Produto Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarProdutoPorCodigoProduto(ex);
            }
        }

        private void txtCodigoProduto_Leave(object sender, EventArgs e)
        {
            if (cont == 0 && txtCodigoProduto.Text != "")
            {
                cont++;

                AdicionarProdutoPorCodigoProduto();

                //FormatandoParaNovaVenda();
            }
            else
            {
                txtCodigoDeBarras.Focus();

                txtCodigoProduto.ReadOnly = true;

                cont = 0;
            }
        }

        private void AdicionarProdutoPorCodigoProduto()
        {
            try
            {
                if (txtCodigoDeBarras.Text == string.Empty)
                {
                    bool isCadastroExiste = Buscar.BuscarProdutoPorCodigo(Convert.ToInt32(txtCodigoProduto.Text));

                    if (isCadastroExiste == true)
                    {
                        PreenchendoGridView();

                        ValorTotal();
                    }
                    else if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Codigo do Produto Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoInserirProdutoPorCodigoProdutoTelaPDV(ex);
            }
        }

        private void cmbFormaPagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbFormaPagamento.Text == "CARNÊ")
            {
                PagamentoCarne();
            }
            else if (cmbFormaPagamento.Text == "CRÉDITO")
            {
                PagamentoCredito();
            }
            else if (cmbFormaPagamento.Text == "DÉBITO")
            {
                PagamentoDebito();
            }
            else if (cmbFormaPagamento.Text == "DINHEIRO")
            {
                PagamentoDinheiro();
            }
            else if (cmbFormaPagamento.Text == "PIX")
            {
                PagamentoPIX();
            }
        }

        private void PagamentoCarne()
        {
            LayoutTipoPagamentoCredito(false);

            lblValorDebito.Visible = false;

            lblTituloFormaPagamento.Text = "CARNÊ";

            lblValorDesconto.Text = "R$ 0,00";
        }

        private void PagamentoCredito()
        {
            LayoutTipoPagamentoCredito(true);

            lblValorDebito.Visible = false;

            txtValorDinheiro.Visible = false;

            lblValorParcela.Text = lblSubtotal.Text;

            lblTituloFormaPagamento.Text = "CRÉDITO";

            lblValorDesconto.Text = "R$ 0,00";

            cmbParcelas.Text = "1x";

            lblValorTotal.Text = String.Format("{0:C}", valorBruto);
        }

        private void PagamentoDebito()
        {
            LayoutTipoPagamentoCredito(false);

            lblTituloFormaPagamento.Text = "DÉBITO";

            lblValorDebito.Font = new Font("Calibri", 36);

            lblValorDebito.Font = new Font("Calibri", 36, FontStyle.Bold);

            lblValorDebito.Visible = true;

            lblValorDebito.Location = new Point(90, 45);

            lblValorDebito.Text = String.Format("{0:C}", valorBruto - (valorBruto * listaDadosFinanceiro[0].descontoAvista / 100));

            PagamentoComDescontos();
        }

        private void PagamentoDinheiro()
        {
            LayoutTipoPagamentoCredito(false);

            lblTituloFormaPagamento.Text = "DINHEIRO";

            lblValorDebito.Visible = false;

            txtValorDinheiro.Visible = true;

            PagamentoComDescontos();

            //txtValorDinheiro.Focus();
        }

        private void PagamentoPIX()
        {
            lblTituloFormaPagamento.Text = "PIX";

            pcbPix.Image = Buscar.BuscarQrCodePix(1);

            lblValorDebito.Visible = true;

            pcbPix.Visible = true;

            lblValorDebito.Font = new Font("Calibri", 28, FontStyle.Bold);

            lblValorDebito.Location = new Point(40, 45);

            lblValorDebito.Text = Buscar.BuscarChavePix();

            txtValorDinheiro.Visible = false;
        }

        private void PagamentoComDescontos()
        {
            lblValorDesconto.Text = String.Format("{0:C}", (valorBruto * listaDadosFinanceiro[0].descontoAvista / 100));

            lblValorTotal.Text = String.Format("{0:C}", valorBruto - (valorBruto * listaDadosFinanceiro[0].descontoAvista / 100));
        }

        private void LayoutTipoPagamentoCredito(bool _ativa)
        {
            pcbPix.Visible = false;
            lblParcelas.Visible = _ativa;
            cmbParcelas.Visible = _ativa;
            lblTituloJuros.Visible = _ativa;
            lblValorJuros.Visible = _ativa;
            lblTituloValorParcela.Visible = _ativa;
            lblValorParcela.Visible = _ativa;
            txtValorDinheiro.Visible = _ativa;
        }

        private void cmbParcelas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbParcelas.Text.Replace("x", "")) > listaDadosFinanceiro[0].parcelasCredito)
            {
                lblValorJuros.Text = string.Format("{0:P}", (listaDadosFinanceiro[0].jurosCredito / 100));

                lblValorParcela.Text = String.Format("{0:C}", (((valorBruto * (listaDadosFinanceiro[0].jurosCredito) / 100) + valorBruto)
                    / Convert.ToDecimal(cmbParcelas.Text.Replace("x", ""))));

                lblValorTotal.Text = String.Format("{0:C}", ((valorBruto * (listaDadosFinanceiro[0].jurosCredito) / 100) + valorBruto));
            }
            else
            {
                lblValorJuros.Text = "0,0%";

                lblValorParcela.Text = String.Format("{0:C}", (valorBruto / Convert.ToDecimal(cmbParcelas.Text.Replace("x", ""))));

                lblValorTotal.Text = String.Format("{0:C}", valorBruto);
            }
        }

        private void txtValorDinheiro_TextChange(object sender, EventArgs e)
        {
            lblTotalRecebido.Text = txtValorDinheiro.Text;
            lblTroco.Text = string.Format("{0:C}", (Convert.ToDecimal(lblTotalRecebido.Text.Replace("R$", "")) - Convert.ToDecimal(lblValorTotal.Text.Replace("R$", ""))));
        }

        private void txtValorDinheiro_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoDinheiro(e, sender, txtValorDinheiro);
            }
        }

        private void txtCodigoDeBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtCodigoDeBarras_TextChange(object sender, EventArgs e)
        {
            PreencherComDadosDoProduto(sender, e);
        }

        private void PreencherComDadosDoProduto(object sender, EventArgs e)
        {
            if (cont <= 0)
            {
                BuscarProdutoPorCodigoBarras();

                AdicionarProdutoPorCodigoBarras();

                pcbPDV.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodigo.Text));

                //mudando quando iniciar uma compra
                pnlFachada.BackgroundColor = Color.Red;

                lblFachada.Text = "CAIXA OCUPADO";

                // mudando quando colocar quantidade
                lblTituloCPFQuant.Text = "CPF NA NOTA";

                txtCPF.Visible = true;

                txtInserirQuant.Visible = false;

                cont++;
            }
            else
            {
                txtCodigoDeBarras.Text = string.Empty;

                cont = 0;

                txtInserirQuant.Text = "1";
            }
        }

        private void txtCodigoDeBarras_Enter(object sender, EventArgs e)
        {
            //txtCPF.UseSystemPasswordChar = true;
        }

        private void txtInserirQuant_Leave(object sender, EventArgs e)
        {
            if (txtInserirQuant.Text == string.Empty)
            {
                txtInserirQuant.Text = "1";
            }

            txtInserirQuant.ReadOnly = true;

            txtCodigoDeBarras.Focus();
        }

        private void cmbFormaPagamento_Layout(object sender, LayoutEventArgs e)
        {
            if (cmbFormaPagamento.Text == "CRÉDITO")
            {
                cmbParcelas.Focus();
            }
            else if (cmbFormaPagamento.Text == "DINHEIRO")
            {
                txtValorDinheiro.Focus();
            }
        }

        private void txtCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtInserirQuant_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void cmbFormaPagamento_Leave(object sender, EventArgs e)
        {
            if (cmbFormaPagamento.Text == "DINHEIRO")
            {
                txtValorDinheiro.Focus();
            }
            else if (cmbFormaPagamento.Text == "CRÉDITO")
            {
                cmbParcelas.Focus();
            }
        }
    }
}