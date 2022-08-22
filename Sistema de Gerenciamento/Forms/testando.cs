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
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        public testando()
        {
            InitializeComponent();

            dataInicial.Value = Convert.ToDateTime("01/01/2022");
            dataFinal.Value = Convert.ToDateTime("01/12/2022");

            //sqlDataSource2.FillAsync();
        }

        private void btnPreencher_Click(object sender, EventArgs e)
        {
            ValorNotaFiscalSaida(Convert.ToDateTime(dataInicial.Text), Convert.ToDateTime(dataFinal.Text));
        }

        private void ValorNotaFiscalSaida(DateTime _dataInicial, DateTime _dataFinal)
        {
            CustomSqlQuery query = new CustomSqlQuery();

            sqlDataSource2.Queries.Clear();

            query.Name = "Teste";
            query.Sql = $"select SUM(ns_valor_pago) as valor,month(ns_emissao) as mes from tb_NotaFiscalSaida " +
                        $"where ns_emissao between '{_dataInicial.ToShortDateString()}' and '{_dataFinal.ToShortDateString()}' " +
                        $"group by month(ns_emissao)";

            sqlDataSource2.Queries.Add(query);
            sqlDataSource2.RebuildResultSchema();
            sqlDataSource2.Fill();

            chartControl1.Series[0].ArgumentDataMember = "";
            chartControl1.Series[0].ValueDataMembersSerializable = "";

            tb_NotaFiscalSaidaBindingSource.DataMember = "Teste";
            tb_NotaFiscalSaidaBindingSource.DataSource = this.sqlDataSource2;

            chartControl1.Series[0].ArgumentDataMember = "mes";
            chartControl1.Series[0].Name = "Series 1";
            chartControl1.Series[0].ValueDataMembersSerializable = "valor";

            chartControl1.DataSource = this.tb_NotaFiscalSaidaBindingSource;

            chartControl1.RefreshData();
        }

        private void ValorProduto(DateTime _dataInicial, DateTime _dataFinal)
        {
            CustomSqlQuery query = new CustomSqlQuery();

            sqlDataSource2.Queries.Clear();

            query.Name = "Teste";
            query.Sql =
                $"select sum(cp_valor_custo* pe.ns_quantidade) as quantidade, month(ns_emissao) as mes from tb_CadastroProdutos as p " +
                $"inner join tb_NotaFiscalSaida pe on p.cp_id = pe.ns_codigo_produto " +
                $" where ns_emissao between '{_dataInicial.ToShortDateString()}' and '{_dataFinal.ToShortDateString()}' " +
                $"group by month(ns_emissao)";

            sqlDataSource2.Queries.Add(query);
            sqlDataSource2.RebuildResultSchema();
            sqlDataSource2.Fill();

            chartControl1.Series[0].ArgumentDataMember = "";
            chartControl1.Series[0].ValueDataMembersSerializable = "";

            tb_NotaFiscalSaidaBindingSource.DataMember = "Teste";
            tb_NotaFiscalSaidaBindingSource.DataSource = this.sqlDataSource2;

            chartControl1.Series[0].ArgumentDataMember = "mes";
            chartControl1.Series[0].Name = "Series 1";
            chartControl1.Series[0].ValueDataMembersSerializable = "quantidade";
            chartControl1.DataSource = this.tb_NotaFiscalSaidaBindingSource;

            chartControl1.RefreshData();
        }

        private void btnValorProduto_Click(object sender, EventArgs e)
        {
            ValorProduto(Convert.ToDateTime(dataInicial.Text), Convert.ToDateTime(dataFinal.Text));
        }

        private List<DadosNotaFiscalSaida> listaNotaFiscalSaidas = new List<DadosNotaFiscalSaida>();

        private DataTable CreateChartData()
        {
            // Create an empty table.
            DataTable table = new DataTable("Table1");

            // Add two columns to the table.
            table.Columns.Add("Argument", typeof(Int32));
            table.Columns.Add("Value", typeof(decimal));

            // Add data rows to the table.
            DataRow row = null;

            casas(row, table);

            //NotaFiscalSaida(row, table);

            return table;
        }

        private void testando_Load(object sender, EventArgs e)
        {
            // Create a chart.
            //ChartControl chart = new ChartControl();

            // Create an empty Bar series and add it to the chart.
            Series series = new Series("Series1", ViewType.Bar);
            chartControl1.Series.Add(series);

            // Generate a data table and bind the series to it.
            series.DataSource = CreateChartData();

            // Specify data members to bind the series.
            series.ArgumentScaleType = ScaleType.Numerical;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            //series.ValueDataMembersSerializable = "Value";
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void NotaFiscalSaida(DataRow row, DataTable table)
        {
            foreach (DadosNotaFiscalSaida item in Buscar.BuscarValorBrutoNotaFinalSaidaPorDataAvancada(dataInicial.Value, dataFinal.Value))
            {
                row = table.NewRow();
                row["Argument"] = item.mes;
                row["Value"] = item.valor;
                table.Rows.Add(row);
            }
        }

        private void casas(DataRow row, DataTable table)
        {
            List<DadosNotaFiscalSaida> listaValorBrutoNotaFiscalSaida = new List<DadosNotaFiscalSaida>(); // ok

            List<DadosPagamentoCarne> listaValorBrutoPagamentoCarne = new List<DadosPagamentoCarne>(); // ok

            listaValorBrutoNotaFiscalSaida = Buscar.BuscarValorBrutoNotaFinalSaidaPorDataAvancada(dataInicial.Value, dataFinal.Value);

            listaValorBrutoPagamentoCarne = Buscar.BuscarValorBrutoCarnePorDataAvancada(dataInicial.Value, dataFinal.Value);

            foreach (var item in listaValorBrutoNotaFiscalSaida)
            {
                foreach (var item1 in listaValorBrutoPagamentoCarne)
                {
                    if (item.mes == item1.mes)
                    {
                        row = table.NewRow();
                        row["Argument"] = item.mes;
                        row["Value"] = (item.valor + item1.valor);
                        table.Rows.Add(row);

                        //listaCompleta.Add(new DadosEstatiscasFinanceiras((item.valor+item1.valor), item.mes, atribuindoValorIndice));
                        //atribuindoValorIndice += 6;

                        break;
                    }
                }

                if (listaValorBrutoPagamentoCarne.Count == 0)
                {
                    row = table.NewRow();
                    row["Argument"] = item.mes;
                    row["Value"] = (item.valor);
                    table.Rows.Add(row);

                    //listaCompleta.Add(new DadosEstatiscasFinanceiras(item.valor, item.mes, atribuindoValorIndice));
                    //atribuindoValorIndice += 6;
                }
            }
        }
    }
}