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
using System.IO;
using DevExpress.XtraEditors;
using Sistema_de_Gerenciamento.Properties;

namespace Sistema_de_Gerenciamento
{
    public partial class Forms_TelaAdministrador : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private List<DadosProduto> ListaProdutosComEstoqueMinimo = new List<DadosProduto>();

        private List<DadosDespesaCusto> ListaDadosDespesaCustos = new List<DadosDespesaCusto>();

        private Forms_Login login;

        private int dias = 0;

        public Forms_TelaAdministrador()
        {
            InitializeComponent();
        }

        public Forms_TelaAdministrador(Forms_Login _login)
        {
            InitializeComponent();

            AutomatizacaoVerificarDespesaCustoEstoqueMinimo();

            LayoutUsuario();

            TimerVerificarDespesaCustoFixo.Enabled = true;

            login = _login;
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

        private void btnGrupoDeMaterial_Click(object sender, EventArgs e)
        {
            Forms_CadastroGrupoProduto cadastroGrupoDeMaterial = new Forms_CadastroGrupoProduto();
            cadastroGrupoDeMaterial.ShowDialog();
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

        private void btnFluxoCaixaConsole_Click(object sender, EventArgs e)
        {
            Forms_FluxoCaixa fluxoCaixa = new Forms_FluxoCaixa();
            fluxoCaixa.ShowDialog();
        }

        private void btnResumoVendasConsole_Click(object sender, EventArgs e)
        {
            Forms_ResumoVendas resumoVendas = new Forms_ResumoVendas();
            resumoVendas.ShowDialog();
        }

        private void btnCConsultarEstoqueConsole_Click(object sender, EventArgs e)
        {
            Forms_ConsultarEstoque consultarEstoque = new Forms_ConsultarEstoque();
            consultarEstoque.ShowDialog();
        }

        private void btnConsultarEstoque_Click(object sender, EventArgs e)
        {
            Forms_ConsultarEstoque consultarEstoque = new Forms_ConsultarEstoque();
            consultarEstoque.ShowDialog();
        }

        private void btnResumoVendas_Click(object sender, EventArgs e)
        {
            Forms_ResumoVendas resumoVendas = new Forms_ResumoVendas();
            resumoVendas.ShowDialog();
        }

        private void btnFluxoCaixa_Click(object sender, EventArgs e)
        {
            Forms_FluxoCaixa fluxoCaixa = new Forms_FluxoCaixa();
            fluxoCaixa.ShowDialog();
        }

        private void tabCadastro_Click(object sender, EventArgs e)
        {
            LayoutUsuario();
        }

        private void LayoutUsuario()
        {
            if (Global.NomeDeUsuario == "ADMIN")
            {
                tabControl.Visible = true;
            }
            else
            {
                btnVendaConsole.Location = new Point(93, 100);
                btnPDVConsole.Location = new Point(245, 100);
                btnProdutoConsole.Location = new Point(394, 100);
                btnClienteConsole.Location = new Point(546, 100);
                btnCConsultarEstoqueConsole.Location = new Point(695, 100);
                btnTrocaConsole.Location = new Point(6, 400);
                btnDespesasConsole.Location = new Point(161, 400);
                btnComprasConsole.Location = new Point(317, 400);
                btnResumoVendasConsole.Location = new Point(472, 400);
                btnFluxoCaixaConsole.Location = new Point(625, 400);
                btnSair.Location = new Point(778, 400);
                tabControl.Visible = false;
            }
        }

        private void TimerVerificarDespesaCustoFixo_Tick(object sender, EventArgs e)
        {
            AutomatizacaoVerificarDespesaCustoEstoqueMinimo();
        }

        private void AutomatizacaoVerificarDespesaCustoEstoqueMinimo()
        {
            List<DadosDespesaCusto> listaDespesasCustos = Buscar.BuscarListaDespesaCustoFixa();

            foreach (DadosDespesaCusto despesaCusto in listaDespesasCustos)
            {
                AutomatizaVerificacaoContasDespesas(despesaCusto);
            }

            VerificarEstoqueMinimo();
        }

        private void VerificarEstoqueMinimo()
        {
            if (Global.NomeDeUsuario == "ADMIN")
            {
                ListaProdutosComEstoqueMinimo = Buscar.BuscarEstoqueAbaixoEstoqueMinimo();

                if (ListaProdutosComEstoqueMinimo.Count != 0)
                {
                    foreach (DadosProduto ProdutoComEstoqueMinimo in ListaProdutosComEstoqueMinimo)
                    {
                        ChamandoAlertaEstoqueBaixo(ProdutoComEstoqueMinimo.descricaoProduto, ProdutoComEstoqueMinimo.codigoProduto);
                    }
                }
            }
        }

        private void ChamandoAlertaEstoqueBaixo(string _descricaoProdruto, int _codigoProduto)
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta(_descricaoProdruto, _codigoProduto);
            alertEstoqueMinimo.Show(this, $" { msg.titulo} \n{msg.descricao}", msg.texto, "", msg.image, msg);
        }

        private void alertEstoqueMinimo_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e)
        {
            e.AlertForm.OpacityLevel = 1;
        }

        private void alertEstoqueMinimo_AlertClick(object sender, DevExpress.XtraBars.Alerter.AlertClickEventArgs e)
        {
            DadosMensagemAlerta msg = e.Info.Tag as DadosMensagemAlerta;
            XtraMessageBox.Show(msg.texto, msg.descricao);
        }

        private void AutomatizaVerificacaoContasDespesas(DadosDespesaCusto _despesaCusto)
        {
            if (_despesaCusto.vencimento <= DateTime.Today && _despesaCusto.verificar == "nok")
            {
                Atualizar.AtualziarCodigoDespesaCustosFixoRepeticao(_despesaCusto.codigo);

                if (_despesaCusto.tipo == "Fixa")
                {
                    TransformarFrenquenciaEmDias(_despesaCusto);

                    if (_despesaCusto.forncedorTitulo == "Comissao")
                    {
                        VerificarDiaPagamento(_despesaCusto);

                        _despesaCusto.valorParcela = 0;

                        InserirDespesaCustosFixosRepeticao(_despesaCusto);
                    }
                    else
                    {
                        VerificarDiaPagamento(_despesaCusto);

                        InserirDespesaCustosFixosRepeticao(_despesaCusto);
                    }
                }
            }

            VerificarUsuarioMensagemPagamentoPendente(_despesaCusto);
        }

        private void VerificarDiaPagamento(DadosDespesaCusto _despesaCusto)
        {
            DateTime data = _despesaCusto.vencimento;

            if (data.DayOfWeek == DayOfWeek.Saturday)
            {
                _despesaCusto.vencimento.AddDays(-1);
            }
            else if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                _despesaCusto.vencimento.AddDays(-2);
            }

            VerificarDiasFeriados(_despesaCusto.vencimento);
        }

        private void VerificarDiasFeriados(DateTime _dataVencimento)
        {
            const string filePath = @"C:\GitHub\Sistema-de-Gerenciamento\FeriadosNacionais.txt";

            string[] data = File.ReadAllLines(filePath);

            foreach (var item in data)
            {
                if (item == _dataVencimento.ToShortDateString())
                {
                    _dataVencimento.AddDays(-1);
                }
            }
        }

        private void VerificarUsuarioMensagemPagamentoPendente(DadosDespesaCusto _despesaCusto)
        {
            if (_despesaCusto.vencimento <= DateTime.Today && _despesaCusto.statusPagamento == "Nao Pago" && Global.NomeDeUsuario == "ADMIN")
            {
                ChamandoAlertaVencimentoContas(_despesaCusto.forncedorTitulo, _despesaCusto.vencimento.ToShortDateString());
            }
        }

        private void ChamandoAlertaVencimentoContas(string _fonecedorTitulo, string _vencimento)
        {
            DadosMensagemAlerta msg = new DadosMensagemAlerta(_fonecedorTitulo, _vencimento);
            alertEstoqueMinimo.Show(this, $" { msg.titulo} \n{msg.descricao}", msg.texto, "", msg.image, msg);
        }

        private void alertVencimentoContas_AlertClick(object sender, DevExpress.XtraBars.Alerter.AlertClickEventArgs e)
        {
            DadosMensagemAlerta msg = e.Info.Tag as DadosMensagemAlerta;
            XtraMessageBox.Show(msg.texto, msg.descricao);
        }

        private void alertVencimentoContas_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e)
        {
            e.AlertForm.OpacityLevel = 1;
        }

        private void TransformarFrenquenciaEmDias(DadosDespesaCusto _despesaCusto)
        {
            switch (_despesaCusto.frequencia)
            {
                case "Semanal":
                    dias = 7;
                    break;

                case "Quinzenal":
                    dias = 15;
                    break;

                case "Mensal":
                    dias = 30;
                    break;

                case "Bimestral":
                    dias = 90;
                    break;

                case "Semestral":
                    dias = 180;
                    break;

                case "Anual":
                    dias = 365;
                    break;
            }
        }

        private void InserirDespesaCustosFixosRepeticao(DadosDespesaCusto _despesaCusto)
        {
            Salvar.DespesaCustosFixoRepeticao(_despesaCusto.codigo, _despesaCusto.tipo, _despesaCusto.descricao, _despesaCusto.forncedorTitulo,
                                _despesaCusto.cnpj, _despesaCusto.emissao, _despesaCusto.vencimento.AddDays(dias), _despesaCusto.frequencia,
                                _despesaCusto.valor, _despesaCusto.quantidadeParcelas, _despesaCusto.valorParcela, _despesaCusto.categoria,
                                ptbStatusPagamento.Image);
        }

        private void Forms_TelaAdministrador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Forms_Sair sair = new Forms_Sair(this, login);
                sair.ShowDialog();
            }
        }

        private void btnEstatisticaFinanceiras_Click(object sender, EventArgs e)
        {
            Forms_EstatisticasFinanceiras estatisticasFinanceiras = new Forms_EstatisticasFinanceiras();
            estatisticasFinanceiras.ShowDialog();
        }
    }
}