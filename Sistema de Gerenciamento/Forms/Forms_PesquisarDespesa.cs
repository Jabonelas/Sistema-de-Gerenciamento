using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using Sistema_de_Gerenciamento.Classes;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_PesquisarDespesa : Form
    {
        private MensagensErro Erro = new MensagensErro();

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private Forms_CadastroDespesas cadastroDespesas;

        public Forms_PesquisarDespesa(Forms_CadastroDespesas _cadastroDespesas)
        {
            InitializeComponent();

            cadastroDespesas = _cadastroDespesas;
        }

        #region Botao Sair

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Sair

        #region Botao Codigo

        private void txtCodigoDespesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion Botao Codigo

        #region Botao Pesquisar

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCodigoDespesa.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroDespesaPorCodigo(Convert.ToInt32(txtCodigoDespesa.Text), gdvPesquisarDespesa);

                if (isCadastroExiste == false)
                {
                    MessageBox.Show("Despesa Não Encontrada ", "Não Encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtDescricao.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroDespesaPorDescricao(txtDescricao.Text, gdvPesquisarDespesa);

                if (isCadastroExiste == false)
                {
                    MessageBox.Show("Despesa Não Encontrada ", "Não Encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtTipo.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroDespesaPorTipo(txtTipo.Text, gdvPesquisarDespesa);

                if (isCadastroExiste == false)
                {
                    MessageBox.Show("Despesa Não Encontrada ", "Não Encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Exibir Todos As Despesas?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    bool isCadastroExiste = Buscar.BuscarCadastroTudoDespesa(gdvPesquisarDespesa);

                    if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Despesa Não Encontrada ", "Não Encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        #endregion Botao Pesquisar

        #region Botao Selecionar

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (gdvPesquisarDespesa.RowCount >= 1)
            {
                int indice = -1;

                cadastroDespesas.txtCodigo.Text = gdvPesquisarDespesa.SelectedCells[indice += 1].Value.ToString();

                cadastroDespesas.txtDescricao.Text = gdvPesquisarDespesa.SelectedCells[indice += 1].Value.ToString();

                cadastroDespesas.txtTipo.Text = gdvPesquisarDespesa.SelectedCells[indice += 1].Value.ToString();

                this.Close();
            }
        }

        #endregion Botao Selecionar

        #region Botao Exportar

        private void btnExportarParaExcel_Click(object sender, EventArgs e)
        {
            if (gdvPesquisarDespesa.RowCount > 0)
            {
                try
                {
                    SaveFileDialog openFileDialog = new SaveFileDialog();
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|Excel 2007 (*.xls)|*.xls";
                    openFileDialog.FilterIndex = 1;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        DataTable dt = ExportarExcel.DataGridView_To_Datatable(gdvPesquisarDespesa);
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

        #region Imprimir Relatorio de Despesas

        private void ImprimirRelatorioDespesas()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Relatorio de Despesas";//Header
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = DateTime.Today.ToString();//Footer
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(gdvPesquisarDespesa);
        }

        #endregion Imprimir Relatorio de Despesas

        #region Botao Imprimir

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirRelatorioDespesas();
        }

        #endregion Botao Imprimir
    }
}