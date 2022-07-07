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
    public partial class Forms_ControleADMIN : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        private Forms_PDV telaPDV;

        private Forms_CadastroCliente cadastroCliente;

        private string tipo = "";

        public Forms_ControleADMIN(Forms_PDV _telaPDV, string _tipo)
        {
            InitializeComponent();

            telaPDV = _telaPDV;

            tipo = _tipo;

            pcbEmpresa.Image = Buscar.BuscarLogoEmpresa(Convert.ToInt32(lblce_id.Text));
        }

        public Forms_ControleADMIN()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tipo == "Remover Produto")
            {
                if (txtUsuario.Text == "ADMIN" && Buscar.BuscarUsuario(txtUsuario.Text, txtSenha.Text))
                {
                    //RemoverProduto();

                    //if (telaPDV.gdvPDV.RowCount > 0)
                    //{
                    //telaPDV.gdvPDV.Rows.RemoveAt(telaPDV.gdvPDV.CurrentRow.Index);

                    telaPDV.RemoverProduto();

                    telaPDV.ValorTotal();

                    this.Close();

                    //ApagandoTextbox();
                    //}
                }
            }
            else
            {
                telaPDV.NovaVenda();

                this.Close();
            }
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            txtUsuario.CharacterCasing = CharacterCasing.Upper;

            ManipulacaoTextBox.DigitoFoiLetrasOuNumerosParaUsuario(e);
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;

            ManipulacaoTextBox.DigitoValidoParaSenha(e);
        }
    }
}