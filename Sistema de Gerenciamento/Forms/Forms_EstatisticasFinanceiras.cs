using Bunifu.DataViz.WinForms;
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
    public partial class Forms_EstatisticasFinanceiras : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private DataPoint colunaValorBruto;

        private DataPoint colunaValorLiquido;

        private DataPoint colunaValorProduto;

        private DataPoint colunaValorContasPagas;

        private DataPoint colunaaValorContasAPagarAtrasadas;

        private DataPoint colunaaValorContasAReceberAtrasadas;

        public Forms_EstatisticasFinanceiras()
        {
            InitializeComponent();

            PreencherDatePicker();
        }

        private void PreencherDatePicker()
        {
            DateTime data = DateTime.Today;

            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));

            dtpDataFinal.Text = ultimoDiaDoMes.ToString();

            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);

            dtpDataInicial.Text = primeiroDiaDoMes.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ValorBruto();

            ValorProdutos();

            ValorContasPagas();

            ValorLiquido();

            ValorContasAPagarAtrasadas();

            ValorContasAreceberAtrasadas();
        }

        private void ValorLiquido()
        {
            decimal valorBruto = Convert.ToDecimal(lblValorTotalBruto.Text.Replace("R$", ""));

            decimal valorContasPagas = Convert.ToDecimal(lblValorTotalContasPagas.Text.Replace("R$", ""));

            decimal valorProduto = Convert.ToDecimal(lblValorTotalProduto.Text.Replace("R$", ""));

            lblValorTotalLiquido.Text = String.Format("{0:c}", valorBruto - (valorContasPagas + valorProduto));
        }

        private void ValorContasAreceberAtrasadas()
        {
            lblContasAReceberAtrasadas.Text = String.Format("{0:c}", Buscar.BuscarValorContasAReceberAtrasadas(dtpDataInicial.Value, dtpDataFinal.Value));
        }

        private void ValorContasAPagarAtrasadas()
        {
            lblContasAPagarAtrasadas.Text = String.Format("{0:c}", Buscar.BuscarValorCustoDespesasComPagamentoAtrasadoPorData(dtpDataInicial.Value, dtpDataFinal.Value));
        }

        private void ValorContasPagas()
        {
            lblValorTotalContasPagas.Text = String.Format("{0:c}", Buscar.BuscarValorCustoDespesasPagosPorData(dtpDataInicial.Value, dtpDataFinal.Value));
        }

        private void ValorProdutos()
        {
            lblValorTotalProduto.Text = String.Format("{0:c}", Buscar.BuscarValorProdutoPorData(dtpDataInicial.Value, dtpDataFinal.Value));
        }

        private void ValorBruto()
        {
            decimal valorBrutoNotaFinalSaida = Buscar.ValorBrutoNotaFinalSaidaPorData(dtpDataInicial.Value, dtpDataFinal.Value);

            decimal ValorBrutoCarne = Buscar.BuscarValorBrutoCarnePorData(dtpDataInicial.Value, dtpDataFinal.Value);

            lblValorTotalBruto.Text = String.Format("{0:c}", ValorBrutoCarne + valorBrutoNotaFinalSaida);
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            Canvas canvas = new Canvas();

            ColunaValorBruto(canvas);

            ColunaValorLiquido(canvas);

            ColunaValorProduto(canvas);

            ColunaValorContasPagas(canvas);

            ColunaValorContasAPagarAtrasadas(canvas);

            ColunaValorContasAReceberAtrasadas(canvas);

            bunifuDataViz1.Render(canvas);
        }

        private void ColunaValorBruto(Canvas canvas)
        {
            colunaValorBruto = new DataPoint(BunifuDataViz._type.Bunifu_column);

            decimal valorDecimal = Convert.ToDecimal(lblValorTotalBruto.Text.Replace("R$", ""));

            string valorBruto = valorDecimal.ToString("N0");

            colunaValorBruto.addLabely("VB", valorBruto);

            bunifuDataViz1.colorSet.Add(Color.Aqua);

            canvas.addData(colunaValorBruto);
        }

        private void ColunaValorLiquido(Canvas canvas)
        {
            colunaValorLiquido = new DataPoint(BunifuDataViz._type.Bunifu_column);

            decimal valorDecimal = Convert.ToDecimal(lblValorTotalLiquido.Text.Replace("R$ ", ""));

            string valorLiquido = valorDecimal.ToString("N0");

            colunaValorLiquido.addLabely("VL", valorLiquido);

            bunifuDataViz1.colorSet.Add(Color.Black);

            canvas.addData(colunaValorLiquido);
        }

        private void ColunaValorProduto(Canvas canvas)
        {
            colunaValorProduto = new DataPoint(BunifuDataViz._type.Bunifu_column);

            decimal valorDecimal = Convert.ToDecimal(lblValorTotalProduto.Text.Replace("R$", ""));

            string valorProduto = valorDecimal.ToString("N0");

            colunaValorLiquido.addLabely("VP", valorProduto);

            bunifuDataViz1.colorSet.Add(Color.Red);

            canvas.addData(colunaValorProduto);
        }

        private void ColunaValorContasPagas(Canvas canvas)
        {
            colunaValorContasPagas = new DataPoint(BunifuDataViz._type.Bunifu_column);

            decimal valorDecimal = Convert.ToDecimal(lblValorTotalContasPagas.Text.Replace("R$", ""));

            string valorContasPagas = valorDecimal.ToString("N0");

            colunaValorLiquido.addLabely("VC", valorContasPagas);

            bunifuDataViz1.colorSet.Add(Color.Green);

            canvas.addData(colunaValorContasPagas);
        }

        private void ColunaValorContasAPagarAtrasadas(Canvas canvas)
        {
            colunaaValorContasAPagarAtrasadas = new DataPoint(BunifuDataViz._type.Bunifu_column);

            decimal valorDecimal = Convert.ToDecimal(lblContasAPagarAtrasadas.Text.Replace("R$", ""));

            string valorContasAPagarAtrasdas = valorDecimal.ToString("N0");

            colunaValorLiquido.addLabely("VCA", valorContasAPagarAtrasdas);

            bunifuDataViz1.colorSet.Add(Color.Gray);

            canvas.addData(colunaaValorContasAPagarAtrasadas);
        }

        private void ColunaValorContasAReceberAtrasadas(Canvas canvas)
        {
            colunaaValorContasAReceberAtrasadas = new DataPoint(BunifuDataViz._type.Bunifu_column);

            decimal valorDecimal = Convert.ToDecimal(lblContasAReceberAtrasadas.Text.Replace("R$", ""));

            string valorContasAReceber = valorDecimal.ToString("N0");

            colunaValorLiquido.addLabely("CRA", valorContasAReceber);

            bunifuDataViz1.colorSet.Add(Color.Yellow);

            canvas.addData(colunaaValorContasAReceberAtrasadas);
        }
    }
}