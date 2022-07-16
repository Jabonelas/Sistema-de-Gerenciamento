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
    public partial class Forms_Troca : Form
    {
        private MensagensErro Erro = new MensagensErro();

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private List<DadosNotaFiscalSaida> listaDadosNotaFiscalSaidaParcial = new List<DadosNotaFiscalSaida>();

        internal List<DadosNotaFiscalSaida> listaDadosNotaFiscalSaidaCompleta = new List<DadosNotaFiscalSaida>();

        private List<DadosProduto> listaDadosEstoqueProduto = new List<DadosProduto>();

        private DadosProduto dadosEstoqueProduto;

        private DadosNotaFiscalSaida dadosNotaFiscalSaidaParcial;

        private DadosNotaFiscalSaida dadosNotaFiscalSaidaCompleta;

        private int cont = 0;

        private decimal memoriaQuantidade = 0;

        private decimal memoriaValorPago = 0;

        private decimal memoriaValorProdTroca = 0;

        private decimal memoriaValorProdDevolucao = 0;

        public int quantidadeItens = 0;

        //private List<DadosProduto> listaDadosProduto = new List<DadosProduto>();

        //private DadosProduto produto;

        public Forms_Troca()
        {
            InitializeComponent();

            pcbImagemProduto.Image = Buscar.BuscarLogoEmpresa(1);

            listaDadosEstoqueProduto = Buscar.BuscarListaProdutos();

            cmbTipo.SelectedIndex = 1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarDadosNotaFiscalSaida();
        }

        private void BuscarDadosNotaFiscalSaida()
        {
            try
            {
                if (txtNotaFiscal.Text != string.Empty && Buscar.BuscarVendaPorNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text)) == true)
                {
                    //Buscar.BuscarVendaPorNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text), gdvDevolucaoTroca);

                    //listaDadosNotaFiscalSaidaParcial = Buscar.BuscarListaNotaFiscalSaidaParcial(Convert.ToInt32(txtNotaFiscal.Text));

                    listaDadosNotaFiscalSaidaCompleta = Buscar.BuscarListaNotaFiscalSaidaCompleto(Convert.ToInt32(txtNotaFiscal.Text));

                    //listaDadosNotaFiscalSaidaCompleta.ForEach(x => dadosNotaFiscalSaidaCompleta = x);

                    //dadosNotaFiscalSaidaCompleta = listaDadosNotaFiscalSaidaCompleta.First(x => x.numeroNF.ToString().StartsWith(txtNotaFiscal.Text));

                    gdvDevolucaoTroca.Rows.Clear();

                    foreach (DadosNotaFiscalSaida item in listaDadosNotaFiscalSaidaCompleta)
                    {
                        var rows = new List<string[]>();
                        string[] row1 = new string[] {item.codigoProduto.ToString(),item.descricao,item.quantidade.ToString("N0"),
                            string.Format("{0:C}", item.valorPago),item.status };
                        //rows.Add(row1);

                        gdvDevolucaoTroca.Rows.Add(row1);

                        //foreach (string[] items in rows)
                        //{
                        //    gdvDevolucaoTroca.Rows.Add(items);
                        //}

                        quantidadeItens++;
                    }

                    //PreenchendoGridView();

                    Buscar.BuscarListaNotaFiscalSaidaParcial(Convert.ToInt32(txtNotaFiscal.Text)).ForEach(nf => listaDadosNotaFiscalSaidaParcial.Add(nf));

                    txtVendedor.Text = listaDadosNotaFiscalSaidaParcial[0].vendedor;
                    txtValidadeTroca.Text = listaDadosNotaFiscalSaidaParcial[0].validadeTroca.ToShortDateString();
                    txtNomeCliente.Text = listaDadosNotaFiscalSaidaParcial[0].nomeCliente;

                    Buscar.BuscarListaNotaFiscalSaidaParcial(Convert.ToInt32(txtNotaFiscal.Text));

                    if (Convert.ToDateTime(txtValidadeTroca.Text) < DateTime.Today && cont == 0)
                    {
                        btnConfirmar.Enabled = false;

                        MessageBox.Show("Prazo para Troca já Excedido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        cont++;
                    }
                    else
                    {
                        btnConfirmar.Enabled = true;

                        cont = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarNotaFiscalSaida(ex);
            }

            ///////////////////////////////////////////////////////////////////////////////////////

            //try
            //{
            //    if (txtNotaFiscal.Text != string.Empty && Buscar.BuscarVendaPorNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text), gdvDevolucaoTroca) == true)
            //    {
            //        //Buscar.BuscarVendaPorNotaFiscalSaida(Convert.ToInt32(txtNotaFiscal.Text), gdvDevolucaoTroca);

            //        listaDadosNotaFiscalSaidaParcial = Buscar.BuscarListaNotaFiscalSaidaParcial(Convert.ToInt32(txtNotaFiscal.Text));

            //        SetarDesignColunaGridView();

            //        Buscar.BuscarListaNotaFiscalSaidaParcial(Convert.ToInt32(txtNotaFiscal.Text)).ForEach(nf => listaDadosNotaFiscalSaidaParcial.Add(nf));

            //        txtVendedor.Text = listaDadosNotaFiscalSaidaParcial[0].vendedor;
            //        txtValidadeTroca.Text = listaDadosNotaFiscalSaidaParcial[0].validadeTroca.ToShortDateString();
            //        txtNomeCliente.Text = listaDadosNotaFiscalSaidaParcial[0].nomeCliente;

            //        Buscar.BuscarListaNotaFiscalSaidaParcial(Convert.ToInt32(txtNotaFiscal.Text));

            //        if (Convert.ToDateTime(txtValidadeTroca.Text) < DateTime.Today && cont == 0)
            //        {
            //            btnConfirmar.Enabled = false;

            //            MessageBox.Show("Prazo para Troca já Excedido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //            cont++;
            //        }
            //        else
            //        {
            //            btnConfirmar.Enabled = true;

            //            cont = 0;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Erro.ErroAoBuscarNotaFiscalSaida(ex);
            //}
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            LayoutConformeNaturezaDaOperacao(cmbTipo.Text);
        }

        private void LayoutConformeNaturezaDaOperacao(string _operacao)
        {
            //bool retorno = _operacao == "DEVOLUÇÃO" ? true : false;

            //lblTroca.Visible = !retorno;
            //lblQuant.Visible = !retorno;
            //lblProduto.Visible = !retorno;
            //lblPreco.Visible = !retorno;
            //lblCodBarras.Visible = !retorno;
            //lblCodigoProduto.Visible = !retorno;
            //lblUnidade.Visible = !retorno;
            //txtCodBarrasTroca.Visible = !retorno;
            //txtCodProdutoTroca.Visible = !retorno;
            //txtProdutoTroca.Visible = !retorno;
            //txtQuantidadeTroca.Visible = !retorno;
            //txtUnidadeTroca.Visible = !retorno;
            //txtPrecoTroca.Visible = !retorno;
            //pnlValorPrudutoTroca.Visible = !retorno;
            //btnBuscarCodigoProduto.Visible = !retorno;

            //if (retorno == true)
            //{
            //    pnlValorProdutoDevolvido.Location = new Point(184, 489);
            //    pnlValorAPagar.Location = new Point(487, 489);
            //    btnFechar.Location = new Point(518, 630);
            //    btnConfirmar.Location = new Point(215, 630);
            //    this.Size = new Size(892, 735);
            //}
            //else
            //{
            //    pnlValorProdutoDevolvido.Location = new Point(12, 542);
            //    pnlValorAPagar.Location = new Point(626, 542);
            //    btnFechar.Location = new Point(538, 683);
            //    btnConfirmar.Location = new Point(150, 683);
            //    this.Size = new Size(892, 773);
            //}
        }

        private void txtCodBarrasDevolucao_TextChange(object sender, EventArgs e)
        {
            if (txtCodBarrasDevolucao.Text == string.Empty)
            {
                txtProdutoDevolucao.Text = string.Empty;

                txtUnidadeDevolucao.Text = string.Empty;

                txtQuantidadeDevolucao.Text = string.Empty;

                txtCodProdutoDevolucao.Text = string.Empty;

                txtPrecoDevolucao.Text = string.Empty;

                pcbImagemProduto.Image = Buscar.BuscarLogoEmpresa(1);

                //lblValorProdDevolvido.Text = "R$ 0,00";

                //txtQuantidadeDevolucao.ReadOnly = true;

                txtQuantidadeDevolucao.Enabled = false;
            }
            else if (Buscar.BuscarCodigoBarras(Convert.ToInt32(txtCodBarrasDevolucao.Text)) == true)
            {
                try
                {
                    DadosNotaFiscalSaida veriricacaoExistenciaNaFota;

                    veriricacaoExistenciaNaFota = listaDadosNotaFiscalSaidaParcial.First(item => item.codigoBarras == Convert.ToInt32(txtCodBarrasDevolucao.Text));

                    if (veriricacaoExistenciaNaFota != null && cont == 1)
                    {
                        memoriaValorPago = 0;

                        memoriaQuantidade = 0;

                        dadosNotaFiscalSaidaParcial = listaDadosNotaFiscalSaidaParcial.Find(prod => prod.codigoBarras.ToString().StartsWith(txtCodBarrasDevolucao.Text));

                        txtProdutoDevolucao.Text = dadosNotaFiscalSaidaParcial.descricao;

                        txtUnidadeDevolucao.Text = dadosNotaFiscalSaidaParcial.unidade;

                        txtQuantidadeDevolucao.Text = dadosNotaFiscalSaidaParcial.quantidade.ToString("N0");

                        txtCodProdutoDevolucao.Text = dadosNotaFiscalSaidaParcial.codigoProduto.ToString();

                        txtPrecoDevolucao.Text = string.Format("{0:C}", dadosNotaFiscalSaidaParcial.preco);

                        //txtQuantidadeDevolucao.ReadOnly = false;

                        txtQuantidadeDevolucao.Enabled = true;

                        pcbImagemProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodProdutoDevolucao.Text));

                        cont = 0;
                        return;
                    }
                    cont++;
                }
                catch (Exception)
                {
                    if (cont == 1)
                    {
                        MessageBox.Show($"Item Não Pertenciente a Nota Fiscal de Nº: {txtNotaFiscal.Text} ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtCodBarrasDevolucao.Text = string.Empty;

                        cont = 0;
                        return;
                    }
                    cont++;
                }
            }
        }

        private void txtQuantidadeDevolucao_TextChange(object sender, EventArgs e)
        {
            memoriaQuantidade = dadosNotaFiscalSaidaParcial.quantidade;

            memoriaValorPago = dadosNotaFiscalSaidaParcial.preco / memoriaQuantidade;

            try
            {
                if (Convert.ToDecimal(txtQuantidadeDevolucao.Text) <= memoriaQuantidade && cont == 0)
                {
                    txtPrecoDevolucao.Text = String.Format("{0:C}", (Convert.ToDecimal(txtQuantidadeDevolucao.Text) *
                        memoriaValorPago));

                    cont++;
                }
                else if (Convert.ToDecimal(txtQuantidadeDevolucao.Text) > memoriaQuantidade && cont == 0)
                {
                    MessageBox.Show("A quantidade informada é maior que a quantidade disponivel", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    cont++;
                }
                else if (cont != 0)
                {
                    cont = 0;
                }
            }
            catch (Exception)
            {
            }
        }

        private void txtQuantidadeDevolucao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtCodBarrasDevolucao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtQuantidadeDevolucao_Enter(object sender, EventArgs e)
        {
            txtQuantidadeDevolucao.Text = string.Empty;
        }

        private void txtPrecoDevolucao_TextChange(object sender, EventArgs e)
        {
            //lblValorProdDevolvido.Text = txtPrecoDevolucao.Text;

            //if (cmbTipo.Text == "DEVOLUÇÃO")
            //{
            //    lblValorAPagar.Text = lblValorProdDevolvido.Text;
            //    lblValorAPagar.ForeColor = Color.Red;
            //}
        }

        private void txtCodBarrasTroca_TextChange(object sender, EventArgs e)
        {
            if (txtCodBarrasTroca.Text == string.Empty)
            {
                txtCodProdutoTroca.Text = string.Empty;
                txtProdutoTroca.Text = string.Empty;
                txtQuantidadeTroca.Text = string.Empty;
                txtUnidadeTroca.Text = string.Empty;
                txtPrecoTroca.Text = string.Empty;
                lblValorProdTroca.Text = "R$ 0,00";
            }
            else if (Buscar.BuscarCodigoBarras(Convert.ToInt32(txtCodBarrasTroca.Text)) == true)
            {
                dadosEstoqueProduto = listaDadosEstoqueProduto.Find(prod => prod.codigoBarras.ToString().StartsWith(txtCodBarrasTroca.Text));

                if (dadosEstoqueProduto.codigoProduto.ToString() == txtCodProdutoDevolucao.Text)
                {
                    txtCodProdutoTroca.Text = dadosEstoqueProduto.codigoProduto.ToString();
                    txtProdutoTroca.Text = dadosEstoqueProduto.descricaoProduto;
                    txtQuantidadeTroca.Text = "1";
                    txtUnidadeTroca.Text = dadosEstoqueProduto.unidade;

                    txtPrecoTroca.Text = String.Format("{0:C}", (Convert.ToDecimal(txtPrecoDevolucao.Text.Replace("R$", "")) / Convert.ToDecimal(txtQuantidadeDevolucao.Text)));

                    txtQuantidadeTroca.Enabled = true;

                    pcbImagemProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodBarrasTroca.Text));
                }
                else
                {
                    txtCodProdutoTroca.Text = dadosEstoqueProduto.codigoProduto.ToString();
                    txtProdutoTroca.Text = dadosEstoqueProduto.descricaoProduto;
                    txtQuantidadeTroca.Text = "1";
                    txtUnidadeTroca.Text = dadosEstoqueProduto.unidade;

                    txtPrecoTroca.Text = string.Format("{0:C}", (dadosEstoqueProduto.preco - (dadosEstoqueProduto.desconto * dadosEstoqueProduto.preco / 100)));

                    txtQuantidadeTroca.Enabled = true;

                    pcbImagemProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodBarrasTroca.Text));
                }
            }
        }

        private void btnBuscarCodigoProduto_Click(object sender, EventArgs e)
        {
            Forms_PesquisarProduto pesquisarProduto = new Forms_PesquisarProduto(this, "Tela Devolucao/Troca");
            pesquisarProduto.ShowDialog();
        }

        private void txtCodProdutoTroca_TextChange(object sender, EventArgs e)
        {
            if (txtCodProdutoTroca.Text == string.Empty)
            {
                txtCodBarrasTroca.Text = string.Empty;
                txtProdutoTroca.Text = string.Empty;
                txtQuantidadeTroca.Text = string.Empty;
                txtUnidadeTroca.Text = string.Empty;
                txtPrecoTroca.Text = string.Empty;
            }
            else if (Buscar.BuscarCodigoBarras(Convert.ToInt32(txtCodProdutoTroca.Text)) == true)
            {
                dadosEstoqueProduto = listaDadosEstoqueProduto.Find(prod => prod.codigoProduto.ToString().StartsWith(txtCodProdutoTroca.Text));

                if (dadosEstoqueProduto.codigoProduto.ToString() == txtCodProdutoDevolucao.Text)
                {
                    txtCodBarrasTroca.Text = dadosEstoqueProduto.codigoBarras.ToString();
                    //txtCodProdutoTroca.Text = dadosEstoqueProduto.codigoProduto.ToString();
                    txtProdutoTroca.Text = dadosEstoqueProduto.descricaoProduto;
                    txtQuantidadeTroca.Text = "1,00";
                    txtUnidadeTroca.Text = dadosEstoqueProduto.unidade;

                    txtPrecoTroca.Text = String.Format("{0:C}", (Convert.ToDecimal(txtPrecoDevolucao.Text.Replace("R$", "")) / Convert.ToDecimal(txtQuantidadeDevolucao.Text)));

                    txtQuantidadeTroca.Enabled = true;

                    pcbImagemProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodProdutoTroca.Text));
                }
                else
                {
                    txtCodBarrasTroca.Text = dadosEstoqueProduto.codigoBarras.ToString();
                    //txtCodProdutoTroca.Text = dadosEstoqueProduto.codigoProduto.ToString();
                    txtProdutoTroca.Text = dadosEstoqueProduto.descricaoProduto;
                    txtQuantidadeTroca.Text = "1,00";
                    txtUnidadeTroca.Text = dadosEstoqueProduto.unidade;

                    txtPrecoTroca.Text = string.Format("{0:C}", (dadosEstoqueProduto.preco - (dadosEstoqueProduto.desconto * dadosEstoqueProduto.preco / 100)));

                    txtQuantidadeTroca.Enabled = true;

                    pcbImagemProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodProdutoTroca.Text));

                    //listaDadosNotaFiscalSaidaCompleta.Clear();

                    //listaDadosNotaFiscalSaidaCompleta = Buscar.BuscarListaNotaFiscalSaidaCompleto(Convert.ToInt32(txtNotaFiscal.Text));

                    //////////////////////////////////////////////////////////////////////

                    //listaDadosNotaFiscalSaidaCompleta.ForEach(x => dadosNotaFiscalSaidaCompleta = x);

                    //dadosNotaFiscalSaidaCompleta = listaDadosNotaFiscalSaidaCompleta.First(x => x.numeroNF.ToString().StartsWith(txtNotaFiscal.Text));

                    gdvDevolucaoTroca.Rows.Clear();

                    foreach (DadosNotaFiscalSaida item in listaDadosNotaFiscalSaidaCompleta)
                    {
                        var rows = new List<string[]>();
                        string[] row1 = new string[] {item.codigoProduto.ToString(),item.descricao,item.quantidade.ToString(),
                            item.valorPago.ToString(),item.status };
                        //rows.Add(row1);

                        gdvDevolucaoTroca.Rows.Add(row1);

                        //foreach (string[] items in rows)
                        //{
                        //    gdvDevolucaoTroca.Rows.Add(items);
                        //}
                    }

                    //listaDadosNotaFiscalSaidaCompleta.Add(dadosNotaFiscalSaidaCompleta.id, dadosNotaFiscalSaidaCompleta.numeroNF,
                    //    dadosNotaFiscalSaidaCompleta.cpf, dadosNotaFiscalSaidaCompleta.nomeCliente, txtCodProdutoTroca.Text,
                    //    txtProdutoTroca.Text, dadosNotaFiscalSaidaCompleta.emissao, txtCodBarrasTroca.Text,
                    //    dadosNotaFiscalSaidaCompleta.vendedor, dadosNotaFiscalSaidaCompleta.validadeTroca,
                    //    dadosEstoqueProduto.preco, txtQuantidadeTroca, dadosEstoqueProduto.unidade, "",
                    //    0, 0, 0, 0, lblStatus.Text, Global.NomeDeUsuario);

                    //      listaDadosNotaFiscalSaidaCompleta.Add(dadosNotaFiscalSaidaCompleta.id, dadosNotaFiscalSaidaCompleta.numeroNF,
                    //dadosNotaFiscalSaidaCompleta.cpf, dadosNotaFiscalSaidaCompleta.nomeCliente, txtCodProdutoTroca.Text,
                    //txtProdutoTroca.Text, dadosNotaFiscalSaidaCompleta.emissao, txtCodBarrasTroca.Text,
                    //dadosNotaFiscalSaidaCompleta.vendedor, dadosNotaFiscalSaidaCompleta.validadeTroca,
                    //dadosEstoqueProduto.preco, txtQuantidadeTroca, dadosEstoqueProduto.unidade, "tipo pagamento",
                    //"quantidade parcelas", "valor desconto",
                    //"valor juros", "valor pago", lblStatus.Text, Global.NomeDeUsuario);
                }
            }
        }

        private void txtCodProdutoTroca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtCodBarrasTroca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void Forms_DevolucaoTroca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Finalziar tela Esc
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F10) // Confirmar F10
            {
                Forms_Pagamento pagamento = new Forms_Pagamento(Convert.ToDecimal(lblValorAPagar.Text.Replace("R$", "")), Convert.ToInt32(txtNotaFiscal.Text),
                    listaDadosNotaFiscalSaidaCompleta, quantidadeItens, this);
                pagamento.ShowDialog();
            }
        }

        private void CalcularValorAPagar()
        {
            if (txtPrecoTroca.Text != string.Empty)
            {
                lblValorProdTroca.Text = string.Format("{0:C}", memoriaValorProdTroca);

                lblValorAPagar.Text = String.Format("{0:C}", (Convert.ToDecimal(memoriaValorProdTroca) -
                        Convert.ToDecimal(lblValorProdDevolvido.Text.Replace("R$ ", ""))));

                if (Convert.ToDecimal(lblValorAPagar.Text.Replace("R$ ", "")) < 0)
                {
                    lblTituloValorAPagar.Text = "Valor a Pagar";

                    lblValorAPagar.ForeColor = Color.Red;
                }
                else
                {
                    lblTituloValorAPagar.Text = "Valor a Receber";

                    lblValorAPagar.ForeColor = Color.Green;
                }
            }
        }

        private void txtQuantidadeDevolucao_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantidadeDevolucao.Text == string.Empty || Convert.ToDecimal(txtQuantidadeDevolucao.Text) > memoriaQuantidade)
                {
                    txtQuantidadeDevolucao.Focus();
                }
            }
            catch (Exception)
            {
            }
        }

        private void txtQuantidadeTroca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ManipulacaoTextBox.TextBoxEstaVazio(this) == false && lblValorAPagar.ForeColor == Color.Green)
            {
                if (Convert.ToDecimal(lblValorAPagar.Text.Replace("R$ ", "")) >= 0)
                {
                    Forms_Pagamento pagamento = new Forms_Pagamento(Convert.ToDecimal(lblValorAPagar.Text.Replace("R$ ", "")), Convert.ToInt32(txtNotaFiscal.Text),
                        listaDadosNotaFiscalSaidaCompleta, quantidadeItens, this);
                    pagamento.ShowDialog();

                    //Forms_Pagamento pagamento = new Forms_Pagamento(Convert.ToDecimal(lblValorAPagar.Text.Replace("R$ ", "")), listaDadosEstoqueProduto);
                    //pagamento.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Não é possivel realizar devolução de Valores!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtQuantidadeTroca_Enter(object sender, EventArgs e)
        {
            txtQuantidadeTroca.Text = string.Empty;
        }

        private void txtQuantidadeTroca_Leave(object sender, EventArgs e)
        {
            if (txtQuantidadeTroca.Text == string.Empty)
            {
                txtQuantidadeTroca.Focus();
            }
        }

        private void txtQuantidadeTroca_TextChange(object sender, EventArgs e)
        {
            if (txtQuantidadeTroca.Text != string.Empty)
            {
                txtPrecoTroca.Text = String.Format("{0:C}", (Convert.ToDecimal(txtQuantidadeTroca.Text) * dadosEstoqueProduto.preco));
            }
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            //AdiconarItensNoGridView();

            //listaDadosNotaFiscalSaidaCompleta = Buscar.BuscarListaNotaFiscalSaidaCompleto(Convert.ToInt32(txtNotaFiscal.Text));

            dadosNotaFiscalSaidaCompleta = listaDadosNotaFiscalSaidaCompleta.First(x => x.numeroNF.ToString().StartsWith(txtNotaFiscal.Text));

            listaDadosNotaFiscalSaidaCompleta.Add(new DadosNotaFiscalSaida(
            dadosNotaFiscalSaidaCompleta.id,
                dadosNotaFiscalSaidaCompleta.numeroNF,
                dadosNotaFiscalSaidaCompleta.cpf,
                dadosNotaFiscalSaidaCompleta.nomeCliente,
                Convert.ToInt32(txtCodProdutoTroca.Text),
                txtProdutoTroca.Text,
                dadosNotaFiscalSaidaCompleta.emissao,
                Convert.ToInt32(txtCodBarrasTroca.Text),
                dadosNotaFiscalSaidaCompleta.vendedor,
                dadosNotaFiscalSaidaCompleta.validadeTroca,
                dadosEstoqueProduto.preco,
                Convert.ToDecimal(txtQuantidadeTroca.Text),
                dadosEstoqueProduto.unidade, "",
                0, 0, 0, Convert.ToDecimal(txtPrecoTroca.Text.Replace("R$", "")), lblStatus.Text, ""));

            gdvDevolucaoTroca.Rows.Clear();

            //if (memoriaQuantidade == Convert.ToDecimal(txtQuantidadeDevolucao.Text))
            //{
            //    DadosNotaFiscalSaida mudancaStatus;
            //    mudancaStatus = listaDadosNotaFiscalSaidaCompleta.First(x => x.codigoBarras.ToString().StartsWith(txtCodBarrasDevolucao.Text));
            //    mudancaStatus.status = "Devolucao";
            //}
            //else
            //{
            //    //pega a quantidade inicial na nota e seta pra quantidade que foi alterada
            //    DadosNotaFiscalSaida atualizarDados;

            //    //quantidadeProdutoNaNotaFiscalSaida = dadosNotaFiscalSaidaCompleta = listaDadosNotaFiscalSaidaCompleta.First(x => x.numeroNF.ToString().StartsWith(txtNotaFiscal.Text));
            //    atualizarDados = dadosNotaFiscalSaidaCompleta = listaDadosNotaFiscalSaidaCompleta.First(x => x.numeroNF.ToString().StartsWith(txtCodBarrasDevolucao.Text));
            //    atualizarDados.valorPago = atualizarDados.valorPago / atualizarDados.quantidade;
            //    atualizarDados.quantidade = atualizarDados.quantidade - Convert.ToDecimal(txtQuantidadeDevolucao.Text);
            //    atualizarDados.valorPago = atualizarDados.valorPago * atualizarDados.quantidade;

            //    listaDadosNotaFiscalSaidaCompleta.Add(new DadosNotaFiscalSaida(
            //    dadosNotaFiscalSaidaCompleta.id,
            //    dadosNotaFiscalSaidaCompleta.numeroNF,
            //    dadosNotaFiscalSaidaCompleta.cpf,
            //    dadosNotaFiscalSaidaCompleta.nomeCliente,
            //    Convert.ToInt32(txtCodProdutoDevolucao.Text),
            //    txtProdutoDevolucao.Text,
            //    dadosNotaFiscalSaidaCompleta.emissao,
            //    Convert.ToInt32(txtCodBarrasDevolucao.Text),
            //    dadosNotaFiscalSaidaCompleta.vendedor,
            //    dadosNotaFiscalSaidaCompleta.validadeTroca,
            //    dadosEstoqueProduto.preco,
            //    Convert.ToDecimal(txtQuantidadeDevolucao.Text),
            //    dadosEstoqueProduto.unidade, "",
            //    0, 0, 0, Convert.ToDecimal(txtPrecoDevolucao.Text.Replace("R$", "")), "Devolucao", ""));
            //}

            foreach (DadosNotaFiscalSaida item in listaDadosNotaFiscalSaidaCompleta)
            {
                var rows = new List<string[]>();
                string[] row1 = new string[] {item.codigoProduto.ToString(),item.descricao,item.quantidade.ToString("N0"),
                            string.Format("{0:C}",item.valorPago),item.status };

                gdvDevolucaoTroca.Rows.Add(row1);
            }

            memoriaValorProdTroca += Convert.ToDecimal(txtPrecoTroca.Text.Replace("R$", ""));

            lblValorProdTroca.Text = String.Format("{0:C}", memoriaValorProdTroca);

            CalcularValorAPagar();

            //dadosNotaFiscalSaidaCompleta = listaDadosNotaFiscalSaidaCompleta.First(x => x.numeroNF.ToString().StartsWith(txtNotaFiscal.Text));

            //listaDadosNotaFiscalSaidaCompleta.Add(dadosNotaFiscalSaidaCompleta.id, dadosNotaFiscalSaidaCompleta.numeroNF,
            //    dadosNotaFiscalSaidaCompleta.cpf, dadosNotaFiscalSaidaCompleta.nomeCliente,txtCodProdutoTroca.Text,
            //    txtProdutoTroca.Text, dadosNotaFiscalSaidaCompleta.emissao, txtCodBarrasTroca.Text,
            //    dadosNotaFiscalSaidaCompleta.vendedor, dadosNotaFiscalSaidaCompleta.validadeTroca,
            //    "valor unitario", txtQuantidadeTroca,"unidade", "tipo pagamento" , "quantidade parcelas", "valor desconto",
            //    "valor juros", "valor pago", "status", lblStatus.Text);
        }

        private void AdiconarItensNoGridView()
        {
            var rows = new List<string[]>();
            string[] row1 = new string[] { txtCodProdutoTroca.Text, txtProdutoTroca.Text, txtQuantidadeTroca.Text,
                txtPrecoTroca.Text, lblStatus.Text};
            rows.Add(row1);

            foreach (string[] item in rows)
            {
                //int contadoLinha = gdvDevolucaoTroca.RowCount;

                int indexlinha;

                gdvDevolucaoTroca.Rows.Add(item);

                gdvDevolucaoTroca.Rows.Add(gdvDevolucaoTroca.Rows[1].Cells["ns_status"].Value = "Devolucao");

                //gdvDevolucaoTroca.Rows.Add(gdvDevolucaoTroca.Rows[1].Cells["ns_codigo_produto"].Value = 1);

                //gdvDevolucaoTroca.Rows[contadoLinha + 1].Cells["ns_codigo_produto"].Value = 1;

                //gdvDevolucaoTroca.Rows[1].Cells["Código"].Value = "casas";
            }
        }

        private void txtNotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void btnAdcionarDevolucao_Click(object sender, EventArgs e)
        {
            gdvDevolucaoTroca.Rows.Clear();

            //dadosNotaFiscalSaidaCompleta = listaDadosNotaFiscalSaidaCompleta.First(x => x.numeroNF.ToString().StartsWith(txtNotaFiscal.Text));

            if (memoriaQuantidade == Convert.ToDecimal(txtQuantidadeDevolucao.Text))
            {
                DadosNotaFiscalSaida mudancaStatus;
                mudancaStatus = listaDadosNotaFiscalSaidaCompleta.First(x => x.codigoBarras.ToString().StartsWith(txtCodBarrasDevolucao.Text));
                mudancaStatus.status = "Devolucao";
                mudancaStatus.valorPago = mudancaStatus.valorPago;
            }
            else
            {
                //pega a quantidade inicial na nota e seta pra quantidade que foi alterada

                DadosNotaFiscalSaida atualizarDados;

                //quantidadeProdutoNaNotaFiscalSaida = dadosNotaFiscalSaidaCompleta = listaDadosNotaFiscalSaidaCompleta.First(x => x.numeroNF.ToString().StartsWith(txtNotaFiscal.Text));
                atualizarDados = listaDadosNotaFiscalSaidaCompleta.First(x => x.codigoBarras.ToString().StartsWith(txtCodBarrasDevolucao.Text));
                atualizarDados.valorPago = atualizarDados.valorPago / atualizarDados.quantidade;
                atualizarDados.quantidade = atualizarDados.quantidade - Convert.ToDecimal(txtQuantidadeDevolucao.Text);
                atualizarDados.valorPago = atualizarDados.valorPago * atualizarDados.quantidade;

                listaDadosNotaFiscalSaidaCompleta.Add(new DadosNotaFiscalSaida(
                atualizarDados.id,
                atualizarDados.numeroNF,
                atualizarDados.cpf,
                atualizarDados.nomeCliente,
                Convert.ToInt32(txtCodProdutoDevolucao.Text),
                txtProdutoDevolucao.Text,
                atualizarDados.emissao,
                Convert.ToInt32(txtCodBarrasDevolucao.Text),
                atualizarDados.vendedor,
                atualizarDados.validadeTroca,
                atualizarDados.valorUnitario,
                Convert.ToDecimal(txtQuantidadeDevolucao.Text),
                atualizarDados.unidade, "",
                0, 0, 0, Convert.ToDecimal(txtPrecoDevolucao.Text.Replace("R$", "")), "Devolucao", ""));

                // listaDadosNotaFiscalSaidaCompleta.Add(new DadosNotaFiscalSaida(
                //atualizarDados.id,
                //atualizarDados.numeroNF,
                //atualizarDados.cpf,
                //atualizarDados.nomeCliente,
                //Convert.ToInt32(txtCodProdutoDevolucao.Text),
                //txtProdutoDevolucao.Text,
                //atualizarDados.emissao,
                //Convert.ToInt32(txtCodBarrasDevolucao.Text),
                //atualizarDados.vendedor,
                //atualizarDados.validadeTroca,
                //atualizarDados.preco,
                //Convert.ToDecimal(txtQuantidadeDevolucao.Text),
                //atualizarDados.unidade, "",
                //0, 0, 0, Convert.ToDecimal(txtPrecoDevolucao.Text.Replace("R$", "")), "Devolucao", ""));

                ///////////////////////////////////////////////////////////////////
                //listaDadosNotaFiscalSaidaCompleta.Add(new DadosNotaFiscalSaida(
                //dadosNotaFiscalSaidaCompleta.id,
                //dadosNotaFiscalSaidaCompleta.numeroNF,
                //dadosNotaFiscalSaidaCompleta.cpf,
                //dadosNotaFiscalSaidaCompleta.nomeCliente,
                //Convert.ToInt32(txtCodProdutoDevolucao.Text),
                //txtProdutoDevolucao.Text,
                //dadosNotaFiscalSaidaCompleta.emissao,
                //Convert.ToInt32(txtCodBarrasDevolucao.Text),
                //dadosNotaFiscalSaidaCompleta.vendedor,
                //dadosNotaFiscalSaidaCompleta.validadeTroca,
                //dadosNotaFiscalSaidaCompleta.preco,
                //Convert.ToDecimal(txtQuantidadeDevolucao.Text),
                //dadosNotaFiscalSaidaCompleta.unidade, "",
                //0, 0, 0, Convert.ToDecimal(txtPrecoDevolucao.Text.Replace("R$", "")), "Devolucao", ""));
            }

            foreach (DadosNotaFiscalSaida item in listaDadosNotaFiscalSaidaCompleta)
            {
                var rows = new List<string[]>();
                string[] row1 = new string[] {item.codigoProduto.ToString(),item.descricao,item.quantidade.ToString("N0"),
                            string.Format("{0:C}",item.valorPago),item.status };

                gdvDevolucaoTroca.Rows.Add(row1);
            }

            memoriaValorProdDevolucao += Convert.ToDecimal(txtPrecoDevolucao.Text.Replace("R$", ""));

            lblValorProdDevolvido.Text = String.Format("{0:C}", memoriaValorProdDevolucao);

            CalcularValorAPagar();
        }
    }
}