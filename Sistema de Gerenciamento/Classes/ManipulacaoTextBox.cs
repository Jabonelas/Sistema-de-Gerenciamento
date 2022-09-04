using Bunifu.UI.WinForms;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Sistema_de_Gerenciamento
{
    public static class ManipulacaoTextBox
    {
        //TextBox Bunifu prenchimento obrigatorio
        //TextBox guna preenchimento opcional

        #region Verificação de preenchimento dos TextBox

        public static bool TextBoxEstaVazio(Form _form)
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

                if (isVazio == true)
                {
                    MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return isVazio;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return false;
            }
        }

        public static bool VerificarTextBoxEstaVazioParaFechamentoTela(Form _form)
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

                        if (textBox.Text != string.Empty)
                        {
                            isVazio = true;
                            break;
                        }
                    }
                    else if (tipoComponente.Name == "GunaComboBox")
                    {
                        if (componente.Text != string.Empty)
                        {
                            isVazio = true;
                            break;
                        }
                    }
                    else if (tipoComponente.Name == "ComboBox")
                    {
                        if (componente.Text != string.Empty)
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

        public static void ApagandoTextBox(Form _form)
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

        public static bool DigitoFoiNumero(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            return true;
        }

        #endregion Digitar Apenas Numeros

        #region Preenchimento Porcentagem

        public static void PreenchimentoPorcentagem(KeyPressEventArgs e, string _textBox, object sender)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    if (_textBox.Length <= 7 || e.KeyChar.Equals((char)Keys.Back))
                    {
                        var tipoComponente = _textBox.GetType();

                        if (tipoComponente.Name == "BunifuTextBox")
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
                        else
                        {
                            TextBox textbox = (TextBox)sender;
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
                }
                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        #endregion Preenchimento Porcentagem

        #region Digitar Apenas Letras

        public static bool DigitoFoiLetras(KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)32)
            {
                e.Handled = true;
            }

            return true;
        }

        #endregion Digitar Apenas Letras

        #region Formato de CPF

        public static void FormatoCPF(KeyPressEventArgs e, BunifuTextBox _txtBox)
        {
            _txtBox.MaxLength = 14;

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (_txtBox.TextLength)
                {
                    case 0:
                        _txtBox.Text = "";
                        break;

                    case 3:
                        _txtBox.Text = _txtBox.Text + ".";
                        _txtBox.SelectionStart = 4;
                        break;

                    case 7:
                        _txtBox.Text = _txtBox.Text + ".";
                        _txtBox.SelectionStart = 8;
                        break;

                    case 11:
                        _txtBox.Text = _txtBox.Text + "-";
                        _txtBox.SelectionStart = 12;
                        break;
                }
            }
        }

        #endregion Formato de CPF

        #region Formato de CNPJ

        public static void FormatoCNPJ(KeyPressEventArgs e, BunifuTextBox _txtBox)
        {
            _txtBox.MaxLength = 18;

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (_txtBox.TextLength)
                {
                    case 0:
                        _txtBox.Text = "";
                        break;

                    case 2:
                        _txtBox.Text = _txtBox.Text + ".";
                        _txtBox.SelectionStart = 3;
                        break;

                    case 6:
                        _txtBox.Text = _txtBox.Text + ".";
                        _txtBox.SelectionStart = 7;
                        break;

                    case 10:
                        _txtBox.Text = _txtBox.Text + "/";
                        _txtBox.SelectionStart = 11;
                        break;

                    case 15:
                        _txtBox.Text = _txtBox.Text + "-";
                        _txtBox.SelectionStart = 16;
                        break;
                }
            }
        }

        #endregion Formato de CNPJ

        #region Formato RG

        public static void FormatoRG(BunifuTextBox _txtBox)
        {
            switch (_txtBox.TextLength)
            {
                case 0:
                    _txtBox.Text = "";
                    break;

                case 2:
                    _txtBox.Text = _txtBox.Text + ".";
                    _txtBox.SelectionStart = 3;
                    break;

                case 6:
                    _txtBox.Text = _txtBox.Text + ".";
                    _txtBox.SelectionStart = 7;
                    break;

                case 10:
                    _txtBox.Text = _txtBox.Text + "-";
                    _txtBox.SelectionStart = 11;
                    break;
            }
        }

        #endregion Formato RG

        #region Formato Data

        public static void FormatoData(BunifuTextBox _txtBox)
        {
            _txtBox.MaxLength = 10;

            switch (_txtBox.TextLength)
            {
                case 0:
                    _txtBox.Text = "";
                    break;

                case 2:
                    _txtBox.Text = _txtBox.Text + "/";
                    _txtBox.SelectionStart = 3;
                    break;

                case 5:
                    _txtBox.Text = _txtBox.Text + "/";
                    _txtBox.SelectionStart = 6;
                    break;
            }
        }

        #endregion Formato Data

        #region Formato CEP

        public static void FormatoCEP(BunifuTextBox _textBox)
        {
            switch (_textBox.TextLength)
            {
                case 0:
                    _textBox.Text = "";
                    break;

                case 5:
                    _textBox.Text = _textBox.Text + "-";
                    _textBox.SelectionStart = 6;
                    break;
            }
        }

        #endregion Formato CEP

        #region Formato Celular

        public static void FormatoCelular(BunifuTextBox _textBox)
        {
            switch (_textBox.TextLength)
            {
                case 0:
                    _textBox.Text = "(";
                    _textBox.SelectionStart = 1;
                    break;

                case 3:
                    _textBox.Text = _textBox.Text + ") ";
                    _textBox.SelectionStart = 5;
                    break;

                case 10:
                    _textBox.Text = _textBox.Text + "-";
                    _textBox.SelectionStart = 11;
                    break;
            }
        }

        #endregion Formato Celular

        #region Formato Telefone Residencial

        public static void FormatoTelefone(GunaTextBox _textBox)
        {
            switch (_textBox.TextLength)
            {
                case 0:
                    _textBox.Text = "(";
                    _textBox.SelectionStart = 1;
                    break;

                case 3:
                    _textBox.Text = _textBox.Text + ") ";
                    _textBox.SelectionStart = 5;
                    break;

                case 10:
                    _textBox.Text = _textBox.Text + "-";
                    _textBox.SelectionStart = 11;
                    break;
            }
        }

        #endregion Formato Telefone Residencial

        #region Formato Dinheiro

        public static void FormatoDinheiro(KeyPressEventArgs e, object sender, BunifuTextBox _textBox)
        {
            try
            {
                _textBox.MaxLength = 10;

                if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {
                    if (_textBox.Text.Length <= 13 || e.KeyChar.Equals((char)Keys.Back))
                    {
                        TextBox textbox = (TextBox)sender;
                        string testoDoTextBox = Regex.Replace(textbox.Text, "[^0-9]", string.Empty);
                        if (testoDoTextBox == string.Empty)
                        {
                            testoDoTextBox = "00";
                        }

                        testoDoTextBox += e.KeyChar;
                        textbox.Text = String.Format("R$ {0:#,##0.00}", double.Parse(testoDoTextBox) / 100);
                        textbox.Select(textbox.Text.Length, 0);
                    }
                }
                e.Handled = true;
            }
            catch (Exception)
            {
            }
        }

        #endregion Formato Dinheiro

        #region Verificar Preenchimento Completo do TextBox

        public static bool VerificarcaoPreencimentoCompleto(BunifuTextBox _textBox)
        {
            if (_textBox.Text.Length != _textBox.MaxLength && _textBox.Text.Length != 0)
            {
                _textBox.BorderColorActive = Color.Red;

                _textBox.Focus();

                MessageBox.Show("Por Favor Preencha o Campo Corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (_textBox.Text.Length == _textBox.MaxLength || _textBox.Text.Length == 0)
            {
                _textBox.BorderColorActive = Color.DodgerBlue;

                return true;
            }

            return false;
        }

        #endregion Verificar Preenchimento Completo do TextBox

        #region Digitar Apenas Letras e Numeros

        public static bool DigitoFoiLetrasOuNumeros(KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)32 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            return true;
        }

        #endregion Digitar Apenas Letras e Numeros

        #region Formatar TextBox Email

        public static bool DigitoValidoParaEmail(KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)64
                && !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)45 && e.KeyChar != (char)46
                && e.KeyChar != (char)95 && e.KeyChar != (char)47)
            {
                e.Handled = true;
            }

            return true;
        }

        #endregion Formatar TextBox Email

        #region Formatacao Para Senha

        public static bool DigitoValidoParaSenha(KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)64
                && !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)45 && e.KeyChar != (char)46 && e.KeyChar != (char)95
                && e.KeyChar != (char)33 && e.KeyChar != (char)35 && e.KeyChar != (char)36 && e.KeyChar != (char)37
                && e.KeyChar != (char)168 && e.KeyChar != (char)38 && e.KeyChar != (char)42 && e.KeyChar != (char)61
                && e.KeyChar != (char)43)
            {
                e.Handled = true;
            }

            return true;
        }

        #endregion Formatacao Para Senha

        #region Validar Data

        public static bool ValidacaoData(BunifuTextBox _textBox)
        {
            if (_textBox.Text.Length == _textBox.MaxLength && _textBox.Text != "----------")
            {
                DateTime time;
                if (DateTime.TryParse(_textBox.Text, out time))
                {
                    _textBox.BorderColorActive = Color.DodgerBlue;

                    return true;
                }
                else
                {
                    _textBox.BorderColorActive = Color.Red;

                    MessageBox.Show($"Data Errada: {_textBox.Text}", "Atencao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    _textBox.Focus();

                    return false;
                }
            }
            return true;
        }

        #endregion Validar Data

        #region Formato Pix

        public static bool DigitoValidoParaChavePix(KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)64
                && !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)45 && e.KeyChar != (char)46
                && e.KeyChar != (char)95 && e.KeyChar != (char)47 && e.KeyChar != (char)32
                && e.KeyChar != (char)40 && e.KeyChar != (char)41)

            {
                e.Handled = true;
            }

            return true;
        }

        #endregion Formato Pix
    }
}