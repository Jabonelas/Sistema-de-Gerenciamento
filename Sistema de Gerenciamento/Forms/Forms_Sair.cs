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
    public partial class Forms_Sair : Form
    {
        private Forms_Login login;

        private Forms_TelaAdministrador fecharAdministrador;

        public Forms_Sair(Forms_Login _login)
        {
            InitializeComponent();

            login = _login;
        }

        public Forms_Sair(Forms_TelaAdministrador _telaAdministrador, Forms_Login _login)
        {
            InitializeComponent();

            fecharAdministrador = _telaAdministrador;

            login = _login;
        }

        public Forms_Sair()
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
        }
    }
}