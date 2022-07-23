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

        public List<DadosNotaFiscalSaida> listaDadosNotaFiscalSaidaCompleta = new List<DadosNotaFiscalSaida>();

        private List<DadosProduto> listaDadosEstoqueProduto = new List<DadosProduto>();

        private DadosProduto dadosEstoqueProduto;

        private DadosNotaFiscalSaida dadosNotaFiscalSaidaParcial;

        private int cont = 0;

        private decimal memoriaQuantidade = 0;

        private decimal memoriaValorPago = 0;

        private decimal memoriaValorProdTroca = 0;

        private decimal memoriaValorProdDevolucao = 0;

        public int quantidadeItens = 0;

        public Forms_Troca()
        {
            InitializeComponent();

            PreencherDados();
        }

        private void PreencherDados()
        {
            pcbImagemProduto.Image = Buscar.BuscarLogoEmpresa(1);

            listaDadosEstoqueProduto = Buscar.BuscarListaProdutos();
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
                    listaDadosNotaFiscalSaidaCompleta.Clear();

                    listaDadosNotaFiscalSaidaCompleta = Buscar.BuscarListaNotaFiscalSaidaCompleto(Convert.ToInt32(txtNotaFiscal.Text));

                    PreencherGridView();

                    quantidadeItens = gdvDevolucaoTroca.Rows.Count;

                    Buscar.BuscarListaNotaFiscalSaidaParcial(Convert.ToInt32(txtNotaFiscal.Text)).ForEach(nf => listaDadosNotaFiscalSaidaParcial.Add(nf));

                    txtVendedor.Text = listaDadosNotaFiscalSaidaParcial[0].vendedor;
                    txtValidadeTroca.Text = listaDadosNotaFiscalSaidaParcial[0].validadeTroca.ToShortDateString();
                    txtNomeCliente.Text = listaDadosNotaFiscalSaidaParcial[0].nomeCliente;

                    Buscar.BuscarListaNotaFiscalSaidaParcial(Convert.ToInt32(txtNotaFiscal.Text));

                    if (Convert.ToDateTime(txtValidadeTroca.Text) < DateTime.Today && cont == 0)
                    {
                        btnConfirmar.Enabled = false;

                        MessageBox.Show("Prazo Para Troca Já Excedido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
        }

        private void PreencherGridView()
        {
            gdvDevolucaoTroca.Rows.Clear();

            foreach (DadosNotaFiscalSaida item in listaDadosNotaFiscalSaidaCompleta)
            {
                var rows = new List<string[]>();
                string[] row1 = new string[] {item.codigoProduto.ToString(),item.descricao,item.quantidade.ToString("N0"),
                            string.Format("{0:C}", item.valorPago),item.status };

                gdvDevolucaoTroca.Rows.Add(row1);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                txtQuantidadeDevolucao.Enabled = false;
            }
            else if (Buscar.BuscarCodigoBarras(Convert.ToInt32(txtCodBarrasDevolucao.Text)) == true)
            {
                try
                {
                    //dadosNotaFiscalSaidaParcial = listaDadosNotaFiscalSaidaParcial.Find(prod => prod.codigoBarras.ToString().StartsWith(txtCodBarrasDevolucao.Text));

                    dadosNotaFiscalSaidaParcial = listaDadosNotaFiscalSaidaParcial.First(prod => prod.codigoBarras == Convert.ToInt32(txtCodBarrasDevolucao.Text) && prod.quantidade > 0);

                    if (dadosNotaFiscalSaidaParcial != null && cont == 0)
                    {
                        if (dadosNotaFiscalSaidaParcial.quantidade > 0)
                        {
                            memoriaValorPago = 0;

                            memoriaQuantidade = 0;

                            txtProdutoDevolucao.Text = dadosNotaFiscalSaidaParcial.descricao;

                            txtUnidadeDevolucao.Text = dadosNotaFiscalSaidaParcial.unidade;

                            txtQuantidadeDevolucao.Text = dadosNotaFiscalSaidaParcial.quantidade.ToString("N0");

                            txtCodProdutoDevolucao.Text = dadosNotaFiscalSaidaParcial.codigoProduto.ToString();

                            txtPrecoDevolucao.Text = string.Format("{0:C}", dadosNotaFiscalSaidaParcial.preco);

                            txtQuantidadeDevolucao.Enabled = true;

                            pcbImagemProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodProdutoDevolucao.Text));

                            cont++;
                        }
                        else
                        {
                            MessageBox.Show("Item sem Saldo para Realização de Troca!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        cont = 0;
                    }
                }
                catch (Exception)
                {
                    if (cont == 0)
                    {
                        MessageBox.Show($"Item Não Pertenciente a Nota Fiscal de Nº: {txtNotaFiscal.Text} ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtCodBarrasDevolucao.Text = string.Empty;

                        cont++;
                    }
                    else
                    {
                        cont = 0;
                    }
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
                    MessageBox.Show("A quantidade Solicitada É Maior Que A Quantidade Disponivel Em Nota", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                pcbImagemProduto.Image = Buscar.BuscarLogoEmpresa(1);
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
                    txtProdutoTroca.Text = dadosEstoqueProduto.descricaoProduto;
                    txtQuantidadeTroca.Text = "1,00";
                    txtUnidadeTroca.Text = dadosEstoqueProduto.unidade;

                    txtPrecoTroca.Text = string.Format("{0:C}", (dadosEstoqueProduto.preco - (dadosEstoqueProduto.desconto * dadosEstoqueProduto.preco / 100)));

                    txtQuantidadeTroca.Enabled = true;

                    pcbImagemProduto.Image = Buscar.BuscarImagemProduto(Convert.ToInt32(txtCodProdutoTroca.Text));

                    PreencherGridView();
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
                Forms_Pagamento pagamento = new Forms_Pagamento(this, "Troca");
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
            if (cmbMotivoTroca.Text != String.Empty && lblValorAPagar.ForeColor == Color.Green)
            {
                if (Convert.ToDecimal(lblValorAPagar.Text.Replace("R$ ", "")) >= 0)
                {
                    Forms_Pagamento pagamento = new Forms_Pagamento(this, "Troca");
                    pagamento.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Não É Possivel Realizar Devolução De Valores!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por Favos Preenchar Todos Os Campos!", "Atencção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            AdcionarTroca();
        }

        private void AdcionarTroca()
        {
            if (txtProdutoTroca.Text != String.Empty)
            {
                DadosNotaFiscalSaida atualizarDados;

                atualizarDados = listaDadosNotaFiscalSaidaCompleta.First(x => x.numeroNF.ToString().StartsWith(txtNotaFiscal.Text));

                AdicionarItensListaDadosNotaFiscalSaidaCompleta(atualizarDados, txtCodProdutoTroca.Text,
                       txtProdutoTroca.Text, txtCodBarrasTroca.Text, lblStatus.Text, Convert.ToDecimal(txtPrecoTroca.Text.Replace("R$", "")),
                        Convert.ToDecimal(txtQuantidadeTroca.Text), "Troca");

                PreencherGridView();

                memoriaValorProdTroca += Convert.ToDecimal(txtPrecoTroca.Text.Replace("R$", ""));

                lblValorProdTroca.Text = String.Format("{0:C}", memoriaValorProdTroca);

                CalcularValorAPagar();

                txtCodBarrasTroca.Text = string.Empty;
            }
        }

        private void txtNotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void btnAdcionarDevolucao_Click(object sender, EventArgs e)
        {
            AdicionarDevolucao();
        }

        private void AdicionarDevolucao()
        {
            if (txtCodProdutoDevolucao.Text != String.Empty)
            {
                DadosNotaFiscalSaida atualizarDados;

                //atualizarDados = listaDadosNotaFiscalSaidaCompleta.First(x => x.codigoBarras.ToString().StartsWith(txtCodBarrasDevolucao.Text));

                atualizarDados = listaDadosNotaFiscalSaidaCompleta.First(prod => prod.codigoBarras == Convert.ToInt32(txtCodBarrasDevolucao.Text) &&
                prod.quantidade > 0);

                if (memoriaQuantidade == Convert.ToDecimal(txtQuantidadeDevolucao.Text))
                {
                    AlterarItensListaDadosNotaFiscalSaidaCompleta(atualizarDados);
                }
                else
                {
                    AdicionarItensListaDadosNotaFiscalSaidaCompleta(atualizarDados, txtCodProdutoDevolucao.Text,
                        txtProdutoDevolucao.Text, txtCodBarrasDevolucao.Text, "Devolucao", -Convert.ToDecimal(txtPrecoDevolucao.Text.Replace("R$", "")),
                         -Convert.ToDecimal(txtQuantidadeDevolucao.Text), "Devolucao");
                }

                PreencherGridView();

                memoriaValorProdDevolucao += Convert.ToDecimal(txtPrecoDevolucao.Text.Replace("R$", ""));

                lblValorProdDevolvido.Text = String.Format("{0:C}", memoriaValorProdDevolucao);

                txtCodBarrasDevolucao.Text = String.Empty;

                CalcularValorAPagar();
            }
        }

        private void AlterarItensListaDadosNotaFiscalSaidaCompleta(DadosNotaFiscalSaida _atualizarDados)
        {
            _atualizarDados.status = "Devolucao";
            _atualizarDados.valorPago = -_atualizarDados.valorPago;
            _atualizarDados.quantidade = -_atualizarDados.quantidade;
            _atualizarDados.deveTrocar = true;
        }

        private void AdicionarItensListaDadosNotaFiscalSaidaCompleta(DadosNotaFiscalSaida _atualizarDados,
            string _codigoProduto, string _produto, string _codBarras, string _status,
            decimal _preco, decimal _quantidade, string _verificar)
        {
            if (_verificar == "Devolucao")
            {
                //Alteração da quantidade inicial na nota e seta pra quantidade que foi alterada
                //Pega o valor total e divide por quantidade total de items retornando o valor unidatio real
                _atualizarDados.valorPago = _atualizarDados.valorPago / _atualizarDados.quantidade;
                //Pega a quantidade total e subtrai a quantidade declarada na devolução e retorna apenas a quantidade real
                _atualizarDados.quantidade = _atualizarDados.quantidade - Convert.ToDecimal(txtQuantidadeDevolucao.Text);
                //Pega o valor unitario real e multiplica pela quantidade real e retorna a valor que devera ser pago
                _atualizarDados.valorPago = _atualizarDados.valorPago * _atualizarDados.quantidade;
                _atualizarDados.deveTrocar = true;
            }

            listaDadosNotaFiscalSaidaCompleta.Add(new DadosNotaFiscalSaida(
            _atualizarDados.id,
            _atualizarDados.numeroNF,
            _atualizarDados.cpf,
            _atualizarDados.nomeCliente,
            Convert.ToInt32(_codigoProduto),
            _produto,
            _atualizarDados.emissao,
            Convert.ToInt32(_codBarras),
            _atualizarDados.vendedor,
            _atualizarDados.validadeTroca,
            _atualizarDados.valorUnitario,
            _quantidade,
            _atualizarDados.unidade, "",
            0, 0, 0,
            _preco, _status, Global.NomeDeUsuario,
            "Motivo Troca", true, _atualizarDados.nfEntrada));
        }
    }
}