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
using Sistema_de_Gerenciamento.Classes;
using System.Threading;

namespace Sistema_de_Gerenciamento
{
    public partial class Forms_TelaAdministrador : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private Forms_Login login;

        public Forms_TelaAdministrador()
        {
            InitializeComponent();
        }

        public Forms_TelaAdministrador(Forms_Login _login)
        {
            InitializeComponent();

            Task.Run(() =>
            {
                Thread.Sleep(1000);
                AutomatizacaoDespesaCustoFixo();
            });

            LayoutUsuario();

            TimerVerificarDespesaCustoFixo.Enabled = true;

            login = _login;
        }

        private void tabCadastro_Click(object sender, EventArgs e)
        {
            LayoutUsuario();
        }

        #region Layout Usuario

        private void LayoutUsuario()
        {
            if (Global.NomeDeUsuario == "ADMIN")
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

                btnTrocaConsole.Location = new Point(6, 400);
                btnDespesasConsole.Location = new Point(161, 400);
                btnComprasConsole.Location = new Point(317, 400);
                btnResumoVendasConsole.Location = new Point(472, 400);
                btnFluxoCaixaConsole.Location = new Point(625, 400);
                btnSair.Location = new Point(778, 400);
                tabControl.Visible = false;
            }
        }

        #endregion Layout Usuario

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

        private void btnClienteConsole_Click(object sender, EventArgs e)
        {
            Forms_PesquisarCliente pesquisarCliente = new Forms_PesquisarCliente("Cliente");
            pesquisarCliente.ShowDialog();
        }

        private void TimerVerificarDespesaCustoFixo_Tick(object sender, EventArgs e)
        {
            AutomatizacaoDespesaCustoFixo();
        }

        #region Automatizacao Despesa e Custo Fixo

        private void AutomatizacaoDespesaCustoFixo()
        {
            int dias = 0;

            List<DadosDespesaCusto> listaDespesasCustos = Buscar.BuscarListaDespesaCustoFixa();

            foreach (DadosDespesaCusto despesaCusto in listaDespesasCustos)
            {
                if (despesaCusto.vencimento <= DateTime.Today && despesaCusto.verificar == "nok")
                {
                    if (Global.NomeDeUsuario == "ADMIN" && despesaCusto.statusPagamento == "Nao Pago")
                    {
                        MessageBox.Show($"Despesa/Custo - {despesaCusto.forncedorTitulo}\n\nVencimento {despesaCusto.vencimento.ToShortDateString()}",
                            "Pagamento Pendente Despesa/Custo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    Atualizar.AtualziarCodigoDespesaCustosFixoRepeticao(despesaCusto.codigo);

                    bool semanal = despesaCusto.frequencia == "Semanal" ? Convert.ToBoolean(dias = 7) : false;
                    bool quinzenal = despesaCusto.frequencia == "Quinzenal" ? Convert.ToBoolean(dias = 15) : false;
                    bool mensal = despesaCusto.frequencia == "Mensal" ? Convert.ToBoolean(dias = 30) : false;
                    bool bimestral = despesaCusto.frequencia == "Bimestral" ? Convert.ToBoolean(dias = 90) : false;
                    bool semestral = despesaCusto.frequencia == "Semestral" ? Convert.ToBoolean(dias = 180) : false;
                    bool anual = despesaCusto.frequencia == "Anual" ? Convert.ToBoolean(dias = 365) : false;

                    Salvar.DespesaCustosFixoRepeticao(despesaCusto.codigo, despesaCusto.tipo, despesaCusto.descricao, despesaCusto.forncedorTitulo,
                        despesaCusto.cnpj, despesaCusto.emissao, despesaCusto.vencimento.AddDays(dias), despesaCusto.frequencia,
                        despesaCusto.valor, despesaCusto.quantidadeParcelas, despesaCusto.valorParcela, despesaCusto.categoria,
                        ptbStatusPagamento.Image);
                }
            }
        }

        #endregion Automatizacao Despesa e Custo Fixo

        private void btnPDV_Click(object sender, EventArgs e)
        {
            Forms_PDV telaPdv = new Forms_PDV();
            telaPdv.ShowDialog();
        }

        private void btnPDVConsole_Click(object sender, EventArgs e)
        {
            Forms_PDV pesquisarCliente = new Forms_PDV();
            pesquisarCliente.ShowDialog();
        }

        private void btnTrocaConsole_Click(object sender, EventArgs e)
        {
            Forms_Troca devolucaoTroca = new Forms_Troca();
            devolucaoTroca.ShowDialog();
        }

        private void btnProdutoConsole_Click(object sender, EventArgs e)
        {
            Forms_PesquisarProduto pesquisarProduto = new Forms_PesquisarProduto(this);
            pesquisarProduto.gdvPesquisarProduto.DoubleClick -= pesquisarProduto.gdvPesquisarProduto_DoubleClick;
            pesquisarProduto.gdvPesquisarProduto.KeyDown -= pesquisarProduto.gdvPesquisarProduto_KeyDown;
            pesquisarProduto.ShowDialog();
        }

        private void btnContaReceber_Click(object sender, EventArgs e)
        {
            Forms_PesquisarContasAReceber contasAReceber = new Forms_PesquisarContasAReceber();
            contasAReceber.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms_ConsultarEstoque consultarEstoque = new Forms_ConsultarEstoque();
            consultarEstoque.ShowDialog();
        }
    }
}