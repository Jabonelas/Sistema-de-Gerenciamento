using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraCharts;
using Sistema_de_Gerenciamento.Classes;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class testando : Form
    {
        private List<DadosProduto> listaValorProduto = new List<DadosProduto>();
        private List<DadosEstatiscasFinanceiras> listaValorContasPagas = new List<DadosEstatiscasFinanceiras>();
        private List<DadosListaValorBruto> listaDadosListaValorBruto = new List<DadosListaValorBruto>();

        private BuscarNoBanco Buscar = new BuscarNoBanco();
        private string nomeMesPorExtenco = "";
        private List<DadosNotaFiscalSaida> listaNotaFiscalSaidas = new List<DadosNotaFiscalSaida>();

        public testando()
        {
            InitializeComponent();

            dataInicial.Value = Convert.ToDateTime("01/06/2022");
            dataFinal.Value = Convert.ToDateTime("01/9/2022");
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

        private string VerificarMesEscreverPorExtenco(int _mes)
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

            listaValorBrutoNotaFiscalSaida = Buscar.BuscarValorBrutoNotaFinalSaidaPorDataAvancada(dataInicial.Value, dataFinal.Value);

            listaValorBrutoPagamentoCarne = Buscar.BuscarValorBrutoCarnePorDataAvancada(dataInicial.Value, dataFinal.Value);

            DataRow row = null;

            foreach (DadosNotaFiscalSaida valorBrutoNotaFiscalSaida in listaValorBrutoNotaFiscalSaida)
            {
                foreach (DadosPagamentoCarne valorBrutoPagamentoCarne in listaValorBrutoPagamentoCarne)
                {
                    if (valorBrutoNotaFiscalSaida.mes == valorBrutoPagamentoCarne.mes)
                    {
                        nomeMesPorExtenco = VerificarMesEscreverPorExtenco(valorBrutoNotaFiscalSaida.mes);

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
                    nomeMesPorExtenco = VerificarMesEscreverPorExtenco(valorBrutoNotaFiscalSaida.mes);

                    row = table.NewRow();
                    row["Argument"] = nomeMesPorExtenco;
                    row["Value"] = (valorBrutoNotaFiscalSaida.valor);
                    table.Rows.Add(row);

                    listaDadosListaValorBruto.Add(new DadosListaValorBruto(valorBrutoNotaFiscalSaida.mes, valorBrutoNotaFiscalSaida.valor));
                }
            }
        }

        private void PercorrerListaValorProduto(DataTable table)
        {
            listaValorProduto = Buscar.BuscarValorProdutoPorDataAvancada(dataInicial.Value, dataFinal.Value);

            DataRow row = null;

            listaValorProduto.ForEach(valorProduto =>
            {
                nomeMesPorExtenco = VerificarMesEscreverPorExtenco(valorProduto.mes);

                row = table.NewRow();
                row["Argument"] = nomeMesPorExtenco;
                row["Value"] = (valorProduto.valor);
                table.Rows.Add(row);
            });
        }

        private void PercorrerListaContasAtrasadasAReceber(DataTable table)
        {
            List<DadosContasAReceber> listaValorAReceberContasAtrasadasAReceber = new List<DadosContasAReceber>(); // ok

            listaValorAReceberContasAtrasadasAReceber = Buscar.BuscarValorContasAReceberAtrasadasDataAvancada(dataInicial.Value, dataFinal.Value);

            DataRow row = null;

            listaValorAReceberContasAtrasadasAReceber.ForEach(contaAtrasadaAReceber =>
            {
                nomeMesPorExtenco = VerificarMesEscreverPorExtenco(contaAtrasadaAReceber.mes);

                row = table.NewRow();
                row["Argument"] = nomeMesPorExtenco;
                row["Value"] = (contaAtrasadaAReceber.valor);
                table.Rows.Add(row);
            });
        }

        private void PercorrerListaContasAtrasadasAPagar(DataTable table)
        {
            List<DadosEstatiscasFinanceiras> listaValorAPagarContasAtrasadasAPagar = new List<DadosEstatiscasFinanceiras>(); // ok

            listaValorAPagarContasAtrasadasAPagar = Buscar.BuscarValorContasAtrasadasPorDataAvancada(dataInicial.Value, dataFinal.Value);

            DataRow row = null;

            listaValorAPagarContasAtrasadasAPagar.ForEach(contasAtrasadaAPagar =>
            {
                nomeMesPorExtenco = VerificarMesEscreverPorExtenco(contasAtrasadaAPagar.mes);

                row = table.NewRow();
                row["Argument"] = nomeMesPorExtenco;
                row["Value"] = (contasAtrasadaAPagar.valor);
                table.Rows.Add(row);
            });
        }

        private void PercorrerListaContasPagas(DataTable table)
        {
            listaValorContasPagas = Buscar.BuscarValorContasPagasPorDataAvancada(dataInicial.Value, dataFinal.Value);

            DataRow row = null;

            listaValorContasPagas.ForEach(contasPagas =>
            {
                nomeMesPorExtenco = VerificarMesEscreverPorExtenco(contasPagas.mes);

                row = table.NewRow();
                row["Argument"] = nomeMesPorExtenco;
                row["Value"] = (contasPagas.valor);
                table.Rows.Add(row);
            });
        }

        private void PercorrerListaValorLiquido(DataTable table)
        {
            listaValorProduto = Buscar.BuscarValorProdutoPorDataAvancada(dataInicial.Value, dataFinal.Value);

            listaValorContasPagas = Buscar.BuscarValorContasPagasPorDataAvancada(dataInicial.Value, dataFinal.Value);

            DataRow row = null;

            foreach (var valorproduto in listaValorProduto)
            {
                foreach (var valorBruto in listaDadosListaValorBruto)
                {
                    foreach (var valorContasPagas in listaValorContasPagas)
                    {
                        if (valorproduto.mes == valorContasPagas.mes && valorproduto.mes == valorBruto.mes)
                        {
                            nomeMesPorExtenco = VerificarMesEscreverPorExtenco(valorproduto.mes);

                            row = table.NewRow();
                            row["Argument"] = nomeMesPorExtenco;
                            row["Value"] = (valorBruto.valor - (valorContasPagas.valor + valorproduto.valor));
                            table.Rows.Add(row);

                            break;
                        }
                    }

                    if (valorproduto.mes == valorBruto.mes)
                    {
                        nomeMesPorExtenco = VerificarMesEscreverPorExtenco(valorproduto.mes);

                        row = table.NewRow();
                        row["Argument"] = nomeMesPorExtenco;
                        row["Value"] = (valorBruto.valor - valorproduto.valor);
                        table.Rows.Add(row);

                        break;
                    }
                    else if (valorproduto.mes != valorBruto.mes)
                    {
                        nomeMesPorExtenco = VerificarMesEscreverPorExtenco(valorproduto.mes);

                        row = table.NewRow();
                        row["Argument"] = nomeMesPorExtenco;
                        row["Value"] = (-valorproduto.valor);
                        table.Rows.Add(row);

                        break;
                    }
                }
            }
        }

        private void chkValorProduto_CheckedChanged(object sender, EventArgs e)
        {
            Series series = new Series("Valor Produto", ViewType.Bar);

            if (chkValorProduto.Checked == true)
            {
                chartControl1.Series.Add(series);
                series.DataSource = CreateChartData();
                series.ArgumentScaleType = ScaleType.Auto;
                series.ArgumentDataMember = "Argument";
                series.ValueScaleType = ScaleType.Numerical;
                series.ValueDataMembers.AddRange(new string[] { "Value" });
            }
            else
            {
                var a = chartControl1.Series.First(x => x.Name == "Valor Produto");

                chartControl1.Series.Remove((Series)a);
            }
        }

        private void chkValorBruto_CheckedChanged(object sender, EventArgs e)
        {
            Series series1 = new Series("Valor Bruto", ViewType.Bar);

            if (chkValorBruto.Checked == true)
            {
                chartControl1.Series.Add(series1);
                series1.DataSource = CreateChartData1();
                series1.ArgumentScaleType = ScaleType.Auto;
                series1.ArgumentDataMember = "Argument";
                series1.ValueScaleType = ScaleType.Numerical;
                series1.ValueDataMembers.AddRange(new string[] { "Value" });
            }
            else
            {
                var a = chartControl1.Series.First(x => x.Name == "Valor Bruto");

                chartControl1.Series.Remove((Series)a);
            }
        }

        private void chkValorContasAPagar_CheckedChanged(object sender, EventArgs e)
        {
            Series series2 = new Series("Valor Contas A Pagar", ViewType.Bar);

            if (chkValorContasAPagar.Checked == true)
            {
                chartControl1.Series.Add(series2);
                series2.DataSource = CreateChartData3();
                series2.ArgumentScaleType = ScaleType.Auto;
                series2.ArgumentDataMember = "Argument";
                series2.ValueScaleType = ScaleType.Numerical;
                series2.ValueDataMembers.AddRange(new string[] { "Value" });
            }
            else
            {
                var a = chartControl1.Series.First(x => x.Name == "Valor Contas A Pagar");

                chartControl1.Series.Remove((Series)a);
            }
        }

        private void chkValorContasAReceber_CheckedChanged(object sender, EventArgs e)
        {
            Series series3 = new Series("Valor Contas A Receber", ViewType.Bar);

            if (chkValorContasAReceber.Checked == true)
            {
                chartControl1.Series.Add(series3);
                series3.DataSource = CreateChartData2();
                series3.ArgumentScaleType = ScaleType.Auto;
                series3.ArgumentDataMember = "Argument";
                series3.ValueScaleType = ScaleType.Numerical;
                series3.ValueDataMembers.AddRange(new string[] { "Value" });
            }
            else
            {
                var a = chartControl1.Series.First(x => x.Name == "Valor Contas A Receber");

                chartControl1.Series.Remove((Series)a);
            }
        }

        private void chkValorContasPagas_CheckedChanged(object sender, EventArgs e)
        {
            Series series4 = new Series("Valor Contas Pagas", ViewType.Bar);

            if (chkValorContasPagas.Checked == true)
            {
                chartControl1.Series.Add(series4);
                series4.DataSource = CreateChartData4();
                series4.ArgumentScaleType = ScaleType.Auto;
                series4.ArgumentDataMember = "Argument";
                series4.ValueScaleType = ScaleType.Numerical;
                series4.ValueDataMembers.AddRange(new string[] { "Value" });
            }
            else
            {
                var a = chartControl1.Series.First(x => x.Name == "Valor Contas Pagas");

                chartControl1.Series.Remove((Series)a);
            }
        }

        private void chkValorLiquido_CheckedChanged(object sender, EventArgs e)
        {
            Series series5 = new Series("Valor Liquido", ViewType.Bar);

            if (chkValorLiquido.Checked == true)
            {
                chartControl1.Series.Add(series5);
                series5.DataSource = CreateChartData5();
                series5.ArgumentScaleType = ScaleType.Auto;
                series5.ArgumentDataMember = "Argument";
                series5.ValueScaleType = ScaleType.Numerical;
                series5.ValueDataMembers.AddRange(new string[] { "Value" });
            }
            else
            {
                var a = chartControl1.Series.First(x => x.Name == "Valor Liquido");

                chartControl1.Series.Remove((Series)a);
            }
        }

        private void testando_Load(object sender, EventArgs e)
        {
            chkValorProduto.Checked = true;
            chkValorBruto.Checked = true;
            chkValorContasAPagar.Checked = true;
            chkValorContasAReceber.Checked = true;
            chkValorContasPagas.Checked = true;
            chkValorLiquido.Checked = true;
        }
    }
}