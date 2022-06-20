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

        private string verificar;

        public Forms_TelaPDV()
        {
            InitializeComponent();

            listaProduto = Buscar.BuscarProdutos();

            //this.Height = Screen.PrimaryScreen.Bounds.Height;

            //this.Width = Screen.PrimaryScreen.Bounds.Width;

            //this.TopMost = true;
        }

        private void Forms_TelaPDV_Load(object sender, EventArgs e)
        {
            txtCodigoBarras.Focus();
        }

        private void Forms_TelaPDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Finalziar tela Esc
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F7) // Finalizar Compra F7
            {
                FormatoTelaPagamento("Pagamento");
            }

            if (e.KeyCode == Keys.F6) // inserir quantidade F6
            {
                lblTituloCPFQuant.Text = "QUANTIDADE";

                txtCPF.Visible = false;

                txtInserirQuant.Visible = true;
                txtInserirQuant.Enabled = true;
                txtInserirQuant.Focus();
            }

            if (e.KeyCode == Keys.F1) // nova venda F1
            {
                gdvPDV.Rows.Clear();

                pcbPDV.Image = Image.FromFile(@"C:\Users\israe\source\repos\Sistema de Gerenciamento\Sistema de Gerenciamento\Resources\png-transparent-logo-pharmacy-pills-miscellaneous-trademark-pharmaceutical-drug.png");

                lblSubtotal.Text = "R$ 0,00";
                lblTroco.Text = "R$ 0,00";
                lblTotalRecebido.Text = "R$ 0,00";
                txtCPF.Text = "-";
                lblCodigoProduto.Text = "-";
                lblTotaldoItem.Text = "R$ 0,00";
                lblValorUnitario.Text = "R$ 0,00";
                pnlFachada.BackgroundColor = Color.Lime;
                lblFachada.Text = "CAIXA DISPONÍVEL";

                txtCPF.UseSystemPasswordChar = false;

                FormatoTelaPagamento("Cancelamento");
            }

            if (e.KeyCode == Keys.F2) // excluir item F2
            {
                RemoverProduto();
            }

            if (e.KeyCode == Keys.F3) // inserir cpf F3
            {
                txtCPF.Text = string.Empty;

                txtCPF.ReadOnly = true;
                txtCPF.Enabled = true;
                txtCPF.Focus();
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
            lblTipoPagamento.Visible = retorno;

            //painel com desconto

            lblDesconto.Visible = retorno;
            lblValorDesconto.Visible = retorno;
            pnlDesconto.Visible = retorno;

            //painel carne
            pnlCarne.Visible = retorno;
            lblTituloCarne.Visible = retorno;
            lblValorCarne.Visible = retorno;

            //painel Credito
            pnlCredito.Visible = retorno;
            lblTituloCredito.Visible = retorno;
            lblValorCredito.Visible = retorno;

            //painel Debito
            pnlDebito.Visible = retorno;
            lblTituloDebito.Visible = retorno;
            lblValorDebito.Visible = retorno;

            //painel Dinheiro
            pnlDinheiro.Visible = retorno;
            lblTituloDinheiro.Visible = retorno;
            txtValorDinheiro.Visible = retorno;

            //painel com as teclas
            pnlpagamento2.Visible = retorno;
            pnlPagamento3.Visible = retorno;
        }

        private void txtcodigoBarras(object sender, EventArgs e)
        {
            if (cont <= 0)
            {
                BuscarProduto();

                AdicionarProduto();

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
                txtCodigoBarras.Text = string.Empty;

                cont = 0;

                txtInserirQuant.Text = "1";
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
            string[] row1 = new string[] { txtCodigo.Text, txtDescricao.Text, txtInserirQuant.Text,
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
                        lblTotaldoItem.Text = string.Format("{0:C}", Convert.ToDecimal(txtInserirQuant.Text) * (produto.preco - (produto.desconto * produto.preco / 100)));

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

        #region Setar o Design Do Forms Coluna de Valores Com R$

        private void SetarDesignColunaGridView()
        {
            this.gdvPDV.Columns["Total"].DefaultCellStyle.Format = "c";
            this.gdvPDV.Columns["VlrUnit"].DefaultCellStyle.Format = "c";
        }

        #endregion Setar o Design Do Forms Coluna de Valores Com R$

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            txtCPF.UseSystemPasswordChar = false;
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            txtCPF.UseSystemPasswordChar = true;

            txtCPF.ReadOnly = true;

            lblNomeCliente.Text = Buscar.BuscarClienteTelaPDVPorCPF(txtCPF.Text).ToUpper();
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoCPF(e, txtCPF);
            }
        }

        #region Remover Produto do GridView

        private void RemoverProduto()
        {
            if (gdvPDV.RowCount > 0)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Remover O Item?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    gdvPDV.Rows.RemoveAt(gdvPDV.CurrentRow.Index);

                    ValorTotal();

                    //ApagandoTextbox();
                }
            }
        }

        #endregion Remover Produto do GridView

        private void txtInserirQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void pnlDebito_Click(object sender, EventArgs e)
        {
        }

        private void lblTituloDebito_Click(object sender, EventArgs e)
        {
        }

        private void lblTituloCarne_Click(object sender, EventArgs e)
        {

        }
    }
}