using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class DadosPagamentoCarne
    {
        public decimal valor { get; set; }
        public int mes { get; set; }
        public int indece { get; set; }

        public DadosPagamentoCarne(decimal _valor, int _mes, int _indece)
        {
            valor = _valor;
            mes = _mes;
            indece = _indece;
        }
    }
}