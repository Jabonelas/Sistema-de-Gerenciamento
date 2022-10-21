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
    public partial class Forms_ConsultaEstoqueDetalhada : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private Forms_ConsultarEstoque forms;

        private List<DadosProduto> listadadosProdutos = new List<DadosProduto>();

        private DadosProduto dadosProduto;

        private int numeroNFEntrada;
        private int codigoBarras;
        private decimal quantidade;

        public Forms_ConsultaEstoqueDetalhada(Forms_ConsultarEstoque _forms)
        {
            InitializeComponent();

            forms = _forms;

            PreencherTextBox();
        }

        private void PegarDadosGridViewConsultarEstoque()
        {
            numeroNFEntrada = Convert.ToInt32(forms.gdvConsultarEstoque.SelectedCells[1].Value);
            codigoBarras = Convert.ToInt32(forms.gdvConsultarEstoque.SelectedCells[10].Value);
            quantidade = Convert.ToDecimal(forms.gdvConsultarEstoque.SelectedCells[6].Value);
        }

        private void PreencherTextBox()
        {
            PegarDadosGridViewConsultarEstoque();

            listadadosProdutos = Buscar.BuscarListaConsultaEstoqueDetalhada(numeroNFEntrada, codigoBarras, quantidade);

            listadadosProdutos.ForEach(x => dadosProduto = x);

            PreenchementoTextBoxRejeitadoPor();

            txtNumeroNFEntrada.Text = dadosProduto.nfEntrada.ToString();
            txtDataEntrada.Text = dadosProduto.dataEntrada.ToString();
            txtCodBarras.Text = dadosProduto.codigoBarras.ToString();
            txtCodProduto.Text = dadosProduto.codigoProduto.ToString();
            txtDescricao.Text = dadosProduto.descricaoProduto;
            txtQuantidade.Text = dadosProduto.quantidade.ToString();
            txtUnidade.Text = dadosProduto.unidade;
            txtValorUnitario.Text = String.Format("{0:c}", dadosProduto.preco);
            txtStatus.Text = dadosProduto.status;
        }

        private void PreenchementoTextBoxRejeitadoPor()

        {
            if (dadosProduto.quantidade < 0)
            {
                txtRejeitatoPor.Text = Buscar.BuscarUsuarioRejeitouProduto(numeroNFEntrada, codigoBarras, quantidade);
            }
            else
            {
                txtRejeitatoPor.Text = "-";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Forms_ConsultaEstoqueDetalhada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
        }
    }
}