using Bunifu.UI.WinForms;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento
{
    public class ManipulacaoTextBox
    {
        public bool VerificarPreenchimentoTextBox(Form _form)
        {
            try
            {
                bool isVazio = false;
                foreach (Control componente in _form.Controls)
                {
                    var tipoComponente = componente.GetType();

                    if (tipoComponente.Name == "BunifuTextBox")
                    {
                        BunifuTextBox textBox = (BunifuTextBox)componente;

                        if (textBox.Text == string.Empty)
                        {
                            isVazio = true;
                            break;
                        }
                    }
                    else if (tipoComponente.Name == "GunaComboBox")
                    {
                        if (componente.Text == string.Empty)
                        {
                            isVazio = true;
                            break;
                        }
                    }
                }
                return isVazio;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return false;
            }
        }

        public void ApagandoTextBox(Form _form)
        {
            foreach (Control componente in _form.Controls)
            {
                var tipoComponente = componente.GetType();

                if (tipoComponente.Name == "BunifuTextBox")
                {
                    BunifuTextBox textBox = (BunifuTextBox)componente;
                    textBox.Text = string.Empty;
                }
                else if (tipoComponente.Name == "RichTextBox")
                {
                    componente.Text = string.Empty;
                }
                else if (tipoComponente.Name == "GunaComboBox")
                {
                    componente.Text = string.Empty;
                }
            }
        }
    }
}