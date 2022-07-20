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

        public string cpfCpnjCliente { get; set; }

        public DadosCliente(string _nome, int _id, string _cpfCpnjCliente)
        {
            nome = _nome;
            id = _id;
            cpfCpnjCliente = _cpfCpnjCliente;
        }
    }
}