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
using Sistema_de_Gerenciamento.Properties;

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

        private bool isDescricaoProtudoExiste;

        public Forms_CadastroProduto()
        {
            InitializeComponent();

            PreencherComboBoxGrupo();

            PreencherComboBoxFornecedor();

            PreencherTextBoxComissao();
        }

        private void PreencherTextBoxComissao()

        {
            decimal valorComissaoIndicadaPorAdmin = 0;

            valorComissaoIndicadaPorAdmin = Buscar.ValorComissaoIndicadaPorAdmin();

            txtComissao.Text = string.Format("{0:f} %", valorComissaoIndicadaPorAdmin);
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)

        {
            NovoCadastroProduto();
        }

        private void NovoCadastroProduto()
        {
            ManipulacaoTextBox.ApagandoTextBox(this);

            pcbProduto.Image = Resources.camera3;

            PreencherComboBoxGrupo();

            PreencherComboBoxFornecedor();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCadastroProduto();
        }

        private void SalvarCadastroProduto()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    isDescricaoProtudoExiste = VerificarExistencia.VerificarExistenciaDeDescricaoProduto(txtDescricao.Text);

                    if (isDescricaoProtudoExiste == false)
                    {
                        DadosProduto dadosProduto;
                        int codigoProduto = 0;
                        int codigoPrimaryKey = 0;

                        codigoPrimaryKey = Salvar.InserirImagemNoCadastroProduto(pcbProduto.Image);

                        lblCodigoPrimaryKey.Text = codigoPrimaryKey.ToString();

                        dadosProduto = PreencherDadosProdutos();

                        codigoProduto = Salvar.InserirCadastroProduto(dadosProduto);

                        txtCodigo.Text = codigoProduto.ToString();
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

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            AtualizarCadastroProduto();
        }

        private DadosProduto PreencherDadosProdutos()
        {
            DadosProduto dadosProduto = new DadosProduto();

            dadosProduto.codigoProduto = 0;
            dadosProduto.descricaoProduto = txtDescricao.Text;
            dadosProduto.unidade = cmbUn.Text;
            dadosProduto.valorCusto = Convert.ToDecimal(txtValorDeCusto.Text.Replace("R$ ", ""));
            dadosProduto.porcentagem = Convert.ToDecimal(txtPorcentagem.Text.Replace("%", ""));
            dadosProduto.valorVenda = Convert.ToDecimal(txtValorVenda.Text.Replace("R$ ", ""));
            dadosProduto.lucro = Convert.ToDecimal(txtLucro.Text.Replace("R$ ", ""));
            dadosProduto.precoAtacado = Convert.ToDecimal(txtPrecoAtacado.Text.Replace("R$ ", ""));
            dadosProduto.grupo = cmbGrupo.Text;
            dadosProduto.subGrupo = cmbSubGrupo.Text;
            dadosProduto.fornecedor = cmbFornecedor.Text;
            dadosProduto.estoqueMinimo = Convert.ToDecimal(txtEstoqueMinimo.Text);
            dadosProduto.garantia = Convert.ToInt32(txtGarantia.Text);
            dadosProduto.marca = txtMarca.Text;
            dadosProduto.referencia = txtReferencia.Text;
            dadosProduto.validade = Convert.ToDateTime(txtValidade.Text);
            dadosProduto.comissao = Convert.ToDecimal(txtComissao.Text.Replace("%", ""));
            dadosProduto.observacao = txtObservacoes.Text;
            dadosProduto.primarykey = Convert.ToInt32(lblCodigoPrimaryKey.Text);

            return dadosProduto;
        }

        private void AtualizarCadastroProduto()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    isDescricaoProtudoExiste = VerificarExistencia.VerificarExistenciaDeDescricaoProduto(txtDescricao.Text);

                    if (isDescricaoProtudoExiste == true)
                    {
                        DadosProduto dadosProduto;

                        dadosProduto = PreencherDadosProdutos();

                        Atualizar.AtualizarCadastroProduto(dadosProduto);

                        Atualizar.AtualizarImagemNoCadastroProduto(pcbProduto.Image, Convert.ToInt32(txtCodigo.Text));
                    }
                    else if (isDescricaoProtudoExiste == false)
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

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            Forms_PesquisarProduto buscarProduto = new Forms_PesquisarProduto(this, "Cadastro Produto");
            buscarProduto.ShowDialog();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            ExcluirCadastroProduto();
        }

        private void ExcluirCadastroProduto()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    isDescricaoProtudoExiste = VerificarExistencia.VerificarExistenciaDeDescricaoProduto(txtDescricao.Text);

                    if (isDescricaoProtudoExiste == true)
                    {
                        Excluir.ExcluirCadastroProduto(txtDescricao.Text);

                        Excluir.ExcluirImagemProduto(Convert.ToInt32(txtCodigo.Text));
                    }
                    else if (isDescricaoProtudoExiste == false)
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

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserirImagemProduto_Click(object sender, EventArgs e)
        {
            InserirImagemProduto();
        }

        private void InserirImagemProduto()
        {
            OpenFileDialog abrirPesquisa = new OpenFileDialog();

            abrirPesquisa.Filter = "Abrir Imagem (*.jpg; *.png; *.gif) |*.jpg; *.png; *.gif ";
            if (abrirPesquisa.ShowDialog() == DialogResult.OK)
            {
                pcbProduto.Image = Image.FromFile(abrirPesquisa.FileName);
            }
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreenchimentoSubGrupo();
        }

        private void PreenchimentoSubGrupo()
        {
            List<DadosSubGrupoMaterial> listaSubGrupo = new List<DadosSubGrupoMaterial>();

            listaSubGrupo = Buscar.BuscarSubGrupoProduto(cmbGrupo.Text);

            cmbSubGrupo.Items.Clear();

            listaSubGrupo.ForEach(prod => cmbSubGrupo.Items.Add(prod.sub_grupo));
        }

        private void cmbSubGrupo_Enter(object sender, EventArgs e)
        {
            VerificarPreenchimentoGrupo();
        }

        private void VerificarPreenchimentoGrupo()
        {
            if (cmbGrupo.Text == string.Empty)
            {
                MessageBox.Show("Por Favor Preencha Primeiro O Campo Grupo!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbGrupo.Focus();
            }
        }

        private void PreencherComboBoxGrupo()
        {
            List<DadosGrupoMaterial> listaGrupo = new List<DadosGrupoMaterial>();

            listaGrupo = Buscar.BuscarGrupoProduto();

            cmbGrupo.Items.Clear();

            listaGrupo.ForEach(grupoProduto => cmbGrupo.Items.Add(grupoProduto.grupo));
        }

        private void PreencherComboBoxFornecedor()
        {
            cmbFornecedor.Items.Clear();

            foreach (var item in Buscar.BuscarListaForcedor())
            {
                cmbFornecedor.Items.Add(item);
            }
        }

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

        private void GerarValorDeVenda_Lucro()
        {
            if (txtValorDeCusto.Text != string.Empty)
            {
                decimal valorDeCusto = 0;
                decimal porcentagem = 0;
                decimal lucro = 0;

                valorDeCusto = Convert.ToDecimal(txtValorDeCusto.Text.Replace("R$ ", string.Empty));
                porcentagem = Convert.ToDecimal(txtPorcentagem.Text.Replace(" %", string.Empty));
                lucro = valorDeCusto * porcentagem / 100;

                txtValorVenda.Text = $"R$ {(valorDeCusto + lucro).ToString("N2")}";
                txtLucro.Text = $"R$ {(lucro).ToString("N2")}";
            }
        }

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
                ManipulacaoTextBox.ValidacaoData(txtValidade);
            }
        }

        private void txtEstoqueMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e))
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtEstoqueMinimo.Text, sender);
            }
        }

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

        private void Forms_CadastroProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
            else if (e.KeyCode == Keys.F1)
            {
                NovoCadastroProduto();
            }
            else if (e.KeyCode == Keys.F10)
            {
                SalvarCadastroProduto();
            }
            else if (e.KeyCode == Keys.F5)
            {
                AtualizarCadastroProduto();
            }
            else if (e.KeyCode == Keys.F2)
            {
                Forms_PesquisarProduto buscarProduto = new Forms_PesquisarProduto(this, "Cadastro Produto");
                buscarProduto.ShowDialog();
            }
            else if (e.KeyCode == Keys.F3)
            {
                ExcluirCadastroProduto();
            }
            else if (e.KeyCode == Keys.D && e.Modifiers == Keys.Control)
            {
                InserirImagemProduto();
            }
        }
    }
}