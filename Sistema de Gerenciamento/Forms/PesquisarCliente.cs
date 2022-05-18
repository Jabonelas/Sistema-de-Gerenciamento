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

namespace Sistema_de_Gerenciamento
{
    public partial class PesquisarCliente : Form
    {
        private CadastroCliente cadastroCliente;

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        public PesquisarCliente(CadastroCliente _cadastroCliente)
        {
            InitializeComponent();
            cadastroCliente = _cadastroCliente;
        }

        #region Botao Pesquisar

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroClientePorCodigo(txtCodigoCliente.Text, gdvPesquisarCliente);

                if (isCadastroExiste == false)
                {
                    MessageBox.Show("Cliente Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtCPF_CNPJ.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroClienteCPF_CNPJ(txtCPF_CNPJ.Text, gdvPesquisarCliente);

                if (isCadastroExiste == false)
                {
                    MessageBox.Show("Cliente Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtRG.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroClienteRG(txtRG.Text, gdvPesquisarCliente);

                if (isCadastroExiste == false)
                {
                    MessageBox.Show("Cliente Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtNome.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroClienteNome(txtNome.Text, gdvPesquisarCliente);

                if (isCadastroExiste == false)
                {
                    MessageBox.Show("Cliente Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Exibir Todos Os Clientes?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    bool isCadastroExiste = Buscar.BuscarCadastroClienteTudo(gdvPesquisarCliente);

                    if (isCadastroExiste == false)
                    {
                        MessageBox.Show("Cliente Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        #endregion Botao Pesquisar

        #region Botao Fechar

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Fechar

        #region GridView

        private void gdvPesquisarCliente_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (gdvPesquisarCliente.RowCount >= 1)
            {
                int indice = 0;

                cadastroCliente.txtCodigo.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtDataCadastro.Text = (((DateTime)gdvPesquisarCliente.SelectedCells[indice += 1].Value).ToShortDateString());

                cadastroCliente.txtNome.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.cmbTipo.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtCPF_CNPJ.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtRG.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.cmbEmissor.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();
                string dataEmissao = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString() == "----------" ? "----------" : Convert.ToDateTime(gdvPesquisarCliente.SelectedCells[indice].Value).ToShortDateString();

                cadastroCliente.txtDataEmissao.Text = dataEmissao;

                cadastroCliente.cmbIns_Est.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtCEP.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtEndereco.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtNumero.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtComplemento.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtBairro.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtCidade.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.cmbUF.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtNaturalidade.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();
                string dataNascimento = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString() == "----------" ? "----------" : Convert.ToDateTime(gdvPesquisarCliente.SelectedCells[indice].Value).ToShortDateString();

                cadastroCliente.txtDataNascimento.Text = dataNascimento;

                cadastroCliente.cmbEstadoCivil.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtCredito.Text = ("R$ " + gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString());

                cadastroCliente.txtSaldo.Text = ("R$ " + gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString());

                cadastroCliente.cmbBloqueio.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtCelular.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtTel_Residencial.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtEmail.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtObservacoes.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.pcbCliente.Image = Buscar.BuscarImagemCliente(Convert.ToInt32(cadastroCliente.txtCodigo.Text));

                this.Close();
            }
        }

        #endregion GridView

        #region Botao Selecionar

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (gdvPesquisarCliente.RowCount >= 1)
            {
                int indice = 0;

                cadastroCliente.txtCodigo.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtDataCadastro.Text = (((DateTime)gdvPesquisarCliente.SelectedCells[indice += 1].Value).ToShortDateString());

                cadastroCliente.txtNome.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.cmbTipo.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtCPF_CNPJ.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtRG.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.cmbEmissor.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();
                string dataEmissao = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString() == "----------" ? "----------" : Convert.ToDateTime(gdvPesquisarCliente.SelectedCells[indice].Value).ToShortDateString();

                cadastroCliente.txtDataEmissao.Text = dataEmissao;

                cadastroCliente.cmbIns_Est.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtCEP.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtEndereco.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtNumero.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtComplemento.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtBairro.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtCidade.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.cmbUF.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtNaturalidade.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();
                string dataNascimento = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString() == "----------" ? "----------" : Convert.ToDateTime(gdvPesquisarCliente.SelectedCells[indice].Value).ToShortDateString();

                cadastroCliente.txtDataNascimento.Text = dataNascimento;

                cadastroCliente.cmbEstadoCivil.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtCredito.Text = ("R$ " + gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString());

                cadastroCliente.txtSaldo.Text = ("R$ " + gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString());

                cadastroCliente.cmbBloqueio.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtCelular.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtTel_Residencial.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtEmail.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.txtObservacoes.Text = gdvPesquisarCliente.SelectedCells[indice += 1].Value.ToString();

                cadastroCliente.pcbCliente.Image = Buscar.BuscarImagemCliente(Convert.ToInt32(cadastroCliente.txtCodigo.Text));

                this.Close();
            }
        }

        #endregion Botao Selecionar

        #region TextBox Codigo

        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Codigo

        #region TextBox CPF_CNPJ

        private void txtCPF_CNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbTipo.Text != string.Empty)
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }

                if (cmbTipo.Text == "Pess. Fisica")
                {
                    txtCPF_CNPJ.MaxLength = 14;

                    if (char.IsNumber(e.KeyChar) == true)
                    {
                        switch (txtCPF_CNPJ.TextLength)
                        {
                            case 0:
                                txtCPF_CNPJ.Text = "";
                                break;

                            case 3:
                                txtCPF_CNPJ.Text = txtCPF_CNPJ.Text + ".";
                                txtCPF_CNPJ.SelectionStart = 4;
                                break;

                            case 7:
                                txtCPF_CNPJ.Text = txtCPF_CNPJ.Text + ".";
                                txtCPF_CNPJ.SelectionStart = 8;
                                break;

                            case 11:
                                txtCPF_CNPJ.Text = txtCPF_CNPJ.Text + "-";
                                txtCPF_CNPJ.SelectionStart = 12;
                                break;
                        }
                    }
                }
                else if (cmbTipo.Text == "Pess. Juridica")
                {
                    txtCPF_CNPJ.MaxLength = 18;

                    if (char.IsNumber(e.KeyChar) == true)
                    {
                        switch (txtCPF_CNPJ.TextLength)
                        {
                            case 0:
                                txtCPF_CNPJ.Text = "";
                                break;

                            case 2:
                                txtCPF_CNPJ.Text = txtCPF_CNPJ.Text + ".";
                                txtCPF_CNPJ.SelectionStart = 3;
                                break;

                            case 6:
                                txtCPF_CNPJ.Text = txtCPF_CNPJ.Text + ".";
                                txtCPF_CNPJ.SelectionStart = 7;
                                break;

                            case 10:
                                txtCPF_CNPJ.Text = txtCPF_CNPJ.Text + "/";
                                txtCPF_CNPJ.SelectionStart = 11;
                                break;

                            case 15:
                                txtCPF_CNPJ.Text = txtCPF_CNPJ.Text + "-";
                                txtCPF_CNPJ.SelectionStart = 16;
                                break;
                        }
                    }
                }
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Por Favor Defina o Tipo!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.OK)
                {
                    cmbTipo.Focus();
                }
                txtCPF_CNPJ.Text = "";
            }
        }

        private void txtCPF_CNPJ_Leave(object sender, EventArgs e)
        {
            if (txtCPF_CNPJ.Text.Length != txtCPF_CNPJ.MaxLength && txtCPF_CNPJ.Text.Length != 0)
            {
                txtCPF_CNPJ.BorderColorActive = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente!");
                txtCPF_CNPJ.Focus();
            }
            else if (txtCPF_CNPJ.Text.Length == txtCPF_CNPJ.MaxLength)
            {
                txtCPF_CNPJ.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox CPF_CNPJ

        #region TextBox RG

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtRG.TextLength)
                {
                    case 0:
                        txtRG.Text = "";
                        break;

                    case 2:
                        txtRG.Text = txtRG.Text + ".";
                        txtRG.SelectionStart = 3;
                        break;

                    case 6:
                        txtRG.Text = txtRG.Text + ".";
                        txtRG.SelectionStart = 7;
                        break;

                    case 10:
                        txtRG.Text = txtRG.Text + "-";
                        txtRG.SelectionStart = 11;
                        break;
                }
            }
        }

        private void txtRG_Leave(object sender, EventArgs e)
        {
            if (txtRG.Text.Length != txtRG.MaxLength && txtRG.Text.Length != 0)
            {
                txtRG.BorderColorActive = Color.Red;

                MessageBox.Show("Por Favor Preencha o Campo Corretamente!");
                txtRG.Focus();
            }
            else if (txtRG.Text.Length == txtRG.MaxLength)
            {
                txtRG.BorderColorActive = Color.DodgerBlue;
            }
        }

        #endregion TextBox RG

        #region TextBox Nome

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Nome

        #region ComboBox Tipo

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "Pess. Fisica")
            {
                lblTipoDeCliente.Text = "CPF";
            }
            else if (cmbTipo.Text == "Pess. Juridica")
            {
                lblTipoDeCliente.Text = "CNPJ";
            }
        }

        #endregion ComboBox Tipo

        #region Botao Exportar Para Excel

        private void btnExportarParaExcel_Click(object sender, EventArgs e)
        {
            if (gdvPesquisarCliente.RowCount > 0)
            {
                try
                {
                    SaveFileDialog openFileDialog = new SaveFileDialog();
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|Excel 2007 (*.xls)|*.xls";
                    openFileDialog.FilterIndex = 1;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        DataTable dt = ExportarExcel.DataGridView_To_Datatable(gdvPesquisarCliente);
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
    }
}