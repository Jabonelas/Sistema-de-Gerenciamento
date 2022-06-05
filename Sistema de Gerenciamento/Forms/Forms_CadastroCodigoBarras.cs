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
    public partial class Forms_CadastroCodigoBarras : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        //private  DadosNotaFiscalEntrada liDadosNotaFiscalEntrada = new DadosNotaFiscalEntrada();

        public DadosNotaFiscalEntrada ListaEntrada;

        public Forms_Compras Compras = new Forms_Compras();

        public Forms_Compras compras;

        private int cont = 1;

        public Forms_CadastroCodigoBarras(Forms_Compras _compras)
        {
            InitializeComponent();

            compras = _compras;

            //compras.listaDadosNotaFiscalEntrada = Buscar.BuscarNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text),compras.gdvCompra);

            compras.listaDadosNotaFiscalEntrada.ForEach(nf => ListaEntrada = nf);

            txtNumeroNotaFiscal.Text = ListaEntrada.numeroNF.ToString();
            txtQuantidade.Text = ListaEntrada.quantidade.ToString();
            txtCodigoProduto.Text = ListaEntrada.codProduto.ToString();
            txtDescricaoProduto.Text = ListaEntrada.descricao.ToString();
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void btnAdicionarCodigoBarras_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= cont; i++)
            {
                //for (int indiceDoItem = 1; indiceDoItem <= Buscar.BuscarQuantidadeDeItensNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text)); indiceDoItem++)
                //{
                //for (int quantidadePorCadaItem = 1; quantidadePorCadaItem <= Buscar.BuscarQuantidadeDeCadaItemNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text), cont); quantidadePorCadaItem++)
                //{
                //    int quantidade = 1;

                //    //Salvar.InserirEstoqueProduto(indiceDoItem, Convert.ToInt32(txtNumeroNotaFiscal.Text),
                //    //    Convert.ToInt32(txtCodigoBarras.Text));

                //    Salvar.InserirEstoqueProduto(cont, Convert.ToInt32(txtNumeroNotaFiscal.Text),
                //        Convert.ToInt32(txtCodigoBarras.Text));

                Atualizar.AtualizarCodigoBarrasEstoqueProduto(Convert.ToInt32(txtCodigoBarras),
                    Convert.ToInt32(txtNumeroNotaFiscal), Convert.ToInt32(txtCodigoProduto));

                //    Atualizar.AtualizarQuantidadeEDataEntradaEstoqueProduto(quantidade, Convert.ToInt32(txtNumeroNotaFiscal.Text));

                //    Atualizar.AtualizarDataLancamentoNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text));
                //}
                //}
            }

            cont++;
        }
    }
}