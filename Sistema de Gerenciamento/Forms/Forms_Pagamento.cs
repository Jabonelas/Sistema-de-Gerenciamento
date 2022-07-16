using Sistema_de_Gerenciamento.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_Pagamento : Form
    {
        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private List<DadosFinanceiro> listaFinanceiro = new List<DadosFinanceiro>();

        private List<DadosNotaFiscalSaida> listaDadosNotaFiscalSaidasParcial = new List<DadosNotaFiscalSaida>();

        private List<DadosNotaFiscalSaida> listaDadosNotaFiscalSaidaCompleta = new List<DadosNotaFiscalSaida>();

        private List<DadosEstoqueProduto> listaDadosEstoqueProdutos = new List<DadosEstoqueProduto>();

        private DadosEstoqueProduto dadosEstoqueProduto;

        //private DadosNotaFiscalSaida dadosNotaFiscalSaida;

        private DadosNotaFiscalSaida dadosNotaFiscalSaidaCompleta;

        private List<DadosNotaFiscalSaida> lista = new List<DadosNotaFiscalSaida>();

        public Forms_Troca telaTroca;

        private decimal valorBruto = 0;

        private int quantidadeItens = 0;

        public Forms_Pagamento(decimal _valorBruto, int _notaFiscal, List<DadosNotaFiscalSaida> _lista, int _quantidadeItens, Forms_Troca _telaTroca)
        {
            InitializeComponent();

            lista = _lista;

            quantidadeItens = _quantidadeItens;

            telaTroca = _telaTroca;

            listaFinanceiro = Buscar.BuscarListaFinanceiro();

            listaDadosNotaFiscalSaidasParcial = Buscar.BuscarListaNotaFiscalSaidaParcial(_notaFiscal);

            listaDadosNotaFiscalSaidaCompleta = Buscar.BuscarListaNotaFiscalSaidaCompleto(_notaFiscal);

            //listaDadosNotaFiscalSaidasParcial = Buscar.BuscarListaNotaFiscalSaidaParcial(Convert.ToInt32(lblNumeroNotaFiscalSaida.Text));

            valorBruto = _valorBruto;

            lblNumeroNotaFiscalSaida.Text = _notaFiscal.ToString();

            lblValorTotal.Text = string.Format("{0:C}", valorBruto);

            cmbFormaPagamento.SelectedIndex = 0;

            PreencherGrid();

            cmbParcelas.SelectedIndex = 0;

            cmbFormaPagamento.Focus();
        }

        private void PreencherGrid()
        {
            foreach (DadosNotaFiscalSaida item in lista)
            {
                var rows = new List<string[]>();
                string[] row1 = new string[] {item.codigoProduto.ToString(),item.descricao,item.quantidade.ToString("N0"),
                            string.Format("{0:C}",item.valorPago),item.status };
                //rows.Add(row1);

                gdvPagamento.Rows.Add(row1);

                //foreach (string[] items in rows)
                //{
                //    gdvDevolucaoTroca.Rows.Add(items);
                //}
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

            lblValorTotal.Text = string.Format("{0:C}", valorBruto);

            cmbParcelas.SelectedIndex = 0;

            //lblValorParcela.Text = lblSubtotal.Text;

            lblTituloFormaPagamento.Text = "CRÉDITO";

            lblValorDesconto.Text = "R$ 0,00";

            ///////
            pnlTroco.Visible = false;

            pnlTotalRecebido.Visible = false;

            pnlQRCode.Visible = false;

            pnlChavePix.Visible = false;

            //cmbFormaPagamento.SelectedIndex = 0;

            //lblValorTotal.Text = String.Format("{0:C}", valorBruto);
        }

        private void PagamentoDebito()
        {
            LayoutTipoPagamentoCredito(false);

            lblTituloFormaPagamento.Text = "DÉBITO";

            //lblValorDebito.Font = new Font("Calibri", 36);

            //lblValorDebito.Font = new Font("Calibri", 36, FontStyle.Bold);

            //lblValorDebito.Location = new Point(90, 45);

            ///////

            pnlTroco.Visible = false;

            pnlTotalRecebido.Visible = false;

            pnlQRCode.Visible = false;

            pnlChavePix.Visible = false;

            lblValorDebito.Text = lblValorTotal.Text;

            PagamentoComDescontos();

            lblValorDebito.Visible = true;

            lblValorDebito.Text = lblValorTotal.Text;
            //lblValorTotal.Text = String.Format("{0:C}", valorBruto - (valorBruto * listaDadosFinanceiro[0].descontoAvista / 100));

            //lblValorDebito.Text = String.Format("{0:C}", valorBruto - (valorBruto * listaDadosFinanceiro[0].descontoAvista / 100));

            //lblValorDesconto.Text = String.Format("{0:C}", (valorBruto * listaDadosFinanceiro[0].descontoAvista / 100));
        }

        private void PagamentoDinheiro()
        {
            LayoutTipoPagamentoCredito(false);

            lblTituloFormaPagamento.Text = "DINHEIRO";

            lblValorDebito.Visible = false;

            txtValorDinheiro.Visible = true;

            ///////
            pnlTroco.Visible = true;

            pnlTotalRecebido.Visible = true;

            pnlQRCode.Visible = false;

            pnlChavePix.Visible = false;

            PagamentoComDescontos();
        }

        private void PagamentoPIX()
        {
            lblTituloFormaPagamento.Text = "PIX";

            LayoutTipoPagamentoCredito(false);

            //pcbPix.Image = Buscar.BuscarQrCodePix(1);

            lblValorDebito.Visible = true;

            //lblValorDebito.Font = new Font("Calibri", 28, FontStyle.Bold);

            //lblValorDebito.Location = new Point(40, 45);

            //lblValorDebito.Text = Buscar.BuscarChavePix();

            txtValorDinheiro.Visible = false;

            ///////
            ///

            pnlTroco.Visible = false;

            pnlTotalRecebido.Visible = false;

            pnlQRCode.Visible = true;

            pnlQRCode.BackgroundImage = Buscar.BuscarQrCodePix(1);

            pnlChavePix.Visible = true;

            lblChavePix.Text = Buscar.BuscarChavePix();

            PagamentoComDescontos();

            lblValorDebito.Text = lblValorTotal.Text;

            //pcbPix.Visible = true;

            //lblValorDesconto.Text = String.Format("{0:C}", (valorBruto * listaDadosFinanceiro[0].descontoAvista / 100));

            //lblValorTotal.Text = String.Format("{0:C}", valorBruto - (valorBruto * listaDadosFinanceiro[0].descontoAvista / 100));
        }

        private void PagamentoComDescontos()
        {
            lblValorDesconto.Text = String.Format("{0:C}", (valorBruto * listaFinanceiro[0].descontoAvista / 100));

            lblValorTotal.Text = String.Format("{0:C}", valorBruto - (valorBruto * listaFinanceiro[0].descontoAvista / 100));
        }

        private void LayoutTipoPagamentoCredito(bool _ativa)
        {
            //pcbPix.Visible = false;
            lblParcelas.Visible = _ativa;
            cmbParcelas.Visible = _ativa;
            lblTituloJuros.Visible = _ativa;
            lblValorJuros.Visible = _ativa;
            lblTituloValorParcela.Visible = _ativa;
            lblValorParcela.Visible = _ativa;
            txtValorDinheiro.Visible = _ativa;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Forms_Pagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Esc para finalizar
            {
                this.Close();
            }
        }

        private void cmbParcelas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbParcelas.Text.Replace("x", "")) >= listaFinanceiro[0].parcelasCredito)
            {
                lblValorJuros.Text = string.Format("{0:P}", listaFinanceiro[0].jurosCredito / 100);

                lblValorTotal.Text = string.Format("{0:C}", listaFinanceiro[0].jurosCredito * valorBruto / 100 + valorBruto);

                lblValorParcela.Text = String.Format("{0:C}", Convert.ToDecimal(lblValorTotal.Text.Replace("R$", "")) / Convert.ToDecimal(cmbParcelas.Text.Replace("x", "")));
            }
            else
            {
                lblValorTotal.Text = string.Format("{0:C}", valorBruto);

                lblValorParcela.Text = String.Format("{0:C}", Convert.ToDecimal(lblValorTotal.Text.Replace("R$", "")) / Convert.ToDecimal(cmbParcelas.Text.Replace("x", "")));

                lblValorJuros.Text = "0,00%";
            }
        }

        private void txtValorDinheiro_TextChange(object sender, EventArgs e)
        {
            lblTotalRecebido.Text = txtValorDinheiro.Text;
            try
            {
                lblTroco.Text = String.Format("{0:C}", (Convert.ToDecimal(txtValorDinheiro.Text.Replace("R$", "")) - Convert.ToDecimal(lblValorTotal.Text.Replace("R$", ""))));
            }
            catch (Exception)
            {
            }
        }

        private void txtValorDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoDinheiro(e, sender, txtValorDinheiro);
            }
        }

        private void Forms_Pagamento_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            dadosNotaFiscalSaidaCompleta = listaDadosNotaFiscalSaidaCompleta.Find(x => x.numeroNF.ToString().StartsWith(lblNumeroNotaFiscalSaida.Text));

            //MessageBox.Show($"{quantidadeItens}");
            //MessageBox.Show($"{gdvPagamento.Rows.Count}");
            //MessageBox.Show($"{lista[i].descricao}");

            decimal valorDesconto = Convert.ToDecimal(lblValorDesconto.Text.Replace("R$", "")) / (gdvPagamento.Rows.Count - quantidadeItens);
            decimal jurosPorProduto;

            if (lblValorJuros.Text != "0,00%")
            {
                jurosPorProduto = (Convert.ToDecimal(lblValorTotal.Text.Replace("R$", ""))) - valorBruto / (gdvPagamento.Rows.Count - quantidadeItens);
            }
            else
            {
                jurosPorProduto = 0;
            }

            for (int i = quantidadeItens; i < gdvPagamento.Rows.Count; i++)
            {
                try
                {
                    Salvar.NotaFiscalSaida(lista[i].cpf, lista[i].numeroNF, lista[i].codigoProduto, lista[i].descricao,
                        lista[i].quantidade, lista[i].valorUnitario, lista[i].emissao, lista[i].codigoBarras, lista[i].vendedor,
                        lista[i].validadeTroca, lista[i].nomeCliente, cmbFormaPagamento.Text, valorDesconto,
                        Convert.ToInt32(cmbParcelas.Text.Replace("x", "")),
                        jurosPorProduto, (lista[i].valorPago - valorDesconto), lista[i].unidade, lista[i].status, Global.NomeDeUsuario,
                        telaTroca.cmbMotivoTroca.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }

            //Salvar.NotaFiscalSaida(dadosNotaFiscalSaidaCompleta.cpf, dadosNotaFiscalSaidaCompleta.numeroNF,
            //    "codigo do produto", dadosNotaFiscalSaidaCompleta.descricao,
            //    dadosNotaFiscalSaidaCompleta.quantidade, dadosNotaFiscalSaidaCompleta.valorUnitario,
            //    dadosNotaFiscalSaidaCompleta.emissao, "codigo de barras", dadosNotaFiscalSaidaCompleta.vendedor,
            //    dadosNotaFiscalSaidaCompleta.validadeTroca, dadosNotaFiscalSaidaCompleta.nomeCliente,
            //    dadosNotaFiscalSaidaCompleta.tipoPagamento, dadosNotaFiscalSaidaCompleta.valorDesconto,
            //    dadosNotaFiscalSaidaCompleta.quantidadeParcelas, dadosNotaFiscalSaidaCompleta.valorJuros,
            //    dadosNotaFiscalSaidaCompleta.valorPago, dadosNotaFiscalSaidaCompleta.unidade, dadosNotaFiscalSaidaCompleta.status,
            //    Global.NomeDeUsuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal valorDesconto = Convert.ToDecimal(lblValorDesconto.Text.Replace("R$", "")) / (gdvPagamento.Rows.Count - quantidadeItens);
            decimal jurosPorProduto;

            if (lblValorJuros.Text != "0,00%")
            {
                jurosPorProduto = ((Convert.ToDecimal(lblValorTotal.Text.Replace("R$", ""))) - valorBruto) / (gdvPagamento.Rows.Count - quantidadeItens);
            }
            else
            {
                jurosPorProduto = 0;
            }

            foreach (DadosNotaFiscalSaida item in lista)
            {
                //if (item.valorPago == )
                //{
                // Item Mantido
                if (item.status == "-")
                {
                    Atualizar.AtualizarQuantidadePosTroca(item.quantidade, item.valorPago, item.numeroNF, item.codigoBarras,
                        item.status, item.trocarVendedor, "-");
                }

                //Item Trocado
                else if (item.status == "Troca")
                {
                    Atualizar.AtualizarQuantidadePosTroca(item.quantidade, item.valorPago, item.numeroNF, item.codigoBarras,
                        item.status, item.trocarVendedor, telaTroca.cmbMotivoTroca.Text);

                    Atualizar.AtualizarQuantidadeEstoquePosDevolucao(-item.quantidade, item.codigoBarras);

                    Salvar.NotaFiscalSaida(item.cpf, item.numeroNF, item.codigoProduto, item.descricao,
                  item.quantidade, item.valorUnitario, item.emissao, item.codigoBarras, item.vendedor,
                  item.validadeTroca, item.nomeCliente, cmbFormaPagamento.Text, valorDesconto,
                  Convert.ToInt32(cmbParcelas.Text.Replace("x", "")),
                  jurosPorProduto, (item.valorPago - valorDesconto), item.unidade, item.status, Global.NomeDeUsuario,
                  telaTroca.cmbMotivoTroca.Text);
                }

                // Item Devolvido
                else if (item.valorPago < 0)
                {
                    if (item.motivoTroca == "-")
                    {
                        Atualizar.AtualizarQuantidadeEstoquePosDevolucao(-item.quantidade, item.codigoBarras);

                        Atualizar.AtualizarQuantidadePosTroca(item.quantidade, item.valorPago, item.numeroNF, item.codigoBarras,
                        item.status, item.trocarVendedor, telaTroca.cmbMotivoTroca.Text);
                    }
                    else
                    {
                        if (telaTroca.cmbMotivoTroca.Text == "Cor/Tamanho")
                        {
                            Atualizar.AtualizarQuantidadeEstoquePosDevolucao(-item.quantidade, item.codigoBarras);

                            MessageBox.Show("entrou na devolução normal");
                        }
                        else
                        {
                            MessageBox.Show("entrou na devolução que colocar no segregado");

                            listaDadosEstoqueProdutos = Buscar.BuscarListaEstoqueProdutoPorCodigoBarras(item.codigoBarras);

                            dadosEstoqueProduto = listaDadosEstoqueProdutos.First(x => x.codigoBarras == item.codigoBarras);

                            Salvar.AdcionarNoEstoqueMaterialSegregado(dadosEstoqueProduto.numeroNF, dadosEstoqueProduto.codigoBarras,
                                dadosEstoqueProduto.codigoProduto, dadosEstoqueProduto.descricaoProduto, item.quantidade, dadosEstoqueProduto.unidade,
                                dadosEstoqueProduto.valorUnitario, dadosEstoqueProduto.dataEntrada, dadosEstoqueProduto.descontoItem, telaTroca.cmbMotivoTroca.Text);
                        }

                        Salvar.NotaFiscalSaida(item.cpf, item.numeroNF, item.codigoProduto, item.descricao,
                        item.quantidade, item.valorUnitario, item.emissao, item.codigoBarras, item.vendedor,
                        item.validadeTroca, item.nomeCliente, cmbFormaPagamento.Text, valorDesconto,
                        Convert.ToInt32(cmbParcelas.Text.Replace("x", "")),
                        jurosPorProduto, (item.valorPago - valorDesconto), item.unidade, item.status, Global.NomeDeUsuario,
                        telaTroca.cmbMotivoTroca.Text);
                    }
                }
                //}
            }
        }
    }
}