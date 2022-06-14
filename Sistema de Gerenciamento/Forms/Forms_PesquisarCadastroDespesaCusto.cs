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
    public partial class Forms_PesquisarCadastroDespesaCusto : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private Forms_CadastroDespesasCusto cadastroDespesas;

        public Forms_PesquisarCadastroDespesaCusto(Forms_CadastroDespesasCusto _cadastroDespesas)
        {
            InitializeComponent();

            cadastroDespesas = _cadastroDespesas;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarDespesa();
        }

        #region Pesquisar Despesa

        private void PesquisarDespesa()
        {
            if (txtCodigoDespesa.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroDespesaPorCodigo(Convert.ToInt32(txtCodigoDespesa.Text), gdvPesquisarDespesaCusto);

                MensagemDespesaCustoNaoEncontrada(isCadastroExiste);
            }
            else if (txtDescricao.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroDespesaPorDescricao(txtDescricao.Text, gdvPesquisarDespesaCusto);

                MensagemDespesaCustoNaoEncontrada(isCadastroExiste);
            }
            else if (txtTipo.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroDespesaPorTipo(txtTipo.Text, gdvPesquisarDespesaCusto);

                MensagemDespesaCustoNaoEncontrada(isCadastroExiste);
            }
            else if (cmbCategoria.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroDespesaPorCategoria(cmbCategoria.Text, gdvPesquisarDespesaCusto);

                MensagemDespesaCustoNaoEncontrada(isCadastroExiste);
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Exibir Todos As Despesas/Custos?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    bool isCadastroExiste = Buscar.BuscarCadastroTudoDespesa(gdvPesquisarDespesaCusto);

                    MensagemDespesaCustoNaoEncontrada(isCadastroExiste);
                }
            }
        }

        private void MensagemDespesaCustoNaoEncontrada(bool _isCadastroExiste)
        {
            if (_isCadastroExiste == false)
            {
                MessageBox.Show("Despesa/Custo Não Encontrada ", "Não Encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion Pesquisar Despesa

        private void btnExportarParaExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel.GerarExcel(gdvPesquisarDespesaCusto);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir.ImprimirGridView("Relatorio de Cadastro de Despesa e Custos", gdvPesquisarDespesaCusto);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            SelecaoGridViewPreencherTextBox();
        }

        private void gdvPesquisarDespesa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecaoGridViewPreencherTextBox();
        }

        #region Selecionar Linha No GridView Para Preencher TextBox

        private void SelecaoGridViewPreencherTextBox()
        {
            if (gdvPesquisarDespesaCusto.RowCount >= 1)
            {
                int indice = -1;

                cadastroDespesas.txtCodigo.Text = gdvPesquisarDespesaCusto.SelectedCells[indice += 1].Value.ToString();

                cadastroDespesas.txtTitulo.Text = gdvPesquisarDespesaCusto.SelectedCells[indice += 1].Value.ToString();

                cadastroDespesas.cmbTipo.Text = gdvPesquisarDespesaCusto.SelectedCells[indice += 1].Value.ToString();

                if (gdvPesquisarDespesaCusto.SelectedCells[indice += 1].Value.ToString() == "Despesa")
                {
                    cadastroDespesas.chbDespesa.Checked = true;
                    cadastroDespesas.chbCusto.Checked = false;
                }
                else if (gdvPesquisarDespesaCusto.SelectedCells[indice].Value.ToString() == "Custo")
                {
                    cadastroDespesas.chbCusto.Checked = true;
                    cadastroDespesas.chbDespesa.Checked = false;
                }

                this.Close();
            }
        }

        #endregion Selecionar Linha No GridView Para Preencher TextBox

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetras(e);
        }

        private void txtCodigoDespesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetras(e);
        }
    }
}