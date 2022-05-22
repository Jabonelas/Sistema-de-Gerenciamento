using Sistema_de_Gerenciamento.Forms;
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
        private Login login;

        public TelaAdministrador()
        {
            InitializeComponent();
        }

        public TelaAdministrador(Login _login)
        {
            InitializeComponent();

            login = _login;

            if (Global.tipoDeUsuario == "ADMIN")
            {
                tabControl.Visible = true;
            }
            else
            {
                btnVendaConsole.Location = new Point(93, 100);
                btnOrdemServicoConsole.Location = new Point(245, 100);
                btnProdutoConsole.Location = new Point(394, 100);
                btnClienteConsole.Location = new Point(546, 100);
                btnContasReceberConsole.Location = new Point(695, 100);

                btnDevolucaoConsole.Location = new Point(6, 400);
                btnDespesasConsole.Location = new Point(161, 400);
                btnComprasConsole.Location = new Point(317, 400);
                btnResumoVendasConsole.Location = new Point(472, 400);
                btnFluxoCaixaConsole.Location = new Point(625, 400);
                btnSair.Location = new Point(778, 400);
                tabControl.Visible = false;
            }
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
            Sair sair = new Sair(this, login);
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

        private void btnVendaConsole_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            venda.ShowDialog();
        }

        private void tabCadastro_Click(object sender, EventArgs e)
        {
            if (Global.tipoDeUsuario == "ADMIN")
            {
                tabControl.Visible = true;
            }
            else
            {
                btnVendaConsole.Location = new Point(93, 100);
                btnOrdemServicoConsole.Location = new Point(245, 100);
                btnProdutoConsole.Location = new Point(394, 100);
                btnClienteConsole.Location = new Point(546, 100);
                btnContasReceberConsole.Location = new Point(695, 100);

                btnDevolucaoConsole.Location = new Point(6, 400);
                btnDespesasConsole.Location = new Point(161, 400);
                btnComprasConsole.Location = new Point(317, 400);
                btnResumoVendasConsole.Location = new Point(472, 400);
                btnFluxoCaixaConsole.Location = new Point(625, 400);
                btnSair.Location = new Point(778, 400);
                tabControl.Visible = false;
            }
        }
    }
}