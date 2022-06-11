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
        public int quantidadeParcelas { get; set; }
        public decimal valorParcela { get; set; }
        public string categoria { get; set; }

        public DadosDespesaCusto(string _tipo, string _descricao, string _forncedorTitulo, string _cnpj,
            DateTime _emissao,
            DateTime _vencimento, string _frequencia, decimal _valor, int _quantidadeParcelas,
            decimal _valorParcela, string _categoria)
        {
            //codigo = _codigo;
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
        }
    }
}