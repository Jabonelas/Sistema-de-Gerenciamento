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
    public partial class Forms_CadastroCodigoBarras : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        public DadosNotaFiscalEntrada ListaEntrada;

        public Forms_Compras compras;

        private int cont = 1;

        public Forms_CadastroCodigoBarras(Forms_Compras _compras)
        {
            InitializeComponent();

            compras = _compras;

            PreenchimentoTextBox();
        }

        #region Preenchimento TextBox

        private void PreenchimentoTextBox()
        {
            if (Global.tipoEntrada == "Entrada")
            {
                compras.listaDadosNotaFiscalEntrada.ForEach(nf => ListaEntrada = nf);

                txtNumeroNotaFiscal.Text = compras.listaDadosNotaFiscalEntrada[0].numeroNF.ToString();
                txtQuantidade.Text = compras.listaDadosNotaFiscalEntrada[0].quantidade.ToString();
                txtCodigoProduto.Text = compras.listaDadosNotaFiscalEntrada[0].codProduto.ToString();
                txtDescricaoProduto.Text = compras.listaDadosNotaFiscalEntrada[0].descricao;

                pcbProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodigoProduto.Text));

                btnAdicionarCodigoBarras.Location = new Point(178, 234);

                btnFechar.Visible = false;
            }
            else if (Global.tipoEntrada == "Alterar")
            {
                compras.listaDadosNotaFiscalEntrada.ForEach(nf => ListaEntrada = nf);

                txtNumeroNotaFiscal.Text = compras.listaDadosEstoqueProdutos[0].numeroNF.ToString();
                txtQuantidade.Text = compras.listaDadosEstoqueProdutos[0].quantidade.ToString();
                txtCodigoProduto.Text = compras.listaDadosEstoqueProdutos[0].codigoProduto.ToString();
                txtDescricaoProduto.Text = compras.listaDadosEstoqueProdutos[0].descricaoProduto;
                txtCodigoBarras.Text = compras.listaDadosEstoqueProdutos[0].codigoBarras.ToString();

                pcbProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodigoProduto.Text));

                btnAdicionarCodigoBarras.Location = new Point(35, 237);

                btnFechar.Location = new Point(308, 237);

                btnFechar.Visible = true;
            }
        }

        #endregion Preenchimento TextBox

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void btnAdicionarCodigoBarras_Click(object sender, EventArgs e)
        {
            if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
            {
                if (Global.tipoEntrada == "Alterar")
                {
                    Atualizar.AtualizarCodigoBarrasEstoqueProduto(Convert.ToInt32(txtCodigoBarras.Text),
                        Convert.ToInt32(txtNumeroNotaFiscal.Text), Convert.ToInt32(txtCodigoProduto.Text));

                    if (cont <= (Buscar.BuscarQuantidadeDeItensNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text)) - 1))
                    {
                        txtNumeroNotaFiscal.Text = compras.listaDadosEstoqueProdutos[cont].numeroNF.ToString();
                        txtQuantidade.Text = compras.listaDadosEstoqueProdutos[cont].quantidade.ToString();
                        txtCodigoProduto.Text = compras.listaDadosEstoqueProdutos[cont].codigoProduto.ToString();
                        txtDescricaoProduto.Text = compras.listaDadosEstoqueProdutos[cont].descricaoProduto;
                        txtCodigoBarras.Text = compras.listaDadosEstoqueProdutos[cont].codigoBarras.ToString();

                        pcbProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodigoProduto.Text));

                        //txtCodigoBarras.Text = string.Empty;

                        cont++;

                        txtCodigoBarras.Focus();
                    }
                    else
                    {
                        AvisoCantoInferiorDireito.Inclusao();

                        this.Close();
                    }
                }
                else if (Global.tipoEntrada == "Entrada")
                {
                    Atualizar.AtualizarCodigoBarrasEstoqueProduto(Convert.ToInt32(txtCodigoBarras.Text),
                        Convert.ToInt32(txtNumeroNotaFiscal.Text), Convert.ToInt32(txtCodigoProduto.Text));

                    if (cont <= (Buscar.BuscarQuantidadeDeItensNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text)) - 1))
                    {
                        txtNumeroNotaFiscal.Text = compras.listaDadosNotaFiscalEntrada[cont].numeroNF.ToString();
                        txtQuantidade.Text = compras.listaDadosNotaFiscalEntrada[cont].quantidade.ToString();
                        txtCodigoProduto.Text = compras.listaDadosNotaFiscalEntrada[cont].codProduto.ToString();
                        txtDescricaoProduto.Text = compras.listaDadosNotaFiscalEntrada[cont].descricao;

                        pcbProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodigoProduto.Text));

                        txtCodigoBarras.Text = string.Empty;

                        cont++;

                        txtCodigoBarras.Focus();
                    }
                    else
                    {
                        AvisoCantoInferiorDireito.Inclusao();

                        this.Close();
                    }
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}