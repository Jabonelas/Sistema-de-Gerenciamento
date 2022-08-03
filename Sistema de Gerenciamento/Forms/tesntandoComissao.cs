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
    public partial class tesntandoComissao : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private List<DadosNotaFiscalSaida> listaCodigoProdutos = new List<DadosNotaFiscalSaida>();

        private List<DadosUsuario> usuarios = new List<DadosUsuario>();

        private AtualizacaoNoBanco Atualizacao = new AtualizacaoNoBanco();

        private decimal valorComissaoPorProduto;

        public tesntandoComissao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{DateTime.Today}");

            PreencherListaComNomeUsuario();
        }

        private void PreencherListaComNomeUsuario()
        {
            decimal valorCaixaDiario;

            decimal porcentagemComissaoPorproduto;

            decimal valorComissaoGeral;

            decimal porcentagemComissaoGeral;

            decimal valorTotal;

            usuarios = Buscar.BuscaListaUsuario();

            // comissao geral

            porcentagemComissaoGeral = Buscar.BuscarPorcentagemComissao();

            // valor total

            foreach (var item in usuarios)
            {
                valorCaixaDiario = Buscar.BuscarValorTotalFluxoCaixa(item.usuario, DateTime.Today.AddDays(-300), DateTime.Today.AddDays(1));

                valorComissaoGeral = valorCaixaDiario * porcentagemComissaoGeral / 100;

                listaCodigoProdutos = Buscar.BuscarCodigoProdutosVendidos(item.usuario, DateTime.Today.AddDays(-300), DateTime.Today.AddDays(1));

                foreach (var item1 in listaCodigoProdutos)
                {
                    porcentagemComissaoPorproduto = Buscar.BuscarValorComissaoPorProduto(item1.codigoProduto);

                    valorComissaoPorProduto += item1.preco * porcentagemComissaoPorproduto / 100;
                }

                valorTotal = valorComissaoPorProduto + valorComissaoGeral;

                Atualizacao.AtualizarComissaoDiariamente(valorTotal, item.usuario, DateTime.Today.AddDays(-300), DateTime.Today.AddDays(-1));
            }
        }
    }
}