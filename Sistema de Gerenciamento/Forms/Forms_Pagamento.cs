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

        private List<DadosEstoqueProduto> listaDadosEstoqueProdutos = new List<DadosEstoqueProduto>();

        public List<DadosNotaFiscalSaida> listaDadosNotaFiscalSaidaCompleta = new List<DadosNotaFiscalSaida>();

        private DadosEstoqueProduto dadosEstoqueProduto;

        private Forms_Troca telaTroca;

        private Forms_Venda telaVenda;

        private DadosNotaFiscalSaida dadosNotaFiscalSaida;

        public decimal valorBruto = 0;

        private int quantidadeItens = 0;

        private string tipoPagamento = "";

        public Forms_Pagamento(Forms_Troca _telaTroca, string _tipoPagamento)
        {
            InitializeComponent();

            telaTroca = _telaTroca;

            lblNumeroNotaFiscalSaida.Visible = true;

            PreencherDados(telaTroca.listaDadosNotaFiscalSaidaCompleta, _telaTroca.quantidadeItens,
            Convert.ToDecimal(_telaTroca.lblValorAPagar.Text.Replace("R$ ", "")), _tipoPagamento);

            lblNumeroNotaFiscalSaida.Text = telaTroca.txtNotaFiscal.Text;

            PreencherGrid();

            cmbFormaPagamento.Focus();
        }

        public Forms_Pagamento(Forms_Venda _telaVenda, string _tipoPagamento)
        {
            InitializeComponent();

            tipoPagamento = _tipoPagamento;

            lblNumeroNotaFiscalSaida.Visible = false;

            PreencherDados(_telaVenda.listaDadosNotaFiscalSaidaCompleta, _telaVenda.quantidadeItens,
                Convert.ToDecimal(_telaVenda.lblValorTotal.Text.Replace("R$ ", "")), _tipoPagamento);

            PreencherGrid();

            cmbFormaPagamento.Focus();
        }

        private void PreencherDados(List<DadosNotaFiscalSaida> _listaDadosNotaFiscalSaidaCompleta, int _quantidadeItem,
            decimal _valoAPagar, string _tipoPagamento)
        {
            quantidadeItens = _quantidadeItem;

            tipoPagamento = _tipoPagamento;

            listaFinanceiro = Buscar.BuscarListaDadosFinanceiro();

            valorBruto = _valoAPagar;

            lblValorTotal.Text = string.Format("{0:C}", valorBruto);

            cmbFormaPagamento.SelectedIndex = 0;

            cmbParcelas.SelectedIndex = 0;

            listaDadosNotaFiscalSaidaCompleta = _listaDadosNotaFiscalSaidaCompleta;
        }

        private void PreencherGrid()
        {
            foreach (DadosNotaFiscalSaida item in listaDadosNotaFiscalSaidaCompleta)
            {
                var rows = new List<string[]>();
                string[] row1 = new string[] {item.codigoProduto.ToString(),item.descricao,item.quantidade.ToString("N0"),
                            string.Format("{0:C}",item.valorPago),item.status };

                gdvPagamento.Rows.Add(row1);
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
            LayoutTipoPagamentoCredito(true);
            lblValorDebito.Visible = false;
            txtValorDinheiro.Visible = false;
            lblValorTotal.Text = string.Format("{0:C}", valorBruto);
            cmbParcelas.SelectedIndex = 0;
            lblTituloFormaPagamento.Text = "CARNÊ";
            lblValorDesconto.Text = "R$ 0,00";
            pnlTroco.Visible = false;
            pnlTotalRecebido.Visible = false;
            pnlQRCode.Visible = false;
            pnlChavePix.Visible = false;
        }

        private void PagamentoCredito()
        {
            LayoutTipoPagamentoCredito(true);
            lblValorDebito.Visible = false;
            txtValorDinheiro.Visible = false;
            lblValorTotal.Text = string.Format("{0:C}", valorBruto);
            cmbParcelas.SelectedIndex = 0;
            lblTituloFormaPagamento.Text = "CRÉDITO";
            lblValorDesconto.Text = "R$ 0,00";
            pnlTroco.Visible = false;
            pnlTotalRecebido.Visible = false;
            pnlQRCode.Visible = false;
            pnlChavePix.Visible = false;
        }

        private void PagamentoDebito()
        {
            LayoutTipoPagamentoCredito(false);
            lblTituloFormaPagamento.Text = "DÉBITO";
            pnlTroco.Visible = false;
            pnlTotalRecebido.Visible = false;
            pnlQRCode.Visible = false;
            pnlChavePix.Visible = false;
            lblValorDebito.Text = lblValorTotal.Text;
            PagamentoComDescontos();
            lblValorDebito.Visible = true;
            lblValorDebito.Text = lblValorTotal.Text;
        }

        private void PagamentoDinheiro()
        {
            LayoutTipoPagamentoCredito(false);
            lblTituloFormaPagamento.Text = "DINHEIRO";
            lblValorDebito.Visible = false;
            txtValorDinheiro.Visible = true;
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
            lblValorDebito.Visible = true;
            txtValorDinheiro.Visible = false;
            pnlTroco.Visible = false;
            pnlTotalRecebido.Visible = false;
            pnlQRCode.Visible = true;
            pnlQRCode.BackgroundImage = Buscar.BuscarQrCodePix(1);
            pnlChavePix.Visible = true;
            lblChavePix.Text = Buscar.BuscarChavePix();
            PagamentoComDescontos();
            lblValorDebito.Text = lblValorTotal.Text;
        }

        private void PagamentoComDescontos()
        {
            lblValorDesconto.Text = String.Format("{0:C}", (valorBruto * listaFinanceiro[0].descontoAvista / 100));
            lblValorTotal.Text = String.Format("{0:C}", valorBruto - (valorBruto * listaFinanceiro[0].descontoAvista / 100));
        }

        private void LayoutTipoPagamentoCredito(bool _ativa)
        {
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
            if (cmbFormaPagamento.Text == "CRÉDITO")
            {
                SelecionadoCredito();
            }
            else
            {
                SelecionadoCarne();
            }
        }

        private void SelecionadoCredito()
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

        private void SelecionadoCarne()
        {
            if (Convert.ToInt32(cmbParcelas.Text.Replace("x", "")) >= listaFinanceiro[0].parcelasCredito)
            {
                lblValorJuros.Text = string.Format("{0:P}", listaFinanceiro[0].jurosCarne / 100);
                lblValorTotal.Text = string.Format("{0:C}", listaFinanceiro[0].jurosCarne * valorBruto / 100 + valorBruto);
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (tipoPagamento == "Troca")
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
                foreach (DadosNotaFiscalSaida item in listaDadosNotaFiscalSaidaCompleta)
                {
                    if (item.deveRealizarTrocar == true)
                    {
                        // Item Mantido
                        if (item.status == "Status Venda")
                        {
                            Atualizar.AtualizarQuantidadePosTrocaNotaFiscalSaida(item.quantidade, item.valorPago, item.numeroNF, item.codigoBarras,
                            item.status, item.trocarVendedor, "-", item.id, item.nfEntrada);
                        }

                        //Item Trocado
                        else if (item.status == "Troca" && item.motivoTroca == "Motivo Troca")
                        {
                            Atualizar.AtualizarQuantidadeEstoquePosDevolucao(-item.quantidade, item.codigoBarras, item.nfEntrada);

                            //Inserir o novo item na nota
                            Salvar.NotaFiscalSaida(item.cpf, item.numeroNF, item.codigoProduto, item.descricao,
                            item.quantidade, item.valorUnitario, item.emissao, item.codigoBarras, item.vendedor,
                            item.validadeTroca, item.nomeCliente, cmbFormaPagamento.Text, valorDesconto,
                            Convert.ToInt32(cmbParcelas.Text.Replace("x", "")),
                            jurosPorProduto, (item.valorPago - valorDesconto), item.unidade, item.status, Global.NomeDeUsuario,
                            telaTroca.cmbMotivoTroca.Text, item.nfEntrada);
                        }

                        // Item Devolvido
                        else if (item.valorPago < 0 && item.status == "Devolucao")
                        {
                            //Devolução quando a quantidade Devolvida é igual a quantidade em nota
                            if (item.quantidadeParcelas > 0 && telaTroca.cmbMotivoTroca.Text == "Cor/Tamanho")
                            {
                                Atualizar.AtualizarQuantidadeEstoquePosDevolucao(-item.quantidade, item.codigoBarras, item.nfEntrada);

                                Atualizar.AtualizarQuantidadePosTrocaNotaFiscalSaida(item.quantidade, item.valorPago, item.numeroNF, item.codigoBarras,
                                item.status, item.trocarVendedor, telaTroca.cmbMotivoTroca.Text, item.id, item.nfEntrada);
                            }
                            else if (telaTroca.cmbMotivoTroca.Text == "Cor/Tamanho")
                            {
                                Atualizar.AtualizarQuantidadeEstoquePosDevolucao(-item.quantidade, item.codigoBarras, item.nfEntrada);

                                //Devolução quando a quantidade devolvida é diferente da quantidade em nota
                                Salvar.NotaFiscalSaida(item.cpf, item.numeroNF, item.codigoProduto, item.descricao,
                                item.quantidade, item.valorUnitario, item.emissao, item.codigoBarras, item.vendedor,
                                item.validadeTroca, item.nomeCliente, cmbFormaPagamento.Text, valorDesconto,
                                Convert.ToInt32(cmbParcelas.Text.Replace("x", "")),
                                jurosPorProduto, (item.valorPago - valorDesconto), item.unidade, item.status, Global.NomeDeUsuario,
                                telaTroca.cmbMotivoTroca.Text, item.nfEntrada);
                            }
                            else if (item.quantidadeParcelas > 0 && telaTroca.cmbMotivoTroca.Text == "Produto Com Danificado/Defeito")
                            {
                                //Atualizar.AtualizarQuantidadeEstoquePosDevolucao(-item.quantidade, item.codigoBarras, item.nfEntrada);

                                Atualizar.AtualizarQuantidadePosTrocaNotaFiscalSaida(item.quantidade, item.valorPago, item.numeroNF, item.codigoBarras,
                              item.status, item.trocarVendedor, telaTroca.cmbMotivoTroca.Text, item.id, item.nfEntrada);

                                //Devolução Danificado/Defeito
                                listaDadosEstoqueProdutos = Buscar.BuscarListaEstoqueProdutoPorCodigoBarras(item.codigoBarras);

                                dadosEstoqueProduto = listaDadosEstoqueProdutos.First(x => x.codigoBarras == item.codigoBarras);

                                Salvar.AdcionarNoEstoqueMaterialSegregado(dadosEstoqueProduto.numeroNF, dadosEstoqueProduto.codigoBarras,
                                dadosEstoqueProduto.codigoProduto, dadosEstoqueProduto.descricaoProduto, item.quantidade, dadosEstoqueProduto.unidade,
                                dadosEstoqueProduto.valorUnitario, dadosEstoqueProduto.dataEntrada, dadosEstoqueProduto.descontoItem, telaTroca.cmbMotivoTroca.Text);
                            }
                            else
                            {
                                //Devolução Danificado/Defeito
                                listaDadosEstoqueProdutos = Buscar.BuscarListaEstoqueProdutoPorCodigoBarras(item.codigoBarras);

                                dadosEstoqueProduto = listaDadosEstoqueProdutos.First(x => x.codigoBarras == item.codigoBarras);

                                Salvar.AdcionarNoEstoqueMaterialSegregado(dadosEstoqueProduto.numeroNF, dadosEstoqueProduto.codigoBarras,
                                dadosEstoqueProduto.codigoProduto, dadosEstoqueProduto.descricaoProduto, item.quantidade, dadosEstoqueProduto.unidade,
                                dadosEstoqueProduto.valorUnitario, dadosEstoqueProduto.dataEntrada, dadosEstoqueProduto.descontoItem, telaTroca.cmbMotivoTroca.Text);
                            }
                        }
                    }
                }

                Atualizar.AtuazliarPrazoGarantia(listaDadosNotaFiscalSaidaCompleta[0].numeroNF,
                    listaDadosNotaFiscalSaidaCompleta[0].validadeTroca.AddDays(30));

                AvisoCantoInferiorDireito.Confirmacao();
            }
            //Venda
            else
            {
                lblDescricaoItem.Text = "Nº NOTA FISCAL:";

                int numeroNFSaida = Buscar.BuscarNumeroNotaFiscalSaida();

                lblNumeroNotaFiscalSaida.Text = numeroNFSaida.ToString();

                lblNumeroNotaFiscalSaida.Visible = true;

                if (cmbFormaPagamento.Text != "CARNÊ")
                {
                    foreach (DadosNotaFiscalSaida item in listaDadosNotaFiscalSaidaCompleta)
                    {
                        if (cmbFormaPagamento.Text == "DÉBITO" || cmbFormaPagamento.Text == "DINHEIRO" || cmbFormaPagamento.Text == "PIX")
                        {
                            //Pagamento com desconto
                            Salvar.NotaFiscalSaida(item.cpf, numeroNFSaida, item.codigoProduto,
                               item.descricao, item.quantidade, item.valorUnitario - (item.valorUnitario * listaFinanceiro[0].descontoAvista / 100),
                               DateTime.Now, item.codigoBarras, item.vendedor, item.validadeTroca, item.nomeCliente,
                               cmbFormaPagamento.Text, item.valorUnitario * listaFinanceiro[0].descontoAvista / 100,
                               Convert.ToInt32(cmbParcelas.Text.Replace("x", "")), item.valorJuros,
                               item.valorUnitario - (item.valorUnitario * listaFinanceiro[0].descontoAvista / 100), item.unidade,
                               item.status, item.trocarVendedor, item.motivoTroca, item.nfEntrada);

                            Atualizar.AtualizarQuantidadeEstoquePosVenda(item.quantidade, item.codigoBarras, item.numeroNF);
                        }
                        else if (lblValorJuros.Text == "0,00%")
                        {
                            //Pagamento normal
                            Salvar.NotaFiscalSaida(item.cpf, numeroNFSaida, item.codigoProduto,
                                item.descricao, item.quantidade, item.valorUnitario, DateTime.Now, item.codigoBarras, item.vendedor,
                                item.validadeTroca, item.nomeCliente, cmbFormaPagamento.Text, item.valorDesconto,
                                Convert.ToInt32(cmbParcelas.Text.Replace("x", "")), item.valorJuros, item.valorPago, item.unidade,
                                item.status, item.trocarVendedor, item.motivoTroca, item.nfEntrada);

                            Atualizar.AtualizarQuantidadeEstoquePosVenda(item.quantidade, item.codigoBarras, item.numeroNF);
                        }
                        else if (lblValorJuros.Text != "0,00%")
                        {
                            //Pagamento com Juros
                            Salvar.NotaFiscalSaida(item.cpf, numeroNFSaida, item.codigoProduto,
                            item.descricao, item.quantidade, item.valorUnitario + (item.valorUnitario * listaFinanceiro[0].jurosCredito / 100),
                            DateTime.Now, item.codigoBarras, item.vendedor, item.validadeTroca, item.nomeCliente, cmbFormaPagamento.Text,
                            item.valorDesconto, Convert.ToInt32(cmbParcelas.Text.Replace("x", "")),
                            (item.valorUnitario * listaFinanceiro[0].jurosCredito / 100),
                            item.valorUnitario + (item.valorUnitario * listaFinanceiro[0].jurosCredito / 100), item.unidade, item.status,
                            item.trocarVendedor, item.motivoTroca, item.nfEntrada);

                            Atualizar.AtualizarQuantidadeEstoquePosVenda(item.quantidade, item.codigoBarras, item.numeroNF);
                        }
                    }

                    AvisoCantoInferiorDireito.Confirmacao();
                }
                else
                {
                    int quantidadeParcelas = Convert.ToInt32(cmbParcelas.Text.Replace("x", "")) - 1;

                    Forms_GerarCarne gerarCarne = new Forms_GerarCarne(listaDadosNotaFiscalSaidaCompleta, valorBruto, quantidadeParcelas);
                    gerarCarne.ShowDialog();
                }
            }
            btnConfirmar.Enabled = false;
        }

        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}