using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class DadosCliente
    {
        public string nome { get; set; }

        public int id { get; set; }

        public DadosCliente(string _nome, int _id)
        {
            nome = _nome;
            id = _id;
        }
    }
}