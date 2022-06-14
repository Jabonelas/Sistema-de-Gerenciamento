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
    public partial class Forms_PesquisarDespesaCustos : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private Forms_DespesasCustos despesas;

        public Forms_PesquisarDespesaCustos()
        {
            InitializeComponent();
        }

        public Forms_PesquisarDespesaCustos(Forms_DespesasCustos _despesas, string _lblCategoria)
        {
            InitializeComponent();

            lblCategoria.Text = _lblCategoria;

            despesas = _despesas;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir.ImprimirGridView("Relatorio de Despesas", gdvPesquisarDespesa);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarDespesa();

            SetarDesignColunaGridView();
        }

        #region Pesquisar Despesa

        private void PesquisarDespesa()
        {
            if (txtCodigoDespesa.Text != string.Empty)
            {
                bool isDespesaExiste = Buscar.BuscarDespesaPorCogigo(Convert.ToInt32(txtCodigoDespesa.Text),
                    lblCategoria.Text, gdvPesquisarDespesa, lblEstatusPagamento.Text);

                MensagemDespesaNaoEncontrada(isDespesaExiste);
            }
            else if (cmbTipoDespesa.Text != String.Empty)
            {
                bool isDespesaExiste = Buscar.BuscarDespesaPorTipo(cmbTipoDespesa.Text,
                    lblCategoria.Text, gdvPesquisarDespesa, lblEstatusPagamento.Text);

                MensagemDespesaNaoEncontrada(isDespesaExiste);
            }
            else if (txtTitulo.Text != String.Empty)
            {
                bool isDespesaExiste = Buscar.BuscarDespesaPorTitulo(txtTitulo.Text,
                    lblCategoria.Text, gdvPesquisarDespesa, lblEstatusPagamento.Text);

                MensagemDespesaNaoEncontrada(isDespesaExiste);
            }
            else if (txtDescricao.Text != String.Empty)
            {
                bool isDespesaExiste = Buscar.BuscarDespesaPorDescricao(txtDescricao.Text,
                    lblCategoria.Text, gdvPesquisarDespesa, lblEstatusPagamento.Text);

                MensagemDespesaNaoEncontrada(isDespesaExiste);
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Exibir Todos As Despesas?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    bool isDespesaExiste = Buscar.BuscarDespesa(lblCategoria.Text, gdvPesquisarDespesa, lblEstatusPagamento.Text);

                    MensagemDespesaNaoEncontrada(isDespesaExiste);
                }
            }
        }

        #region Mensagem Despesa Não Encontrada

        private void MensagemDespesaNaoEncontrada(bool _isDespesaExiste)
        {
            if (_isDespesaExiste == false)
            {
                MessageBox.Show("Despesa Não Encontrada ", "Não Encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion Mensagem Despesa Não Encontrada

        #endregion Pesquisar Despesa

        private void btnExportarParaExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel.GerarExcel(gdvPesquisarDespesa);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            SelecionarGridView();
        }

        private void gdvPesquisarDespesa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelecionarGridView();
        }

        #region Selecionar GridView

        private void SelecionarGridView()
        {
            if (gdvPesquisarDespesa.RowCount > 0)
            {
                int indice = 1;

                despesas.txtCodigo.Text = gdvPesquisarDespesa.SelectedCells[indice += 1].Value.ToString();
                despesas.cmbTipoDespesa.Text = gdvPesquisarDespesa.SelectedCells[indice += 1].Value.ToString();
                despesas.txtDescricao.Text = gdvPesquisarDespesa.SelectedCells[indice += 1].Value.ToString();
                despesas.cmbFornecedorTitulo.Text = gdvPesquisarDespesa.SelectedCells[indice += 1].Value.ToString();
                despesas.txtCNPJ.Text = gdvPesquisarDespesa.SelectedCells[indice += 1].Value.ToString();
                despesas.txtEmissao.Text = Convert.ToDateTime(gdvPesquisarDespesa.SelectedCells[indice += 1].Value).ToShortDateString();
                despesas.txtVencimento.Text = Convert.ToDateTime(gdvPesquisarDespesa.SelectedCells[indice += 1].Value).ToShortDateString();
                despesas.cmbFrequencia.Text = gdvPesquisarDespesa.SelectedCells[indice += 1].Value.ToString();
                despesas.txtValor.Text = String.Format("R$ {0:#,##0.00}", gdvPesquisarDespesa.SelectedCells[indice += 1].Value.ToString());
                despesas.cmbQuantidadeParcelas.Text = (gdvPesquisarDespesa.SelectedCells[indice += 1].Value + "x");
                despesas.txtValorParcelas.Text = String.Format("R$ {0:#,##0.00}", gdvPesquisarDespesa.SelectedCells[indice += 1].Value.ToString());

                this.Close();
            }
        }

        #endregion Selecionar GridView

        private void txtCodigoDespesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        #region Setar o Design Do Forms

        private void SetarDesignColunaGridView()
        {
            this.gdvPesquisarDespesa.Columns["dc_valor"].DefaultCellStyle.Format = "c";
        }

        #endregion Setar o Design Do Forms
    }
}