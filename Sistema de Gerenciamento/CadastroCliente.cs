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
    public partial class CadastroCliente : Form
    {
        private TelaAdministrador formTelaAdministrador;

        private string formPrincipal = "";

        public CadastroCliente(TelaAdministrador _tela_Administrador, string _form)
        {
            InitializeComponent();

            formTelaAdministrador = _tela_Administrador;

            formPrincipal = _form;
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            if (formPrincipal == "Fornecedor")
            {
                btnCadastroProduto.IdleIconLeftImage = Image.FromFile(@"C:\Users\israe\source\repos\Sistema de Gerenciamento\Sistema de Gerenciamento\Resources\fornecedor.png");
            }
            else if (formPrincipal == "Cliente")
            {
                //btnCadastroProduto.IdleIconLeftImage = Image.FromFile(@"C:\Users\israe\source\repos\Sistema de Gerenciamento\Sistema de Gerenciamento\Resources\entregador.png");
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            PesquisarCliente buscarCliente = new PesquisarCliente();
            buscarCliente.ShowDialog();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        
    }
}