using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.CorreiosServiceReference;
using Guna.UI2.WinForms;
using Sistema_de_Gerenciamento.Classes;
using Exception = System.Exception;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_ConfiguracaoGerencial : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private ManipulacaoTextBox TextBox = new ManipulacaoTextBox();

        private AtualizacaoNoBanco Atualizacao = new AtualizacaoNoBanco();

        public Forms_ConfiguracaoGerencial()
        {
            InitializeComponent();

            PreencherComboBoxGrupo();
        }

        #region Botao Fechar

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Fechar

        #region Botao Confirmar Desconto Por Grupo

        private void btnConfirmarGrupo_Click(object sender, EventArgs e)
        {
            if (cmbSub_GrupoProduto.Text != String.Empty && cmbGrupoProduto.Text != String.Empty && txtDescontoPorGrupo.Text != String.Empty)
            {
                Atualizacao.AtualizarDescontoPorGrupoDeProduto(cmbGrupoProduto.Text,
                    cmbSub_GrupoProduto.Text, Convert.ToDecimal(txtDescontoPorGrupo.Text.Replace("%", "")));

                cmbSub_GrupoProduto.Text = String.Empty;
                cmbGrupoProduto.Text = String.Empty;
                txtDescontoPorGrupo.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Por Favor Preencha Todos Campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmbGrupoProduto.Focus();
            }
        }

        #endregion Botao Confirmar Desconto Por Grupo

        #region Preencher Combobox

        #region Preencher ComboBox Grupo

        private void PreencherComboBoxGrupo()
        {
            List<DadosGrupoMaterial> listaGrupo = new List<DadosGrupoMaterial>();

            listaGrupo = Buscar.BuscarGrupoProduto();

            cmbGrupoProduto.Items.Clear();

            listaGrupo.ForEach(prod => cmbGrupoProduto.Items.Add(prod.grupo));

            cmbGrupoProduto.Items.Add(string.Empty);
        }

        private void cmbGrupoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherComboBoxSubGrupo();
        }

        #endregion Preencher ComboBox Grupo

        #region Preencher ComboBox Sub-Grupo

        private void PreencherComboBoxSubGrupo()
        {
            List<DadosSubGrupoMaterial> listaSubGrupo = new List<DadosSubGrupoMaterial>();

            listaSubGrupo = Buscar.BuscarSubGrupoProduto(cmbGrupoProduto.Text);

            cmbSub_GrupoProduto.Items.Clear();

            listaSubGrupo.ForEach(prod => cmbSub_GrupoProduto.Items.Add(prod.sub_grupo));

            cmbSub_GrupoProduto.Items.Add(string.Empty);
        }

        private void cmbSub_GrupoProduto_Enter(object sender, EventArgs e)
        {
            if (cmbGrupoProduto.Text == String.Empty)
            {
                MessageBox.Show("Por Favor Preencha Primeiro O Campo Grupo Produto!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbGrupoProduto.Focus();
            }
        }

        #endregion Preencher ComboBox Sub-Grupo

        #endregion Preencher Combobox

        #region TextBox Desconto Por Grupo

        private void txtDescontoPorGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox.DigitarApenasNumeros(e);

            try
            {
                if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    if (txtDescontoPorGrupo.Text.Length <= 7 || e.KeyChar.Equals((char)Keys.Back))
                    {
                        TextBox textbox = (TextBox)sender;
                        string testoDoTextBox = Regex.Replace(textbox.Text, "[^0-9]", string.Empty);
                        if (testoDoTextBox == string.Empty)
                        {
                            testoDoTextBox = "0";
                        }

                        testoDoTextBox += e.KeyChar;
                        textbox.Text = String.Format("{0:#,##0.00} %", double.Parse(testoDoTextBox) / 100);
                        textbox.Select(textbox.Text.Length, 0);
                    }
                }
                e.Handled = true;
            }
            catch (Exception)
            {
            }
        }

        #endregion TextBox Desconto Por Grupo

        #region TextBox Desconto Avista

        private void txtDescontoAvista_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox.DigitarApenasNumeros(e);

            try
            {
                if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    if (txtDescontoAvista.Text.Length <= 7 || e.KeyChar.Equals((char)Keys.Back))
                    {
                        TextBox textbox = (TextBox)sender;
                        string testoDoTextBox = Regex.Replace(textbox.Text, "[^0-9]", string.Empty);
                        if (testoDoTextBox == string.Empty)
                        {
                            testoDoTextBox = "0";
                        }

                        testoDoTextBox += e.KeyChar;
                        textbox.Text = String.Format("{0:#,##0.00} %", double.Parse(testoDoTextBox) / 100);
                        textbox.Select(textbox.Text.Length, 0);
                    }
                }
                e.Handled = true;
            }
            catch (Exception)
            {
            }
        }

        #endregion TextBox Desconto Avista

        #region TextBox Prazo Carne

        private void txtPrazoCarne_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox.DigitarApenasNumeros(e);
        }

        #endregion TextBox Prazo Carne

        #region TextBox Juros Credito

        private void txtJurosCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox.DigitarApenasNumeros(e);

            TextBox.PreenchimentoPorcentagem(e, txtJurosCredito.Text, sender);
        }

        #endregion TextBox Juros Credito

        #region TextBox Juros Carne

        private void txtJurosCarne_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox.DigitarApenasNumeros(e);

            TextBox.PreenchimentoPorcentagem(e, txtJurosCarne.Text, sender);
        }

        #endregion TextBox Juros Carne

        #region TextBox Juros Credito

        private void txtJurosCredito_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            TextBox.DigitarApenasNumeros(e);

            TextBox.PreenchimentoPorcentagem(e, txtJurosCredito.Text, sender);
        }

        #endregion TextBox Juros Credito

        #region Botao Confirmar Desconto Avista

        private void btnConfirmarAvista_Click(object sender, EventArgs e)
        {
            if (txtDescontoAvista.Text != String.Empty)
            {
                Atualizacao.AtualizarPagamentoDescontoAvista(Convert.ToDecimal(txtDescontoAvista.Text.Replace("%", "")));

                txtDescontoAvista.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Por Favor Preencha Todos Campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtDescontoAvista.Focus();
            }
        }

        #endregion Botao Confirmar Desconto Avista

        #region Botao Confirmar Juros Carne

        private void btnConfirmarCarne_Click(object sender, EventArgs e)
        {
            if (txtPrazoCarne.Text != String.Empty && cmbParcelasCarne.Text != String.Empty && txtJurosCarne.Text != String.Empty)
            {
                Atualizacao.JurosPorCarne(Convert.ToInt32(txtPrazoCarne.Text), Convert.ToDecimal(txtJurosCarne.Text.Replace("%", "")),
                    Convert.ToInt32(cmbParcelasCarne.Text.Replace("x", "")));

                txtPrazoCarne.Text = String.Empty;
                cmbParcelasCarne.Text = String.Empty;
                txtJurosCarne.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Por Favor Preencha Todos Campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmbParcelasCarne.Focus();
            }
        }

        #endregion Botao Confirmar Juros Carne

        #region Botao Confirmar Juros Credito

        private void btnConfirmarCredito_Click(object sender, EventArgs e)
        {
            if (txtJurosCredito.Text != String.Empty && cmbParcelasCredito.Text != String.Empty)
            {
                Atualizacao.JurosCredito(Convert.ToDecimal(txtJurosCredito.Text.Replace("%", "")),
                    Convert.ToInt32(cmbParcelasCredito.Text.Replace("x", "")));
            }
            else
            {
                MessageBox.Show("Por Favor Preencha Todos Campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmbParcelasCredito.Focus();
            }
        }

        #endregion Botao Confirmar Juros Credito
    }
}