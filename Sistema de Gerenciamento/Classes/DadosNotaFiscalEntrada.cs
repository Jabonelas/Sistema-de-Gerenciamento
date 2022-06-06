using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    public class DadosNotaFiscalEntrada
    {
        //public int indice { get; set; }
        public int numeroNF { get; set; }

        public string cnpj { get; set; }
        public string razaoSocial { get; set; }
        public int codProduto { get; set; }
        public string descricao { get; set; }
        public decimal quantidade { get; set; }
        public string unidade { get; set; }
        public decimal valorUnitario { get; set; }
        public decimal valorTotal { get; set; }
        public DateTime? dataEmissao { get; set; } = null;
        public DateTime? dataLancamento { get; set; } = null;

        public DadosNotaFiscalEntrada(int _numeroNF, string _cnpj, string _razaoSocial, int _codProduto,
    string _descricao, decimal _quantidade, string _unidade, decimal _valorUnitario, decimal _valorTotal, DateTime? _dataEmissao, DateTime? _dataLancamento)
        {
            //indice = _indice;
            numeroNF = _numeroNF;
            cnpj = _cnpj;
            razaoSocial = _razaoSocial;
            codProduto = _codProduto;
            descricao = _descricao;
            quantidade = _quantidade;
            unidade = _unidade;
            valorUnitario = _valorUnitario;
            valorTotal = _valorTotal;
            dataEmissao = _dataEmissao;
            dataLancamento = _dataLancamento;
        }
    }
}