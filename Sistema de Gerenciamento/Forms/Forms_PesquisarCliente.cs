using Sistema_de_Gerenciamento.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using DGVPrinterHelper;

namespace Sistema_de_Gerenciamento
{
    public partial class Forms_PesquisarCliente : Form
    {
        private Forms_CadastroCliente cadastroCliente;

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        public Forms_PesquisarCliente(Forms_CadastroCliente _cadastroCliente)
        {
            InitializeComponent();
            cadastroCliente = _cadastroCliente;
        }

        public Forms_PesquisarCliente()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            PesquisarCliente();
        }

        #region Pesquisar Cliente Por Codigo, CPF/CNPJ, RG e Nome

        private void PesquisarCliente()
        {
            if (txtCodigoCliente.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroClientePorCodigo(txtCodigoCliente.Text, gdvPesquisarCliente);

                MenssagemClienteNaoEncontrado(isCadastroExiste);
            }
            else if (txtCPF_CNPJ.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroClienteCPF_CNPJ(txtCPF_CNPJ.Text, gdvPesquisarCliente);

                MenssagemClienteNaoEncontrado(isCadastroExiste);
            }
            else if (txtRG.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroClienteRG(txtRG.Text, gdvPesquisarCliente);

                MenssagemClienteNaoEncontrado(isCadastroExiste);
            }
            else if (txtNome.Text != string.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCadastroClientePorNome(txtNome.Text, gdvPesquisarCliente);

                MenssagemClienteNaoEncontrado(isCadastroExiste);
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Exibir Todos Os Clientes?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    bool isCadastroExiste = Buscar.BuscarCadastroClienteTudo(gdvPesquisarCliente);

                    MenssagemClienteNaoEncontrado(isCadastroExiste);
                }
            }
        }

        private void MenssagemClienteNaoEncontrado(bool _isCadastroExiste)
        {
            if (_isCadastroExiste == false)
            {
                MessageBox.Show("Cliente Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion Pesquisar Cliente Por Codigo, CPF/CNPJ, RG e Nome

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportarParaExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel.GerarExcel(gdvPesquisarCliente);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir.ImprimirGridView("Relatorio de Cliente", gdvPesquisarCliente);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            SelecaoGridViewPreencherTextBox();
        }

        private void gdvPesquisarCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelecaoGridViewPreencherTextBox();
        }

        #region Selecionar Linha No Gridview Para Preencher TextBox na Tela De Cadastro de Cliente

        private void SelecaoGridViewPreencherTextBox()
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

        #endregion Selecionar Linha No Gridview Para Preencher TextBox na Tela De Cadastro de Cliente

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelTipoCliente();
        }

        #region Formatacao da Label Por Tipo de Cliente

        private void LabelTipoCliente()
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

        #endregion Formatacao da Label Por Tipo de Cliente

        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtCPF_CNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatarCPF_CNPJ(e);
        }

        #region Formatar CPF/CNPJ

        private void FormatarCPF_CNPJ(KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                if (cmbTipo.Text == "Pess. Fisica")
                {
                    ManipulacaoTextBox.FormatoCPF(e, txtCPF_CNPJ);
                }
                else if (cmbTipo.Text == "Pess. Juridica")
                {
                    ManipulacaoTextBox.FormatoCNPJ(e, txtCPF_CNPJ);
                }
            }
        }

        #endregion Formatar CPF/CNPJ

        private void txtCPF_CNPJ_Enter(object sender, EventArgs e)
        {
            VerificacaoPreenchimentoTipoCliente();
        }

        #region Verificar se o Campo Tipo de Cliente Foi Preenchido Primeiramente

        private void VerificacaoPreenchimentoTipoCliente()
        {
            if (cmbTipo.Text == String.Empty)
            {
                txtCPF_CNPJ.BorderColorActive = Color.Silver;

                cmbTipo.BorderColor = Color.DodgerBlue;

                cmbTipo.Focus();

                MessageBox.Show("Por Favor Preencha Primeiro O Campo Tipo!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion Verificar se o Campo Tipo de Cliente Foi Preenchido Primeiramente

        private void txtCPF_CNPJ_Leave(object sender, EventArgs e)
        {
            ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtCPF_CNPJ);
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoRG(txtRG);
            }
        }

        private void txtRG_Leave(object sender, EventArgs e)
        {
            ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtRG);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetras(e);
        }
    }
}