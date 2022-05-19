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
    public partial class CadastroDespesas : Form
    {
        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        private MensagensErro Erro = new MensagensErro();

        private ManipulacaoTextBox TextBox = new ManipulacaoTextBox();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private ExcluirNoBanco Excluir = new ExcluirNoBanco();

        public CadastroDespesas()
        {
            InitializeComponent();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Botao Buscar

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            PesquisarDespesa buscarCliente = new PesquisarDespesa();
            buscarCliente.ShowDialog();
        }

        #endregion Botao Buscar

        #region Botao Salvar

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeDespesa(txtDescricao.Text) == false)
                    {
                        Salvar.InserirCadastroDespesa(
                       txtDescricao.Text,
                       txtTipo.Text);

                        txtCodigo.Text = Buscar.BuscarCodigoDespesa(txtDescricao.Text).ToString();

                        //Chamar o forms de alerta de inclusao com sucesso
                        Global.tipoDoAlerta = "Inclusao";

                        Aviso buscarCliente = new Aviso();
                        buscarCliente.Show();
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeDespesa(txtDescricao.Text) == true)
                    {
                        MessageBox.Show("Despesa Já Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoInserirCadastroDespesa(ex);
            }
        }

        #endregion Botao Salvar

        #region Botao Alterar

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeDespesa(txtDescricao.Text) == true)
                    {
                        Atualizar.AtualizarCadastroDespesa(
                            Convert.ToInt32(txtCodigo.Text),
                            txtDescricao.Text,
                            txtTipo.Text);

                        //Chamar o forms de alerta de atualizacao com sucesso
                        Global.tipoDoAlerta = "Atualizacao";

                        Aviso buscarCliente = new Aviso();
                        buscarCliente.Show();
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeDespesa(txtDescricao.Text) == false)
                    {
                        MessageBox.Show("Despesa Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Preenchimento Dos Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCadastroDespesa(ex);
            }
        }

        #endregion Botao Alterar

        #region Botao Excluir

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox.VerificarPreenchimentoTextBox(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeDespesa(txtDescricao.Text) == true)
                    {
                        Excluir.ExcluirCadastroDespesa(Convert.ToInt32(txtCodigo.Text), txtDescricao.Text);

                        //Chamar o forms de alerta de exclusao com sucesso
                        Global.tipoDoAlerta = "Exclusao";

                        Aviso buscarCliente = new Aviso();
                        buscarCliente.Show();
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeDespesa(txtDescricao.Text) == false)
                    {
                        MessageBox.Show("Cliente Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirCadastroDespesa(ex);
            }
        }

        #endregion Botao Excluir
    }
}