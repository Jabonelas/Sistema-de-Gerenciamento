using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class ValidacaoCNPJ
    {
        public static bool IsCnpj(string _cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            _cnpj = _cnpj.Trim();
            _cnpj = _cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (_cnpj.Length != 14)
                return false;
            tempCnpj = _cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return _cnpj.EndsWith(digito);
        }

        public static void MensagemCNPJDigitadoInvalido()
        {
            MessageBox.Show("Por Favor Digite Um CNPJ InVálido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}