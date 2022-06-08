using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class DadosDespesasCusto
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public string tipo { get; set; }
        public string categoria { get; set; }

        public DadosDespesasCusto(int _codigo, string _descricao, string _tipo, string _categoria)
        {
            codigo = _codigo;
            descricao = _descricao;
            tipo = _tipo;
            categoria = _categoria;
        }
    }
}