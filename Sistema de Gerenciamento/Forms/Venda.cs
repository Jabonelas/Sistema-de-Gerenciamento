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
    public partial class Venda : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        public Venda()
        {
            InitializeComponent();

            txtData.Text = DateTime.Today.ToShortDateString();

            cmbCliente.Items.Clear();
            foreach (var item in Buscar.BuscarListaCliente())
            {
                cmbCliente.Items.Add(item);
            }
        }

        private void btnAbriCadastroCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente buscarCliente = new CadastroCliente();
            buscarCliente.ShowDialog();
        }

        #region Botao Sair

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Sair

        private void cmbCliente_Leave(object sender, EventArgs e)
        {
            if (cmbCliente.Text != string.Empty)
            {
                txtCodigoCliente.Text = Buscar.BuscarIdClientePorNome(cmbCliente.Text).ToString();
            }
        }
    }
}