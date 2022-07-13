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

        public DateTime validadeTroca { get; set; }

        public string nomeCliente { get; set; }

        public int codigoBarras { get; set; }

        public int codigoProduto { get; set; }

        public string descricao { get; set; }

        public decimal quantidade { get; set; }

        public string unidade { get; set; }

        public decimal preco { get; set; }

        public decimal valorUnitario { get; set; }

        public string cpf { get; set; }

        public int numeroNF { get; set; }

        public DateTime emissao { get; set; }

        public string tipoPagamento { get; set; }
        public decimal quantidadeParcelas { get; set; }
        public decimal valorDesconto { get; set; }
        public decimal valorJuros { get; set; }
        public decimal valorPago { get; set; }
        public string status { get; set; }
        public string trocarVendedor { get; set; }

        public DadosNotaFiscalSaida(string _vendedor, DateTime _validadeTroca, string _nomeCliente,
            int _codigoBarras, int _codigoProduto, string _descricao, decimal _quantidade, string _unidade,
            decimal _preco, decimal _valorUnitario)
        {
            vendedor = _vendedor;
            validadeTroca = _validadeTroca;
            nomeCliente = _nomeCliente;
            codigoBarras = _codigoBarras;
            codigoProduto = _codigoProduto;
            descricao = _descricao;
            quantidade = _quantidade;
            unidade = _unidade;
            preco = _preco;
            valorUnitario = _valorUnitario;
        }

        public DadosNotaFiscalSaida(string _vendedor, DateTime _validadeTroca, string _nomeCliente,
        int _codigoBarras, int _codigoProduto, string _descricao, decimal _quantidade, string _unidade,
         decimal _valorUnitario, string _cpf, int _numeroNF, DateTime _emissao, string _tipoPagamento,
         int _quantidadeParcelas, decimal _valorDesconto, decimal _valorJuros, decimal _valorPago, string _status,
         string _trocarVendedor)
        {
            numeroNF = _numeroNF;
            cpf = _cpf;
            nomeCliente = _nomeCliente;
            codigoProduto = _codigoProduto;
            descricao = _descricao;
            emissao = _emissao;
            codigoBarras = _codigoBarras;
            vendedor = _vendedor;
            validadeTroca = _validadeTroca;
            valorUnitario = _valorUnitario;
            quantidade = _quantidade;
            unidade = _unidade;
            tipoPagamento = _tipoPagamento;
            quantidadeParcelas = _quantidadeParcelas;
            valorDesconto = _valorDesconto;
            valorJuros = _valorJuros;
            valorPago = _valorPago;
            status = _status;
            trocarVendedor = _trocarVendedor;
        }
    }
}