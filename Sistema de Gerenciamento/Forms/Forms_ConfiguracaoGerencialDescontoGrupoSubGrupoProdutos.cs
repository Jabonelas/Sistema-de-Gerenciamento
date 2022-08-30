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
    public partial class Forms_ConfiguracaoGerencialDescontoGrupoSubGrupoProdutos : Form
    {
        private AtualizacaoNoBanco Atualizacao = new AtualizacaoNoBanco();

        private BuscarNoBanco Buscar = new BuscarNoBanco();

        public Forms_ConfiguracaoGerencialDescontoGrupoSubGrupoProdutos()
        {
            InitializeComponent();

            PreencherComboBoxGrupo();
        }

        private void Forms_ConfiguracaoGerencialDescontoGrupoSubGrupoProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharTela.DesejaFecharTela(this, e);
            }
            else if (e.KeyCode == Keys.F10)
            {
                AtualizacaoPorcentagemDesconto();
            }
        }

        private void btnConfirmarGrupo_Click(object sender, EventArgs e)
        {
            AtualizacaoPorcentagemDesconto();
        }

        private void cmbGrupoProduto_SelectedValueChanged(object sender, EventArgs e)
        {
            PreencherComboBoxSubGrupo();
        }

        private void cmbSub_GrupoProduto_Enter(object sender, EventArgs e)
        {
            VerificarPreenchimentoGrupo();
        }

        private void txtDescontoPorGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ManipulacaoTextBox.DigitoFoiNumero(e) == true)
            {
                ManipulacaoTextBox.PreenchimentoPorcentagem(e, txtDescontoPorGrupo.Text.Replace("%", ""), sender);
            }
        }

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

        private void PreencherComboBoxGrupo()
        {
            List<DadosGrupoMaterial> listaGrupo = new List<DadosGrupoMaterial>();

            listaGrupo = Buscar.BuscarGrupoProduto();

            cmbGrupoProduto.Items.Clear();

            listaGrupo.ForEach(prod => cmbGrupoProduto.Items.Add(prod.grupo));

            cmbGrupoProduto.Items.Add(string.Empty);
        }

        private void PreencherComboBoxSubGrupo()
        {
            List<DadosSubGrupoMaterial> listaSubGrupo = new List<DadosSubGrupoMaterial>();

            listaSubGrupo = Buscar.BuscarSubGrupoProduto(cmbGrupoProduto.Text);

            cmbSub_GrupoProduto.Items.Clear();

            listaSubGrupo.ForEach(prod => cmbSub_GrupoProduto.Items.Add(prod.sub_grupo));

            cmbSub_GrupoProduto.Items.Add(string.Empty);
        }

        private void VerificarPreenchimentoGrupo()
        {
            if (cmbGrupoProduto.Text == String.Empty)
            {
                MessageBox.Show("Por Favor Preencha Primeiro O Campo Grupo Produto!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbGrupoProduto.Focus();
            }
        }
    }
}