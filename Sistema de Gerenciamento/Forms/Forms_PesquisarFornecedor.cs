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

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_PesquisarFornecedor : Form
    {
        private Forms_CadastroFornecedor cadastroFornecedor;

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        public Forms_PesquisarFornecedor(Forms_CadastroFornecedor _cadastroFornecedor)
        {
            InitializeComponent();

            cadastroFornecedor = _cadastroFornecedor;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarFornecedor();
        }

        #region Pesquisar Fornecedor

        private void PesquisarFornecedor()
        {
            if (txtCodigoFornecedor.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroFornecedorPorCodigo(txtCodigoFornecedor.Text, gdvPesquisarFornecedor);

                MenssgemFornecedorNaoEncontrado(isCadastroExiste);
            }
            else if (txtCNPJ.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroFornecedorPorCNPJ(txtCNPJ.Text, gdvPesquisarFornecedor);

                MenssgemFornecedorNaoEncontrado(isCadastroExiste);
            }
            else if (txtNomeFantasia.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroFornecedorPorNomeFantasia(txtNomeFantasia.Text, gdvPesquisarFornecedor);

                MenssgemFornecedorNaoEncontrado(isCadastroExiste);
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Exibir Todos Os Fornecedores?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    bool isCadastroExiste = Buscar.BuscarCadastroFornecedorTudo(gdvPesquisarFornecedor);

                    MenssgemFornecedorNaoEncontrado(isCadastroExiste);
                }
            }
        }

        private void MenssgemFornecedorNaoEncontrado(bool _isCadastroExiste)
        {
            if (_isCadastroExiste == false)
            {
                MessageBox.Show("Fornecedor Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion Pesquisar Fornecedor

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportarParaExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel.GerarExcel(gdvPesquisarFornecedor);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            SelecaoGridViewPreencherTextBox();
        }

        #region Selecao Linha no GridView Para Preencher TextBox

        private void SelecaoGridViewPreencherTextBox()
        {
            if (gdvPesquisarFornecedor.RowCount >= 1)
            {
                int indice = -1;

                cadastroFornecedor.txtCodigo.Text = (gdvPesquisarFornecedor.SelectedCells[indice += 1].Value).ToString();

                cadastroFornecedor.txtRazaoSocial.Text = gdvPesquisarFornecedor.SelectedCells[indice += 1].Value.ToString();

                cadastroFornecedor.txtDataCadastro.Text = (((DateTime)gdvPesquisarFornecedor.SelectedCells[indice += 1].Value).ToShortDateString());

                cadastroFornecedor.txtCNPJ.Text = gdvPesquisarFornecedor.SelectedCells[indice += 1].Value.ToString();

                cadastroFornecedor.txtNomeFantasia.Text = gdvPesquisarFornecedor.SelectedCells[indice += 1].Value.ToString();

                cadastroFornecedor.txtCEP.Text = gdvPesquisarFornecedor.SelectedCells[indice += 1].Value.ToString();

                cadastroFornecedor.txtEndereco.Text = gdvPesquisarFornecedor.SelectedCells[indice += 1].Value.ToString();

                cadastroFornecedor.txtComplemento.Text = gdvPesquisarFornecedor.SelectedCells[indice += 1].Value.ToString();

                cadastroFornecedor.txtNumero.Text = gdvPesquisarFornecedor.SelectedCells[indice += 1].Value.ToString();

                cadastroFornecedor.txtBairro.Text = gdvPesquisarFornecedor.SelectedCells[indice += 1].Value.ToString();

                cadastroFornecedor.txtCidade.Text = gdvPesquisarFornecedor.SelectedCells[indice += 1].Value.ToString();

                cadastroFornecedor.cmbUF.Text = gdvPesquisarFornecedor.SelectedCells[indice += 1].Value.ToString();

                cadastroFornecedor.txtTelefone.Text = gdvPesquisarFornecedor.SelectedCells[indice += 1].Value.ToString();

                cadastroFornecedor.txtEmail.Text = gdvPesquisarFornecedor.SelectedCells[indice += 1].Value.ToString();

                cadastroFornecedor.txtObservacoes.Text = gdvPesquisarFornecedor.SelectedCells[indice += 1].Value.ToString();

                cadastroFornecedor.pcbFornecedor.Image = Buscar.BuscarImagemFornecedor(Convert.ToInt32(cadastroFornecedor.txtCodigo.Text));

                this.Close();
            }
        }

        #endregion Selecao Linha no GridView Para Preencher TextBox

        private void gdvPesquisarFornecedor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelecaoGridViewPreencherTextBox();
        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoCNPJ(e, txtCNPJ);
            }
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtCNPJ);
        }

        private void txtCodigoFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir.ImprimirGridView("Relatorio de Fornecedor", gdvPesquisarFornecedor);
        }

        private void Forms_PesquisarFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
            else if (e.KeyCode == Keys.F10)
            {
                SelecaoGridViewPreencherTextBox();
            }
            else if (e.KeyCode == Keys.F2)
            {
                PesquisarFornecedor();
            }
            else if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                Imprimir.ImprimirGridView("Relatorio de Fornecedor", gdvPesquisarFornecedor);
            }
            else if (e.KeyCode == Keys.E && e.Modifiers == Keys.Control)
            {
                ExportarExcel.GerarExcel(gdvPesquisarFornecedor);
            }
        }
    }
}