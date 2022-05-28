using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class DadosCarne
    {
        public int prazo { get; set; }

        public decimal juros { get; set; }

        public int parcelas { get; set; }

        public DadosCarne(int _prazo, decimal _juros, int _parecelas)
        {
            prazo = _prazo;
            juros = _juros;
            parcelas = _parecelas;
        }
    }
}