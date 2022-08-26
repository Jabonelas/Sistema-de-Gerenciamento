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
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private VerificacaoDeExistencia verificacaoDeExistencia = new VerificacaoDeExistencia();

        private List<DadosEstoqueProduto> listaDadosEstoqueProdutos = new List<DadosEstoqueProduto>();

        private DadosEstoqueProduto dadosEstoqueProduto;

        public Forms_ConsultarEstoque()
        {
            InitializeComponent();
        }

        private void btnBuscarCodigoProduto_Click(object sender, EventArgs e)
        {
            Forms_PesquisarProduto pesquisarProduto = new Forms_PesquisarProduto(this, "Tela Consultar Estoque");
            pesquisarProduto.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConfirmarBuscaComVerificacao();
        }

        private void btnBuscarItensEmContagem_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text != String.Empty)
            {
                Forms_ConsultaEstoqueContagem consultaEstoqueContagem = new Forms_ConsultaEstoqueContagem(this);
                consultaEstoqueContagem.ShowDialog();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            AbrirFormsConsultaDetalhada();
        }

        private void gdvContarPagar_DoubleClick(object sender, EventArgs e)
        {
            AbrirFormsConsultaDetalhada();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void ConfirmarBuscaComVerificacao()
        {
            if (txtCodigo.Text != string.Empty)
            {
                bool isCadastroExiste = verificacaoDeExistencia.VerificarExistenciaCadastroProdutoPorCodigo(Convert.ToInt32(txtCodigo.Text));

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

                    Buscar.BuscarEstoqueProdutoCompletoPorCodigo(Convert.ToInt32(txtCodigo.Text), gdvConsultarEstoque);

                    txtQuantidadeEmContagem.Text = Buscar.BuscarQuantidadeItensEmContagem(Convert.ToInt32(txtCodigo.Text)).ToString();
                }
                else if (isCadastroExiste == false)
                {
                    MessageBox.Show("Codigo do Produto Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (var item in gdvConsultarEstoque.Rows)
                    {
                        gdvConsultarEstoque.Rows.Remove((DataGridViewRow)item);
                    }

                    if (gdvConsultarEstoque.RowCount > 0)
                    {
                        gdvConsultarEstoque.Rows.RemoveAt(gdvConsultarEstoque.Rows.Count - 1);
                    }

                    ManipulacaoTextBox.ApagandoTextBox(this);
                }
            }
        }

        private void Forms_ConsultarEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Classes.FecharTela.DesejaFecharTela(this, e);
            }

            if (e.KeyCode == Keys.Enter)
            {
                AbrirFormsConsultaDetalhada();
            }
        }

        private void FecharTela()
        {
            DialogResult OpcaoDoUsuario = new DialogResult();
            OpcaoDoUsuario = MessageBox.Show("Realmente Deseja Sair da Tela de Consulta Estoque?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (OpcaoDoUsuario == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void AbrirFormsConsultaDetalhada()
        {
            Forms_ConsultaEstoqueDetalhada exibirConsultaEstoque = new Forms_ConsultaEstoqueDetalhada(this);
            exibirConsultaEstoque.ShowDialog();
        }
    }
}