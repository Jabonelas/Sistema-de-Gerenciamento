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
    public partial class Forms_PesquisarDespesa : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private Forms_Despesas despesas;

        public Forms_PesquisarDespesa()
        {
            InitializeComponent();
        }

        public Forms_PesquisarDespesa(Forms_Despesas _despesas)
        {
            InitializeComponent();

            despesas = _despesas;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarDespesa();
        }

        #region Pesquisar Despesa

        private void PesquisarDespesa()
        {
            if (txtCodigoDespesa.Text != string.Empty)
            {
                bool isDespesaExiste = Buscar.BuscarDespesaPorCogigo(Convert.ToInt32(txtCodigoDespesa.Text),
                    lblDespesa.Text, gdvPesquisarDespesa);

                MensagemDespesaNaoEncontrada(isDespesaExiste);
            }
            else if (cmbTipoDespesa.Text != String.Empty)
            {
                bool isDespesaExiste = Buscar.BuscarDespesaPorTipo(cmbTipoDespesa.Text,
                    lblDespesa.Text, gdvPesquisarDespesa);

                MensagemDespesaNaoEncontrada(isDespesaExiste);
            }
            else if (txtTitulo.Text != String.Empty)
            {
                bool isDespesaExiste = Buscar.BuscarDespesaPorTitulo(txtTitulo.Text,
                    lblDespesa.Text, gdvPesquisarDespesa);

                MensagemDespesaNaoEncontrada(isDespesaExiste);
            }
            else if (txtDescricao.Text != String.Empty)
            {
                bool isDespesaExiste = Buscar.BuscarDespesaPorDescricao(txtDescricao.Text,
                    lblDespesa.Text, gdvPesquisarDespesa);

                MensagemDespesaNaoEncontrada(isDespesaExiste);
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Exibir Todos As Despesas?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    bool isDespesaExiste = Buscar.BuscarDespesa(lblDespesa.Text, gdvPesquisarDespesa);

                    MensagemDespesaNaoEncontrada(isDespesaExiste);
                }
            }
        }

        #region Mensagem Despesa Não Encontrada

        private void MensagemDespesaNaoEncontrada(bool _isDespesaExiste)
        {
            if (_isDespesaExiste == false)
            {
                MessageBox.Show("Despesa Não Encontrada ", "Não Encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion Mensagem Despesa Não Encontrada

        #endregion Pesquisar Despesa
    }
}