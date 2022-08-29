using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DashboardWin.Design;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using Sistema_de_Gerenciamento.Properties;

namespace Sistema_de_Gerenciamento.Classes
{
    public class DadosMensagemAlerta
    {
        public string titulo { get; set; }
        public string texto { get; set; }
        public Bitmap image { get; set; }
        public string descricao { get; set; }

        public DadosMensagemAlerta(string _descricaoProduto, int _codigoProduto)
        {
            this.titulo = "Extoque Baixo";
            this.texto = $"Codigo Produto: {_codigoProduto} \nDescrição Produto: {_descricaoProduto}";
            this.image = Resources.ImagemEstoqueBaixo;
        }

        public DadosMensagemAlerta(string _fonecedorTitulo, string _vencimento)
        {
            this.titulo = "Vencimento Contas";
            this.texto = $"Fornecedor: {_fonecedorTitulo} \nData Vencimento: {_vencimento}";
            this.image = Resources.ImagemVencimentoContas;
        }
    }
}