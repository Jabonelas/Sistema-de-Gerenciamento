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

        private DataPoint colunas;

        private decimal valorContasPagas = 0;

        private decimal valorContasAReceberAtrasadas = 0;

        private decimal valorContasAPagarAtrasadas = 0;

        private decimal valorProdutos = 0;

        private decimal valorBrutoNotaFinalSaida = 0;

        private decimal valorBrutoCarne = 0;

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
            BuscarValores();

            ValorBruto();

            ValorProdutos();

            ValorContasPagas();

            ValorLiquido();

            ValorContasAPagarAtrasadas();

            ValorContasAReceberAtrasadas();
        }

        private void BuscarValores()
        {
            valorContasAReceberAtrasadas = Buscar.BuscarValorContasAReceberAtrasadas(dtpDataInicial.Value, dtpDataFinal.Value);

            valorContasAPagarAtrasadas = Buscar.BuscarValorContasComPagamentoAtrasadoPorData(dtpDataInicial.Value, dtpDataFinal.Value);

            valorContasPagas = Buscar.BuscarValorContasPagasPorData(dtpDataInicial.Value, dtpDataFinal.Value);

            valorProdutos = Buscar.BuscarValorProdutoPorData(dtpDataInicial.Value, dtpDataFinal.Value);

            valorBrutoNotaFinalSaida = Buscar.ValorBrutoNotaFinalSaidaPorData(dtpDataInicial.Value, dtpDataFinal.Value);

            valorBrutoCarne = Buscar.BuscarValorBrutoCarnePorData(dtpDataInicial.Value, dtpDataFinal.Value);
        }

        private void ValorLiquido()
        {
            lblValorTotalLiquido.Text = String.Format("{0:c}", (valorBrutoNotaFinalSaida + valorBrutoCarne) - (valorContasPagas + valorProdutos));
        }

        private void ValorContasAReceberAtrasadas()
        {
            lblContasAReceberAtrasadas.Text = String.Format("{0:c}", valorContasAReceberAtrasadas);
        }

        private void ValorContasAPagarAtrasadas()
        {
            lblContasAPagarAtrasadas.Text = String.Format("{0:c}", valorContasAPagarAtrasadas);
        }

        private void ValorContasPagas()
        {
            lblValorTotalContasPagas.Text = String.Format("{0:c}", valorContasPagas);
        }

        private void ValorProdutos()
        {
            lblValorTotalProduto.Text = String.Format("{0:c}", valorProdutos);
        }

        private void ValorBruto()
        {
            lblValorTotalBruto.Text = String.Format("{0:c}", valorBrutoCarne + valorBrutoNotaFinalSaida);
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            Canvas canvas = new Canvas();

            colunas = new DataPoint(BunifuDataViz._type.Bunifu_column);

            ColunaValorBruto(canvas, colunas);

            ColunaValorLiquido(canvas, colunas);

            ColunaValorProduto(canvas, colunas);

            ColunaValorContasPagas(canvas, colunas);

            ColunaValorContasAPagarAtrasadas(canvas, colunas);

            ColunaValorContasAReceberAtrasadas(canvas, colunas);

            canvas.addData(colunas);

            bunifuDataViz1.Render(canvas);
        }

        private void ColunaValorBruto(Canvas canvas, DataPoint _colunas)
        {
            string valorBruto = (valorBrutoCarne + valorBrutoNotaFinalSaida).ToString("N0").Replace(".", "");

            _colunas.addLabely("VB", valorBruto);

            bunifuDataViz1.colorSet.Add(Color.Aqua);
        }

        private void ColunaValorLiquido(Canvas canvas, DataPoint _colunas)
        {
            string valorLiquido = ((valorBrutoNotaFinalSaida + valorBrutoCarne) - (valorContasPagas + valorProdutos)).ToString("N0").Replace(".", "");

            _colunas.addLabely("VL", valorLiquido);

            bunifuDataViz1.colorSet.Add(Color.Black);
        }

        private void ColunaValorProduto(Canvas canvas, DataPoint _colunas)
        {
            string valorProduto = valorProdutos.ToString("N0").Replace(".", "");

            _colunas.addLabely("VP", valorProduto);

            bunifuDataViz1.colorSet.Add(Color.Red);
        }

        private void ColunaValorContasPagas(Canvas canvas, DataPoint _colunas)
        {
            string valorContasPaga = valorContasPagas.ToString("N0").Replace(".", "");

            _colunas.addLabely("CP", valorContasPagas);

            bunifuDataViz1.colorSet.Add(Color.Green);
        }

        private void ColunaValorContasAPagarAtrasadas(Canvas canvas, DataPoint _colunas)
        {
            string valorContasAPagarAtrasada = valorContasAPagarAtrasadas.ToString("N0").Replace(".", "");

            _colunas.addLabely("CPA", valorContasAPagarAtrasada);

            bunifuDataViz1.colorSet.Add(Color.Gray);
        }

        private void ColunaValorContasAReceberAtrasadas(Canvas canvas, DataPoint _colunas)
        {
            string valorContasAReceberAtrasada = valorContasAReceberAtrasadas.ToString("N0").Replace(".", "");

            _colunas.addLabely("CRA", valorContasAReceberAtrasada);

            bunifuDataViz1.colorSet.Add(Color.Yellow);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            List<DadosEstatiscasFinanceiras> ContasPagas = new List<DadosEstatiscasFinanceiras>();

            List<DadosEstatiscasFinanceiras> ContasAtrasadas = new List<DadosEstatiscasFinanceiras>();

            List<DadosEstatiscasFinanceiras> listaCompleta = new List<DadosEstatiscasFinanceiras>();

            ContasPagas = Buscar.BuscarValorContasPagasPorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            ContasAtrasadas = Buscar.BuscarValorContasAtrasadasPorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            Canvas canvas = new Canvas();

            colunas = new DataPoint(BunifuDataViz._type.Bunifu_column);

            foreach (var item in ContasPagas)
            {
                listaCompleta.Add(new DadosEstatiscasFinanceiras(item.valor, item.mes));

                //string valorContasPaga = item.valor.ToString("N0").Replace(".", "");

                //colunas.addLabely(item.mes.ToString(), valorContasPaga);

                //bunifuDataViz1.colorSet.Add(Color.Green);
            }

            foreach (var item1 in ContasAtrasadas)
            {
                listaCompleta.Add(new DadosEstatiscasFinanceiras(item1.valor, item1.mes));

                //string valorContasAPagarAtrasada = item1.valor.ToString("N0").Replace(".", "");

                //colunas.addLabely(item1.mes.ToString(), valorContasAPagarAtrasada);

                //bunifuDataViz1.colorSet.Add(Color.Gray);
            }

            int cont = 0;

            foreach (var item in listaCompleta)
            {
                if (cont == 0)
                {
                    string valorContasPaga = item.valor.ToString("N0").Replace(".", "");

                    colunas.addLabely(item.mes.ToString(), valorContasPaga);

                    bunifuDataViz1.colorSet.Add(Color.Green);

                    cont++;
                }

                if (item.mes == 5)
                {
                    string valorContasAPagarAtrasada = item.valor.ToString("N0").Replace(".", "");

                    colunas.addLabely(item.mes.ToString(), valorContasAPagarAtrasada);

                    bunifuDataViz1.colorSet.Add(Color.Gray);
                }
            }

            canvas.addData(colunas);

            bunifuDataViz1.Render(canvas);
        }

        private void estavadandocerto()
        {
            List<DadosEstatiscasFinanceiras> ContasPagas = new List<DadosEstatiscasFinanceiras>();

            List<DadosEstatiscasFinanceiras> ContasAtrasadas = new List<DadosEstatiscasFinanceiras>();

            ContasPagas = Buscar.BuscarValorContasPagasPorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            ContasAtrasadas = Buscar.BuscarValorContasAtrasadasPorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            Canvas canvas = new Canvas();

            colunas = new DataPoint(BunifuDataViz._type.Bunifu_column);

            foreach (var item in ContasPagas)
            {
                string valorContasPaga = item.valor.ToString("N0").Replace(".", "");

                colunas.addLabely(item.mes.ToString(), valorContasPaga);

                bunifuDataViz1.colorSet.Add(Color.Green);
            }

            foreach (var item1 in ContasAtrasadas)
            {
                string valorContasAPagarAtrasada = item1.valor.ToString("N0").Replace(".", "");

                colunas.addLabely(item1.mes.ToString(), valorContasAPagarAtrasada);

                bunifuDataViz1.colorSet.Add(Color.Gray);

                //break;
            }

            canvas.addData(colunas);

            bunifuDataViz1.Render(canvas);
        }
    }
}