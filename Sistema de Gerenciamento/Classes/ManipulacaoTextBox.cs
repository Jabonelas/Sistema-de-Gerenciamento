using Bunifu.UI.WinForms;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Sistema_de_Gerenciamento
{
    public class ManipulacaoTextBox
    {
        //TextBox Bunifu prenchimento obrigatorio
        //TextBox guna preenchimento opcional

        #region Verificação de preenchimento dos TextBox

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
                    else if (tipoComponente.Name == "ComboBox")
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

        #endregion Verificação de preenchimento dos TextBox

        #region Limpando dados dos TextBox

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
                else if (tipoComponente.Name == "GunaTextBox")
                {
                    componente.Text = string.Empty;
                }
                else if (tipoComponente.Name == "ComboBox")
                {
                    componente.Text = string.Empty;
                }
            }
        }

        #endregion Limpando dados dos TextBox

        #region Digitar Apenas Numeros

        public void DigitarApenasNumeros(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion Digitar Apenas Numeros

        #region Preenchimento Porcentagem

        public void PreenchimentoPorcentagem(KeyPressEventArgs e, string _textBox, object sender)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    if (_textBox.Length <= 7 || e.KeyChar.Equals((char)Keys.Back))
                    {
                        Guna2TextBox textbox = (Guna2TextBox)sender;
                        string testoDoTextBox = Regex.Replace(textbox.Text, "[^0-9]", string.Empty);
                        if (testoDoTextBox == string.Empty)
                        {
                            testoDoTextBox = "0";
                        }

                        testoDoTextBox += e.KeyChar;
                        textbox.Text = String.Format("{0:#,##0.00} %", double.Parse(testoDoTextBox) / 100);
                        textbox.Select(textbox.Text.Length, 0);
                    }
                }
                e.Handled = true;
            }
            catch (Exception)
            {
            }
        }

        #endregion Preenchimento Porcentagem
    }
}