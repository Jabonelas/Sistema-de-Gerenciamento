using Sistema_de_Gerenciamento.Classes;
using Sistema_de_Gerenciamento.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento
{
    public partial class Forms_CadastroProduto : Form
    {
        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        private ExcluirNoBanco Excluir = new ExcluirNoBanco();

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        public Forms_CadastroProduto()
        {
            InitializeComponent();

            PreencherComboBoxGrupo();

            PreencherComboBoxFornecedor();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            NovoCadastroProduto();
        }

        #region Novo Cadastro Produto

        private void NovoCadastroProduto()
        {
            ManipulacaoTextBox.ApagandoTextBox(this);

            pcbProduto.Image = Image.FromFile(@"C:\Users\israe\source\repos\Sistema de Gerenciamento\Sistema de Gerenciamento\Resources\camera3.png");

            PreencherComboBoxGrupo();

            PreencherComboBoxFornecedor();
        }

        #endregion Novo Cadastro Produto

        #region Botao Salvar

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCadastroProduto();
        }

        #endregion Botao Salvar

        #region Salvar Cadastro Produto

        private void SalvarCadastroProduto()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeDescricaoProduto(txtDescricao.Text) == false)
                    {
                        lblCodigo.Text = (Salvar.InserirImagemNoCadastroProduto(pcbProduto.Image)).ToString();

                        txtCodigo.Text = (Salvar.InserirCadastroProduto(txtDescricao.Text,
                            cmbUn.Text,
                            Convert.ToDecimal(txtValorDeCusto.Text.Replace("R$ ", string.Empty)),
                            Convert.ToDecimal(txtPorcentagem.Text.Replace(" %", string.Empty)),
                            Convert.ToDecimal(txtValorVenda.Text.Replace("R$ ", string.Empty)),
                            Convert.ToDecimal(txtLucro.Text.Replace("R$ ", string.Empty)),
                            Convert.ToDecimal(txtPrecoAtacado.Text.Replace("R$ ", string.Empty)),
                            cmbGrupo.Text,
                            cmbSubGrupo.Text,
                            cmbFornecedor.Text,
                            Convert.ToDecimal(txtEstoqueMinimo.Text),
                            txtGarantia.Text,
                            txtMarca.Text,
                            txtReferencia.Text,
                            Convert.ToDateTime(txtValidade.Text),
                            Convert.ToDecimal(txtComissao.Text.Replace(" %", string.Empty)),
                            txtObservacoes.Text,
                            Convert.ToInt32(lblCodigo.Text))).ToString();
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeDescricaoProduto(txtDescricao.Text) == true)
                    {
                        MessageBox.Show("Produto Já Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCadastroProduto(ex);
            }
        }

        #endregion Salvar Cadastro Produto

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            AtualizarCadastroProduto();
        }

        #region Atualizar Cadastro Produto

        private void AtualizarCadastroProduto()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeDescricaoProduto(txtDescricao.Text) == true)
                    {
                        Atualizar.AtualizarCadastroProduto(txtDescricao.Text,
                            cmbUn.Text,
                            Convert.ToDecimal(txtValorDeCusto.Text.Replace("R$ ", string.Empty)),
                            Convert.ToDecimal(txtPorcentagem.Text.Replace(" %", string.Empty)),
                            Convert.ToDecimal(txtValorVenda.Text.Replace("R$ ", string.Empty)),
                            Convert.ToDecimal(txtLucro.Text.Replace("R$ ", string.Empty)),
                            Convert.ToDecimal(txtPrecoAtacado.Text.Replace("R$ ", string.Empty)),
                            cmbGrupo.Text,
                            cmbSubGrupo.Text,
                            cmbFornecedor.Text,
                            Convert.ToDecimal(txtEstoqueMinimo.Text),
                            txtGarantia.Text,
                            txtMarca.Text,
                            txtReferencia.Text,
                            Convert.ToDateTime(txtValidade.Text),
                            Convert.ToDecimal(txtComissao.Text.Replace(" %", string.Empty)),
                            txtObservacoes.Text);

                        Atualizar.AtualizarImagemNoCadastroProduto(pcbProduto.Image, Convert.ToInt32(txtCodigo.Text));
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeDescricaoProduto(txtDescricao.Text) == false)
                    {
                        MessageBox.Show("Produto Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCadastroProduto(ex);
            }
        }

        #endregion Atualizar Cadastro Produto

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            Forms_PesquisarProduto buscarProduto = new Forms_PesquisarProduto(this);
            buscarProduto.ShowDialog();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            ExcluirCadastroProduto();
        }

        #region Excluir Cadastro Produto

        private void ExcluirCadastroProduto()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    if (VerificarExistencia.VerificarExistenciaDeDescricaoProduto(txtDescricao.Text) == true)
                    {
                        Excluir.ExcluirCadastroProduto(txtDescricao.Text);

                        Excluir.ExcluirImagemProduto(Convert.ToInt32(txtCodigo.Text));
                    }
                    else if (VerificarExistencia.VerificarExistenciaDeDescricaoProduto(txtDescricao.Text) == false)
                    {
                        MessageBox.Show("Produto Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirCadastroProduto(ex);
            }
        }

        #endregion Excluir Cadastro Produto

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserirImagemProduto_Click(object sender, EventArgs e)
        {
            InserirImagemProduto();
        }

        #region Inserir Imagem Produto

        private void InserirImagemProduto()
        {
            OpenFileDialog abrirPesquisa = new OpenFileDialog();

            abrirPesquisa.Filter = "Abrir Imagem (*.jpg; *.png; *.gif) |*.jpg; *.png; *.gif ";
            if (abrirPesquisa.ShowDialog() == DialogResult.OK)
            {
                pcbProduto.Image = Image.FromFile(abrirPesquisa.FileName);
            }
        }

        #endregion Inserir Imagem Produto

        private void txtValorDeCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoDinheiro(e, sender, txtValorDeCusto);
        }

        private void txtPorcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e))
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtPorcentagem.Text, sender);
            }
        }

        private void txtPorcentagem_Leave(object sender, EventArgs e)
        {
            GerarValorDeVenda_Lucro();
        }

        #region Gerar Valor De Venda e Valor de Lucro

        private void GerarValorDeVenda_Lucro()
        {
            if (txtValorDeCusto.Text != String.Empty)
            {
                decimal valorDeCusto = Convert.ToDecimal(txtValorDeCusto.Text.Replace("R$ ", string.Empty));
                decimal porcentagem = Convert.ToDecimal(txtPorcentagem.Text.Replace(" %", string.Empty));
                decimal lucro = (valorDeCusto * porcentagem / 100);

                txtValorVenda.Text = ($"R$ {(valorDeCusto + lucro).ToString("N2")}");

                txtLucro.Text = ($"R$ {(lucro).ToString("N2")}");
            }
        }

        #endregion Gerar Valor De Venda e Valor de Lucro

        private void txtPrecoAPrazoAtacado_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.FormatoDinheiro(e, sender, txtPrecoAtacado);
        }

        private void txtComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtComissao.Text, sender);
            }
        }

        private void txtValidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoData(txtValidade);
            }
        }

        private void txtValidade_Leave(object sender, EventArgs e)
        {
            if (ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtValidade) == true)
            {
                ManipulacaoTextBox.FormatoData(txtValidade);
            }
        }

        private void txtEstoqueMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e))
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtEstoqueMinimo.Text, sender);
            }
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreenchimentoSubGrupo();
        }

        #region Preenchimento do ComboBox Sub-Grupo

        private void PreenchimentoSubGrupo()
        {
            List<DadosSubGrupoMaterial> listaSubGrupo = new List<DadosSubGrupoMaterial>();

            listaSubGrupo = Buscar.BuscarSubGrupoProduto(cmbGrupo.Text);

            cmbSubGrupo.Items.Clear();

            listaSubGrupo.ForEach(prod => cmbSubGrupo.Items.Add(prod.sub_grupo));
        }

        #endregion Preenchimento do ComboBox Sub-Grupo

        private void cmbSubGrupo_Enter(object sender, EventArgs e)
        {
            VerificarPreenchimentoGrupo();
        }

        #region Verificar Se o ComboBox Grupo Esta Preenchdo

        private void VerificarPreenchimentoGrupo()
        {
            if (cmbGrupo.Text == string.Empty)
            {
                MessageBox.Show("Por Favor Preencha Primeiro O Campo Grupo!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbGrupo.Focus();
            }
        }

        #endregion Verificar Se o ComboBox Grupo Esta Preenchdo

        #region Preencher Combobox Grupo

        private void PreencherComboBoxGrupo()
        {
            List<DadosGrupoMaterial> listaGrupo = new List<DadosGrupoMaterial>();

            listaGrupo = Buscar.BuscarGrupoProduto();

            cmbGrupo.Items.Clear();

            listaGrupo.ForEach(prod => cmbGrupo.Items.Add(prod.grupo));
        }

        #endregion Preencher Combobox Grupo

        #region Preencher ComboBox Fornecedor

        private void PreencherComboBoxFornecedor()
        {
            cmbFornecedor.Items.Clear();

            foreach (var item in Buscar.BuscarListaForcedor())
            {
                cmbFornecedor.Items.Add(item);
            }
        }

        #endregion Preencher ComboBox Fornecedor

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtObservacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }
    }
}