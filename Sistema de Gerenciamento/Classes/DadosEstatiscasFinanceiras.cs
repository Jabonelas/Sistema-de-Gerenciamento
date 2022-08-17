using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class DadosEstatiscasFinanceiras
    {
        public decimal valor { get; set; }
        public int mes { get; set; }

        public int indice { get; set; }

        public DadosEstatiscasFinanceiras(decimal _valor, int _mes)
        {
            valor = _valor;
            mes = _mes;
        }

        public DadosEstatiscasFinanceiras(decimal _valor, int _mes, int _indice)
        {
            valor = _valor;
            mes = _mes;
            indice = _indice;
        }
    }
}