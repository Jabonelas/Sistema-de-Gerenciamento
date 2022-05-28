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

        public Forms_Compras()
        {
            InitializeComponent();
        }

        #region TextBox Numero da Nota Fiscal

        private void txtNumeroNotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Numero da Nota Fiscal

        #region Botao Buscar

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeroNotaFiscal.Text != string.Empty)
                {
                    if (Buscar.BuscarNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text), gdvCompra) == true)//verificação de existencia de nota fiscal
                    {
                        //Buscar.BuscarNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text), gdvCompra);
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

        #endregion Botao Buscar

        #region Botao Salvar

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeroNotaFiscal.Text != string.Empty)
                {
                    if (VerificarExistencia.VerificarSeEstoqueFoiConsumidoSalvar(Convert.ToInt32(txtNumeroNotaFiscal.Text)) == false) //verificação de existencia de nota fiscal
                    {
                        if (Buscar.BuscarNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text), gdvCompra) == true)//verificação de existencia de nota fiscal
                        {
                            for (int indiceDoItem = 1; indiceDoItem <= Buscar.BuscarQuantidadeDeItensNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text)); indiceDoItem++)
                            {
                                for (int quantidadePorCadaItem = 1; quantidadePorCadaItem <= Buscar.BuscarQuantidadeDeCadaItemNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text), indiceDoItem); quantidadePorCadaItem++)
                                {
                                    int quantidade = 1;

                                    Salvar.InserirEstoqueProduto(indiceDoItem, Convert.ToInt32(txtNumeroNotaFiscal.Text));

                                    Atualizar.AtualizarQuantidadeEDataEntradaEstoqueProduto(quantidade, Convert.ToInt32(txtNumeroNotaFiscal.Text));

                                    Atualizar.AtualizarDataLancamentoNotaFiscalEntrada(Convert.ToInt32(txtNumeroNotaFiscal.Text));

                                    Global.tipoDoAlerta = "Inclusao";

                                    Forms_Aviso buscarCliente = new Forms_Aviso();
                                    buscarCliente.Show();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nota Fiscal Já Consumida!", "Informação!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarNotaFiscalEntrada(ex);
            }
        }

        #endregion Botao Salvar

        #region Botao Sair

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Sair

        #region Botao Excluir

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNumeroNotaFiscal.Text != string.Empty)
            {
                if (VerificarExistencia.VerificarSeEstoqueFoiConsumidoExcluir(Convert.ToInt32(txtNumeroNotaFiscal.Text)) == false)//verificação de existencia de nota fiscal
                {
                    Atualizar.AtualizarQuantidadeCanceladaEstoqueProduto(Convert.ToInt32(txtNumeroNotaFiscal.Text));

                    Atualizar.AtualizarDataLancamentoNotaFiscalEntradaQuandoCancelada(Convert.ToInt32(txtNumeroNotaFiscal.Text));

                    Global.tipoDoAlerta = "Exclusao";

                    Forms_Aviso buscarCliente = new Forms_Aviso();
                    buscarCliente.Show();
                }
                else
                {
                    MessageBox.Show("Nota Fiscal Já Cancelada!", "Informação!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        #endregion Botao Excluir
    }
}