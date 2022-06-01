﻿using Sistema_de_Gerenciamento.Classes;
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

        #region Botao Pesquisar

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCodigoFornecedor.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroFornecedorPorCodigo(txtCodigoFornecedor.Text, gdvPesquisarFornecedor);

                if (isCadastroExiste == false)
                {
                    MessageBox.Show("Fornecedor Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtCNPJ.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroFornecedorPorCNPJ(txtCNPJ.Text, gdvPesquisarFornecedor);

                if (isCadastroExiste == false)
                {
                    MessageBox.Show("Fornecedor Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtNomeFantasia.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroFornecedorPorNomeFantasia(txtNomeFantasia.Text, gdvPesquisarFornecedor);

                if (isCadastroExiste == false)
                {
                    MessageBox.Show("Fornecedor Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Exibir Todos Os Fornecedores?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    bool isCadastroExiste = Buscar.BuscarCadastroFornecedorTudo(gdvPesquisarFornecedor);

                    if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Fornecedor Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        #endregion Botao Pesquisar

        #region Botao Fechar

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Fechar

        #region Botao Selecionar

        private void btnSelecionar_Click(object sender, EventArgs e)
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

        #endregion Botao Selecionar

        #region Gridview Fornecedor

        private void gdvPesquisarFornecedor_MouseDoubleClick(object sender, MouseEventArgs e)
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

        #endregion Gridview Fornecedor

        #region TextBox CNPJ

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCNPJ.MaxLength = 18;

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCNPJ.TextLength)
                {
                    case 0:
                        txtCNPJ.Text = "";
                        break;

                    case 2:
                        txtCNPJ.Text = txtCNPJ.Text + ".";
                        txtCNPJ.SelectionStart = 3;
                        break;

                    case 6:
                        txtCNPJ.Text = txtCNPJ.Text + ".";
                        txtCNPJ.SelectionStart = 7;
                        break;

                    case 10:
                        txtCNPJ.Text = txtCNPJ.Text + "/";
                        txtCNPJ.SelectionStart = 11;
                        break;

                    case 15:
                        txtCNPJ.Text = txtCNPJ.Text + "-";
                        txtCNPJ.SelectionStart = 16;
                        break;
                }
            }
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (txtCNPJ.Text.Length != txtCNPJ.MaxLength && txtCNPJ.Text.Length != 0)
            {
                txtCNPJ.BorderColorActive = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCNPJ.Focus();
            }
            else if (txtCNPJ.Text.Length == txtCNPJ.MaxLength)
            {
                txtCNPJ.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox CNPJ

        #region TextBox Codigo

        private void txtCodigoFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Codigo

        #region Botao Exportar Para Excel

        private void btnExportarParaExcel_Click(object sender, EventArgs e)
        {
            if (gdvPesquisarFornecedor.RowCount > 0)
            {
                try
                {
                    SaveFileDialog openFileDialog = new SaveFileDialog();
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|Excel 2007 (*.xls)|*.xls";
                    openFileDialog.FilterIndex = 1;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        DataTable dt = ExportarExcel.DataGridView_To_Datatable(gdvPesquisarFornecedor);
                        dt.exportToExcel(openFileDialog.FileName);
                    }
                }
                catch (Exception ex)
                {
                    Erro.ErroAoExportarDadosExecel(ex);
                }
            }
            else
            {
                MessageBox.Show("Primeiro Realizar a Pesquisa!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion Botao Exportar Para Excel

        #region Imprimir Relatorio Fornecedor

        private void ImprimirRelatorioFornecedores()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Relatorio de Fornecedores";//Header
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = DateTime.Today.ToString();//Footer
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(gdvPesquisarFornecedor);
        }

        #endregion Imprimir Relatorio Fornecedor

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            ImprimirRelatorioFornecedores();
        }
    }
}