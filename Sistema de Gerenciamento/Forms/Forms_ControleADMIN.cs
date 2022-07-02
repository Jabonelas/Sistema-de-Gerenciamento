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

        private Forms_TelaPDV telaPDV;

        private Forms_CadastroCliente cadastroCliente;

        public Forms_ControleADMIN(Forms_TelaPDV _telaPDV)
        {
            InitializeComponent();

            telaPDV = _telaPDV;
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

        ////////////////////////////////////////////////////////////////////////
        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            txtUsuario.CharacterCasing = CharacterCasing.Upper;

            ManipulacaoTextBox.DigitoFoiLetrasOuNumerosParaUsuario(e);
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            ManipulacaoTextBox.DigitoValidoParaSenha(e);
        }
    }
}