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
    public partial class CadastroDespesas : Form
    {
        public CadastroDespesas()
        {
            InitializeComponent();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}