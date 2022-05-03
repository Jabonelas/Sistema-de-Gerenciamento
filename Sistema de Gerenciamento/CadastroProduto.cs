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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            PesquisarProduto buscarProduto = new PesquisarProduto();
            buscarProduto.ShowDialog();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}