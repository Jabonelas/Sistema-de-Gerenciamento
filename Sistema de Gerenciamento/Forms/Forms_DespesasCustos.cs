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

        private int cont = 1;

        private int frequencia = 1;

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
        }

        #region Layout Tela Despesa

        private void layoutDespesa()
        {
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

        #endregion Layout Tela Despesa

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
                        if (cmbFrequencia.Text == "Semanal")
                        {
                            frequencia = 7;
                        }
                        else if (cmbFrequencia.Text == "Quinzenal")
                        {
                            frequencia = 15;
                        }
                        else if (cmbFrequencia.Text == "Mensal")
                        {
                            frequencia = 30;
                        }
                        else if (cmbFrequencia.Text == "Bimestral")
                        {
                            frequencia = 90;
                        }
                        else if (cmbFrequencia.Text == "Semestral")
                        {
                            frequencia = 180;
                        }
                        else if (cmbFrequencia.Text == "Anual")
                        {
                            frequencia = 365;
                        }

                        for (int i = 1; i <= Convert.ToInt32(cmbQuantidadeParcelas.Text.Replace("x", "")); i++)
                        {
                            if (i == 1)
                            {
                                Salvar.InserirDespesaCusto(cmbTipoDespesa.Text, txtDescricao.Text, cmbFornecedorTitulo.Text,
                                    txtCNPJ.Text, Convert.ToDateTime(txtEmissao.Text), Convert.ToDateTime(txtVencimento.Text), cmbFrequencia.Text,
                                    Convert.ToDecimal(txtValor.Text.Replace("R$ ", "")),
                                    i,
                                    Convert.ToDecimal(txtValorParcelas.Text.Replace("R$ ", "")), lblCategoria.Text);

                                txtCodigo.Text = Buscar.BuscarCodigo(txtDescricao.Text).ToString();

                                Atualizar.AlterarCodigoDespesaCusto(Convert.ToInt32(txtCodigo.Text), txtDescricao.Text);
                            }
                            else
                            {
                                Salvar.InserirDespesaCusto(cmbTipoDespesa.Text, txtDescricao.Text, cmbFornecedorTitulo.Text,
                                    txtCNPJ.Text, Convert.ToDateTime(txtEmissao.Text),
                                    Convert.ToDateTime(txtVencimento.Text).AddDays(frequencia * cont), cmbFrequencia.Text,
                                    Convert.ToDecimal(txtValor.Text.Replace("R$ ", "")), i,
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
                        Atualizar.AtualizarDespesaCusto(cmbTipoDespesa.Text, txtDescricao.Text, cmbFornecedorTitulo.Text,
                            txtCNPJ.Text, Convert.ToDateTime(txtEmissao.Text), Convert.ToDateTime(txtVencimento.Text), cmbFrequencia.Text,
                            Convert.ToDecimal(txtValor.Text.Replace("R$", "")), Convert.ToInt32(cmbQuantidadeParcelas.Text),
                            Convert.ToDecimal(txtValorParcelas.Text), lblCategoria.Text, Convert.ToInt32(txtCodigo.Text));
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

            List<DadosCadastroDespesasCusto> listaDespesas = Buscar.BuscarListaDespesaPorTipo(cmbTipoDespesa.Text, lblCategoria.Text);

            if (listaDespesas.Count != 0)
            {
                foreach (DadosCadastroDespesasCusto item in listaDespesas)
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
            VerificarData();
        }

        #region Verificar Data

        private void VerificarData()
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

                    txtVencimento.Focus();
                }
            }
        }

        #endregion Verificar Data

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
            if (txtValor.Text != string.Empty)
            {
                txtValorParcelas.Text = string.Format("R$ {0:#,##0.00}", Convert.ToDecimal(txtValor.Text.Replace("R$", "")));
            }

            Convert.ToDecimal(cmbQuantidadeParcelas.Text.Replace("x", ""));
        }

        private void txtVencimento_Enter(object sender, EventArgs e)
        {
            if (txtEmissao.Text == String.Empty)
            {
                txtEmissao.Focus();
            }
        }

     
    }
}