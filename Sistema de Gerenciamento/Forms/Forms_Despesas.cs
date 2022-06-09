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

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_Despesas : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        public Forms_Despesas()
        {
            InitializeComponent();

            layout();
        }

        #region Layout Tela Despesa

        private void layout()
        {
            lblCNPJ.Visible = false;
            txtCNPJ.Visible = false;
            txtValorParcelas.Visible = false;
            lblValorParcelas.Visible = false;
            cmbQuantidadeParcelas.Visible = false;
            lblQuantidadeParcelas.Visible = false;
        }

        #endregion Layout Tela Despesa

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoDinheiro(e, sender, txtValor);
            }
        }

        private void txtVencimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoData(txtVencimento);
            }
        }

        private void txtEmissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoData(txtEmissao);
            }
        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void txtEmissao_Leave(object sender, EventArgs e)
        {
            if (ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtEmissao) == true)
            {
                ManipulacaoTextBox.ValidacaoData(txtEmissao);
            }
        }

        private void cmbTipoDespesa_Enter(object sender, EventArgs e)
        {
            PreencherComboBoxTipo();
        }

        #region Preencher ComboBox Tipo

        private void PreencherComboBoxTipo()
        {
            cmbTipoDespesa.MaxLength = 50;

            cmbTipoDespesa.Items.Clear();

            foreach (string item in Buscar.BuscarListaDespesa())
            {
                cmbTipoDespesa.Items.Add(item);
            }
        }

        #endregion Preencher ComboBox Tipo

        private void cmbTipoDespesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void cmbDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void cmbDescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarCodigoDespesa();
        }

        #region Buscar Codigo de Despesa

        private void BuscarCodigoDespesa()
        {
            List<DadosDespesasCusto> listaDespesas = Buscar.BuscarListaDespesaPorTipo(cmbTipoDespesa.Text);

            if (listaDespesas.Count != 0)
            {
                foreach (DadosDespesasCusto item in listaDespesas)
                {
                    if (cmbFornecedorTitulo.Text == item.descricao)
                    {
                        txtCodigo.Text = item.codigo.ToString();
                    }
                }
            }
        }

        #endregion Buscar Codigo de Despesa

        private void btnExcluir_Click(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Forms_PesquisarDespesa pesquisarDespesa = new Forms_PesquisarDespesa(this);
            pesquisarDespesa.ShowDialog();
        }

        private void cmbTipoDespesa_SelectedValueChanged(object sender, EventArgs e)
        {
            PreencherComboBoxFornecedorTitulo();
        }

        #region Preencher ComboBox Fornecedor Titulo

        private void PreencherComboBoxFornecedorTitulo()
        {
            cmbFornecedorTitulo.Items.Clear();
            cmbFornecedorTitulo.Text = String.Empty;
            txtCodigo.Text = String.Empty;

            List<DadosDespesasCusto> listaDespesas = Buscar.BuscarListaDespesaPorTipo(cmbTipoDespesa.Text);

            if (listaDespesas.Count != 0)
            {
                foreach (DadosDespesasCusto item in listaDespesas)
                {
                    cmbFornecedorTitulo.Items.Add(item.descricao);
                }
            }
            else
            {
                txtCodigo.Text = string.Empty;
            }

            if (cmbTipoDespesa.Text == string.Empty)
            {
                txtCodigo.Text = string.Empty;
            }
        }

        #endregion Preencher ComboBox Fornecedor Titulo

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDespesa();
        }

        #region Salvar Despesa

        private void SalvarDespesa()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    Salvar.InserirDespesa(Convert.ToInt32(txtCodigo.Text), cmbTipoDespesa.Text, txtDescricao.Text, cmbFornecedorTitulo.Text,
                              txtCNPJ.Text, Convert.ToDateTime(txtEmissao.Text), Convert.ToDateTime(txtVencimento.Text), cmbFrequencia.Text,
                        Convert.ToDecimal(txtValor.Text.Replace("R$", "")), Convert.ToInt32(cmbQuantidadeParcelas.Text),
                        Convert.ToDecimal(txtValorParcelas.Text), lblCategoria.Text);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoInserirDadosDespesa(ex);
            }
        }

        #endregion Salvar Despesa

        private void txtVencimento_Leave(object sender, EventArgs e)
        {
            VerificarData();
        }

        #region Verificar Data

        private void VerificarData()
        {
            if (ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtVencimento) == false)
            {
                ManipulacaoTextBox.ValidacaoData(txtVencimento);

                if (Convert.ToDateTime(txtEmissao.Text) > Convert.ToDateTime(txtVencimento.Text))
                {
                    MessageBox.Show("A Data de Emissão Não Pode Ser Maior que a Data De Vencimento!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtVencimento.Focus();
                }
            }
        }

        #endregion Verificar Data
    }
}