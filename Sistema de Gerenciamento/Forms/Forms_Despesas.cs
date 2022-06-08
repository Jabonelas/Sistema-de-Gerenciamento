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

        private List<DadosDespesasCusto> despesa = new List<DadosDespesasCusto>();

        public Forms_Despesas()
        {
            InitializeComponent();
        }

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
            cmbTipoDespesa.MaxLength = 50;

            cmbTipoDespesa.Items.Clear();

            foreach (string item in Buscar.BuscarListaDespesa())
            {
                cmbTipoDespesa.Items.Add(item);
            }
        }

        private void cmbTipoDespesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void cmbTipoDespesa_MouseUp(object sender, MouseEventArgs e)
        {
            //List<DadosDespesasCusto> listaDespesas = Buscar.BuscarListaDespesaPorTipo(cmbTipoDespesa.Text);

            //if (listaDespesas.Count != 0)
            //{
            //    foreach (DadosDespesasCusto item in listaDespesas)
            //    {
            //        txtCodigo.Text = item.codigo.ToString();
            //    }
            //}
            //else
            //{
            //    txtCodigo.Text = string.Empty;
            //}

            //if (cmbTipoDespesa.Text == string.Empty)
            //{
            //    txtCodigo.Text = string.Empty;
            //}
        }

        private void cmbDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiLetrasOuNumeros(e);
        }

        private void cmbTipoDespesa_Leave(object sender, EventArgs e)
        {
            cmbDescricao.Items.Clear();

            List<DadosDespesasCusto> listaDespesas = Buscar.BuscarListaDespesaPorTipo(cmbTipoDespesa.Text);

            if (listaDespesas.Count != 0)
            {
                foreach (DadosDespesasCusto item in listaDespesas)
                {
                    cmbDescricao.Items.Add(item.descricao);
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

        private void cmbDescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DadosDespesasCusto> listaDespesas = Buscar.BuscarListaDespesaPorTipo(cmbTipoDespesa.Text);

            if (listaDespesas.Count != 0)
            {
                foreach (DadosDespesasCusto item in listaDespesas)
                {
                    if (cmbDescricao.Text == item.descricao)
                    {
                        txtCodigo.Text = item.codigo.ToString();
                    }
                }
            }
        }
    }
}