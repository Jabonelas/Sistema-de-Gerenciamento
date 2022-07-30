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
    public partial class Forms_ConsultarEstoque : Form
    {
        private List<DadosEstoqueProduto> listaDadosEstoqueProdutos = new List<DadosEstoqueProduto>();

        private DadosEstoqueProduto dadosEstoqueProduto;

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        public Forms_ConsultarEstoque()
        {
            InitializeComponent();
        }

        private void btnBuscarCodigoProduto_Click(object sender, EventArgs e)
        {
            Forms_PesquisarProduto pesquisarProduto = new Forms_PesquisarProduto(this, "Tela Consultar Estoque");
            pesquisarProduto.ShowDialog();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarProdutoPorCodigo(Convert.ToInt32(txtCodigo.Text));

                if (isCadastroExiste == true)
                {
                    listaDadosEstoqueProdutos.Clear();

                    listaDadosEstoqueProdutos = Buscar.BuscarDescricaoUnidadeEstoqueProduto(Convert.ToInt32(txtCodigo.Text));

                    listaDadosEstoqueProdutos.ForEach(x => dadosEstoqueProduto = x);

                    txtDescricao.Text = dadosEstoqueProduto.descricaoProduto;

                    txtUnidade.Text = dadosEstoqueProduto.unidade;

                    txtQuantidadeLiberada.Text = Buscar.BuscarQuantidadeLiberadaEstoqueProduto(Convert.ToInt32(txtCodigo.Text)).ToString();

                    txtQuantidadeRejeitada.Text = Buscar.BuscarQuantidadeRejeitadaEstoqueProduto(Convert.ToInt32(txtCodigo.Text)).ToString();

                    txtQuantidadeEmTransito.Text = Buscar.BuscarQuantidadeEmTransitoEstoqueProduto(Convert.ToInt32(txtCodigo.Text)).ToString();

                    txtQuantidadeEmTerceiros.Text = Buscar.BuscarQuantidadeEmTerceirosEstoqueProduto(Convert.ToInt32(txtCodigo.Text)).ToString();

                    txtQuantidadeTotalEmEstoque.Text = (Convert.ToDecimal(txtQuantidadeLiberada.Text) + Convert.ToDecimal(txtQuantidadeRejeitada.Text)).ToString();

                    Buscar.BuscarEstoqueProdutoCompletoPorCodigo(Convert.ToInt32(txtCodigo.Text), gdvContarPagar);
                }
                else if (isCadastroExiste == false)
                {
                    MessageBox.Show("Codigo do Produto Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ManipulacaoTextBox.ApagandoTextBox(this);
                }
            }
        }
    }
}