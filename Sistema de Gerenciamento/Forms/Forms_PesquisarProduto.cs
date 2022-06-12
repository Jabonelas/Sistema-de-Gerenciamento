using Sistema_de_Gerenciamento.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Sistema_de_Gerenciamento
{
    public partial class Forms_PesquisarProduto : Form
    {
        private Forms_CadastroProduto cadastroProduto;

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        public Forms_PesquisarProduto(Forms_CadastroProduto _cadastroProduto)
        {
            InitializeComponent();

            cadastroProduto = _cadastroProduto;

            PreencherComboBoxGrupo();
        }

        #region Preencher ComboBox Grupo

        private void PreencherComboBoxGrupo()
        {
            List<DadosGrupoMaterial> listaGrupo = new List<DadosGrupoMaterial>();

            listaGrupo = Buscar.BuscarGrupoProduto();

            cmbGrupo.Items.Clear();

            listaGrupo.ForEach(prod => cmbGrupo.Items.Add(prod.grupo));
        }

        #endregion Preencher ComboBox Grupo

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            SelecaoGridViewPreencherTextBox();
        }

        private void gdvPesquisarProduto_DoubleClick(object sender, EventArgs e)
        {
            SelecaoGridViewPreencherTextBox();
        }

        #region Selecionar Linha No Gridview Para Preencher TextBox na Tela De Cadastro de Produto

        private void SelecaoGridViewPreencherTextBox()
        {
            if (gdvPesquisarProduto.RowCount >= 1)
            {
                int indice = 0;

                cadastroProduto.txtCodigo.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtDescricao.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.cmbUn.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtValorDeCusto.Text = ("R$ " + gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString());

                cadastroProduto.txtPorcentagem.Text = (gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString() + " %");

                cadastroProduto.txtValorVenda.Text = ("R$ " + gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString());

                cadastroProduto.txtLucro.Text = ("R$ " + gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString());

                cadastroProduto.txtPrecoAtacado.Text = ("R$ " + gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString());

                cadastroProduto.cmbGrupo.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.cmbSubGrupo.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.cmbFornecedor.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtEstoqueMinimo.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtGarantia.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtMarca.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtReferencia.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.txtValidade.Text = (((DateTime)gdvPesquisarProduto.SelectedCells[indice += 1].Value).ToShortDateString());

                cadastroProduto.txtComissao.Text = (gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString() + " %");

                cadastroProduto.txtObservacoes.Text = gdvPesquisarProduto.SelectedCells[indice += 1].Value.ToString();

                cadastroProduto.pcbProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(cadastroProduto.txtCodigo.Text));

                this.Close();
            }
        }

        #endregion Selecionar Linha No Gridview Para Preencher TextBox na Tela De Cadastro de Produto

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarProduto();
        }

        #region Pesquisar Produto

        private void PesquisarProduto()
        {
            if (txtCodigoProduto.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroProdutoPorCodigo(Convert.ToInt32(txtCodigoProduto.Text), gdvPesquisarProduto);

                MessagemProdutoNaoEncontrado(isCadastroExiste);
            }
            else if (txtDescicao.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroProdutoPorDescricao(txtDescicao.Text, gdvPesquisarProduto);

                MessagemProdutoNaoEncontrado(isCadastroExiste);
            }
            else if (cmbGrupo.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroProdutoPorGrupo(cmbGrupo.Text, gdvPesquisarProduto);

                MessagemProdutoNaoEncontrado(isCadastroExiste);
            }
            else if (cmbSubGrupo.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroProdutoPorSubGrupo(cmbSubGrupo.Text, gdvPesquisarProduto);

                MessagemProdutoNaoEncontrado(isCadastroExiste);
            }
            else if (txtMarca.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroProdutoPorMarca(txtMarca.Text, gdvPesquisarProduto);

                MessagemProdutoNaoEncontrado(isCadastroExiste);
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Exibir Todos Os Produtos?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    bool isCadastroExiste = Buscar.BuscarCadastroProdutoTudo(gdvPesquisarProduto);

                    MessagemProdutoNaoEncontrado(isCadastroExiste);
                    ;
                }
            }
        }

        private void MessagemProdutoNaoEncontrado(bool _isCadastroExiste)
        {
            if (_isCadastroExiste == false)
            {
                MessageBox.Show("Produto Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion Pesquisar Produto

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click_1(object sender, EventArgs e)
        {
            ExportarExcel.GerarExcel(gdvPesquisarProduto);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir.ImprimirGridView("Relatorio de Produto", gdvPesquisarProduto);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void cmbGrupo_SelectedValueChanged(object sender, EventArgs e)
        {
            PreencherComboBoxSubGrupo();
        }

        #region Preencher ComboBox Sug-Grupo

        private void PreencherComboBoxSubGrupo()
        {
            List<DadosSubGrupoMaterial> ListaSubGrupo = new List<DadosSubGrupoMaterial>();

            ListaSubGrupo = Buscar.BuscarSubGrupoProduto(cmbGrupo.Text);

            cmbSubGrupo.Items.Clear();

            ListaSubGrupo.ForEach(grupoProduto => cmbSubGrupo.Items.Add(grupoProduto.sub_grupo));
        }

        #endregion Preencher ComboBox Sug-Grupo

        private void cmbSubGrupo_Enter(object sender, EventArgs e)
        {
            VerificarPreencimentoComboBoxGrupo();
        }

        #region Vrificar Preechimento do ComboBox Grupo

        private void VerificarPreencimentoComboBoxGrupo()
        {
            if (cmbGrupo.Text == string.Empty)
            {
                MessageBox.Show("Por Favor Preencha Primeiro O Campo Grupo!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbGrupo.Focus();
            }
        }

        #endregion Vrificar Preechimento do ComboBox Grupo

        private void txtDescicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

      
    }
}