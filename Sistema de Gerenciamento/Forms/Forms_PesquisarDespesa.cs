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
                bool isCadastroExiste = Buscar.BuscarCadastroDespesaPorCodigo(Convert.ToInt32(txtCodigoDespesa.Text), gdvPesquisarDespesa);

                MensagemDespesaNaoEncontrada(isCadastroExiste);
            }
            else if (txtDescricao.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroDespesaPorDescricao(txtDescricao.Text, gdvPesquisarDespesa);

                MensagemDespesaNaoEncontrada(isCadastroExiste);
            }
            else if (txtTipo.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroDespesaPorTipo(txtTipo.Text, gdvPesquisarDespesa);

                MensagemDespesaNaoEncontrada(isCadastroExiste);
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Exibir Todos As Despesas?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    bool isCadastroExiste = Buscar.BuscarCadastroTudoDespesa(gdvPesquisarDespesa);

                    MensagemDespesaNaoEncontrada(isCadastroExiste);
                }
            }
        }

        private void MensagemDespesaNaoEncontrada(bool _isCadastroExiste)
        {
            if (_isCadastroExiste == false)
            {
                MessageBox.Show("Despesa Não Encontrada ", "Não Encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion Pesquisar Despesa

        private void btnExportarParaExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel.GerarExcel(gdvPesquisarDespesa);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir.ImprimirGridView("Relatorio de Despesa", gdvPesquisarDespesa);
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
            if (gdvPesquisarDespesa.RowCount >= 1)
            {
                int indice = -1;

                cadastroDespesas.txtCodigo.Text = gdvPesquisarDespesa.SelectedCells[indice += 1].Value.ToString();

                cadastroDespesas.txtDescricao.Text = gdvPesquisarDespesa.SelectedCells[indice += 1].Value.ToString();

                cadastroDespesas.txtTipo.Text = gdvPesquisarDespesa.SelectedCells[indice += 1].Value.ToString();

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
    }
}