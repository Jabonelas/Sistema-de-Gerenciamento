using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gerenciamento.Forms;

namespace Sistema_de_Gerenciamento
{
    public partial class Sair : Form
    {
        private Login login;

        private TelaAdministrador fecharAdministrador;

        public Sair(Login _login)
        {
            InitializeComponent();

            login = _login;
        }

        public Sair(TelaAdministrador _telaAdministrador, Login _login)
        {
            InitializeComponent();

            fecharAdministrador = _telaAdministrador;

            login = _login;
        }

        public Sair()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult OpcaoDoUsuario = new DialogResult();
            OpcaoDoUsuario = MessageBox.Show("Deseja Finalizar o Processo?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (OpcaoDoUsuario == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTrocarUsuario_Click(object sender, EventArgs e)
        {
            fecharAdministrador.Hide();
            this.Hide();
            login.Show();

            //this.Hide();
            //Login TrocarUsuario = new Login();
            //TrocarUsuario.ShowDialog();
        }
    }
}