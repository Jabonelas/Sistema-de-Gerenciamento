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
            valorContasAReceberAtrasadas = Buscar.BuscarValorContasAReceberAtrasadasPorData(dtpDataInicial.Value, dtpDataFinal.Value);

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

        private struct dadosParaPegarValorLiquido
        {
            internal decimal valor { get; set; }
            internal int mes { get; set; }
            internal int indice { get; set; }

            public dadosParaPegarValorLiquido(decimal _valor, int _mes, int _indice)
            {
                valor = _valor;
                mes = _mes;
                indice = _indice;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            List<dadosParaPegarValorLiquido> listaDadosParaPegarValorLiquidos = new List<dadosParaPegarValorLiquido>();

            List<DadosNotaFiscalSaida> listaValorBrutoNotaFiscalSaida = new List<DadosNotaFiscalSaida>(); // ok

            List<DadosPagamentoCarne> listaValorBrutoPagamentoCarne = new List<DadosPagamentoCarne>(); // ok

            List<DadosEstatiscasFinanceiras> listaValorLiquido = new List<DadosEstatiscasFinanceiras>();

            List<DadosProduto> listaValorProduto = new List<DadosProduto>(); // ok

            List<DadosEstatiscasFinanceiras> listaValorContasPagas = new List<DadosEstatiscasFinanceiras>(); // ok

            List<DadosEstatiscasFinanceiras> listaValorAPagarContasAtrasadas = new List<DadosEstatiscasFinanceiras>(); // ok

            List<DadosContasAReceber> listaValorAReceberContasAtrasadas = new List<DadosContasAReceber>(); // ok

            List<DadosEstatiscasFinanceiras> listaCompleta = new List<DadosEstatiscasFinanceiras>();

            List<DadosEstatiscasFinanceiras> listaCompleta1 = new List<DadosEstatiscasFinanceiras>();

            listaValorBrutoNotaFiscalSaida = Buscar.BuscarValorBrutoNotaFinalSaidaPorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            listaValorBrutoPagamentoCarne = Buscar.BuscarValorBrutoCarnePorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            listaValorContasPagas = Buscar.BuscarValorContasPagasPorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            listaValorAPagarContasAtrasadas = Buscar.BuscarValorContasAtrasadasPorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            listaValorAReceberContasAtrasadas = Buscar.BuscarValorContasAReceberAtrasadasDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            listaValorProduto = Buscar.BuscarValorProdutoPorDataAvancada(dtpDataInicial.Value, dtpDataFinal.Value);

            Canvas canvas = new Canvas();

            colunas = new DataPoint(BunifuDataViz._type.Bunifu_column);

            int atribuindoValorIndice = 1;
            //Valor Bruto
            foreach (var item in listaValorBrutoNotaFiscalSaida)
            {
                foreach (var item1 in listaValorBrutoPagamentoCarne)
                {
                    if (item.mes == item1.mes)
                    {
                        listaCompleta.Add(new DadosEstatiscasFinanceiras((item.valor + item1.valor), item.mes, atribuindoValorIndice));
                        atribuindoValorIndice += 6;

                        break;
                    }
                }

                if (listaValorBrutoPagamentoCarne.Count == 0)
                {
                    listaCompleta.Add(new DadosEstatiscasFinanceiras(item.valor, item.mes, atribuindoValorIndice));
                    atribuindoValorIndice += 6;
                }
            }

            ////Valor Liquido
            lblValorTotalLiquido.Text = String.Format("{0:c}", (valorBrutoNotaFinalSaida + valorBrutoCarne) - (valorContasPagas + valorProdutos));

            int indice = 0;
            atribuindoValorIndice = 2;
            // Para Pegar Valor de contas pagas + Valor dos Produtos
            foreach (var item in listaValorProduto)
            {
                foreach (var item1 in listaValorContasPagas)
                {
                    if (item.mes == item1.mes)
                    {
                        listaDadosParaPegarValorLiquidos.Add(new dadosParaPegarValorLiquido(item.valor, item.mes, indice));

                        break;
                    }
                }

                if (listaValorContasPagas.Count == 0)
                {
                    listaDadosParaPegarValorLiquidos.Add(new dadosParaPegarValorLiquido(item.valor, item.mes, indice));
                }
            }

            //Setando o valor Liquido = (valorBrutoNotaFinalSaida + valorBrutoCarne) - (valorContasPagas + valorProdutos)

            foreach (var item in listaCompleta)
            {
                listaCompleta1.Add(new DadosEstatiscasFinanceiras(item.valor, item.mes, item.indice));
            }

            foreach (var item in listaCompleta1)
            {
                foreach (var item1 in listaDadosParaPegarValorLiquidos)
                {
                    if (item.mes == item1.mes && item.indice == 1 || item.indice == 7 || item.indice == 13)
                    {
                        listaCompleta.Add(new DadosEstatiscasFinanceiras((item.valor - item1.valor), item.mes, atribuindoValorIndice));
                        atribuindoValorIndice += 6;

                        break;
                    }
                }

                if (listaValorContasPagas.Count == 0)
                {
                    listaCompleta.Add(new DadosEstatiscasFinanceiras(item.valor, item.mes, atribuindoValorIndice));
                    atribuindoValorIndice += 6;
                }
            }

            //Valor Produto
            atribuindoValorIndice = 3;
            foreach (DadosProduto item in listaValorProduto)
            {
                listaCompleta.Add(new DadosEstatiscasFinanceiras(item.valor, item.mes, atribuindoValorIndice));
                atribuindoValorIndice += 6;
            }

            //Valor Contas Pagas
            atribuindoValorIndice = 4;
            foreach (DadosEstatiscasFinanceiras item in listaValorContasPagas)
            {
                listaCompleta.Add(new DadosEstatiscasFinanceiras(item.valor, item.mes, atribuindoValorIndice));
                atribuindoValorIndice += 6;
            }

            //Valor Contas A Pagar Atrasadas
            atribuindoValorIndice = 5;
            foreach (DadosEstatiscasFinanceiras item in listaValorAPagarContasAtrasadas)
            {
                listaCompleta.Add(new DadosEstatiscasFinanceiras(item.valor, item.mes, atribuindoValorIndice));
                atribuindoValorIndice += 6;
            }

            //Valor Contas A Receber Atrasadas
            atribuindoValorIndice = 6;
            foreach (DadosContasAReceber item in listaValorAReceberContasAtrasadas)
            {
                listaCompleta.Add(new DadosEstatiscasFinanceiras(item.valor, item.mes, atribuindoValorIndice));
                atribuindoValorIndice += 6;
            }

            foreach (DadosEstatiscasFinanceiras item in listaCompleta)
            {
                if (item.indice == 1 || item.indice == 7 || item.indice == 13)
                {
                    string valorBruto = item.valor.ToString("N0").Replace(".", "");

                    colunas.addLabely(item.mes.ToString(), valorBruto);

                    bunifuDataViz1.colorSet.Add(Color.Aqua);

                    continue;
                }

                if (item.indice == 2 || item.indice == 8 || item.indice == 14)
                {
                    string valorLiquido = item.valor.ToString("N0").Replace(".", "");

                    colunas.addLabely(item.mes.ToString(), valorLiquido);

                    bunifuDataViz1.colorSet.Add(Color.Black);

                    continue;
                }

                if (item.indice == 3 || item.indice == 9 || item.indice == 15)
                {
                    string valorContasPaga = item.valor.ToString("N0").Replace(".", "");

                    colunas.addLabely(item.mes.ToString(), valorContasPaga);

                    bunifuDataViz1.colorSet.Add(Color.Green);

                    continue;
                }

                if (item.indice == 4 || item.indice == 10 || item.indice == 16)
                {
                    string valorProduto = item.valor.ToString("N0").Replace(".", "");

                    colunas.addLabely(item.mes.ToString(), valorProduto);

                    bunifuDataViz1.colorSet.Add(Color.Red);

                    continue;
                }

                if (item.indice == 5 || item.indice == 11 || item.indice == 17)
                {
                    string valorContasAPagarAtrasada = item.valor.ToString("N0").Replace(".", "");

                    colunas.addLabely(item.mes.ToString(), valorContasAPagarAtrasada);

                    bunifuDataViz1.colorSet.Add(Color.Gray);

                    continue;
                }

                if (item.indice == 6 || item.indice == 12 || item.indice == 18)
                {
                    string valorContasAReceberAtrasada = item.valor.ToString("N0").Replace(".", "");

                    colunas.addLabely(item.mes.ToString(), valorContasAReceberAtrasada);

                    bunifuDataViz1.colorSet.Add(Color.Yellow);

                    continue;
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