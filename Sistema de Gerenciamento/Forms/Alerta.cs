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
    public partial class Alerta : Form
    {
        public Alerta()
        {
            InitializeComponent();

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alerta_Load(object sender, EventArgs e)
        {
            if (Global.tipoDoAlerta == "Inclusao")
            {
                this.BackColor = Color.Green;
            }
            else if (Global.tipoDoAlerta == "Atualizacao")
            {
                this.BackColor = Color.Blue;
            }
            else if (Global.tipoDoAlerta == "Exclusao")
            {
                this.BackColor = Color.Red;
            }
        }
    }
}