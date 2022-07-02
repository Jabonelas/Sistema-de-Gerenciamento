﻿using System;
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
    public partial class Forms_TelaPDV : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private List<DadosProduto> listaProduto = new List<DadosProduto>();

        private List<DadosFinanceiro> listaFinanceiro = new List<DadosFinanceiro>();

        private DadosProduto produto;

        //private DadosFinanceiro financeiro;

        private decimal valorBruto = 0;

        private int cont = 0;

        //private string verificar;

        public Forms_TelaPDV()
        {
            InitializeComponent();

            listaProduto = Buscar.BuscarProdutos();

            listaFinanceiro = Buscar.BuscarFinanceiro();

            //this.Height = Screen.PrimaryScreen.Bounds.Height;

            //this.Width = Screen.PrimaryScreen.Bounds.Width;

            //this.TopMost = true;
        }

        private void Forms_TelaPDV_Load(object sender, EventArgs e)
        {
            txtCodigoDeBarras.Focus();
        }

        private void Forms_TelaPDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Finalziar tela Esc
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F1) // nova venda F1
            {
                //if (gdvPDV.Rows.Count <= 0)
                //{
                gdvPDV.Rows.Clear();

                pcbPDV.Image = Image.FromFile(@"C:\Users\israe\source\repos\Sistema de Gerenciamento\Sistema de Gerenciamento\Resources\png-transparent-logo-pharmacy-pills-miscellaneous-trademark-pharmaceutical-drug.png");

                lblSubtotal.Text = "R$ 0,00";
                lblTroco.Text = "R$ 0,00";
                lblTotalRecebido.Text = "R$ 0,00";
                txtCPF.Text = "-";
                txtCodigoProduto.Text = "-";
                lblTotaldoItem.Text = "R$ 0,00";
                lblValorUnitario.Text = "R$ 0,00";
                pnlFachada.BackgroundColor = Color.Lime;

                lblFachada.Location = new Point(97, -9);
                lblFachada.Text = "CAIXA DISPONÍVEL";

                txtCPF.UseSystemPasswordChar = false;

                FormatoTelaPagamento("Cancelamento");

                txtCodigoDeBarras.Focus();

                lblDescricaoItem.Text = "DESCRIÇÃO DO ITEM";
                lblUnidade.Text = "UN";
                //}
            }

            if (e.KeyCode == Keys.F2) // excluir item F2
            {
                if (gdvPDV.Rows.Count > 0)
                {
                    if (Global.tipoDeUsuario == "ADMIN")
                    {
                        RemoverProduto();
                    }
                    else
                    {
                        Forms_ControleADMIN controleADMIN = new Forms_ControleADMIN(this);
                        controleADMIN.ShowDialog();
                    }
                }
            }

            if (e.KeyCode == Keys.F3) // inserir cpf F3
            {
                txtCPF.Text = string.Empty;

                txtCPF.ReadOnly = true;
                txtCPF.Enabled = true;
                txtCPF.Focus();
            }

            if (e.KeyCode == Keys.F4) // Buscar Por Codigo F4
            {
                txtCodigoProduto.Enabled = true;
                txtCodigoProduto.Visible = true;
                txtCodigoProduto.Text = String.Empty;
                txtCodigoProduto.Focus();

                //txtCodigoProduto.Visible = true;
            }

            if (e.KeyCode == Keys.F6) // inserir quantidade F6
            {
                lblTituloCPFQuant.Text = "QUANTIDADE";

                txtCPF.Visible = false;

                txtInserirQuant.Visible = true;
                txtInserirQuant.Enabled = true;
                txtInserirQuant.Focus();
            }

            if (e.KeyCode == Keys.F7) // Finalizar Compra F7
            {
                //if (gdvPDV.Rows.Count >= 0)
                //{
                FormatoTelaPagamento("Pagamento");

                //depois ve se ainda esta bugado
                txtValorDinheiro.Visible = false;
                lblTituloValorParcela.Visible = false;

                cmbFormaPagamento.Focus();
                lblDescricaoItem.Text = "PAGAMENTO";
                lblUnidade.Text = string.Empty;
                //}
            }
        }

        private void FormatoTelaPagamento(string _verificar)
        {
            bool retorno = (_verificar == "Pagamento") ? retorno = true : retorno = false;

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
            pnlpagamento2.Visible = retorno;
            pnlPagamento3.Visible = retorno;
        }

        private void txtcodigoBarras(object sender, EventArgs e)
        {
            if (cont <= 0)
            {
                BuscarProdutoPorCodigoBarras();

                AdicionarProdutoPorCodigoBarras();

                SetarDesignColunaGridView();

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

                        //ApagandoTextbox();
                    }
                    else if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Codigo de Barras Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoInserirProdutoTelaPDV(ex);
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
                lblValorUnitario.Text, lblTotaldoItem.Text,txtDesconto.Text};
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
                        produto = listaProduto.Find(prod => prod.codigoBarras.ToString().StartsWith(txtCodigoDeBarras.Text));

                        txtCodigo.Text = produto.codigoProduto.ToString();
                        txtDescricao.Text = produto.descricaoProduto;
                        lblDescricaoItem.Text = produto.descricaoProduto;
                        txtCodigoProduto.Text = produto.codigoProduto.ToString();
                        lblUnidade.Text = produto.unidade;
                        lblValorUnitario.Text = string.Format("{0:C}", (produto.preco - (produto.desconto * produto.preco / 100)));
                        lblTotaldoItem.Text = string.Format("{0:C}", Convert.ToDecimal(txtInserirQuant.Text) * (produto.preco - (produto.desconto * produto.preco / 100)));

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

        private void SetarDesignColunaGridView()
        {
            this.gdvPDV.Columns["Total"].DefaultCellStyle.Format = "c";
            this.gdvPDV.Columns["VlrUnit"].DefaultCellStyle.Format = "c";
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            txtCPF.UseSystemPasswordChar = false;
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            //txtCPF.UseSystemPasswordChar = true;

            txtCPF.ReadOnly = true;

            lblNomeCliente.Text = Buscar.BuscarClienteTelaPDVPorCPF(txtCPF.Text).ToUpper();

            txtCodigoDeBarras.Focus();
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
            //if (gdvPDV.RowCount > 0)
            //{
            DialogResult OpcaoDoUsuario = new DialogResult();
            OpcaoDoUsuario = MessageBox.Show("Deseja Remover O Item?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (OpcaoDoUsuario == DialogResult.Yes)
            {
                //_gridView.Rows.RemoveAt(_gridView.CurrentRow.Index);

                gdvPDV.Rows.RemoveAt(gdvPDV.CurrentRow.Index);

                ValorTotal();

                //ApagandoTextbox();
            }
            //}
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
                        produto = listaProduto.Find(prod => prod.codigoProduto.ToString().StartsWith(txtCodigoProduto.Text));

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
            if (cont == 0)
            {
                AdicionarProdutoPorCodigoProduto();

                SetarDesignColunaGridView();

                cont++;
            }
            else
            {
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

                        //ApagandoTextbox();
                    }
                    else if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Codigo do Produto Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoInserirProdutoTelaPDV(ex);
            }
        }

        private void pnlDinheiro_Click(object sender, EventArgs e)
        {
        }

        private void bunifuPanel7_Click(object sender, EventArgs e)
        {
        }

        private void txtCodigoProduto_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtInserirQuant_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbFormaPagamento_Leave(object sender, EventArgs e)
        {
        }

        private void cmbFormaPagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbFormaPagamento.Text == "CARNÊ")
            {
                LayoutTipoPagamentoCredito(false);

                lblValorDebito.Visible = false;

                lblTituloFormaPagamento.Text = "CARNÊ";

                lblValorDesconto.Text = "R$ 0,00";
            }
            else if (cmbFormaPagamento.Text == "CRÉDITO")
            {
                LayoutTipoPagamentoCredito(true);

                lblValorDebito.Visible = false;

                txtValorDinheiro.Visible = false;

                lblTituloFormaPagamento.Text = "CRÉDITO";

                lblValorDesconto.Text = "R$ 0,00";

                cmbParcelas.Text = "1x";

                lblValorTotal.Text = String.Format("{0:C}", valorBruto);
            }
            else if (cmbFormaPagamento.Text == "DÉBITO")
            {
                LayoutTipoPagamentoCredito(false);

                lblTituloFormaPagamento.Text = "DÉBITO";

                lblValorDebito.Visible = true;

                lblValorTotal.Text = string.Format("{0:C}", valorBruto - (valorBruto * listaFinanceiro[0].descontoAvista / 100));

                lblValorDebito.Text = string.Format("{0:C}", valorBruto - (valorBruto * listaFinanceiro[0].descontoAvista / 100));

                lblValorDesconto.Text = String.Format("{0:C}", (valorBruto * listaFinanceiro[0].descontoAvista / 100));
            }
            else if (cmbFormaPagamento.Text == "DINHEIRO")
            {
                LayoutTipoPagamentoCredito(false);

                lblTituloFormaPagamento.Text = "DINHEIRO";

                lblValorDebito.Visible = false;

                txtValorDinheiro.Visible = true;

                lblValorDesconto.Text = String.Format("{0:C}", (valorBruto * listaFinanceiro[0].descontoAvista / 100));

                lblValorTotal.Text = string.Format("{0:C}", valorBruto - (valorBruto * listaFinanceiro[0].descontoAvista / 100));

                //txtValorDinheiro.Focus();
            }
            else if (cmbFormaPagamento.Text == "PIX")
            {
                lblTituloFormaPagamento.Text = "PIX";

                txtValorDinheiro.Visible = false;

                pcbPix.Visible = true;
            }
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

            //lblTituloValorTotal.Visible = _ativa;
            //lblValorTotal.Visible = _ativa;
        }

        private void cmbParcelas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbParcelas.Text.Replace("x", "")) > listaFinanceiro[0].parcelasCredito)
            {
                lblValorJuros.Text = string.Format("{0:P}", (listaFinanceiro[0].jurosCredito / 100));

                lblValorParcela.Text = String.Format("{0:C}", (((valorBruto * (listaFinanceiro[0].jurosCredito) / 100) + valorBruto)
                    / Convert.ToDecimal(cmbParcelas.Text.Replace("x", ""))));

                lblValorTotal.Text = String.Format("{0:C}", ((valorBruto * (listaFinanceiro[0].jurosCredito) / 100) + valorBruto));
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

        private void txtValorDinheiro_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblValorTotal_Click(object sender, EventArgs e)
        {
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
            txtcodigoBarras(sender, e);
        }

        private void txtCodigoDeBarras_Enter(object sender, EventArgs e)
        {
            txtCPF.UseSystemPasswordChar = true;
        }
    }
}