using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class DadosContasAReceber
    {
        public decimal valor { get; set; }
        public int mes { get; set; }

        public int indice { get; set; }

        public DadosContasAReceber(decimal _valor, int _mes, int _indice)
        {
            valor = _valor;
            mes = _mes;
            indice = _indice;
        }
    }
}