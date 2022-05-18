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

namespace Sistema_de_Gerenciamento
{
    public partial class PesquisarProduto : Form
    {
        private CadastroProduto cadastroProduto;

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        public PesquisarProduto(CadastroProduto _cadastroProduto)
        {
            InitializeComponent();
            cadastroProduto = _cadastroProduto;
        }

        #region Gridview

        private void gdvPesquisarProduto_DoubleClick(object sender, EventArgs e)
        {
            if (gdvPesquisarProduto.RowCount >= 1)
            {
                int indice = 0;

                cadastroProduto.txtCodigo.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtDescricao.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.cmbUn.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtValorDeCusto.Text = ("R$ " + gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString());

                cadastroProduto.txtPorcentagem.Text = (gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString() + " %");

                cadastroProduto.txtValorVenda.Text = ("R$ " + gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString());

                cadastroProduto.txtLucro.Text = ("R$ " + gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString());

                cadastroProduto.txtPrecoAtacado.Text = ("R$ " + gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString());

                cadastroProduto.cmbGrupo.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.cmbSubGrupo.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.cmbFornecedor.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtEstoqueMinimo.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtGarantia.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtMarca.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtReferencia.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtValidade.Text = (((DateTime)gdvPesquisarProduto.SelectedCells[indice += 1].Value).ToShortDateString());

                cadastroProduto.txtComissao.Text = (gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString() + " %");

                cadastroProduto.txtObservacoes.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.pcbProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(cadastroProduto.txtCodigo.Text));

                this.Close();
            }
        }

        #endregion Gridview

        #region Botao Selececionar

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (gdvPesquisarProduto.RowCount >= 1)
            {
                int indice = 0;

                cadastroProduto.txtCodigo.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtDescricao.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.cmbUn.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtValorDeCusto.Text = ("R$ " + gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString());

                cadastroProduto.txtPorcentagem.Text = (gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString() + " %");

                cadastroProduto.txtValorVenda.Text = ("R$ " + gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString());

                cadastroProduto.txtLucro.Text = ("R$ " + gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString());

                cadastroProduto.txtPrecoAtacado.Text = ("R$ " + gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString());

                cadastroProduto.cmbGrupo.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.cmbSubGrupo.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.cmbFornecedor.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtEstoqueMinimo.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtGarantia.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtMarca.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtReferencia.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtValidade.Text = (((DateTime)gdvPesquisarProduto.SelectedCells[indice += 1].Value).ToShortDateString());

                cadastroProduto.txtComissao.Text = (gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString() + " %");

                cadastroProduto.txtObservacoes.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.pcbProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(cadastroProduto.txtCodigo.Text));

                this.Close();
            }
        }

        #endregion Botao Selececionar

        #region Botao Pesquisar

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCodigoProduto.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroProdutoPorCodigo(Convert.ToInt32(txtCodigoProduto.Text), gdvPesquisarProduto);

                if (isCadastroExiste == false)
                {
                    MessageBox.Show("Produto Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtDescicao.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroProdutoPorDescricao(txtDescicao.Text, gdvPesquisarProduto);

                if (isCadastroExiste == false)
                {
                    MessageBox.Show("Produto Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtGrupo.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroProdutoPorGrupo(txtGrupo.Text, gdvPesquisarProduto);

                if (isCadastroExiste == false)
                {
                    MessageBox.Show("Produto Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtSubGrupo.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroProdutoPorSubGrupo(txtSubGrupo.Text, gdvPesquisarProduto);

                if (isCadastroExiste == false)
                {
                    MessageBox.Show("Produto Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtMarca.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroProdutoPorMarca(txtMarca.Text, gdvPesquisarProduto);

                if (isCadastroExiste == false)
                {
                    MessageBox.Show("Produto Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Exibir Todos Os Produtos?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    bool isCadastroExiste = Buscar.BuscarCadastroProdutoTudo(gdvPesquisarProduto);

                    if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Produto Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        #endregion Botao Pesquisar

        #region Botao Sair

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Sair

        #region Botao Exportar

        private void btnExportar_Click_1(object sender, EventArgs e)
        {
            if (gdvPesquisarProduto.RowCount > 0)
            {
                try
                {
                    SaveFileDialog openFileDialog = new SaveFileDialog();
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|Excel 2007 (*.xls)|*.xls";
                    openFileDialog.FilterIndex = 1;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        DataTable dt = ExportarExcel.DataGridView_To_Datatable(gdvPesquisarProduto);
                        dt.exportToExcel(openFileDialog.FileName);
                    }
                }
                catch (Exception ex)
                {
                    Erro.ErroAoExportarDadosExecel(ex);
                }
            }
            else
            {
                MessageBox.Show("Primeiro Realizar a Pesquisa!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion Botao Exportar

        #region TextBox Codigo

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Codigo
    }
}