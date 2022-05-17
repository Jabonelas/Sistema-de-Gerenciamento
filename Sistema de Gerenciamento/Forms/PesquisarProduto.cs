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

                this.Close();
            }
        }

        #endregion Botao Selececionar

        #region Botao Pesquisar

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //bool isCadastroExiste = Buscar.BuscarCadastroCliente(txtCodigoCliente.Text, txtCPF_CNPJ.Text, txtRG.Text, txtNome.Text, gdvPesquisarCliente);

            //if (iscadastroexiste == false)
            //{
            //    messagebox.show("cliente não encontrado ", "não encontrado!", messageboxbuttons.ok, messageboxicon.information);
            //}
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
        }

        #endregion Botao Exportar
    }
}