using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento.Classes
{
    public static class FecharTela
    {
        public static void DesejaFecharTela(Form _form, KeyEventArgs e)
        {
            if (ManipulacaoTextBox.VerificarTextBoxEstaVazioParaFechamentoTela(_form) == false)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    _form.Close();
                }
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Realmente Deseja Fechar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    _form.Close();
                }
            }
        }
    }
}