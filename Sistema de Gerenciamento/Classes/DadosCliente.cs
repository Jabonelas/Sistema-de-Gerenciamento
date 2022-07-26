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

        public decimal credito { get; set; }

        public decimal saldo { get; set; }

        public string status { get; set; }

        public DadosCliente(string _nome, int _id, string _cpfCpnjCliente)
        {
            nome = _nome;
            id = _id;
            cpfCpnjCliente = _cpfCpnjCliente;
        }

        public DadosCliente(string _nome, int _id, string _cpfCpnjCliente, decimal _credito, decimal _saldo, string _status)
        {
            nome = _nome;
            id = _id;
            cpfCpnjCliente = _cpfCpnjCliente;
            credito = _credito;
            saldo = _saldo;
            status = _status;
        }
    }
}