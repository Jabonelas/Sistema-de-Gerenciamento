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
    public partial class Venda : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        public Venda()
        {
            InitializeComponent();

            txtData.Text = DateTime.Today.ToShortDateString();

            cmbCliente.Items.Clear();
            foreach (var item in Buscar.BuscarListaCliente())
            {
                cmbCliente.Items.Add(item);
            }

            txtVendedor.Text = Global.tipoDeUsuario;
        }

        #region Botao Abrir Cadastro Cliente

        private void btnAbriCadastroCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente buscarCliente = new CadastroCliente();
            buscarCliente.ShowDialog();
        }

        #endregion Botao Abrir Cadastro Cliente

        #region Botao Sair

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Sair

        #region ComboBox Cleinte

        private void cmbCliente_Leave(object sender, EventArgs e)
        {
            if (cmbCliente.Text != string.Empty)
            {
                txtCodigoCliente.Text = Buscar.BuscarIdClientePorNome(cmbCliente.Text).ToString();
            }
        }

        #endregion ComboBox Cleinte

        #region Botao Adcionar

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodBarras.Text != string.Empty)
                {
                    bool isCadastroExiste = Buscar.BuscarEstoqueProdutoPorCodigo(txtCodBarras.Text, gdvVenda);

                    if (isCadastroExiste == false)
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

        #endregion Botao Adcionar

        #region TextBox Codigo de Barras

        private void txtCodBarras_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCodBarras.Text != string.Empty)
                {
                    txtCodProduto.Text = Buscar.BuscarEstoqueProdutoCodigoProdutoPorCodigoDeBarras(Convert.ToInt32(txtCodBarras.Text)).ToString();

                    txtProduto.Text = Buscar.BuscarEstoqueProdutoDescricaoProdutoPorCodigoDeBarras(Convert.ToInt32(txtCodBarras.Text));

                    txtUnidade.Text = Buscar.BuscarEstoqueProdutoUnidadeProdutoPorCodigoDeBarras(Convert.ToInt32(txtCodBarras.Text));

                    txtQuantidade.Text = Buscar.BuscarEstoqueProdutoQuantidadeProdutoPorCodigoDeBarras(Convert.ToInt32(txtCodBarras.Text)).ToString();

                    txtPrecoVenda.Text = Buscar.BuscarEstoqueProdutoPrecoProdutoPorCodigoDeBarras(Convert.ToInt32(txtCodBarras)).ToString();

                    //txtPrecoVenda.Text = (Convert.ToDecimal(txtQuantidade.Text) * Buscar.BuscarEstoqueProdutoPrecoProdutoPorCodigoDeBarras(Convert.ToInt32(txtCodBarras))).ToString();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarEstoqueProduto(ex);
            }
        }

        private void txtCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Codigo de Barras
    }
}