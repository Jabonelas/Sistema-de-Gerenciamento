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
    public partial class Forms_DevolucaoTroca : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private List<DadosNotaFiscalSaida> listaDadosNotaFiscalSaida = new List<DadosNotaFiscalSaida>();

        private DadosNotaFiscalSaida dadosNotaFiscalSaida;

        private int cont = 0;

        //private List<DadosProduto> listaProduto = new List<DadosProduto>();

        //private DadosProduto produto;

        public Forms_DevolucaoTroca()
        {
            InitializeComponent();

            //listaProduto = Buscar.BuscarProdutos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar.BuscarVendaPorNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text), gdvDevolucaoTroca);

            listaDadosNotaFiscalSaida = Buscar.ListaNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text));

            SetarDesignColunaGridView();

            //Buscar.ListaNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text)).ForEach(nf => listaDadosNotaFiscalSaida.Add(nf));

            //foreach (var item in Buscar.ListaNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text)))
            //{
            //    listaDadosNotaFiscalSaida.Add(item);
            //}

            //txtVendedor.Text = listaDadosNotaFiscalSaida[0].vendedor;
            //txtValidadeTroca.Text = listaDadosNotaFiscalSaida[0].ValidadeTroca.ToShortDateString();
            //txtNomeCliente.Text = listaDadosNotaFiscalSaida[0].nomeCliente;

            //compras.listaDadosNotaFiscalEntrada.ForEach(nf => ListaEntrada = nf);

            //Buscar.ListaNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text));
        }

        private void SetarDesignColunaGridView()
        {
            //gdvDevolucaoTroca.Columns["Total"].DefaultCellStyle.Format = "c";
            //gdvDevolucaoTroca.Columns["VlrUnit"].DefaultCellStyle.Format = "c";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "DEVOLUÇÃO")
            {
                lblTroca.Visible = false;
                lblQuant.Visible = false;
                lblProduto.Visible = false;
                lblPreco.Visible = false;
                lblCodBarras.Visible = false;
                lblCodigoProduto.Visible = false;
                lblUnidade.Visible = false;
                txtCodBarrasTroca.Visible = false;
                txtCodProdutoTroca.Visible = false;
                txtProdutoTroca.Visible = false;
                txtQuantidadeTroca.Visible = false;
                txtUnidadeTroca.Visible = false;
                txtPrecoTroca.Visible = false;

                pnlValorPrudutoTroca.Visible = false;

                pnlValorProdutoDevolvido.Location = new Point(184, 489);
                pnlValorAPagar.Location = new Point(487, 489);
                btnFechar.Location = new Point(350, 637);
                this.Size = new Size(892, 735);
            }
        }

        private void txtCodBarrasDevolucao_TextChange(object sender, EventArgs e)
        {
            if (txtCodBarrasDevolucao.Text == string.Empty)
            {
            }
            else if (Buscar.BuscarCodigoBarras(Convert.ToInt32(txtCodBarrasDevolucao.Text)) == true)
            {
                //listaProduto.Find(prod => prod.codigoBarras.ToString().StartsWith(txtCodBarrasDevolucao.Text));

                //produto = listaProduto.Find(prod => prod.codigoBarras.ToString().StartsWith(txtCodBarrasDevolucao.Text));

                //txtCodBarrasDevolucao.Text = (dadosNotaFiscalSaida.Equals(testc => txtCodBarrasDevolucao.Text = testc));

                //dadosNotaFiscalSaida.descricao.Equals(testc => txtCodBarrasDevolucao.Text == testc);

                //teste = listaDadosNotaFiscalSaida.Where(a => a == 1);

                //teste = dadosNotaFiscalSaida.Equals(x => x == 1);

                DadosNotaFiscalSaida veriricacaoExistenciaNaFota;
                try
                {
                    veriricacaoExistenciaNaFota = listaDadosNotaFiscalSaida.First(item => item.codigoBarras == Convert.ToInt32(txtCodBarrasDevolucao.Text));
                    if (veriricacaoExistenciaNaFota != null)
                    {
                        dadosNotaFiscalSaida = listaDadosNotaFiscalSaida.Find(prod => prod.codigoBarras.ToString().StartsWith(txtCodBarrasDevolucao.Text));

                        txtProdutoDevolucao.Text = dadosNotaFiscalSaida.descricao;

                        txtUnidadeDevolucao.Text = dadosNotaFiscalSaida.unidade;

                        txtCodProdutoDevolucao.Text = dadosNotaFiscalSaida.codigoProduto.ToString();

                        txtPrecoDevolucao.Text = (string.Format("{0:C}", dadosNotaFiscalSaida.preco));

                        MessageBox.Show($"{dadosNotaFiscalSaida.preco}");
                    }
                }
                catch (Exception)
                {
                    if (cont == 1)
                    {
                        MessageBox.Show($"Item Não Pertenciente a Nota Fiscal de Nº: {txtNotaFiscal.Text} ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        cont = 0;
                        return;
                    }
                    cont++;
                }

                //dadosNotaFiscalSaida = listaDadosNotaFiscalSaida.Find(prod => prod.codigoBarras.ToString().StartsWith(txtCodBarrasDevolucao.Text));

                //txtProdutoDevolucao.Text = dadosNotaFiscalSaida.descricao;

                //txtUnidadeDevolucao.Text = dadosNotaFiscalSaida.unidade;

                //txtCodProdutoDevolucao.Text = dadosNotaFiscalSaida.codigoProduto.ToString();

                //txtPrecoDevolucao.Text = string.Format($"{0:c}", dadosNotaFiscalSaida.preco);

                //////////////////////////////////////////////////////////////////////////

                //txtProdutoDevolucao.Text = listaProduto[0].descricaoProduto;

                //txtUnidadeDevolucao.Text = listaProduto[0].descricaoProduto;

                //txtPrecoDevolucao.Text = listaProduto[0].preco.ToString();

                //txtCodProdutoDevolucao.Text = listaProduto[0].codigoProduto.ToString();

                //Buscar.BuscarEstoqueProdutoPorCodigo(txtCodBarrasDevolucao.Text);
            }
        }

        private void txtQuantidadeDevolucao_TextChange(object sender, EventArgs e)
        {
            txtPrecoDevolucao.Text = String.Format($"{0:C}", (Convert.ToDecimal(txtQuantidadeDevolucao.Text) *
              Convert.ToDecimal(txtPrecoDevolucao.Text.Replace("R$", ""))));
        }

        private void txtQuantidadeDevolucao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtCodBarrasDevolucao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }
    }
}