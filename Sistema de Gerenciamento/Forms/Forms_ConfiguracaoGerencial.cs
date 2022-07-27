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
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private AtualizacaoNoBanco Atualizacao = new AtualizacaoNoBanco();

        public Forms_ConfiguracaoGerencial()
        {
            InitializeComponent();

            PreencherComboBoxGrupo();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarGrupo_Click(object sender, EventArgs e)
        {
            AtualizacaoPorcentagemDesconto();
        }

        #region Atualizacao Da Porgentadem De Desconto Por Grupo De Produto

        private void AtualizacaoPorcentagemDesconto()
        {
            if (cmbSub_GrupoProduto.Text != String.Empty && cmbGrupoProduto.Text != String.Empty && txtDescontoPorGrupo.Text != String.Empty)
            {
                Atualizacao.AtualizarDescontoPorGrupoDeProduto(cmbGrupoProduto.Text,
                    cmbSub_GrupoProduto.Text, Convert.ToDecimal(txtDescontoPorGrupo.Text.Replace("%", "")));

                cmbSub_GrupoProduto.Text = String.Empty;
                cmbGrupoProduto.Text = String.Empty;
                txtDescontoPorGrupo.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Por Favor Preencha Todos Campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmbGrupoProduto.Focus();
            }
        }

        #endregion Atualizacao Da Porgentadem De Desconto Por Grupo De Produto

        private void btnConfirmarAvista_Click(object sender, EventArgs e)
        {
            AtualizacaoPorcentagemAvista();
        }

        #region Atualizacao de Porcentagem do Desconto Avista

        private void AtualizacaoPorcentagemAvista()
        {
            if (txtDescontoAvista.Text != String.Empty)
            {
                Atualizacao.AtualizarPagamentoDescontoAvista(Convert.ToDecimal(txtDescontoAvista.Text.Replace("%", "")));

                txtDescontoAvista.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Por Favor Preencha Todos Campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtDescontoAvista.Focus();
            }
        }

        #endregion Atualizacao de Porcentagem do Desconto Avista

        private void btnConfirmarCarne_Click(object sender, EventArgs e)
        {
            AtualizacaoPorcentagemJurosCarne();
        }

        #region Atualizacao de Porcentagem do Juros Por Carne

        private void AtualizacaoPorcentagemJurosCarne()
        {
            if (txtPrazoCarne.Text != String.Empty && cmbParcelasCarne.Text != String.Empty && txtJurosCarneParcelas.Text != String.Empty)
            {
                Atualizacao.JurosPorCarne(Convert.ToInt32(txtPrazoCarne.Text), Convert.ToDecimal(txtJurosCarneParcelas.Text.Replace("%", "")),
                    Convert.ToInt32(cmbParcelasCarne.Text.Replace("x", "")), Convert.ToDecimal(txtJurosCarneAtrasoPagamento.Text.Replace("%", "")),
                    Convert.ToDecimal(txtMultaCarneAtrasoPagamento.Text.Replace("%", "")));

                txtPrazoCarne.Text = String.Empty;
                cmbParcelasCarne.Text = String.Empty;
                txtJurosCarneParcelas.Text = String.Empty;
                txtJurosCarneAtrasoPagamento.Text = String.Empty;
                txtMultaCarneAtrasoPagamento.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Por Favor Preencha Todos Campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmbParcelasCarne.Focus();
            }
        }

        #endregion Atualizacao de Porcentagem do Juros Por Carne

        private void btnConfirmarCredito_Click(object sender, EventArgs e)
        {
            AtualziacaoPorcentagemJurosCredito();
        }

        #region Atualizacao de Porcentagem do Juros Por Carne

        private void AtualziacaoPorcentagemJurosCredito()
        {
            if (txtJurosCredito.Text != String.Empty && cmbParcelasCredito.Text != String.Empty)
            {
                Atualizacao.JurosCredito(Convert.ToDecimal(txtJurosCredito.Text.Replace("%", "")),
                    Convert.ToInt32(cmbParcelasCredito.Text.Replace("x", "")));

                cmbParcelasCredito.Text = String.Empty;
                txtJurosCredito.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Por Favor Preencha Todos Campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmbParcelasCredito.Focus();
            }
        }

        #endregion Atualizacao de Porcentagem do Juros Por Carne

        private void btnConfirmarComissao_Click(object sender, EventArgs e)
        {
            AtualziacaoPorcentagemComissao();
        }

        private void AtualziacaoPorcentagemComissao()
        {
            if (txtComissao.Text != String.Empty)
            {
                Atualizacao.AtualizarComissao(Convert.ToDecimal(txtComissao.Text.Replace("%", "")));

                txtComissao.Text = String.Empty;
                ;
            }
            else
            {
                MessageBox.Show("Por Favor Preencha O Campo!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtComissao.Focus();
            }
        }

        private void cmbGrupoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherComboBoxSubGrupo();
        }

        #region Preencher ComboBox Grupo

        private void PreencherComboBoxGrupo()
        {
            List<DadosGrupoMaterial> listaGrupo = new List<DadosGrupoMaterial>();

            listaGrupo = Buscar.BuscarGrupoProduto();

            cmbGrupoProduto.Items.Clear();

            listaGrupo.ForEach(prod => cmbGrupoProduto.Items.Add(prod.grupo));

            cmbGrupoProduto.Items.Add(string.Empty);
        }

        #endregion Preencher ComboBox Grupo

        #region Preencher ComboBox Sub-Grupo

        private void PreencherComboBoxSubGrupo()
        {
            List<DadosSubGrupoMaterial> listaSubGrupo = new List<DadosSubGrupoMaterial>();

            listaSubGrupo = Buscar.BuscarSubGrupoProduto(cmbGrupoProduto.Text);

            cmbSub_GrupoProduto.Items.Clear();

            listaSubGrupo.ForEach(prod => cmbSub_GrupoProduto.Items.Add(prod.sub_grupo));

            cmbSub_GrupoProduto.Items.Add(string.Empty);
        }

        #endregion Preencher ComboBox Sub-Grupo

        private void cmbSub_GrupoProduto_Enter(object sender, EventArgs e)
        {
            VerificarPreenchimentoGrupo();
        }

        #region Verificar se o Campo de Grupo Foi Preenchido

        private void VerificarPreenchimentoGrupo()
        {
            if (cmbGrupoProduto.Text == String.Empty)
            {
                MessageBox.Show("Por Favor Preencha Primeiro O Campo Grupo Produto!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbGrupoProduto.Focus();
            }
        }

        #endregion Verificar se o Campo de Grupo Foi Preenchido

        private void txtPrazoCarne_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManipulacaoTextBox.DigitoFoiNumero(e);
        }

        private void txtJurosCarne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtJurosCarneParcelas.Text.Replace("%", ""), sender);
            }
        }

        private void txtJurosCredito_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtJurosCredito.Text.Replace("%", ""), sender);
            }
        }

        private void txtDescontoPorGrupo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtDescontoPorGrupo.Text.Replace("%", ""), sender);
            }
        }

        private void txtDescontoAvista_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtDescontoAvista.Text.Replace("%", ""), sender);
            }
        }

        private void txtComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtComissao.Text.Replace("%", ""), sender);
            }
        }

        private void txtJurosCarneAtrasoPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtJurosCarneAtrasoPagamento.Text.Replace("%", ""), sender);
            }
        }

        private void txtMultaCarneAtrasoPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtMultaCarneAtrasoPagamento.Text.Replace("%", ""), sender);
            }
        }
    }
}