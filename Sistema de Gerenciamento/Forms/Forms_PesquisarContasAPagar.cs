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
using Sistema_de_Gerenciamento.Forms;

namespace Sistema_de_Gerenciamento
{
    public partial class Forms_PesquisarContasAPagar : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        //private Forms_EditarPagamento editarPagamento = new Forms_EditarPagamento();

        public Forms_EditarPagamentoAPagar editarPagamento;

        private int linhasSelecionadas = 0;

        private decimal valor = 0;

        public Forms_PesquisarContasAPagar(Forms_EditarPagamentoAPagar _editarPagamento)
        {
            InitializeComponent();

            editarPagamento = _editarPagamento;
        }

        public Forms_PesquisarContasAPagar()
        {
            InitializeComponent();

            PreencherDatePicker();

            SetarDesignColunaGridView();
        }

        #region Carregar DatePicker

        private void PreencherDatePicker()
        {
            DateTime data = DateTime.Today;

            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));

            dtpDataFinal.Text = ultimoDiaDoMes.ToString();

            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);

            dtpDataInicial.Text = primeiroDiaDoMes.ToString();
        }

        #endregion Carregar DatePicker

        #region Preencher ComboBox Titulo

        private void PreencherComboBoxTitulo()
        {
            cmbTitulo.Items.Clear();

            List<string> listaTitulo = new List<string>();

            listaTitulo = Buscar.BuscarTitulo(cmbCategoria.Text, cmbTipo.Text);

            listaTitulo.ForEach(titulo => cmbTitulo.Items.Add(titulo));
        }

        #endregion Preencher ComboBox Titulo

        #region Preencher Label Numero de Lancamentos Selecionados

        private void NumeroLancamentosSelecionado()
        {
            lblNumeroLancamentos.Text = gdvContarPagar.RowCount.ToString();
        }

        #endregion Preencher Label Numero de Lancamentos Selecionados

        #region Preencher Label Com Os Valores de Contas Pagas

        private void ValorContasPagas()
        {
            lblPagas.Text = string.Format("R$ {0:#,##0.00}", Buscar.BuscarValorDespesaCustoPagas(dtpDataInicial.Value, dtpDataFinal.Value));
        }

        #endregion Preencher Label Com Os Valores de Contas Pagas

        #region Preencher Label Com Os Valores Total de Contas Pagas

        private void TotalPagamento()
        {
            lblTotalPagamento.Text = String.Format("{0:C}", Buscar.BuscarValorTotalDespesaCustoPagas());
        }

        #endregion Preencher Label Com Os Valores Total de Contas Pagas

        #region Preencher Label Com Os Valores de Contas Nao Pagas

        private void ValorContasAPagar()
        {
            lblAPagar.Text = string.Format("R$ {0:#,##0.00}", Buscar.BuscarValorDespesaCustoNaoPagas(dtpDataInicial.Value, dtpDataFinal.Value));
        }

        #endregion Preencher Label Com Os Valores de Contas Nao Pagas

        #region Preencher Label Com Valores Vencidos

        private void BuscarContasVencidas()
        {
            lblVencidas.Text = string.Format("R$ {0:#,##0.00}", Buscar.BuscarValorDespesaCustoVencidas(dtpDataInicial.Value, dtpDataFinal.Value));
        }

        #endregion Preencher Label Com Valores Vencidos

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            valor = 0;

            linhasSelecionadas = 0;

            PesquisarDespesaCusto();

            NumeroLancamentosSelecionado();

            ValorContasPagas();

            TotalPagamento();

            ValorContasAPagar();

            BuscarContasVencidas();
        }

        #region Pesquisar Despesa e Custo por Codigo,Titulo, Descricao e Status do Pagamento

        private void PesquisarDespesaCusto()
        {
            if (txtCodigoDespesa.Text != string.Empty && cmbPagamento.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarDespesaCustoPorCogigoStatusPagamento(Convert.ToInt32(txtCodigoDespesa.Text), gdvContarPagar,
                    dtpDataInicial.Value, dtpDataFinal.Value, cmbPagamento.Text);

                MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
            }
            else if (cmbTitulo.Text != string.Empty && cmbPagamento.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarDespesaCustoPorTituloStatusPagamento(cmbTitulo.Text, gdvContarPagar, dtpDataInicial.Value, dtpDataFinal.Value,
                    cmbPagamento.Text);

                MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
            }
            else if (txtDescricao.Text != string.Empty && cmbPagamento.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarDespesaCustoPorDescricaoStatusPagamento(txtDescricao.Text, gdvContarPagar, dtpDataInicial.Value, dtpDataFinal.Value,
                    cmbPagamento.Text);

                MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
            }
            else if (txtCodigoDespesa.Text != string.Empty && cmbPagamento.Text == string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarDespesaCustoPorCogigo(Convert.ToInt32(txtCodigoDespesa.Text), gdvContarPagar, dtpDataInicial.Value, dtpDataFinal.Value);

                MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
            }
            else if (cmbTitulo.Text != string.Empty && cmbPagamento.Text == string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarDespesaCustoPorTitulo(cmbTitulo.Text, gdvContarPagar, dtpDataInicial.Value, dtpDataFinal.Value);

                MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
            }
            else if (txtDescricao.Text != string.Empty && cmbPagamento.Text == string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarDespesaCustoPorDescricao(txtDescricao.Text, gdvContarPagar, dtpDataInicial.Value, dtpDataFinal.Value);

                MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
            }
            else if (cmbPagamento.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarDespesaCustoPorStatusPagamento(cmbPagamento.Text, gdvContarPagar, dtpDataInicial.Value, dtpDataFinal.Value);

                MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Exibir Todas As Despesa/Custo?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    bool isCadastroExiste = Buscar.BuscarDespesaCusto(gdvContarPagar, dtpDataInicial.Value, dtpDataFinal.Value);

                    MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
                }
            }
        }

        private void MenssagemDespesaCustoNaoEncontrado(bool _isCadastroExiste)
        {
            if (_isCadastroExiste == false)
            {
                MessageBox.Show("Despesa/Custo Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion Pesquisar Despesa e Custo por Codigo,Titulo, Descricao e Status do Pagamento

        private void dtpDataFinal_Leave(object sender, EventArgs e)
        {
            if (dtpDataInicial.Value > dtpDataFinal.Value)
            {
                MessageBox.Show("A Data Final Esta Maior Que a Data Inicial!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtpDataFinal.Focus();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Setar o Design Do Forms

        private void SetarDesignColunaGridView()
        {
            this.gdvContarPagar.Columns["dc_valor"].DefaultCellStyle.Format = "c";
            this.gdvContarPagar.Columns["dc_valor_parcela"].DefaultCellStyle.Format = "c";
        }

        #endregion Setar o Design Do Forms

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtCodigoDespesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherComboBoxTitulo();

            if (cmbTipo.Text == String.Empty)
            {
                cmbCategoria.Text = String.Empty;
                cmbTitulo.Text = String.Empty;
            }
        }

        private void cmbTitulo_Enter(object sender, EventArgs e)
        {
            if (cmbCategoria.Text == String.Empty)
            {
                MessageBox.Show("Por Favor Primeiro Preencher o Campo Categoria!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
            }
            else if (cmbTipo.Text == String.Empty)
            {
                MessageBox.Show("Por Favor Primeiro Preencher o Campo Tipo!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipo.Focus();
            }
        }

        private void cmbTipo_Enter(object sender, EventArgs e)
        {
            if (cmbCategoria.Text == String.Empty)
            {
                MessageBox.Show("Por Favor Primeiro Preencher o Campo Categoria!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir.ImprimirGridView("Relatorio de Despesas/Custos", gdvContarPagar);
        }

        private void btnExportarParaExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel.GerarExcel(gdvContarPagar);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            AbrirPreencherEditarPagamento();
        }

        private void gdvContarPagar_DoubleClick(object sender, EventArgs e)
        {
            AbrirPreencherEditarPagamento();
        }

        #region Abrir Tela de Edicao de Pagametno e Preencher Editar Pagamento

        private void AbrirPreencherEditarPagamento()
        {
            if (gdvContarPagar.Rows.Count > 0)
            {
                Forms_EditarPagamentoAPagar editarPagamento = new Forms_EditarPagamentoAPagar(this);

                int indice = 2;

                editarPagamento.txtCodigo.Text = gdvContarPagar.SelectedCells[indice += 1].Value.ToString();
                editarPagamento.txtTipoDespesa.Text = gdvContarPagar.SelectedCells[indice += 1].Value.ToString();
                editarPagamento.txtTitulo.Text = gdvContarPagar.SelectedCells[indice += 1].Value.ToString();
                editarPagamento.txtDescricao.Text = gdvContarPagar.SelectedCells[indice += 1].Value.ToString();
                editarPagamento.txtCNPJ.Text = gdvContarPagar.SelectedCells[indice += 1].Value.ToString();
                editarPagamento.txtEmissao.Text = Convert.ToDateTime(gdvContarPagar.SelectedCells[indice += 1].Value).ToShortDateString();
                editarPagamento.txtVencimento.Text = Convert.ToDateTime(gdvContarPagar.SelectedCells[indice += 1].Value).ToShortDateString();
                editarPagamento.txtValor.Text = String.Format("{0:C}", (gdvContarPagar.SelectedCells[indice += 2].Value));
                editarPagamento.txtQuantParcelas.Text = gdvContarPagar.SelectedCells[indice += 1].Value.ToString();
                editarPagamento.txtValorParcela.Text = String.Format("{0:C}", (gdvContarPagar.SelectedCells[indice += 1].Value));
                editarPagamento.lblVerificacaoPagamento.Text = gdvContarPagar.SelectedCells[indice += 2].Value.ToString();

                //for (int i = 1; i < 30; i++)
                //{
                //    MessageBox.Show($"{i} = {gdvContarPagar.SelectedCells[i].Value.ToString()}");
                //}

                //verificar se o pagamento foi realizado
                if (gdvContarPagar.SelectedCells[20].Value.ToString() == "0,00")
                {
                    editarPagamento.txtValorPago.Text = String.Format("{0:C}", (gdvContarPagar.SelectedCells[13].Value));
                }
                else
                {
                    editarPagamento.txtDataPagamento.Text = Convert.ToDateTime(gdvContarPagar.SelectedCells[17].Value).ToShortDateString();
                    editarPagamento.txtDescontoTaxas.Text = String.Format("{0:P}", Convert.ToDecimal(gdvContarPagar.SelectedCells[18].Value) / 100);
                    editarPagamento.txtJurosMulta.Text = String.Format("{0:P}", Convert.ToDecimal(gdvContarPagar.SelectedCells[19].Value) / 100);
                    editarPagamento.txtValorPago.Text = String.Format("{0:C}", gdvContarPagar.SelectedCells[20].Value);
                }

                editarPagamento.ShowDialog();
            }
        }

        #endregion Abrir Tela de Edicao de Pagametno e Preencher Editar Pagamento

        private void gdvContarPagar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecaoGridView(e);
        }

        #region Selecao GridView

        private void SelecaoGridView(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                DataGridViewRow linha = gdvContarPagar.Rows[e.RowIndex];

                linha.Cells[0].Value = !Convert.ToBoolean(linha.Cells[0].EditedFormattedValue);

                if (Convert.ToBoolean(linha.Cells[0].Value) == true)
                {
                    valor += Convert.ToDecimal(linha.Cells[12].Value);

                    linhasSelecionadas++;
                }
                else
                {
                    valor -= Convert.ToDecimal(linha.Cells[12].Value);

                    linhasSelecionadas--;
                }
            }

            lblTotalLancamentoSelecionado.Text = String.Format("{0:C}", valor);

            lblNumeroLancamentosSelecionados.Text = linhasSelecionadas.ToString();
        }

        #endregion Selecao GridView

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.Text == String.Empty)
            {
                cmbTipo.Text = String.Empty;
                cmbTitulo.Text = String.Empty;
            }
        }
    }
}