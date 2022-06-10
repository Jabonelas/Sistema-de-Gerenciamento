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
    public partial class Forms_TelaAdministrador : Form
    {
        private Forms_Login login;

        public Forms_TelaAdministrador()
        {
            InitializeComponent();
        }

        public Forms_TelaAdministrador(Forms_Login _login)
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

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            Forms_CadastroProduto cadastroProdutos = new Forms_CadastroProduto();
            cadastroProdutos.ShowDialog();
        }

        private void bntCadastroUsuario_Click(object sender, EventArgs e)
        {
            Forms_CadastroUsuario cadastroUsuario = new Forms_CadastroUsuario();
            cadastroUsuario.ShowDialog();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            Forms_CadastroCliente cadastroCliente = new Forms_CadastroCliente();
            cadastroCliente.ShowDialog();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            Forms_CadastroFornecedor cadastroFornecedor = new Forms_CadastroFornecedor();
            cadastroFornecedor.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Forms_Sair sair = new Forms_Sair(this, login);
            sair.ShowDialog();
        }

        private void btnCadastroEmpresa_Click(object sender, EventArgs e)
        {
            Forms_CadastroEmpresa cadastroEmpresa = new Forms_CadastroEmpresa();
            cadastroEmpresa.ShowDialog();
        }

        private void btnDespesas_Click(object sender, EventArgs e)
        {
            Forms_CadastroDespesasCusto cadastroDespesa = new Forms_CadastroDespesasCusto();
            cadastroDespesa.ShowDialog();
        }

        private void btnContasAPagar_Click(object sender, EventArgs e)
        {
            Forms_PesquisarContasAPagar pesquisarContasAPagar = new Forms_PesquisarContasAPagar();
            pesquisarContasAPagar.ShowDialog();
        }

        private void bntGrupoDeMaterial_Click(object sender, EventArgs e)
        {
            Forms_CadastroGrupoProduto cadastroGrupoDeMaterial = new Forms_CadastroGrupoProduto();
            cadastroGrupoDeMaterial.ShowDialog();
        }

        private void TelaAdministrador_Load(object sender, EventArgs e)
        {
        }

        private void btnVendaConsole_Click(object sender, EventArgs e)
        {
            Forms_Venda venda = new Forms_Venda();
            venda.ShowDialog();
        }

        private void btnComprasConsole_Click(object sender, EventArgs e)
        {
            Forms_Compras compras = new Forms_Compras();
            compras.ShowDialog();
        }

        private void btnVendaMovimentacao_Click(object sender, EventArgs e)
        {
            Forms_Venda venda = new Forms_Venda();
            venda.ShowDialog();
        }

        private void btnComprasMovimentacao_Click(object sender, EventArgs e)
        {
            Forms_Compras compras = new Forms_Compras();
            compras.ShowDialog();
        }

        private void btnConfiguracaoGerencial_Click(object sender, EventArgs e)
        {
            Forms_ConfiguracaoGerencial configuracaoGerencial = new Forms_ConfiguracaoGerencial();
            configuracaoGerencial.ShowDialog();
        }

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            Forms_DespesasCustos despesas = new Forms_DespesasCustos("Despesa");
            despesas.ShowDialog();
        }

        private void btnLançarContasAPagar_Click(object sender, EventArgs e)
        {
            Forms_DespesasCustos custos = new Forms_DespesasCustos("Custo");
            custos.ShowDialog();
        }
    }
}