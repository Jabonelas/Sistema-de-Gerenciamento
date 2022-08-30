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
using DevExpress.XtraCharts;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_EstatisticasFinanceiras : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private List<DadosListaValorBruto> listaDadosListaValorBruto = new List<DadosListaValorBruto>();

        private List<DadosProduto> listaValorProduto = new List<DadosProduto>();

        private List<DadosEstatiscasFinanceiras> listaValorContasPagas = new List<DadosEstatiscasFinanceiras>();

        private string nomeMesPorExtenco = string.Empty;

        public Forms_EstatisticasFinanceiras()
        {
            InitializeComponent();

            PreencherDatePicker();

            sqlDataSource1.FillAsync();

            ValorBruto();

            ValorLiquido();

            ValorProduto();

            ValorContasPagas();

            ValorContasAPagar();

            ValorContasAReceber();
        }

        private void Forms_EstatisticasFinanceiras_Load(object sender, EventArgs e)
        {
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            BuscarEstatisticasFinanceiras();
        }

        private void BuscarEstatisticasFinanceiras()
        {
            DeletarColunaValorBruto();
            ValorBruto();

            DeletarValorLiquido();
            ValorLiquido();

            DeletarValorProduto();
            ValorProduto();

            DeletarValorContasPagas();
            ValorContasPagas();

            DeletarValorContasAPagar();
            ValorContasAPagar();

            DeletarValorContasAReceber();
            ValorContasAReceber();
        }

        private void DeletarColunaValorBruto()
        {
            var indeceValorBruto = chrEstatisicasFinanceiras.Series.First(x => x.Name == "Valor Bruto");
            chrEstatisicasFinanceiras.Series.Remove((Series)indeceValorBruto);
        }

        private void DeletarValorLiquido()
        {
            var indeceValorLiquido = chrEstatisicasFinanceiras.Series.First(x => x.Name == "Valor Liquido");
            chrEstatisicasFinanceiras.Series.Remove((Series)indeceValorLiquido);
        }

        private void DeletarValorProduto()
        {
            var indeceValorProduto = chrEstatisicasFinanceiras.Series.First(x => x.Name == "Valor Produto");
            chrEstatisicasFinanceiras.Series.Remove((Series)indeceValorProduto);
        }

        private void DeletarValorContasPagas()
        {
            var indeceValorContasPagas = chrEstatisicasFinanceiras.Series.First(x => x.Name == "Valor Contas Pagas");
            chrEstatisicasFinanceiras.Series.Remove((Series)indeceValorContasPagas);
        }

        private void DeletarValorContasAPagar()
        {
            var indiceValorContasAPagar = chrEstatisicasFinanceiras.Series.First(x => x.Name == "Valor Contas A Pagar");
            chrEstatisicasFinanceiras.Series.Remove((Series)indiceValorContasAPagar);
        }

        private void DeletarValorContasAReceber()
        {
            var indeceValorContasAReceber = chrEstatisicasFinanceiras.Series.First(x => x.Name == "Valor Contas A Receber");
            chrEstatisicasFinanceiras.Series.Remove((Series)indeceValorContasAReceber);
        }

        private void ValorBruto()
        {
            Series series = new Series("Valor Bruto", ViewType.Bar);

            GerarColunaValorBruto(series);
        }

        private void ValorLiquido()
        {
            Series series = new Series("Valor Liquido", ViewType.Bar);

            GerarColunaValorLiquido(series);
        }

        private void ValorProduto()
        {
            Series series = new Series("Valor Produto", ViewType.Bar);

            GerarColunaValorProduto(series);
        }

        private void ValorContasPagas()
        {
            Series series = new Series("Valor Contas Pagas", ViewType.Bar);

            GerarColunaValorContasPagas(series);
        }

        private void ValorContasAPagar()
        {
            Series series = new Series("Valor Contas A Pagar", ViewType.Bar);

            GerarColunaValorContasAPagar(series);
        }

        private void ValorContasAReceber()
        {
            Series series = new Series("Valor Contas A Receber", ViewType.Bar);

            GerarColunaValorContasAReceber(series);
        }

        private void PreencherDatePicker()
        {
            DateTime data = DateTime.Today;

            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));

            dtpDataFinal.Text = ultimoDiaDoMes.ToString();

            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);

            dtpDataInicial.Text = primeiroDiaDoMes.ToString();
        }

        private DataTable CreateChartData()
        {
            DataTable table = new DataTable("Table");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PercorrerListaValorProduto(table);

            return table;
        }

        private DataTable CreateChartData1()
        {
            DataTable table = new DataTable("Table1");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PercorrerListaValorBruto(table);

            return table;
        }

        private DataTable CreateChartData2()
        {
            DataTable table = new DataTable("Table2");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PercorrerListaContasAtrasadasAReceber(table);

            return table;
        }

        private DataTable CreateChartData3()
        {
            DataTable table = new DataTable("Table3");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PercorrerListaContasAtrasadasAPagar(table);

            return table;
        }

        private DataTable CreateChartData4()
        {
            DataTable table = new DataTable("Table4");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PercorrerListaContasPagas(table);

            return table;
        }

        private DataTable CreateChartData5()
        {
            DataTable table = new DataTable("Table5");

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            PercorrerListaValorLiquido(table);

            return table;
        }

        private string VerificarMesEscreverPorExtenso(int _mes)
        {
            string escreverMesPorExtenco = "";

            switch (_mes)
            {
                case 1:

                    escreverMesPorExtenco = "Janeiro";
                    return escreverMesPorExtenco;

                case 2:

                    escreverMesPorExtenco = "Fevereiro";
                    return escreverMesPorExtenco;

                case 3:

                    escreverMesPorExtenco = "Março";
                    return escreverMesPorExtenco;

                case 4:

                    escreverMesPorExtenco = "Abril";
                    return escreverMesPorExtenco;

                case 5:

                    escreverMesPorExtenco = "Maio";
                    return escreverMesPorExtenco;

                case 6:

                    escreverMesPorExtenco = "Junho";
                    return escreverMesPorExtenco;

                case 7:

                    escreverMesPorExtenco = "Julho";
                    return escreverMesPorExtenco;

                case 8:

                    escreverMesPorExtenco = "Agosto";
                    return escreverMesPorExtenco;

                case 9:

                    escreverMesPorExtenco = "Setembro";
                    return escreverMesPorExtenco;

                case 10:

                    escreverMesPorExtenco = "Outubro";
                    return escreverMesPorExtenco;

                case 11:

                    escreverMesPorExtenco = "Novembro";
                    return escreverMesPorExtenco;

                case 12:

                    escreverMesPorExtenco = "Dezembro";
                    return escreverMesPorExtenco;
            }

            return escreverMesPorExtenco;
        }

        private struct DadosListaValorBruto
        {
            public int mes { get; set; }
            public decimal valor { get; set; }

            public DadosListaValorBruto(int _mes, decimal _valor)
            {
                mes = _mes;
                valor = _valor;
            }
        }

        private void PercorrerListaValorBruto(DataTable table)
        {
            List<DadosNotaFiscalSaida> listaValorBrutoNotaFiscalSaida = new List<DadosNotaFiscalSaida>();

            List<DadosPagamentoCarne> listaValorBrutoPagamentoCarne = new List<DadosPagamentoCarne>();

            listaValorBrutoNotaFiscalSaida = Buscar.BuscarValorBrutoNotaFiscalSaidaPorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            listaValorBrutoPagamentoCarne = Buscar.BuscarValorBrutoCarnePorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            DataRow row = null;

            foreach (DadosNotaFiscalSaida valorBrutoNotaFiscalSaida in listaValorBrutoNotaFiscalSaida)
            {
                foreach (DadosPagamentoCarne valorBrutoPagamentoCarne in listaValorBrutoPagamentoCarne)
                {
                    if (valorBrutoNotaFiscalSaida.mes == valorBrutoPagamentoCarne.mes)
                    {
                        nomeMesPorExtenco = VerificarMesEscreverPorExtenso(valorBrutoNotaFiscalSaida.mes);

                        row = table.NewRow();
                        row["Argument"] = nomeMesPorExtenco;
                        row["Value"] = (valorBrutoNotaFiscalSaida.valor + valorBrutoPagamentoCarne.valor);
                        table.Rows.Add(row);

                        listaDadosListaValorBruto.Add(new DadosListaValorBruto(valorBrutoNotaFiscalSaida.mes, (valorBrutoNotaFiscalSaida.valor + valorBrutoPagamentoCarne.valor)));

                        break;
                    }
                }

                if (listaValorBrutoPagamentoCarne.Count == 0)
                {
                    nomeMesPorExtenco = VerificarMesEscreverPorExtenso(valorBrutoNotaFiscalSaida.mes);

                    row = table.NewRow();
                    row["Argument"] = nomeMesPorExtenco;
                    row["Value"] = valorBrutoNotaFiscalSaida.valor;
                    table.Rows.Add(row);

                    listaDadosListaValorBruto.Add(new DadosListaValorBruto(valorBrutoNotaFiscalSaida.mes, valorBrutoNotaFiscalSaida.valor));
                }
            }
        }

        private void PercorrerListaValorProduto(DataTable table)
        {
            listaValorProduto = Buscar.BuscarValorProdutoPorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            DataRow row = null;

            listaValorProduto.ForEach(valorProduto =>
            {
                nomeMesPorExtenco = VerificarMesEscreverPorExtenso(valorProduto.mes);

                row = table.NewRow();
                row["Argument"] = nomeMesPorExtenco;
                row["Value"] = valorProduto.valor;
                table.Rows.Add(row);
            });
        }

        private void PercorrerListaContasAtrasadasAReceber(DataTable table)
        {
            List<DadosContasAReceber> listaValorAReceberContasAtrasadasAReceber = new List<DadosContasAReceber>();

            listaValorAReceberContasAtrasadasAReceber = Buscar.BuscarValorContasAReceberAtrasadasDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            DataRow row = null;

            listaValorAReceberContasAtrasadasAReceber.ForEach(contaAtrasadaAReceber =>
            {
                nomeMesPorExtenco = VerificarMesEscreverPorExtenso(contaAtrasadaAReceber.mes);

                row = table.NewRow();
                row["Argument"] = nomeMesPorExtenco;
                row["Value"] = contaAtrasadaAReceber.valor;
                table.Rows.Add(row);
            });
        }

        private void PercorrerListaContasAtrasadasAPagar(DataTable table)
        {
            List<DadosEstatiscasFinanceiras> listaValorAPagarContasAtrasadasAPagar = new List<DadosEstatiscasFinanceiras>();

            listaValorAPagarContasAtrasadasAPagar = Buscar.BuscarValorContasAtrasadasPorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            DataRow row = null;

            listaValorAPagarContasAtrasadasAPagar.ForEach(contasAtrasadaAPagar =>
            {
                nomeMesPorExtenco = VerificarMesEscreverPorExtenso(contasAtrasadaAPagar.mes);

                row = table.NewRow();
                row["Argument"] = nomeMesPorExtenco;
                row["Value"] = contasAtrasadaAPagar.valor;
                table.Rows.Add(row);
            });
        }

        private void PercorrerListaContasPagas(DataTable table)
        {
            listaValorContasPagas = Buscar.BuscarValorContasPagasPorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            DataRow row = null;

            listaValorContasPagas.ForEach(contasPagas =>
            {
                nomeMesPorExtenco = VerificarMesEscreverPorExtenso(contasPagas.mes);

                row = table.NewRow();
                row["Argument"] = nomeMesPorExtenco;
                row["Value"] = contasPagas.valor;
                table.Rows.Add(row);
            });
        }

        private void PercorrerListaValorLiquido(DataTable table)
        {
            listaValorProduto = Buscar.BuscarValorProdutoPorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            listaValorContasPagas = Buscar.BuscarValorContasPagasPorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            DataRow row = null;

            foreach (DadosProduto valorproduto in listaValorProduto)
            {
                foreach (DadosListaValorBruto valorBruto in listaDadosListaValorBruto)
                {
                    foreach (DadosEstatiscasFinanceiras valorContasPagas in listaValorContasPagas)
                    {
                        if (valorproduto.mes == valorContasPagas.mes && valorproduto.mes == valorBruto.mes)
                        {
                            nomeMesPorExtenco = VerificarMesEscreverPorExtenso(valorproduto.mes);

                            row = table.NewRow();
                            row["Argument"] = nomeMesPorExtenco;
                            row["Value"] = (valorBruto.valor - (valorContasPagas.valor + valorproduto.valor));
                            table.Rows.Add(row);

                            break;
                        }
                    }

                    if (valorproduto.mes == valorBruto.mes)
                    {
                        nomeMesPorExtenco = VerificarMesEscreverPorExtenso(valorproduto.mes);

                        row = table.NewRow();
                        row["Argument"] = nomeMesPorExtenco;
                        row["Value"] = (valorBruto.valor - valorproduto.valor);
                        table.Rows.Add(row);

                        break;
                    }
                    else if (valorproduto.mes != valorBruto.mes)
                    {
                        nomeMesPorExtenco = VerificarMesEscreverPorExtenso(valorproduto.mes);

                        row = table.NewRow();
                        row["Argument"] = nomeMesPorExtenco;
                        row["Value"] = -valorproduto.valor;
                        table.Rows.Add(row);

                        break;
                    }
                }
            }
        }

        private void GerarColunaValorBruto(Series series)
        {
            chrEstatisicasFinanceiras.Series.Add(series);
            series.DataSource = CreateChartData1();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaValorLiquido(Series series)
        {
            chrEstatisicasFinanceiras.Series.Add(series);
            series.DataSource = CreateChartData5();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaValorProduto(Series series)
        {
            chrEstatisicasFinanceiras.Series.Add(series);
            series.DataSource = CreateChartData();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaValorContasPagas(Series series)
        {
            chrEstatisicasFinanceiras.Series.Add(series);
            series.DataSource = CreateChartData4();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaValorContasAPagar(Series series)
        {
            chrEstatisicasFinanceiras.Series.Add(series);
            series.DataSource = CreateChartData3();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void GerarColunaValorContasAReceber(Series series)
        {
            chrEstatisicasFinanceiras.Series.Add(series);
            series.DataSource = CreateChartData2();
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void Forms_EstatisticasFinanceiras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                BuscarEstatisticasFinanceiras();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}