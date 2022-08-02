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
    public partial class Forms_FluxoCaixa : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private List<DadosUsuario> listaUsuario = new List<DadosUsuario>();

        public Forms_FluxoCaixa()
        {
            InitializeComponent();

            PreencherDatePicker();

            PreencherComboBoxUsuario();

            FormatarGridView();
        }

        private void FormatarGridView()
        {
            this.gdvFluxoCaixa.Columns["ns_valor_pago"].DefaultCellStyle.Format = "c";
        }

        private void PreencherComboBoxUsuario()
        {
            listaUsuario = Buscar.BuscaListaUsuario();

            foreach (var item in listaUsuario)
            {
                cmbUsuario.Items.Add(item.usuario);
            }
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
            Buscar.BuscarDadosPreencherGridView(cmbUsuario.Text, dtpDataInicial.Value, dtpDataFinal.Value, gdvFluxoCaixa);

            BuscarValorTotal();
        }

        private void BuscarValorTotal()
        {
            lblValorTotal.Text = string.Format("{0:c}", Buscar.BuscarValorTotalFluxoCaixa(cmbUsuario.Text, dtpDataInicial.Value, dtpDataFinal.Value));
        }
    }
}