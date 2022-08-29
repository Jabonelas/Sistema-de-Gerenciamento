using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class teste : Form
    {
        public teste()
        {
            InitializeComponent();
        }

        private void bntEmail_Click(object sender, EventArgs e)
        {
            Regex validaEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            if (!validaEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("email invalido");
            }
            else
            {
                MessageBox.Show("email valido");
            }
        }
    }
}