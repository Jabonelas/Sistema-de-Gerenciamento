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

        public DadosEstatiscasFinanceiras(decimal _valor, int _mes)
        {
            this.valor = _valor;
            this.mes = _mes;
        }
    }
}