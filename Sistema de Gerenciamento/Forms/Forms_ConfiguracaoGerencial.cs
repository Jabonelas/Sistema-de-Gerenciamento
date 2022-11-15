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
        public Forms_ConfiguracaoGerencial()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfiguracaoGerencialPagamentoCarne_Click(object sender, EventArgs e)
        {
            Forms_ConfiguracaoGerencialPagamentoCarne configuracaoGerencialPagamentoCarne = new Forms_ConfiguracaoGerencialPagamentoCarne();
            configuracaoGerencialPagamentoCarne.ShowDialog();
        }

        private void btnDescontoPorGrupoSubGrupoProdutos_Click(object sender, EventArgs e)
        {
            Forms_ConfiguracaoGerencialDescontoGrupoSubGrupoProdutos configuracaoGerencialDescontoGrupoSubGrupoProdutos = new Forms_ConfiguracaoGerencialDescontoGrupoSubGrupoProdutos();
            configuracaoGerencialDescontoGrupoSubGrupoProdutos.ShowDialog();
        }

        private void btnDescontoPoPagamentoAvista_Click(object sender, EventArgs e)
        {
            Forms_ConfiguracaoGerencialDescontoPorPagamentoAvista configuracaoGerencialDescontoPorPagamentoAvista = new Forms_ConfiguracaoGerencialDescontoPorPagamentoAvista();
            configuracaoGerencialDescontoPorPagamentoAvista.ShowDialog();
        }

        private void btnComissaoPorProduto_Click(object sender, EventArgs e)
        {
            Forms_ConfiguracaoGerencialComissaoPorProduto gerencialComissãoPorProduto = new Forms_ConfiguracaoGerencialComissaoPorProduto();
            gerencialComissãoPorProduto.ShowDialog();
        }

        private void btnJurosPorPagamentoaCredito_Click(object sender, EventArgs e)
        {
            Forms_ConfiguracaoGerencialJurosPorPagamentoaCredito jurosPorPagamentoaCredito = new Forms_ConfiguracaoGerencialJurosPorPagamentoaCredito();
            jurosPorPagamentoaCredito.Show();
            jurosPorPagamentoaCredito.ShowDialog();
        }

        private void Forms_ConfiguracaoGerencial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
        }
    }
}