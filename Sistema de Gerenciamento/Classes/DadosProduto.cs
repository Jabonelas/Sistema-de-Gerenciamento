using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class DadosProduto
    {
        public int codigo { get; set; }

        public string descricaoProduto { get; set; }

        public decimal quantidade { get; set; }

        public string unidade { get; set; }

        public decimal preco { get; set; }

        public DadosProduto(int _codigo, string _descricaoProduto, decimal _quantidade, string _unidade, decimal _preco)
        {
            codigo = _codigo;
            descricaoProduto = _descricaoProduto;
            quantidade = _quantidade;
            unidade = _unidade;
            preco = _preco;
        }
    }
}