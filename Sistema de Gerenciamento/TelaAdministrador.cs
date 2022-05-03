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
    public partial class TelaAdministrador : Form
    {
        public TelaAdministrador()
        {
            InitializeComponent();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroProdutos = new CadastroProduto();
            cadastroProdutos.ShowDialog();
        }
    }
}