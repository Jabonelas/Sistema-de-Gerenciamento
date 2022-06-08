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
using Sistema_de_Gerenciamento.Forms;

namespace Sistema_de_Gerenciamento
{
    public partial class Forms_CadastroDespesasCusto : Form
    {
        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        private MensagensErro Erro = new MensagensErro();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private ExcluirNoBanco Excluir = new ExcluirNoBanco();

        public Forms_CadastroDespesasCusto()
        {
            InitializeComponent();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Forms_PesquisarDespesaCusto buscarCliente = new Forms_PesquisarDespesaCusto(this);
            buscarCliente.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCastroDespesas();
        }

        #region Salvar Cadastro Despesas

        private void SalvarCastroDespesas()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    if (chbCusto.Checked == false && chbDespesa.Checked == false)
                    {
                        MessageBox.Show("Defina a Categoria!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeDespesa(txtDescricao.Text) == false)
                    {
                        Salvar.InserirCadastroDespesa(txtDescricao.Text, txtTipo.Text, lblCategoria.Text);

                        txtCodigo.Text = Buscar.BuscarCodigoDespesa(txtDescricao.Text).ToString();
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeDespesa(txtDescricao.Text) == true)
                    {
                        MessageBox.Show("Despesa/Custo Já Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoInserirCadastroDespesa(ex);
            }
        }

        #endregion Salvar Cadastro Despesas

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarCadastoDespesa();
        }

        #region Atualziar Casdastro de Despesas

        private void AlterarCadastoDespesa()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeDespesa(txtDescricao.Text) == false)
                    {
                        MessageBox.Show("Despesa Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Atualizar.AtualizarCadastroDespesa(Convert.ToInt32(txtCodigo.Text), txtDescricao.Text,
                            txtTipo.Text, lblCategoria.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCadastroDespesa(ex);
            }
        }

        #endregion Atualziar Casdastro de Despesas

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCadastroDespesa();
        }

        #region Excluir Cadastro Despesa

        private void ExcluirCadastroDespesa()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeDespesa(txtDescricao.Text) == false)
                    {
                        MessageBox.Show("Cliente Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Excluir.ExcluirCadastroDespesa(Convert.ToInt32(txtCodigo.Text), txtDescricao.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirCadastroDespesa(ex);
            }
        }

        #endregion Excluir Cadastro Despesa

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void chbDespesa_Click(object sender, EventArgs e)
        {
            if (chbDespesa.Checked == true)
            {
                chbCusto.Checked = false;

                lblDescricao.Text = "Descrição Despesa";
                lblTipo.Text = "Tipo Despesa";

                lblCategoria.Text = "Despesa";
                this.Text = "Cadastro Despesa";
            }
        }

        private void chbCusto_Click(object sender, EventArgs e)
        {
            if (chbCusto.Checked == true)
            {
                chbDespesa.Checked = false;

                lblDescricao.Text = "Descrição Custo";
                lblTipo.Text = "Tipo Custo";

                lblCategoria.Text = "Custo";
                this.Text = "Cadastro Custo";
            }
        }
    }
}