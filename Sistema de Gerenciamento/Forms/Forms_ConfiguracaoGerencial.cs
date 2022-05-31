using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Sistema_de_Gerenciamento.Classes;

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

            PreencherComboBoxGrupoeSub_Grup();
        }

        #region Preencher Combobox

        private void PreencherComboBoxGrupoeSub_Grup()
        {
            List<DadosGrupoMaterial> listaGrupo = new List<DadosGrupoMaterial>();

            listaGrupo = Buscar.BuscarGrupoProduto();

            cmbGrupoProduto.Items.Clear();

            cmbSub_GrupoProduto.Items.Clear();

            foreach (DadosGrupoMaterial item in listaGrupo)
            {
                cmbGrupoProduto.Items.Add(item.grupo);
                cmbSub_GrupoProduto.Items.Add(item.sub_grupo);
            }
        }

        #endregion Preencher Combobox

        #region Botao Fechar

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botao Fechar

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

        private void btnConfirmarGrupo_Click(object sender, EventArgs e)
        {
            Atualizacao.AtualizarDescontoPorGrupoDeProduto(cmbGrupoProduto.Text,
                cmbSub_GrupoProduto.Text, Convert.ToDecimal(txtDescontoPorGrupo.Text.Replace("%", "")));
        }
    }
}