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
            FinalizarAplicacao();
        }

        private void FinalizarAplicacao()
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
            TrocaUsuario();
        }

        private void TrocaUsuario()
        {
            fecharAdministrador.Hide();
            this.Hide();
            login.Show();
        }

        private void Forms_Sair_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                FinalizarAplicacao();
            }
            else if (e.KeyCode == Keys.L && e.Modifiers == Keys.Control)
            {
                TrocaUsuario();
            }
        }
    }
}