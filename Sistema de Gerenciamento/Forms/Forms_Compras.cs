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

        private void btnBuscar_Click(object sender, EventArgs e)
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
                    if ((listaDadosNotaFiscalEntrada = Buscar.BuscarNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text), gdvCompra)) != null)
                    {
                        SetarDesignForms();
                    }
                    else
                    {
                        MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                //Erro.ErroAoBuscarNotaFiscalEntrada(ex);
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
                if (txtNumeroNotaFiscal.Text != string.Empty)
                {
                    if ((listaDadosNotaFiscalEntrada = Buscar.BuscarNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text), gdvCompra)) != null)
                    {
                        if (VerificarExistencia.VerificarSeEstoqueFoiConsumidoSalvar(Convert.ToInt32(txtNumeroNotaFiscal.Text)) == false) //verificação de existencia de nota fiscal
                        {
                            SetarDesignForms();

                            Global.tipoEntrada = "Entrada";

                            Salvar.InserirEstoqueProduto(Convert.ToInt32(txtNumeroNotaFiscal.Text));

                            Atualizar.AtualizarDataLancamentoNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text));

                            listaDadosNotaFiscalEntrada.ForEach(nf => notaFiscalEntrada = nf);

                            Forms_CadastroCodigoBarras inserirCodigoBarras = new Forms_CadastroCodigoBarras(this);
                            inserirCodigoBarras.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Nota Fiscal Já Foi Dado Entrada!", "Informação!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarNotaFiscalEntrada(ex);
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
            if (txtNumeroNotaFiscal.Text != string.Empty)
            {
                if (VerificarExistencia.VerificarSeEstoqueFoiConsumidoExcluir(Convert.ToInt32(txtNumeroNotaFiscal.Text)) == false)//verificação de existencia de nota fiscal
                {
                    SetarDesignForms();

                    Atualizar.AtualizarQuantidadeCanceladaEstoqueProduto(Convert.ToInt32(txtNumeroNotaFiscal.Text));

                    Atualizar.AtualizarDataLancamentoNotaFiscalEntradaQuandoCancelada(Convert.ToInt32(txtNumeroNotaFiscal.Text));

                    txtNumeroNotaFiscal.Text = string.Empty;
                    gdvCompra.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Nota Fiscal Indisponivel Para Exclusão!", "Informação!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        #endregion Excluir Compras

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeroNotaFiscal.Text != string.Empty)
                {
                    if ((listaDadosEstoqueProdutos = Buscar.BuscarEstoqueProduto(Convert.ToInt32(txtNumeroNotaFiscal.Text), gdvEstoque)) != null)
                    {
                        if (VerificarExistencia.VerificarSeEstoqueFoiConsumidoSalvar(Convert.ToInt32(txtNumeroNotaFiscal.Text)) != false) //verificação de existencia de nota fiscal
                        {
                            this.gdvEstoque.Columns["ep_valor_unitario"].DefaultCellStyle.Format = "c";

                            gdvEstoque.Visible = true;
                            gdvCompra.Visible = false;

                            //gdvEstoque.Size = new Size(632, 303);
                            //gdvEstoque.Location = new Point(138, 196);

                            this.Size = new Size(686, 554);

                            Global.tipoEntrada = "Alterar";

                            listaDadosEstoqueProdutos.ForEach(nf => estoqueProduto = nf);

                            Forms_CadastroCodigoBarras inserirCodigoBarras = new Forms_CadastroCodigoBarras(this);
                            inserirCodigoBarras.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Nota Fiscal Já Consumida!", "Informação!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarNotaFiscalEntrada(ex);
            }
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
    }
}