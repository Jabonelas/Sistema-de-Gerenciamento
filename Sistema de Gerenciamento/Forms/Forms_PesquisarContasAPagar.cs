using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento
{
    public partial class Forms_PesquisarContasAPagar : Form
    {
        public Forms_PesquisarContasAPagar()
        {
            InitializeComponent();

            DateTime data = DateTime.Today;

            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));

            dtpDataFinal.Text = ultimoDiaDoMes.ToString();

            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);

            dtpDataInicial.Text = primeiroDiaDoMes.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
        }

        private void dtpDataFinal_Leave(object sender, EventArgs e)
        {
            if (dtpDataInicial.Value > dtpDataFinal.Value)
            {
                MessageBox.Show("A Data Final Esta Maior Que a Data Inicial!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtpDataFinal.Focus();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}