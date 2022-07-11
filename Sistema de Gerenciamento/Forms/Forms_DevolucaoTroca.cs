﻿using Sistema_de_Gerenciamento.Classes;
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
    public partial class Forms_DevolucaoTroca : Form
    {
        private MensagensErro Erro = new MensagensErro();

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private List<DadosNotaFiscalSaida> listaDadosNotaFiscalSaida = new List<DadosNotaFiscalSaida>();

        private List<DadosProduto> listaDadosEstoqueProduto = new List<DadosProduto>();

        private DadosProduto dadosEstoqueProduto;

        private DadosNotaFiscalSaida dadosNotaFiscalSaida;

        private int cont = 0;

        private decimal memoriaQuantidade = 0;

        private decimal memoriaValorPago = 0;

        //private List<DadosProduto> listaProduto = new List<DadosProduto>();

        //private DadosProduto produto;

        public Forms_DevolucaoTroca()
        {
            InitializeComponent();

            pcbImagemProduto.Image = Buscar.BuscarLogoEmpresa(1);

            listaDadosEstoqueProduto = Buscar.BuscarProdutos();

            cmbTipo.SelectedIndex = 1;

            //listaProduto = Buscar.BuscarProdutos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarDadosNotaFiscalSaida();
        }

        private void BuscarDadosNotaFiscalSaida()
        {
            try
            {
                if (txtNotaFiscal.Text != string.Empty && Buscar.BuscarVendaPorNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text), gdvDevolucaoTroca) == true)
                {
                    //Buscar.BuscarVendaPorNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text), gdvDevolucaoTroca);

                    listaDadosNotaFiscalSaida = Buscar.ListaNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text));

                    SetarDesignColunaGridView();

                    Buscar.ListaNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text)).ForEach(nf => listaDadosNotaFiscalSaida.Add(nf));

                    txtVendedor.Text = listaDadosNotaFiscalSaida[0].vendedor;
                    txtValidadeTroca.Text = listaDadosNotaFiscalSaida[0].ValidadeTroca.ToShortDateString();
                    txtNomeCliente.Text = listaDadosNotaFiscalSaida[0].nomeCliente;

                    Buscar.ListaNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text));
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarNotaFiscalSaida(ex);
            }
        }

        private void SetarDesignColunaGridView()
        {
            gdvDevolucaoTroca.Columns["ns_valor_pago"].DefaultCellStyle.Format = "c";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            LayoutConformeNaturezaDaOperacao(cmbTipo.Text);
        }

        private void LayoutConformeNaturezaDaOperacao(string _operacao)
        {
            bool retorno = _operacao == "DEVOLUÇÃO" ? true : false;

            lblTroca.Visible = !retorno;
            lblQuant.Visible = !retorno;
            lblProduto.Visible = !retorno;
            lblPreco.Visible = !retorno;
            lblCodBarras.Visible = !retorno;
            lblCodigoProduto.Visible = !retorno;
            lblUnidade.Visible = !retorno;
            txtCodBarrasTroca.Visible = !retorno;
            txtCodProdutoTroca.Visible = !retorno;
            txtProdutoTroca.Visible = !retorno;
            txtQuantidadeTroca.Visible = !retorno;
            txtUnidadeTroca.Visible = !retorno;
            txtPrecoTroca.Visible = !retorno;
            pnlValorPrudutoTroca.Visible = !retorno;
            btnBuscarCodigoProduto.Visible = !retorno;

            if (retorno == true)
            {
                pnlValorProdutoDevolvido.Location = new Point(184, 489);
                pnlValorAPagar.Location = new Point(487, 489);
                btnFechar.Location = new Point(518, 630);
                btnConfirmar.Location = new Point(215, 630);
                this.Size = new Size(892, 735);
            }
            else
            {
                pnlValorProdutoDevolvido.Location = new Point(12, 542);
                pnlValorAPagar.Location = new Point(626, 542);
                btnFechar.Location = new Point(538, 683);
                btnConfirmar.Location = new Point(150, 683);
                this.Size = new Size(892, 773);
            }
        }

        private void txtCodBarrasDevolucao_TextChange(object sender, EventArgs e)
        {
            if (txtCodBarrasDevolucao.Text == string.Empty)
            {
                txtProdutoDevolucao.Text = string.Empty;

                txtUnidadeDevolucao.Text = string.Empty;

                txtQuantidadeDevolucao.Text = string.Empty;

                txtCodProdutoDevolucao.Text = string.Empty;

                txtPrecoDevolucao.Text = string.Empty;

                pcbImagemProduto.Image = Buscar.BuscarLogoEmpresa(1);

                lblValorProdDevolvido.Text = "R$ 0,00";

                //txtQuantidadeDevolucao.ReadOnly = true;

                txtQuantidadeDevolucao.Enabled = false;
            }
            else if (Buscar.BuscarCodigoBarras(Convert.ToInt32(txtCodBarrasDevolucao.Text)) == true)
            {
                memoriaValorPago = 0;

                memoriaQuantidade = 0;

                DadosNotaFiscalSaida veriricacaoExistenciaNaFota;

                try
                {
                    veriricacaoExistenciaNaFota = listaDadosNotaFiscalSaida.First(item => item.codigoBarras == Convert.ToInt32(txtCodBarrasDevolucao.Text));

                    if (veriricacaoExistenciaNaFota != null)
                    {
                        dadosNotaFiscalSaida = listaDadosNotaFiscalSaida.Find(prod => prod.codigoBarras.ToString().StartsWith(txtCodBarrasDevolucao.Text));

                        txtProdutoDevolucao.Text = dadosNotaFiscalSaida.descricao;

                        txtUnidadeDevolucao.Text = dadosNotaFiscalSaida.unidade;

                        txtQuantidadeDevolucao.Text = string.Format("{0:0}", dadosNotaFiscalSaida.quantidade.ToString());

                        txtCodProdutoDevolucao.Text = dadosNotaFiscalSaida.codigoProduto.ToString();

                        txtPrecoDevolucao.Text = string.Format("{0:C}", dadosNotaFiscalSaida.preco);

                        //txtQuantidadeDevolucao.ReadOnly = false;

                        txtQuantidadeDevolucao.Enabled = true;

                        pcbImagemProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodProdutoDevolucao.Text));
                    }
                }
                catch (Exception)
                {
                    if (cont == 1)
                    {
                        MessageBox.Show($"Item Não Pertenciente a Nota Fiscal de Nº: {txtNotaFiscal.Text} ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtCodBarrasDevolucao.Text = string.Empty;

                        cont = 0;
                        return;
                    }
                    cont++;
                }
            }
        }

        private void txtQuantidadeDevolucao_TextChange(object sender, EventArgs e)
        {
            memoriaQuantidade = dadosNotaFiscalSaida.quantidade;

            memoriaValorPago = dadosNotaFiscalSaida.preco / memoriaQuantidade;

            try
            {
                if (Convert.ToDecimal(txtQuantidadeDevolucao.Text) <= memoriaQuantidade && cont == 0)
                {
                    txtPrecoDevolucao.Text = String.Format("{0:C}", (Convert.ToDecimal(txtQuantidadeDevolucao.Text) *
                        memoriaValorPago));

                    cont++;
                }
                else if (Convert.ToDecimal(txtQuantidadeDevolucao.Text) > memoriaQuantidade && cont == 0)
                {
                    MessageBox.Show("A quantidade informada é maior que a quantidade disponivel");

                    cont++;
                }
                else if (cont != 0)
                {
                    cont = 0;
                }
            }
            catch (Exception)
            {
            }
        }

        private void txtQuantidadeDevolucao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtCodBarrasDevolucao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtNotaFiscal_Leave(object sender, EventArgs e)
        {
            BuscarDadosNotaFiscalSaida();
        }

        private void txtQuantidadeDevolucao_Enter(object sender, EventArgs e)
        {
            txtQuantidadeDevolucao.Text = string.Empty;
        }

        private void txtPrecoDevolucao_TextChange(object sender, EventArgs e)
        {
            lblValorProdDevolvido.Text = txtPrecoDevolucao.Text;

            if (cmbTipo.Text == "DEVOLUÇÃO")
            {
                lblValorAPagar.Text = lblValorProdDevolvido.Text;
                lblValorAPagar.ForeColor = Color.Red;
            }
        }

        private void txtCodBarrasTroca_TextChange(object sender, EventArgs e)
        {
            if (txtCodBarrasTroca.Text == string.Empty)
            {
                txtCodProdutoTroca.Text = string.Empty;
                txtProdutoTroca.Text = string.Empty;
                txtQuantidadeTroca.Text = string.Empty;
                txtUnidadeTroca.Text = string.Empty;
                txtPrecoTroca.Text = string.Empty;
                lblValorProdTroca.Text = "R$ 0,00";
            }
            else if (Buscar.BuscarCodigoBarras(Convert.ToInt32(txtCodBarrasTroca.Text)) == true)
            {
                dadosEstoqueProduto = listaDadosEstoqueProduto.Find(prod => prod.codigoBarras.ToString().StartsWith(txtCodBarrasTroca.Text));

                txtCodProdutoTroca.Text = dadosEstoqueProduto.codigoProduto.ToString();
                txtProdutoTroca.Text = dadosEstoqueProduto.descricaoProduto;
                txtQuantidadeTroca.Text = "1,00";
                txtUnidadeTroca.Text = dadosEstoqueProduto.unidade;
                txtPrecoTroca.Text = string.Format("{0:C}", dadosEstoqueProduto.preco);

                txtQuantidadeTroca.Enabled = true;

                pcbImagemProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodBarrasTroca.Text));
            }
        }

        private void btnBuscarCodigoProduto_Click(object sender, EventArgs e)
        {
            Forms_PesquisarProduto pesquisarProduto = new Forms_PesquisarProduto(this, "Tela Devolucao/Troca");
            pesquisarProduto.ShowDialog();
        }

        private void txtCodProdutoTroca_TextChange(object sender, EventArgs e)
        {
            if (txtCodBarrasTroca.Text == string.Empty)
            {
                txtCodProdutoTroca.Text = string.Empty;
                txtProdutoTroca.Text = string.Empty;
                txtQuantidadeTroca.Text = string.Empty;
                txtUnidadeTroca.Text = string.Empty;
                txtPrecoTroca.Text = string.Empty;
            }
            else if (Buscar.BuscarCodigoBarras(Convert.ToInt32(txtCodProdutoTroca.Text)) == true)
            {
                dadosEstoqueProduto = listaDadosEstoqueProduto.Find(prod => prod.codigoBarras.ToString().StartsWith(txtCodProdutoTroca.Text));

                txtCodBarrasTroca.Text = dadosEstoqueProduto.codigoBarras.ToString();
                txtProdutoTroca.Text = dadosEstoqueProduto.descricaoProduto;
                txtQuantidadeTroca.Text = "1";
                txtUnidadeTroca.Text = dadosEstoqueProduto.unidade;
                txtPrecoTroca.Text = String.Format("{0:C}", dadosEstoqueProduto.preco);

                txtQuantidadeTroca.Enabled = true;

                pcbImagemProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodProdutoTroca.Text));
            }
        }

        private void txtCodProdutoTroca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtCodBarrasTroca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void Forms_DevolucaoTroca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Finalziar tela Esc
            {
                this.Close();
            }
        }

        private void txtPrecoTroca_TextChange(object sender, EventArgs e)
        {
            if (txtPrecoTroca.Text != string.Empty)
            {
                lblValorProdTroca.Text = txtPrecoTroca.Text;

                lblValorAPagar.Text = String.Format("{0:C}", (Convert.ToDecimal(lblValorProdTroca.Text.Replace("R$ ", "")) -
                Convert.ToDecimal(lblValorProdDevolvido.Text.Replace("R$ ", ""))));

                if (Convert.ToDecimal(lblValorAPagar.Text.Replace("R$ ", "")) < 0)
                {
                    lblTituloValorAPagar.Text = "Valor a Pagar";

                    lblValorAPagar.ForeColor = Color.Red;
                }
                else
                {
                    lblTituloValorAPagar.Text = "Valor a Receber";

                    lblValorAPagar.ForeColor = Color.Green;
                }
            }
        }

        private void txtQuantidadeDevolucao_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantidadeDevolucao.Text == string.Empty || Convert.ToDecimal(txtQuantidadeDevolucao.Text) > memoriaQuantidade)
                {
                    txtQuantidadeDevolucao.Focus();
                }
            }
            catch (Exception)
            {
            }
        }

        private void txtQuantidadeTroca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ManipulacaoTextBox.TextBoxEstaVazio(this);
        }

        private void txtQuantidadeTroca_Enter(object sender, EventArgs e)
        {
            txtQuantidadeTroca.Text = string.Empty;
        }

        private void txtQuantidadeTroca_Leave(object sender, EventArgs e)
        {
            if (txtQuantidadeTroca.Text == string.Empty)
            {
                txtQuantidadeTroca.Focus();
            }
        }

        private void txtQuantidadeTroca_TextChange(object sender, EventArgs e)
        {
            if (txtQuantidadeTroca.Text != string.Empty)
            {
                txtPrecoTroca.Text = String.Format("{0:C}", (Convert.ToDecimal(txtQuantidadeTroca.Text) * dadosEstoqueProduto.preco));
            }
        }
    }
}