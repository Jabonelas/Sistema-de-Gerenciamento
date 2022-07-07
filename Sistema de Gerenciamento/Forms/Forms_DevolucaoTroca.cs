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
    public partial class Forms_DevolucaoTroca : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private List<DadosNotaFiscalSaida> listaDadosNotaFiscalSaida = new List<DadosNotaFiscalSaida>();

        public Forms_DevolucaoTroca()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar.BuscarVendaPorNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text), gdvDevolucaoTroca);

            foreach (var item in Buscar.ListaNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text)))
            {
                listaDadosNotaFiscalSaida.Add(item);
            }

            txtVendedor.Text = listaDadosNotaFiscalSaida[0].vendedor;
            txtValidadeTroca.Text = listaDadosNotaFiscalSaida[0].ValidadeTroca.ToShortDateString();
            txtNomeCliente.Text = listaDadosNotaFiscalSaida[0].nomeCliente;

            //compras.listaDadosNotaFiscalEntrada.ForEach(nf => ListaEntrada = nf);

            //Buscar.ListaNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text)).ForEach(nf => listaDadosNotaFiscalSaida = nf);

            //Buscar.ListaNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text));
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "DEVOLUÇÃO")
            {
                lblTroca.Visible = false;
                lblQuant.Visible = false;
                lblProduto.Visible = false;
                lblPreco.Visible = false;
                lblCodBarras.Visible = false;
                lblCodigoProduto.Visible = false;
                lblUnidade.Visible = false;
                txtCodBarrasTroca.Visible = false;
                txtCodProdutoTroca.Visible = false;
                txtProdutoTroca.Visible = false;
                txtQuantidadeTroca.Visible = false;
                txtUnidadeTroca.Visible = false;
                txtPrecoTroca.Visible = false;

                pnlValorPrudutoTroca.Visible = false;

                pnlValorProdutoDevolvido.Location = new Point(171, 506);
                pnlValorAPagar.Location = new Point(468, 506);
            }
        }

        private void txtProdutoDevolucao_TextChanged(object sender, EventArgs e)
        {
        }
    }
}