using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class DadosProduto
    {
        public int codigoProduto { get; set; }

        public string descricaoProduto { get; set; }

        public decimal quantidade { get; set; }

        public string unidade { get; set; }

        public decimal preco { get; set; }

        public decimal desconto { get; set; }

        public int codigoBarras { get; set; }

        public int nfEntrada { get; set; }

        public DateTime dataEntrada { get; set; }

        public string status { get; set; }

        public DadosProduto(int _codigoProduto, string _descricaoProduto, decimal _quantidade,
            string _unidade, decimal _preco, decimal _desconto, int _codigoBarras, int _nfEntrada)
        {
            codigoProduto = _codigoProduto;
            descricaoProduto = _descricaoProduto;
            quantidade = _quantidade;
            unidade = _unidade;
            preco = _preco;
            desconto = _desconto;
            codigoBarras = _codigoBarras;
            nfEntrada = _nfEntrada;
        }

        public DadosProduto(int _nfEntrada, DateTime _dateEntrada, int _codigoBarras, int _codigoProduto, string _descricaoProduto,
            decimal _quantidade, string _unidade, decimal _preco, string _status)
        {
            nfEntrada = _nfEntrada;
            dataEntrada = _dateEntrada;
            codigoBarras = _codigoBarras;
            codigoProduto = _codigoProduto;
            descricaoProduto = _descricaoProduto;
            quantidade = _quantidade;
            unidade = _unidade;
            preco = _preco;
            status = _status;
        }
    }
}