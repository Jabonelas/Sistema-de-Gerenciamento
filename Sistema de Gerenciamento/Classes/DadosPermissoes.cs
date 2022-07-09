using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class DadosPermissoes
    {
        public string excluirItem { get; set; }
        public string devolucaoTroca { get; set; }
        public string cancelarVenda { get; set; }
        public string cancelarPagamento { get; set; }

        public DadosPermissoes(string _excluirItem, string _devolucaoTroca, string _cancelarVenda, string _cancelarPagamento)
        {
            excluirItem = _excluirItem;
            devolucaoTroca = _devolucaoTroca;
            cancelarVenda = _cancelarVenda;
            cancelarPagamento = _cancelarPagamento;
        }
    }
}