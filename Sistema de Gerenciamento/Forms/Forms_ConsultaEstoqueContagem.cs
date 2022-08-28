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

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_ConsultaEstoqueContagem : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private Forms_ConsultarEstoque forms_ConsultarEstoque;

        public Forms_ConsultaEstoqueContagem(Forms_ConsultarEstoque _forms_ConsultarEstoque)
        {
            InitializeComponent();

            forms_ConsultarEstoque = _forms_ConsultarEstoque;

            PrreencherTextBox();

            PreencherGridView();
        }

        private void SetarDesignColunaGridView()
        {
            this.gdvEstoqueContagem.Columns["ep_valor_unitario"].DefaultCellStyle.Format = "c";
        }

        private void PreencherGridView()
        {
            SetarDesignColunaGridView();

            Buscar.BuscarEstoqueContagem(Convert.ToInt32(txtCodigo.Text), gdvEstoqueContagem);
        }

        private void PrreencherTextBox()
        {
            txtCodigo.Text = forms_ConsultarEstoque.txtCodigo.Text;
            txtDescricao.Text = forms_ConsultarEstoque.txtDescricao.Text;
            txtUnidade.Text = forms_ConsultarEstoque.txtUnidade.Text;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Forms_ConsultaEstoqueContagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
        }
    }
}