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
    public partial class Forms_GerarCarne : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private MensagensErro Erro = new MensagensErro();

        public Forms_Venda forms;

        //private List<DadosCarne> listaCarne = new List<DadosCarne>();

        public Forms_GerarCarne(Forms_Venda _forms)
        {
            InitializeComponent();

            DadosDoCarneParaPreenchimentoTextBox();

            forms = _forms;
        }

        public Forms_GerarCarne()
        {
            InitializeComponent();
        }

        #region Preenchimentos dos TextBox Prazo, Juros, Parcelas

        private void DadosDoCarneParaPreenchimentoTextBox()
        {
            try
            {
                List<DadosCarne> listaCarne = Buscar.BuscarGerarCarne();

                txtPrazo.Text = listaCarne[0].prazo.ToString();

                txtParcelasQueGeramJuros.Text = listaCarne[0].parcelas.ToString();

                txtPrimeiraParcela.Text = DateTime.Today.AddDays(Convert.ToDouble(txtPrazo.Text)).ToShortDateString();
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarDadosParaPreencherTextBox(ex);
            }
        }

        #endregion Preenchimentos dos TextBox Prazo, Juros, Parcelas

        #region ComboBox Parcela Carne

        #region Preencher GridView

        private void PreencherGridview()
        {
            gdvGerarCarne.Rows.Clear();

            int dias = 30;

            for (int quantParcelas = 1; quantParcelas <= Convert.ToInt32(cmbParcelaCarne.Text.Replace("x", "")); quantParcelas++)
            {
                gdvGerarCarne.ColumnCount = 4;

                var rows = new List<string[]>();
                string[] row1 = new string[] { forms.txtNumeroNF.Text,
                    (cmbParcelaCarne.Text.Replace("x","") +"/" + quantParcelas),
                    txtValorParcelaCarne.Text,
                    (Convert.ToDateTime(txtPrimeiraParcela.Text).AddDays(dias * quantParcelas)).ToShortDateString()};
                rows.Add(row1);

                foreach (string[] item in rows)
                {
                    gdvGerarCarne.Rows.Add(item);
                }
            }
        }

        #endregion Preencher GridView

        #region CalcularJuros

        private void CalcularJuros()
        {
            try
            {
                List<DadosCarne> listaCarne = Buscar.BuscarGerarCarne();

                if (Convert.ToInt32(cmbParcelaCarne.Text.Replace("x", "")) > Convert.ToInt32(txtParcelasQueGeramJuros.Text))
                {
                    txtJurosCarne.Text = string.Format("{0:P}", listaCarne[0].juros / 100).ToString();

                    txtValorTotalCarne.Text = string.Format("{0:C}", (Convert.ToDecimal(txtJurosCarne.Text.Replace("%", "")) *
                                                                         Convert.ToDecimal(forms.txtValorTotal.Text.Replace("R$ ", "")) / 100) +
                                                                     Convert.ToDecimal(forms.txtValorTotal.Text.Replace("R$ ", ""))).ToString();

                    txtValorParcelaCarne.Text = string.Format("{0:C}",
                        (Convert.ToDecimal(txtValorTotalCarne.Text.Replace("R$ ", "")) /
                         Convert.ToDecimal(cmbParcelaCarne.Text.Replace("x", "")))).ToString();
                }
                else
                {
                    txtJurosCarne.Text = string.Format("{0:P}", "0,00%");

                    txtValorTotalCarne.Text = string.Format("{0:C}", (Convert.ToDecimal(txtJurosCarne.Text.Replace("%", "")) *
                                                                         Convert.ToDecimal(forms.txtValorTotal.Text.Replace("R$ ", "")) / 100) +
                                                                     Convert.ToDecimal(forms.txtValorTotal.Text.Replace("R$ ", ""))).ToString();

                    txtValorParcelaCarne.Text = string.Format("{0:C}",
                        (Convert.ToDecimal(txtValorTotalCarne.Text.Replace("R$ ", "")) /
                         Convert.ToDecimal(cmbParcelaCarne.Text.Replace("x", "")))).ToString();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarJurosGerarCarne(ex);
            }
        }

        #endregion CalcularJuros

        private void cmbParcelaCarne_SelectedValueChanged(object sender, EventArgs e)
        {
            CalcularJuros();

            PreencherGridview();
        }

        #endregion ComboBox Parcela Carne

        #region Botão Fechar

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Botão Fechar
    }
}