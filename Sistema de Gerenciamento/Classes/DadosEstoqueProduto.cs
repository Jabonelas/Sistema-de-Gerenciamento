using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    public class DadosEstoqueProduto
    {
        public int numeroNF { get; set; }

        public int codigoBarras { get; set; }

        public int codigoProduto { get; set; }

        public string descricaoProduto { get; set; }

        public decimal quantidade { get; set; }

        public string unidade { get; set; }

        public decimal valorUnitario { get; set; }

        public DateTime dataEntrada { get; set; }

        public decimal descontoItem { get; set; }

        public DadosEstoqueProduto(int _numeroNF, int _codigoBarras, int _codigoProduto, string _descricaoProduto,
            decimal _quantidade, string _unidade, decimal _valorUnitario, DateTime _dataEntrada, decimal _descontoItem)
        {
            numeroNF = _numeroNF;
            codigoBarras = _codigoBarras;
            codigoProduto = _codigoProduto;
            descricaoProduto = _descricaoProduto;
            quantidade = _quantidade;
            unidade = _unidade;
            valorUnitario = _valorUnitario;
            dataEntrada = _dataEntrada;
            descontoItem = _descontoItem;
        }
    }
}