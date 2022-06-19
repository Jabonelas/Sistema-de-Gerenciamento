using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gerenciamento.Classes;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_TelaPDV : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private List<DadosProduto> listaProduto = new List<DadosProduto>();

        private DadosProduto produto;

        private decimal valorBruto = 0;

        private int cont = 0;

        public Forms_TelaPDV()
        {
            InitializeComponent();

            listaProduto = Buscar.BuscarProdutos();

            this.Height = Screen.PrimaryScreen.Bounds.Height;

            this.Width = Screen.PrimaryScreen.Bounds.Width;

            this.TopMost = true;
        }

        private void Forms_TelaPDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
            }
        }

        private void txtcodigoBarras(object sender, EventArgs e)
        {
            if (cont <= 0)
            {
                BuscarProduto();

                AdicionarProduto();

                SetarDesignColunaGridView();

                pcbPDV.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodigo.Text));

                cont++;
            }
            else
            {
                txtCodigoBarras.Text = string.Empty;

                cont = 0;
            }
        }

        #region Adicionar Produto

        private void AdicionarProduto()
        {
            try
            {
                if (txtCodigoBarras.Text != string.Empty)
                {
                    bool isCadastroExiste = Buscar.BuscarEstoqueProdutoPorCodigo(txtCodigoBarras.Text);

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
                Erro.ErroAoBuscarEstoqueProduto(ex);
            }
        }

        #region Valor Total

        private void ValorTotal()
        {
            valorBruto = 0;

            for (int i = 0; i < gdvPDV.RowCount; i++)
            {
                valorBruto += Convert.ToDecimal(gdvPDV.Rows[i].Cells[4].Value.ToString().Replace("R$ ", ""));
            }

            lblSubtotal.Text = string.Format("{0:C}", valorBruto);
        }

        #endregion Valor Total

        #region Preencher GridView

        private void PreenchendoGridView()
        {
            var rows = new List<string[]>();
            string[] row1 = new string[] { txtCodigo.Text, txtDescricao.Text, txtQtd.Text,
                lblValorUnitario.Text, lblTotaldoItem.Text,txtDesconto.Text};
            rows.Add(row1);

            foreach (string[] item in rows)
            {
                gdvPDV.Rows.Add(item);
            }
        }

        #endregion Preencher GridView

        #endregion Adicionar Produto

        #region Buscar Produto e Preencher os TextBox Conforme a Busca

        private void BuscarProduto()
        {
            try
            {
                if (txtCodigoBarras.Text != string.Empty)
                {
                    bool isCadastroExiste = Buscar.BuscarEstoqueProdutoPorCodigo(txtCodigoBarras.Text);

                    if (isCadastroExiste == true)
                    {
                        produto = listaProduto.Find(prod => prod.codigoBarras.ToString().StartsWith(txtCodigoBarras.Text));

                        txtCodigo.Text = produto.codigoProduto.ToString();
                        txtDescricao.Text = produto.descricaoProduto;
                        lblDescricaoItem.Text = produto.descricaoProduto;
                        lblCodigoProduto.Text = produto.codigoProduto.ToString();
                        lblUnidade.Text = produto.unidade;
                        lblValorUnitario.Text = string.Format("{0:C}", (produto.preco - (produto.desconto * produto.preco / 100)));
                        lblTotaldoItem.Text = string.Format("{0:C}", Convert.ToDecimal(txtQtd.Text) * (produto.preco - (produto.desconto * produto.preco / 100)));

                        string desconto = ((produto.desconto / 100) > 0) ? string.Format("{0:P}", produto.desconto / 100) : "Sem Desconto";

                        txtDesconto.Text = desconto;
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

        #endregion Buscar Produto e Preencher os TextBox Conforme a Busca

        #region Setar o Design Do Forms

        private void SetarDesignColunaGridView()
        {
            this.gdvPDV.Columns["Total"].DefaultCellStyle.Format = "c";
            this.gdvPDV.Columns["VlrUnit"].DefaultCellStyle.Format = "c";
        }

        #endregion Setar o Design Do Forms

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

    
    }
}