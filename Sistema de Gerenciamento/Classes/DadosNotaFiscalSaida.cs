using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class DadosNotaFiscalSaida
    {
        public string vendedor { get; set; }

        public DateTime ValidadeTroca { get; set; }

        public string nomeCliente { get; set; }

        public int codigoBarras { get; set; }

        public DadosNotaFiscalSaida(string _vendedor, DateTime _validadeTroca, string _nomeCliente, int _codigoBarras)
        {
            this.vendedor = _vendedor;
            this.ValidadeTroca = _validadeTroca;
            this.nomeCliente = _nomeCliente;
            this.codigoBarras = _codigoBarras;
        }
    }
}