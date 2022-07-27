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
    public partial class Forms_PesquisarContasAReceber : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        public Forms_PesquisarContasAReceber()
        {
            InitializeComponent();

            PreencherDatePicker();

            SetarDesignColunaGridView();
        }

        private void SetarDesignColunaGridView()
        {
            this.gdvContarReceber.Columns["pc_valor_parcela"].DefaultCellStyle.Format = "c";
        }

        private void PreencherDatePicker()
        {
            DateTime data = DateTime.Today;

            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));

            dtpDataFinal.Text = ultimoDiaDoMes.ToString();

            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);

            dtpDataInicial.Text = primeiroDiaDoMes.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNumeroNotaFiscal.Text != String.Empty && cmbStatusPagamento.Text == String.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCarnePorNumeroNotaFiscalSaida(Convert.ToInt32(txtNumeroNotaFiscal.Text), gdvContarReceber,
                    Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text));

                MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
            }
            else if (txtCpfCpnj.Text != String.Empty && cmbStatusPagamento.Text == String.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCarnePorCPFCNPJ(txtCpfCpnj.Text, gdvContarReceber,
                    Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text));

                MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
            }
            else if (txtNomeCliente.Text != String.Empty && cmbStatusPagamento.Text == String.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCarnePorNomeCliente(txtNomeCliente.Text, gdvContarReceber,
                    Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text));

                MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
            }
            else if (cmbStatusPagamento.Text != String.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCarnePorPagamento(cmbStatusPagamento.Text, gdvContarReceber,
                    Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text));

                MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
            }
            else if (txtNumeroNotaFiscal.Text != String.Empty && cmbStatusPagamento.Text != String.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCarnePorNumeroNotaFiscalSaidaComStatusPagamento(Convert.ToInt32(txtNumeroNotaFiscal.Text),
                    gdvContarReceber, Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text),
                    cmbStatusPagamento.Text);

                MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
            }
            else if (txtCpfCpnj.Text != String.Empty && cmbStatusPagamento.Text != String.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCarnePorCPFCNPJComStatusPagamento(txtCpfCpnj.Text, gdvContarReceber,
                Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text), cmbStatusPagamento.Text);

                MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
            }
            else if (txtNomeCliente.Text != String.Empty && cmbStatusPagamento.Text != String.Empty)
            {
                bool isCadastroExiste = Buscar.BuscarCarnePorNomeClienteComStatusPagamento(txtNomeCliente.Text, gdvContarReceber,
                    Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text), cmbStatusPagamento.Text);

                MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Realizar a Busca Completa?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    bool isCadastroExiste = Buscar.BuscarCarneBuscaCompleta(gdvContarReceber,
                        Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text));

                    MenssagemDespesaCustoNaoEncontrado(isCadastroExiste);
                }
            }
        }

        private void MenssagemDespesaCustoNaoEncontrado(bool _isCadastroExiste)
        {
            if (_isCadastroExiste == false)
            {
                MessageBox.Show("Conta Não Encontrado ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Forms_PesquisarContasAReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void gdvContarReceber_DoubleClick(object sender, EventArgs e)
        {
            Forms_EditarPagamentoAReceber editarPagamentoAReceber = new Forms_EditarPagamentoAReceber();
            editarPagamentoAReceber.ShowDialog();
        }
    }
}