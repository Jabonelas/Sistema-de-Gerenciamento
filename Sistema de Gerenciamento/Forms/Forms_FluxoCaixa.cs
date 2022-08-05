﻿using Sistema_de_Gerenciamento.Classes;
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
    public partial class Forms_FluxoCaixa : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private List<DadosUsuario> listaUsuario = new List<DadosUsuario>();

        private decimal valorTotal;

        private decimal valorComissaoPorProduto;

        public Forms_FluxoCaixa()
        {
            InitializeComponent();

            PreencherDatePicker();

            PreencherComboBoxUsuario();

            FormatarGridView();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Buscar.BuscarDadosPreencherGridView(cmbUsuario.Text, dtpDataInicial.Value.AddMilliseconds(1), dtpDataFinal.Value.AddHours(23).AddMinutes(59).AddSeconds(59), gdvFluxoCaixa);

            BuscarValorTotal();

            CalcularComissaoGeral();

            CalcularComissaoPorProduto();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormatarGridView()
        {
            this.gdvFluxoCaixa.Columns["ns_valor_pago"].DefaultCellStyle.Format = "c";
        }

        private void PreencherComboBoxUsuario()
        {
            listaUsuario = Buscar.BuscaListaUsuario();

            foreach (var item in listaUsuario)
            {
                cmbUsuario.Items.Add(item.usuario);
            }
        }

        private void PreencherDatePicker()
        {
            DateTime data = DateTime.Today;

            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));

            dtpDataFinal.Text = ultimoDiaDoMes.ToString();

            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);

            dtpDataInicial.Text = primeiroDiaDoMes.ToString();
        }

        private void BuscarValorTotal()
        {
            valorTotal = Buscar.BuscarValorTotalFluxoCaixa(cmbUsuario.Text, dtpDataInicial.Value.AddMilliseconds(1), dtpDataFinal.Value.AddHours(23).AddMinutes(59).AddSeconds(59));

            lblValorTotal.Text = String.Format("{0:c}", valorTotal);
        }

        private void CalcularComissaoGeral()
        {
            decimal porcentagemComissaoGeral;

            porcentagemComissaoGeral = Buscar.BuscarPorcentagemComissao();

            lblComissao.Text = String.Format("{0:c}", (porcentagemComissaoGeral * valorTotal / 100));
        }

        private void CalcularComissaoPorProduto()
        {
            if (gdvFluxoCaixa.RowCount == 0)
            {
                lblComissaoPorProduto.Text = "R$ 0,00";
            }
            else
            {
                for (int i = 0; i < gdvFluxoCaixa.RowCount; i++)
                {
                    decimal porcentagemComissaoPorproduto;

                    decimal valorPagoProduto;

                    porcentagemComissaoPorproduto = Buscar.BuscarValorComissaoPorProduto(Convert.ToInt32(gdvFluxoCaixa.Rows[i].Cells[3].Value));

                    valorPagoProduto = Convert.ToDecimal(gdvFluxoCaixa.Rows[i].Cells[6].Value.ToString().Replace("R$", ""));

                    valorComissaoPorProduto += Convert.ToDecimal(porcentagemComissaoPorproduto * valorPagoProduto / 100);
                }

                lblComissaoPorProduto.Text = String.Format("{0:c}", valorComissaoPorProduto);
            }
        }

        private void Forms_FluxoCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}