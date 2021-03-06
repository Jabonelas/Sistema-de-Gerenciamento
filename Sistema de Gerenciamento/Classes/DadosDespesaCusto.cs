using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class DadosDespesaCusto
    {
        public int codigo { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
        public string forncedorTitulo { get; set; }
        public string cnpj { get; set; }
        public DateTime emissao { get; set; }
        public DateTime vencimento { get; set; }
        public string frequencia { get; set; }
        public decimal valor { get; set; }
        public string quantidadeParcelas { get; set; }
        public decimal valorParcela { get; set; }
        public string categoria { get; set; }
        public string verificar { get; set; }

        public string statusPagamento { get; set; }

        public DadosDespesaCusto(int _codigo, string _tipo, string _descricao, string _forncedorTitulo, string _cnpj,
            DateTime _emissao, DateTime _vencimento, string _frequencia, decimal _valor, string _quantidadeParcelas,
            decimal _valorParcela, string _categoria, string _verificar, string _statusPàgamento)
        {
            codigo = _codigo;
            tipo = _tipo;
            descricao = _descricao;
            forncedorTitulo = _forncedorTitulo;
            cnpj = _cnpj;
            emissao = _emissao;
            vencimento = _vencimento;
            valor = _valor;
            frequencia = _frequencia;
            quantidadeParcelas = _quantidadeParcelas;
            valorParcela = _valorParcela;
            categoria = _categoria;
            verificar = _verificar;
            statusPagamento = _statusPàgamento;
        }
    }
}