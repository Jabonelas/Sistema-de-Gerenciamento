using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Sistema_de_Gerenciamento.Classes;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_DespesasCustos : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private AdicionarNoBanco Salvar = new AdicionarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        private AtualizacaoNoBanco Atualizar = new AtualizacaoNoBanco();

        private ExcluirNoBanco Excluir = new ExcluirNoBanco();

        private List<DadosCadastroDespesasCusto> listaDespesaCusto = new List<DadosCadastroDespesasCusto>();

        private int cont = 1;

        private int dias = 1;

        public Forms_DespesasCustos(string _tituloForm)
        {
            InitializeComponent();

            this.Text = _tituloForm;

            if (this.Text == "Despesa")
            {
                layoutDespesa();
            }
            else if (this.Text == "Custo")
            {
                layoutCusto();
            }

            DataAtualDatePikcer();
        }

        #region Data Atual DatePicker

        private void DataAtualDatePikcer()
        {
            dtpEmissao.Value = DateTime.Today;
            dtpVencimento.Value = DateTime.Today;
        }

        #endregion Data Atual DatePicker

        private void layoutDespesa()
        {
            listaDespesaCusto = Buscar.BuscarListaDespesaPorTipo(cmbTipoDespesa.Text, lblCategoria.Text);

            lblCNPJ.Visible = false;
            txtCNPJ.Visible = false;
            txtCNPJ.Text = "-";
            txtValorParcelas.Visible = false;
            txtValorParcelas.Text = "0";
            lblValorParcelas.Visible = false;
            cmbQuantidadeParcelas.Visible = false;
            cmbQuantidadeParcelas.Text = "1";
            lblQuantidadeParcelas.Visible = false;
        }

        #region Layout Tela Custos

        private void layoutCusto()
        {
            lblCategoria.Text = "Custo";
            txtValorParcelas.Text = String.Empty;
            cmbQuantidadeParcelas.Text = String.Empty;
            txtCNPJ.Text = String.Empty;
            cmbFrequencia.Visible = true;
        }

        #endregion Layout Tela Custos

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
            {
                Excluir.ExcluirDespesaCusto(Convert.ToInt32(txtCodigo.Text));

                ManipulacaoTextBox.ApagandoTextBox(this);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Forms_PesquisarDespesaCustos pesquisarDespesa = new Forms_PesquisarDespesaCustos(this, this.Text);
            pesquisarDespesa.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDespesa();

            if (txtCodigo.Text != string.Empty)
            {
                Salvar.InserirImagemPagamentoDespesaCusto(pcbStatusPagamento.Image, Convert.ToInt32(txtCodigo.Text), lblStatusPagamento.Text);
            }
        }

        #region Salvar Despesa

        private void SalvarDespesa()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    List<DadosDespesaCusto> listaDespesas = Buscar.BuscarListaDespesaCusto(cmbTipoDespesa.Text, lblCategoria.Text);

                    if (listaDespesas.Find(lista => lista.descricao == txtDescricao.Text && lista.forncedorTitulo == cmbFornecedorTitulo.Text) == null)
                    {
                        bool semanal = cmbFrequencia.Text == "Semanal" ? Convert.ToBoolean(dias = 7) : false;
                        bool quinzenal = cmbFrequencia.Text == "Quinzenal" ? Convert.ToBoolean(dias = 15) : false;
                        bool mensal = cmbFrequencia.Text == "Mensal" ? Convert.ToBoolean(dias = 30) : false;
                        bool bimestral = cmbFrequencia.Text == "Bimestral" ? Convert.ToBoolean(dias = 90) : false;
                        bool semestral = cmbFrequencia.Text == "Semestral" ? Convert.ToBoolean(dias = 180) : false;
                        bool anual = cmbFrequencia.Text == "Anual" ? Convert.ToBoolean(dias = 365) : false;

                        for (int i = 1; i <= Convert.ToInt32(cmbQuantidadeParcelas.Text.Replace("x", "")); i++)
                        {
                            if (i == 1)
                            {
                                Salvar.InserirDespesaCusto(cmbTipoDespesa.Text, txtDescricao.Text, cmbFornecedorTitulo.Text,
                                    txtCNPJ.Text, Convert.ToDateTime(txtEmissao.Text), Convert.ToDateTime(txtVencimento.Text), cmbFrequencia.Text,
                                    Convert.ToDecimal(txtValor.Text.Replace("R$ ", "")),
                                    ($"{i}/" + cmbQuantidadeParcelas.Text.Replace("x", "")),
                                    Convert.ToDecimal(txtValorParcelas.Text.Replace("R$ ", "")), lblCategoria.Text);

                                txtCodigo.Text = Buscar.BuscarCodigo(txtDescricao.Text).ToString();

                                Atualizar.AlterarCodigoDespesaCusto(Convert.ToInt32(txtCodigo.Text), txtDescricao.Text);

                                btnSalvar.Enabled = false;
                            }
                            else
                            {
                                Salvar.InserirDespesaCusto(cmbTipoDespesa.Text, txtDescricao.Text, cmbFornecedorTitulo.Text,
                                    txtCNPJ.Text, Convert.ToDateTime(txtEmissao.Text),
                                    Convert.ToDateTime(txtVencimento.Text).AddDays(dias * cont), cmbFrequencia.Text,
                                    Convert.ToDecimal(txtValor.Text.Replace("R$ ", "")),
                                    ($"{i}/" + cmbQuantidadeParcelas.Text.Replace("x", "")),
                                    Convert.ToDecimal(txtValorParcelas.Text.Replace("R$ ", "")), lblCategoria.Text);

                                Atualizar.AlterarCodigoDespesaCusto(Convert.ToInt32(txtCodigo.Text), txtDescricao.Text);

                                cont++;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Despesa Já Cadastrada!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoInserirDadosDespesa(ex);
            }
        }

        #endregion Salvar Despesa

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarDespesa();
        }

        #region Alterar Despesa

        private void AlterarDespesa()
        {
            try
            {
                if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false)
                {
                    List<DadosDespesaCusto> listaDespesas = Buscar.BuscarListaDespesaCusto(cmbTipoDespesa.Text, lblCategoria.Text);

                    if (listaDespesas.Find(lista => lista.descricao == txtDescricao.Text && lista.forncedorTitulo == cmbFornecedorTitulo.Text) == null)
                    {
                        if (cmbTipoDespesa.Text == "Fixa")
                        {
                            Atualizar.AtualizarDespesaCusto(cmbTipoDespesa.Text, txtDescricao.Text, cmbFornecedorTitulo.Text,
                                txtCNPJ.Text, Convert.ToDateTime(txtEmissao.Text), Convert.ToDateTime(txtVencimento.Text), cmbFrequencia.Text,
                                Convert.ToDecimal(txtValor.Text.Replace("R$", "")), cmbQuantidadeParcelas.Text,
                                Convert.ToDecimal(txtValorParcelas.Text.Replace("R$", "")), lblCategoria.Text, Convert.ToInt32(txtCodigo.Text));
                        }
                        else
                        {
                            Atualizar.AtualizarDespesaCusto(cmbTipoDespesa.Text, txtDescricao.Text, cmbFornecedorTitulo.Text,
                                txtCNPJ.Text, Convert.ToDateTime(txtEmissao.Text), Convert.ToDateTime(txtVencimento.Text), cmbFrequencia.Text,
                                Convert.ToDecimal(txtValor.Text.Replace("R$", "")), cmbQuantidadeParcelas.Text,
                                Convert.ToDecimal(txtValorParcelas.Text.Replace("R$", "")), lblCategoria.Text, Convert.ToInt32(txtCodigo.Text));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Despesa Já Cadastrada!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoInserirDadosDespesa(ex);
            }
        }

        #endregion Alterar Despesa

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            ManipulacaoTextBox.ApagandoTextBox(this);

            txtCNPJ.Text = "-";
            txtValorParcelas.Text = "0";
            cmbQuantidadeParcelas.Text = "1";

            btnSalvar.Enabled = true;
        }

        private void cmbTipoDespesa_SelectedValueChanged(object sender, EventArgs e)
        {
            PreencherComboBoxFornecedorTitulo();

            //if (cmbTipoDespesa.Text == "Variavel")
            //{
            //    cmbFrequencia.Enabled = false;
            //    cmbFrequencia.Text = "--------";
            //}
            //else
            //{
            //    cmbFrequencia.Enabled = true;
            //    cmbFrequencia.Text = String.Empty;
            //}
        }

        #region Preencher ComboBox Fornecedor Titulo

        private void PreencherComboBoxFornecedorTitulo()
        {
            cmbFornecedorTitulo.Items.Clear();
            cmbFornecedorTitulo.Text = String.Empty;

            listaDespesaCusto = Buscar.BuscarListaDespesaPorTipo(cmbTipoDespesa.Text, lblCategoria.Text);

            if (listaDespesaCusto.Count != 0)
            {
                foreach (DadosCadastroDespesasCusto item in listaDespesaCusto)
                {
                    cmbFornecedorTitulo.Items.Add(item.descricao);
                }
            }
        }

        #endregion Preencher ComboBox Fornecedor Titulo

        private void cmbTipoDespesa_Enter(object sender, EventArgs e)
        {
            PreencherComboBoxTipo();
        }

        #region Preencher ComboBox Tipo

        private void PreencherComboBoxTipo()
        {
            cmbTipoDespesa.MaxLength = 50;

            cmbTipoDespesa.Items.Clear();

            foreach (string item in Buscar.BuscarListaDespesa(lblCategoria.Text))
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

        private void txtVencimento_Leave(object sender, EventArgs e)
        {
            VerificarDataTextBox(txtVencimento);
        }

        #region Verificar Data TextBox

        private void VerificarDataTextBox(BunifuTextBox _textBox)
        {
            if (txtVencimento.Text != String.Empty && txtEmissao.Text != String.Empty)
            {
                if (ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtVencimento) == true)
                {
                    if (ManipulacaoTextBox.ValidacaoData(txtVencimento) == false)
                    {
                        return;
                    }
                    if (Convert.ToDateTime(txtEmissao.Text) > Convert.ToDateTime(txtVencimento.Text))
                    {
                        MessageBox.Show("A Data de Emissão Não Pode Ser Maior que a Data De Vencimento!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        _textBox.Focus();
                    }
                }
            }
        }

        #endregion Verificar Data TextBox

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

        private void txtCNPJ_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.FormatoCNPJ(e, txtCNPJ);
            }
        }

        private void cmbQuantidadeParcelas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txtValor.Text != "")
            {
                txtValorParcelas.Text = string.Format("R$ {0:#,##0.00}", Convert.ToDecimal(txtValor.Text.Replace("R$", "")) /
                Convert.ToDecimal(cmbQuantidadeParcelas.Text.Replace("x", "")));
            }
        }

        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtValorParcelas.Text = string.Format("R$ {0:#,##0.00}", Convert.ToDecimal(txtValor.Text.Replace("R$", "")) /
                Convert.ToDecimal(cmbQuantidadeParcelas.Text.Replace("x", "")));
            }
            catch (Exception exception)
            {
            }
        }

        private void txtVencimento_Enter(object sender, EventArgs e)
        {
            if (txtEmissao.Text == String.Empty)
            {
                txtEmissao.Focus();
            }
        }

        private void dtpEmissao_ValueChanged(object sender, EventArgs e)
        {
            if (cmbTipoDespesa.Text != string.Empty)
            {
                txtEmissao.Text = dtpEmissao.Value.ToShortDateString();
            }
        }

        private void dtpVencimento_ValueChanged(object sender, EventArgs e)
        {
            if (cmbTipoDespesa.Text != string.Empty)
            {
                txtVencimento.Text = dtpVencimento.Value.ToShortDateString();
            }
        }

        private void dtpVencimento_Leave(object sender, EventArgs e)
        {
            VerificarDataDatePicker(dtpVencimento);
        }

        #region Verificar Data DataPicker

        private void VerificarDataDatePicker(BunifuDatePicker _datePicker)
        {
            if (txtEmissao.Text != String.Empty && txtVencimento.Text != String.Empty)
            {
                if (ManipulacaoTextBox.VerificarcaoPreencimentoCompleto(txtVencimento) == true)
                {
                    if (Convert.ToDateTime(txtEmissao.Text) > Convert.ToDateTime(txtVencimento.Text))
                    {
                        MessageBox.Show("A Data de Emissão Não Pode Ser Maior que a Data De Vencimento!", "Atenção!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        _datePicker.Focus();
                    }
                }
            }
        }

        #endregion Verificar Data DataPicker

        private void dtpVencimento_Enter(object sender, EventArgs e)
        {
            if (txtEmissao.Text == String.Empty)
            {
                dtpEmissao.Focus();
            }
        }

        private void cmbFornecedorTitulo_Leave(object sender, EventArgs e)
        {
            DadosCadastroDespesasCusto _tituloDescricao;

            _tituloDescricao = listaDespesaCusto.Find(despesasCusto => despesasCusto.descricao.Equals(cmbFornecedorTitulo.Text));

            if (_tituloDescricao == null && cmbFornecedorTitulo.Text != string.Empty)
            {
                MessageBox.Show("Titulo Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmbFornecedorTitulo.Focus();
            }
        }
    }
}