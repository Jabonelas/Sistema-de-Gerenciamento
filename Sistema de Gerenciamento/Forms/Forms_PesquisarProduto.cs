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
using Sistema_de_Gerenciamento.Forms;

namespace Sistema_de_Gerenciamento
{
    public partial class Forms_PesquisarProduto : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private Forms_CadastroProduto cadastroProduto;

        private Forms_TelaAdministrador telaAdministrador;

        private Forms_PDV forms_PDV;

        private Forms_Troca forms_Troca;

        private string nomeTelaSolicitacao;

        private Forms_ConsultarEstoque forms_ConsultarEstoque;

        public Forms_PesquisarProduto(Forms_CadastroProduto _cadastroProduto)
        {
            InitializeComponent();

            cadastroProduto = _cadastroProduto;

            PreencherComboBoxGrupo();
        }

        public Forms_PesquisarProduto(Forms_PDV _forms_PDV, string _telaSolicitacao)
        {
            InitializeComponent();

            nomeTelaSolicitacao = _telaSolicitacao;

            forms_PDV = _forms_PDV;

            PreencherComboBoxGrupo();

            LayoutApenasSelecionarEFechar();
        }

        public Forms_PesquisarProduto(Forms_Troca _forms_Troca, string _telaSolicitacao)
        {
            InitializeComponent();

            nomeTelaSolicitacao = _telaSolicitacao;

            forms_Troca = _forms_Troca;

            PreencherComboBoxGrupo();

            LayoutApenasSelecionarEFechar();
        }

        public Forms_PesquisarProduto(Forms_ConsultarEstoque _telaConsultarEstoque, string _nomeTelaSolicitacao)
        {
            InitializeComponent();

            forms_ConsultarEstoque = _telaConsultarEstoque;

            nomeTelaSolicitacao = _nomeTelaSolicitacao;

            PreencherComboBoxGrupo();

            LayoutApenasSelecionarEFechar();
        }

        public Forms_PesquisarProduto(Forms_TelaAdministrador _telaAdministrador)
        {
            InitializeComponent();

            LayoutApenasSelecionarEFechar();

            PreencherComboBoxGrupo();
        }

        private void LayoutApenasSelecionarEFechar()
        {
            btnImprimir.Visible = false;
            btnExportar.Visible = false;
            btnFechar.Location = new Point(447, 437);
            btnSelecionar.Location = new Point(250, 437);
            btnFechar.TabIndex = 7;
        }

        private void PreencherComboBoxGrupo()

        {
            List<DadosGrupoMaterial> listaGrupo = new List<DadosGrupoMaterial>();

            listaGrupo = Buscar.BuscarGrupoProduto();

            cmbGrupo.Items.Clear();

            listaGrupo.ForEach(prod => cmbGrupo.Items.Add(prod.grupo));
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            ConfirmarSelececao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarProduto();
        }

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

        private void cmbSubGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarPreencimentoComboBoxGrupo();
        }

        private void cmbGrupo_SelectedValueChanged(object sender, EventArgs e)
        {
            PreencherComboBoxSubGrupo();
        }

        private void txtDescicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        public void gdvPesquisarProduto_KeyDown(object sender, KeyEventArgs e)
        {
            ConfirmarSelececao();
        }

        public void gdvPesquisarProduto_DoubleClick(object sender, EventArgs e)
        {
            ConfirmarSelececao();
        }

        private void ConfirmarSelecaoPreencherConsultarEstoque()
        {
            forms_ConsultarEstoque.txtCodigo.Text = gdvPesquisarProduto.SelectedCells[1].Value.ToString();

            this.Close();
        }

        private void ConfirmarSelececao()
        {
            if (nomeTelaSolicitacao == "Tela PDV")
            {
                ConfirmarSelecaoPreencherTelaPDV();
            }
            else if (nomeTelaSolicitacao == "Tela Devolucao/Troca")
            {
                ConfirmarSelecaoPreencherTelaTroca();
            }
            else if (nomeTelaSolicitacao == "Tela Consultar Estoque")
            {
                ConfirmarSelecaoPreencherConsultarEstoque();
            }
            else
            {
                SelecaoGridViewPreencherTelaCadastroProduto();
            }
        }

        private void SelecaoGridViewPreencherTelaCadastroProduto()
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

        private void PreencherComboBoxSubGrupo()
        {
            List<DadosSubGrupoMaterial> ListaSubGrupo = new List<DadosSubGrupoMaterial>();

            ListaSubGrupo = Buscar.BuscarSubGrupoProduto(cmbGrupo.Text);

            cmbSubGrupo.Items.Clear();

            ListaSubGrupo.ForEach(grupoProduto => cmbSubGrupo.Items.Add(grupoProduto.sub_grupo));
        }

        private void VerificarPreencimentoComboBoxGrupo()
        {
            int cont = 0;

            if (cmbGrupo.Text == string.Empty && cont == 0 && cmbSubGrupo.Text != String.Empty)
            {
                cmbGrupo.Focus();

                cmbSubGrupo.Text = string.Empty;

                MessageBox.Show("Por Favor Preencha Primeiro O Campo Grupo!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cont++;
            }
        }

        private void ConfirmarSelecaoPreencherTelaPDV()
        {
            forms_PDV.txtCodigoProduto.Text = gdvPesquisarProduto.SelectedCells[1].Value.ToString();

            this.Close();
        }

        private void ConfirmarSelecaoPreencherTelaTroca()
        {
            forms_Troca.txtCodProdutoTroca.Text = gdvPesquisarProduto.SelectedCells[1].Value.ToString();

            this.Close();
        }

        private void Forms_PesquisarProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}