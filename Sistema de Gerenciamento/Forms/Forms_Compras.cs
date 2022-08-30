using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Sistema_de_Gerenciamento.Classes;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_Compras : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        public List<DadosNotaFiscalEntrada> listaDadosNotaFiscalEntrada = new List<DadosNotaFiscalEntrada>();

        public List<DadosEstoqueProduto> listaDadosEstoqueProdutos = new List<DadosEstoqueProduto>();

        public DadosEstoqueProduto estoqueProduto;

        public DadosNotaFiscalEntrada notaFiscalEntrada;

        public Forms_Compras()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            BuscarCompra();
        }

        private void BuscarCompra()
        {
            try
            {
                if (txtNumeroNotaFiscal.Text != string.Empty)
                {
                    if ((listaDadosNotaFiscalEntrada = Buscar.BuscarNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text))) == null)
                    {
                        MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Buscar.BuscarNotaFiscalEntradaPreencherGridView(Convert.ToInt32(txtNumeroNotaFiscal.Text), gdvCompra);

                        txtFornecedor.Text = listaDadosNotaFiscalEntrada[0].razaoSocial;
                        txtCNPJ.Text = listaDadosNotaFiscalEntrada[0].cnpj;
                        txtTotalItens.Text = Buscar.BuscarQuantidadeDeItensNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text)).ToString();
                        txtValorTotal.Text = string.Format("{0:C}", Buscar.BuscarValorTotalNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text))).ToString();

                        SetarDesignForms();
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarNotaFiscalEntrada(ex);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (SalvarCompras() == true)
            {
                LancarCustos();
            }
        }

        private bool SalvarCompras()
        {
            try
            {
                if (txtNumeroNotaFiscal.Text != string.Empty)
                {
                    if ((listaDadosNotaFiscalEntrada = Buscar.BuscarNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text))) == null)
                    {
                        MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if ((VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(listaDadosNotaFiscalEntrada[0].cnpj)) == false)
                    {
                        MessageBox.Show("Fornecedor Não Cadastrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeDescricaoProduto(listaDadosNotaFiscalEntrada[0].descricao) == false)
                    {
                        MessageBox.Show("Produto Não Cadastrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (VerificarExistencia.VerificarSeEstoqueFoiConsumidoSalvar(Convert.ToInt32(txtNumeroNotaFiscal.Text)) == true)
                    {
                        MessageBox.Show("Nota Fiscal Já Foi Dado Entrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (gdvCompra.RowCount > 0)
                    {
                        SetarDesignForms();

                        Buscar.BuscarNotaFiscalEntradaPreencherGridView(Convert.ToInt32(txtNumeroNotaFiscal.Text), gdvCompra);

                        Global.tipoEntrada = "Entrada";

                        if (ComparacaoValorCadastroProdutoNFEntrada() == true)
                        {
                            InserirProdutoEstoque();

                            Atualizar.AtualizarDataLancamentoNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text));

                            PreencherListaNotaFiscalEntradaAbrirFormsCadastroCodigoBarras();

                            return true;
                        }

                        return false;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                Erro.ErroAoSalvarNotaFiscalEntrada(ex);
                return false;
            }
        }

        private bool ComparacaoValorCadastroProdutoNFEntrada()
        {
            for (int i = 0; i < gdvCompra.RowCount; i++)
            {
                int codigoProduto = Convert.ToInt32(gdvCompra.Rows[i].Cells[4].Value);

                int numeroNFEntrada = Convert.ToInt32(gdvCompra.Rows[i].Cells[1].Value);

                bool isValoresCorretos = VerificarExistencia.ComparacaoValorProdutoCadastroNFEntrada(codigoProduto, numeroNFEntrada);

                if (isValoresCorretos == false)
                {
                    MessageBox.Show("Valores dos Produtos Em Nota Fiscal Divergente Dos Valores No Cadastro Do Produto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return false;
                }
            }

            return true;
        }

        private void PreencherListaNotaFiscalEntradaAbrirFormsCadastroCodigoBarras()
        {
            listaDadosNotaFiscalEntrada.ForEach(nf => notaFiscalEntrada = nf);

            Forms_CadastroCodigoBarras inserirCodigoBarras = new Forms_CadastroCodigoBarras(this);
            inserirCodigoBarras.ShowDialog();
        }

        private void InserirProdutoEstoque()
        {
            for (int i = 0; i < gdvCompra.RowCount; i++)
            {
                int codigoProduto = Convert.ToInt32(gdvCompra.Rows[i].Cells[4].Value);

                Salvar.InserirEstoqueProduto(Convert.ToInt32(txtNumeroNotaFiscal.Text), codigoProduto);
            }
        }

        private void LancarCustos()
        {
            DialogResult OpcaoDoUsuario = new DialogResult();
            OpcaoDoUsuario = MessageBox.Show("Deseja Inserir Nos Custos?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (OpcaoDoUsuario == DialogResult.Yes)
            {
                Forms_DespesasCustos custos = new Forms_DespesasCustos("Custos");
                custos.cmbTipoDespesa.Text = "Variavel";
                custos.cmbTipoDespesa.Enabled = false;
                custos.cmbFornecedorTitulo.Text = "Fornecedor";
                custos.cmbFornecedorTitulo.Enabled = false;
                custos.txtCNPJ.Text = txtCNPJ.Text;
                custos.txtCNPJ.Enabled = false;
                custos.txtEmissao.Text = Convert.ToDateTime(listaDadosNotaFiscalEntrada[0].dataEmissao).ToShortDateString();
                custos.txtEmissao.Enabled = false;
                custos.txtValor.Text = txtValorTotal.Text;
                custos.txtValor.Enabled = false;
                custos.btnBuscar.Visible = false;
                custos.btnAlterar.Visible = false;
                custos.btnExcluir.Visible = false;
                custos.btnNova.Visible = false;
                custos.btnSalvar.Location = new Point(11, 25);
                custos.bntSair.Location = new Point(88, 25);
                custos.lblCategoria.Text = "Custo";

                custos.txtDescricao.Text = ($"Nº Nota Fiscal: { txtNumeroNotaFiscal.Text } - Fornecedor: { txtFornecedor.Text }");

                custos.ShowDialog();
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExlcuirCompra();
        }

        private void ExlcuirCompra()
        {
            try
            {
                if (txtNumeroNotaFiscal.Text != string.Empty)
                {
                    if (Buscar.QuantidadeTotalProdutoNotaEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text)) !=
                        Buscar.QuantidadeTotalEstoqueProdutoMesmaNFEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text)))
                    {
                        MessageBox.Show("Nota Fiscal Indisponivel Para Exclusão! \n\n Saldo Já Movimentado", "Informação!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else if ((listaDadosNotaFiscalEntrada = Buscar.BuscarNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text))) == null)
                    {
                        MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if ((VerificarExistencia.VerificarExistenciaDeCNPJFornecedor(listaDadosNotaFiscalEntrada[0].cnpj)) == false)
                    {
                        MessageBox.Show("Fornecedor Não Cadastrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeDescricaoProduto(listaDadosNotaFiscalEntrada[0].descricao) == false)
                    {
                        MessageBox.Show("Produto Não Cadastrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (gdvCompra.RowCount > 0)
                    {
                        DialogResult OpcaoDoUsuario = new DialogResult();
                        OpcaoDoUsuario = MessageBox.Show("Deseja Realmente Excluir a Nota Fiscal?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (OpcaoDoUsuario == DialogResult.Yes)
                        {
                            Atualizar.AtualizarQuantidadeEstoqueProdutoNotaFiscalEntradaCancelada(Convert.ToInt32(txtNumeroNotaFiscal.Text));

                            Atualizar.AtualizarDataLancamentoNotaFiscalEntradaQuandoCancelada(Convert.ToInt32(txtNumeroNotaFiscal.Text));

                            ManipulacaoTextBox.ApagandoTextBox(this);

                            LimparGrid(gdvCompra);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroExcluirNotaFiscalEntrada(ex);
            }
        }

        private void LimparGrid(BunifuDataGridView _tabela)
        {
            if (_tabela.Rows.Count > 0)
            {
                do
                {
                    _tabela.Rows.RemoveAt(0);
                } while (_tabela.Rows.Count > 0);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarCodigoBarras();
        }

        private void AlterarCodigoBarras()
        {
            try
            {
                if (txtNumeroNotaFiscal.Text != string.Empty)
                {
                    if ((listaDadosEstoqueProdutos = Buscar.BuscarEstoqueProdutoListaProduto(Convert.ToInt32(txtNumeroNotaFiscal.Text))) == null)
                    {
                        MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (VerificarExistencia.VerificarSeEstoqueFoiConsumido(Convert.ToInt32(txtNumeroNotaFiscal.Text)) !=
                        Buscar.QuantidadeTotalProdutoNotaEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text)))
                    {
                        MessageBox.Show("Nota Fiscal Indisponivel Para Alteração!", "Informação!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else if (gdvEstoque.RowCount == 0)
                    {
                        Buscar.BuscarEstoqueProdutoPreencherGridView(Convert.ToInt32(txtNumeroNotaFiscal.Text), gdvEstoque);

                        LayoutFormsCompra();

                        PreencherEstoqueProdutoAbrirFormsCadastroCodiBarras();
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAlterarCodigoBarrasNotaFiscalEntrada(ex);
            }
        }

        private void LayoutFormsCompra()
        {
            gdvEstoque.Visible = true;
            gdvCompra.Visible = false;

            this.Size = new Size(686, 554);

            Global.tipoEntrada = "Alterar";
        }

        private void PreencherEstoqueProdutoAbrirFormsCadastroCodiBarras()
        {
            listaDadosEstoqueProdutos.ForEach(nf => estoqueProduto = nf);

            Forms_CadastroCodigoBarras inserirCodigoBarras = new Forms_CadastroCodigoBarras(this);
            inserirCodigoBarras.ShowDialog();
        }

        private void txtNumeroNotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void SetarDesignForms()
        {
            this.gdvCompra.Columns["ne_valor_unitario"].DefaultCellStyle.Format = "c";
            this.gdvCompra.Columns["ne_valor_total"].DefaultCellStyle.Format = "c";

            gdvEstoque.Visible = false;
            gdvCompra.Visible = true;

            this.Size = new Size(958, 554);
        }

        private void Forms_Compras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
            else if (e.KeyCode == Keys.F10)
            {
                if (SalvarCompras() == true)
                {
                    LancarCustos();
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                AlterarCodigoBarras();
            }
            else if (e.KeyCode == Keys.F3)
            {
                ExlcuirCompra();
            }
        }
    }
}