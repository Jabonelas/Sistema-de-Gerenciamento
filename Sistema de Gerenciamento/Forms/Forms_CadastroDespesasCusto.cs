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
                    else if (VerificarExistencia.VerificarExistenciaDeDespesa(txtTitulo.Text) == false)
                    {
                        Salvar.InserirCadastroDespesa(txtTitulo.Text, cmbTipo.Text, lblCategoria.Text);

                        txtCodigo.Text = Buscar.BuscarCodigoDespesa(txtTitulo.Text).ToString();
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeDespesa(txtTitulo.Text) == true)
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
                    if (VerificarExistencia.VerificarExistenciaDeDespesa(txtTitulo.Text) == false)
                    {
                        MessageBox.Show("Despesa Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Atualizar.AtualizarCadastroDespesa(Convert.ToInt32(txtCodigo.Text), txtTitulo.Text,
                            cmbTipo.Text, lblCategoria.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCadastroDespesa(ex);
            }
        }

        #endregion Atualziar Casdastro de Despesas

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Forms_PesquisarCadastroDespesaCusto buscarDespesasCusto = new Forms_PesquisarCadastroDespesaCusto(this);
            buscarDespesasCusto.ShowDialog();
        }

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
                    if (VerificarExistencia.VerificarExistenciaDeDespesa(txtTitulo.Text) == false)
                    {
                        MessageBox.Show("Cliente Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Excluir.ExcluirCadastroDespesa(Convert.ToInt32(txtCodigo.Text), txtTitulo.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirCadastroDespesa(ex);
            }
        }

        #endregion Excluir Cadastro Despesa

        private void chbDespesa_Click(object sender, EventArgs e)
        {
            LayoutDespesa();
        }

        #region LayoutDespesa

        private void LayoutDespesa()
        {
            if (chbDespesa.Checked == true)
            {
                chbCusto.Checked = false;

                lblDescricao.Text = "Titulo Despesa";
                lblTipo.Text = "Tipo Despesa";

                lblCategoria.Text = "Despesa";
                this.Text = "Cadastro Despesa";
            }
        }

        #endregion LayoutDespesa

        private void chbCusto_Click(object sender, EventArgs e)
        {
            LayoutCusto();
        }

        #region Layout Custo

        private void LayoutCusto()
        {
            if (chbCusto.Checked == true)
            {
                chbDespesa.Checked = false;

                lblDescricao.Text = "Titulo Custo";
                lblTipo.Text = "Tipo Custo";

                lblCategoria.Text = "Custo";
                this.Text = "Cadastro Custo";
            }
        }

        #endregion Layout Custo

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }
    }
}