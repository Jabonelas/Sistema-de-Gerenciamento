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
                Buscar.BuscarResumoVendaPorData(dtpDataInicial.Value, dtpDataFinal.Value, gdvResumoVendas);
            }
            else if (cmbTipoPesquisa.Text == "Devolucao")
            {
                Buscar.BuscarResumoPorDevolucao(dtpDataInicial.Value, dtpDataFinal.Value, gdvResumoVendas);
            }
            else if (cmbTipoPesquisa.Text == "Produtos mais Vendidos")
            {
                Buscar.BuscarResumoPorProdutoMaisVendido(dtpDataInicial.Value, dtpDataFinal.Value, gdvResumoVendas);
            }
            else if (cmbTipoPesquisa.Text == "Tipo Pagamento")
            {
                Buscar.BuscarResumoVendaPorTipoPagamento(dtpDataInicial.Value, dtpDataFinal.Value, gdvResumoVendas);
            }
            else if (cmbTipoPesquisa.Text == "Vendedor")
            {
            }
        }
    }
}