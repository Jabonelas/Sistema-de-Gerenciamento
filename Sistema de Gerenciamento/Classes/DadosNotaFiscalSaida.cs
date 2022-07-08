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

        public int codigoProduto { get; set; }

        public string descricao { get; set; }

        public decimal quantidade { get; set; }

        public string unidade { get; set; }

        public decimal preco { get; set; }

        public DadosNotaFiscalSaida(string _vendedor, DateTime _validadeTroca, string _nomeCliente,
            int _codigoBarras, int _codigoProduto, string _descricao, decimal _quantidade, string _unidade,
            decimal _preco)
        {
            vendedor = _vendedor;
            ValidadeTroca = _validadeTroca;
            nomeCliente = _nomeCliente;
            codigoBarras = _codigoBarras;
            codigoProduto = _codigoProduto;
            descricao = _descricao;
            quantidade = _quantidade;
            unidade = _unidade;
            preco = _preco;
        }
    }
}