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
    public partial class Forms_BuscaAvancadaNFEntrada : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        public Forms_BuscaAvancadaNFEntrada()
        {
            InitializeComponent();

            PreencherDatePicker();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscarNotaFiscal();

            SetarDisingColunasValoresGridView();
        }

        private void PreencherDatePicker()
        {
            DateTime data = DateTime.Today;

            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));

            dtpDataFinal.Text = ultimoDiaDoMes.ToString();

            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);

            dtpDataInicial.Text = primeiroDiaDoMes.ToString();
        }

        private void Forms_BuscaAvancadaNFEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                BuscarNotaFiscal();
            }
        }

        private void BuscarNotaFiscal()
        {
            bool isExisteNF = Buscar.BuscarAvancadaNFEntrada(dtpDataInicial.Value, dtpDataFinal.Value, gdvBuscaAvancadaNFEntrada);

            if (isExisteNF == false)
            {
                MessageBox.Show("Nenhuma Nota Fiscal Encontrada!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel.GerarExcel(gdvBuscaAvancadaNFEntrada);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir.ImprimirGridView("Relatorio de Nota Fiscal Entrada", gdvBuscaAvancadaNFEntrada);
        }

        private void SetarDisingColunasValoresGridView()
        {
            this.gdvBuscaAvancadaNFEntrada.Columns["ne_valor_unitario"].DefaultCellStyle.Format = "c";
            this.gdvBuscaAvancadaNFEntrada.Columns["ne_valor_total"].DefaultCellStyle.Format = "c";
        }
    }
}