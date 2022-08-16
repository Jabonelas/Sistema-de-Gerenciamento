using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    public class DadosNotaFiscalSaida
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
        public int quantidadeParcelas { get; set; }
        public decimal valorDesconto { get; set; }
        public decimal valorJuros { get; set; }
        public decimal valorPago { get; set; }
        public string status { get; set; }
        public string trocarVendedor { get; set; }
        public int id { get; set; }
        public string motivoTroca { get; set; }
        public bool deveRealizarTrocar { get; set; }
        public int nfEntrada { get; set; }

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

        public DadosNotaFiscalSaida(int _id, int _numeroNF, string _cpf, string _nomeCliente, int _codigoProduto,
        string _descricao, DateTime _emissao, int _codigoBarras, string _vendedor, DateTime _validadeTroca, decimal _valorUnitario,
        decimal _quantidade, string _unidade, string _tipoPagamento, int _quantidadeParcelas, decimal _valorDesconto,
         decimal _valorJuros, decimal _valorPago, string _status, string _trocarVendedor, string _motivoTroca, bool _deveTrocar,
         int _nfEntrada)

        {
            id = _id;
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
            motivoTroca = _motivoTroca;
            deveRealizarTrocar = _deveTrocar;
            nfEntrada = _nfEntrada;
        }

        public DadosNotaFiscalSaida(int _codigoProduto, decimal _preco)
        {
            codigoProduto = _codigoProduto;
            preco = _preco;
        }

        public DadosNotaFiscalSaida()
        {
        }
    }
}