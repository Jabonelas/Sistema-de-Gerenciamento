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
    public partial class Forms_ResumoVendas : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        public Forms_ResumoVendas()
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
            if (cmbTipoPesquisa.Text == "Data")
            {
                bool isResultadoEncontrado = Buscar.BuscarResumoVendaPorData(dtpDataInicial.Value, dtpDataFinal.Value, gdvResumoVendas);

                MenssagemResultadoNaoEncontrado(isResultadoEncontrado);
            }
            else if (cmbTipoPesquisa.Text == "Devolucao")
            {
                bool isResultadoEncontrado = Buscar.BuscarResumoPorDevolucao(dtpDataInicial.Value, dtpDataFinal.Value, gdvResumoVendas);

                MenssagemResultadoNaoEncontrado(isResultadoEncontrado);
            }
            else if (cmbTipoPesquisa.Text == "Produtos mais Vendidos")
            {
                bool isResultadoEncontrado = Buscar.BuscarResumoPorProdutoMaisVendido(dtpDataInicial.Value, dtpDataFinal.Value, gdvResumoVendas);

                MenssagemResultadoNaoEncontrado(isResultadoEncontrado);
            }
            else if (cmbTipoPesquisa.Text == "Tipo Pagamento")
            {
                bool isResultadoEncontrado = Buscar.BuscarResumoVendaPorTipoPagamento(dtpDataInicial.Value, dtpDataFinal.Value, gdvResumoVendas);

                MenssagemResultadoNaoEncontrado(isResultadoEncontrado);
            }
            else if (cmbTipoPesquisa.Text == "Vendedor")
            {
                bool isResultadoEncontrado = Buscar.BuscarResumoVendaPorVendedor(dtpDataInicial.Value, dtpDataFinal.Value, gdvResumoVendas);

                MenssagemResultadoNaoEncontrado(isResultadoEncontrado);
            }

            string valorGastoBruto = Buscar.BuscarGastosBrutos().ToString("c");

            string valorBrutovendido = Buscar.BuscarValorBrutoVendido(dtpDataInicial.Value, dtpDataFinal.Value).ToString("c");

            string itensVendidos = Buscar.BuscarQuantidadeItensVendidos(dtpDataInicial.Value, dtpDataFinal.Value).ToString("N0");

            lblQtditensVendidos.Text = itensVendidos;

            lblValorBrutoVendido.Text = valorBrutovendido;

            lblValorGastoBruto.Text = valorGastoBruto;
        }

        private void MenssagemResultadoNaoEncontrado(bool _isResultadoEncontrado)
        {
            if (_isResultadoEncontrado == false)
            {
                MessageBox.Show("Dados Não Encontrado", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Forms_ResumoVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}