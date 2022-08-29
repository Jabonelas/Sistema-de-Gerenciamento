using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class ValidacaoEmail
    {
        public static void VerificarPreenchimentoEmail(string _email, BunifuTextBox _txtBox)
        {
            Regex validaEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            if (!validaEmail.IsMatch(_email))
            {
                MessageBox.Show("Por Favor Digite Um Email Inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                _txtBox.Focus();
            }
        }
    }
}