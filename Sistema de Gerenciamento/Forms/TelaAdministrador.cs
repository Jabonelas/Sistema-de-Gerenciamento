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

        private void bntCadastroUsuario_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.ShowDialog();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.ShowDialog();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            CadastroFornecedor cadastroFornecedor = new CadastroFornecedor();
            cadastroFornecedor.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair sair = new Sair();
            sair.ShowDialog();
        }

        private void btnCadastroEmpresa_Click(object sender, EventArgs e)
        {
            CadastroEmpresa cadastroEmpresa = new CadastroEmpresa();
            cadastroEmpresa.ShowDialog();
        }

        private void btnDespesas_Click(object sender, EventArgs e)
        {
            CadastroDespesas cadastroDespesa = new CadastroDespesas();
            cadastroDespesa.ShowDialog();
        }

        private void btnContasAPagar_Click(object sender, EventArgs e)
        {
            PesquisarContasAPagar pesquisarContasAPagar = new PesquisarContasAPagar();
            pesquisarContasAPagar.ShowDialog();
        }

        private void bntGrupoDeMaterial_Click(object sender, EventArgs e)
        {
            CadastroGrupoDeMaterial cadastroGrupoDeMaterial = new CadastroGrupoDeMaterial();
            cadastroGrupoDeMaterial.ShowDialog();
        }

        private void TelaAdministrador_Load(object sender, EventArgs e)
        {
        }

        private void tabCadastro_Click(object sender, EventArgs e)
        {
        }
    }
}