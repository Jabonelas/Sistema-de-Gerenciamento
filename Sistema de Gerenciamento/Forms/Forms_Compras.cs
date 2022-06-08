﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        #region Buscar Compra

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

        #endregion Buscar Compra

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCompras();
        }

        #region Salvar Compras

        private void SalvarCompras()
        {
            try
            {
                //gdvCompra.DataSource = null; //Remover a datasource
                //gdvCompra.Columns.Clear(); //Remover as colunas
                //gdvCompra.Rows.Clear(); //Remover as linhas
                //gdvCompra.Refresh(); //Para a grid se actualizar
                //emp.clear(); //limpar a dataset que é utilizado para preencher a datagrid

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
                    else if (VerificarExistencia.VerificarSeEstoqueFoiConsumidoSalvar(Convert.ToInt32(txtNumeroNotaFiscal.Text)) == true) //verificação de existencia de nota fiscal
                    {
                        MessageBox.Show("Nota Fiscal Já Foi Dado Entrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (gdvCompra.RowCount > 0)
                    {
                        SetarDesignForms();

                        Buscar.BuscarNotaFiscalEntradaPreencherGridView(Convert.ToInt32(txtNumeroNotaFiscal.Text), gdvCompra);

                        Global.tipoEntrada = "Entrada";

                        Salvar.InserirEstoqueProduto(Convert.ToInt32(txtNumeroNotaFiscal.Text));

                        Atualizar.AtualizarDataLancamentoNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text));

                        listaDadosNotaFiscalEntrada.ForEach(nf => notaFiscalEntrada = nf);

                        Forms_CadastroCodigoBarras inserirCodigoBarras = new Forms_CadastroCodigoBarras(this);
                        inserirCodigoBarras.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoSalvarNotaFiscalEntrada(ex);
            }
        }

        #endregion Salvar Compras

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExlcuirCompra();
        }

        #region Excluir Compras

        private void ExlcuirCompra()
        {
            try
            {
                if (txtNumeroNotaFiscal.Text != string.Empty)
                {
                    if (VerificarExistencia.VerificarSeEstoqueFoiConsumido(Convert.ToInt32(txtNumeroNotaFiscal.Text)) !=
                        Buscar.BuscarQuantidadeDeItensNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text)))
                    {
                        MessageBox.Show("Nota Fiscal Indisponivel Para Exclusão!", "Informação!", MessageBoxButtons.OK,
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
                        SetarDesignForms();

                        Atualizar.AtualizarQuantidadeCanceladaEstoqueProduto(Convert.ToInt32(txtNumeroNotaFiscal.Text));

                        Atualizar.AtualizarDataLancamentoNotaFiscalEntradaQuandoCancelada(Convert.ToInt32(txtNumeroNotaFiscal.Text));

                        txtNumeroNotaFiscal.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroExcluirNotaFiscalEntrada(ex);
            }
        }

        #endregion Excluir Compras

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarCodigoBarras();
        }

        #region Alterar Codigo de Barras

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
                        Buscar.BuscarQuantidadeDeItensNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text)))
                    {
                        MessageBox.Show("Nota Fiscal Indisponivel Para Alteração!", "Informação!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else if (gdvEstoque.RowCount == 0)
                    {
                        //this.gdvEstoque.Columns["ep_valor_unitario"].DefaultCellStyle.Format = "c";

                        gdvEstoque.Visible = true;
                        gdvCompra.Visible = false;

                        Buscar.BuscarEstoqueProdutoPreencherGridView(Convert.ToInt32(txtNumeroNotaFiscal.Text), gdvEstoque);

                        this.Size = new Size(686, 554);

                        Global.tipoEntrada = "Alterar";

                        listaDadosEstoqueProdutos.ForEach(nf => estoqueProduto = nf);

                        Forms_CadastroCodigoBarras inserirCodigoBarras = new Forms_CadastroCodigoBarras(this);
                        inserirCodigoBarras.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAlterarCodigoBarrasNotaFiscalEntrada(ex);
            }
        }

        #endregion Alterar Codigo de Barras

        private void txtNumeroNotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        #region Setar o Design Do Forms

        private void SetarDesignForms()
        {
            this.gdvCompra.Columns["ne_valor_unitario"].DefaultCellStyle.Format = "c";
            this.gdvCompra.Columns["ne_valor_total"].DefaultCellStyle.Format = "c";

            gdvEstoque.Visible = false;
            gdvCompra.Visible = true;

            this.Size = new Size(958, 554);
        }

        #endregion Setar o Design Do Forms
    }
}