using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;

namespace Sistema_de_Gerenciamento.Classes
{
    public class DadosProduto
    {
        public int codigoProduto { get; set; }
        public string descricaoProduto { get; set; }
        public string unidade { get; set; }
        public decimal valorCusto { get; set; }
        public decimal porcentagem { get; set; }
        public decimal valorVenda { get; set; }
        public decimal lucro { get; set; }
        public decimal precoAtacado { get; set; }
        public string grupo { get; set; }
        public string subGrupo { get; set; }
        public string fornecedor { get; set; }
        public decimal estoqueMinimo { get; set; }
        public int garantia { get; set; }
        public string marca { get; set; }
        public string referencia { get; set; }
        public DateTime validade { get; set; }
        public decimal comissao { get; set; }
        public string observacao { get; set; }
        public decimal quantidade { get; set; }
        public decimal preco { get; set; }
        public decimal desconto { get; set; }
        public int codigoBarras { get; set; }
        public int nfEntrada { get; set; }
        public DateTime dataEntrada { get; set; }
        public string status { get; set; }
        public int primarykey { get; set; }

        public decimal valor { get; set; }

        public int mes { get; set; }

        public int indice { get; set; }

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

        public DadosProduto(int _codigoProduto, string _descricaoProduto)
        {
            codigoProduto = _codigoProduto;
            descricaoProduto = _descricaoProduto;
        }

        public DadosProduto(int _codigoProduto, string _descricaoProduto, string _unidade, decimal _valorCusto, decimal _porcentagem, decimal _valorVenda,
            decimal _lucro, decimal _precoAtacado, string _grupo, string _subGrupo, string _fornecedor, decimal _estoqueMinimo, int _garantia, string _marca,
            string _referencia, DateTime _validade, decimal _comissao, string _observacao, int _primarykey)
        {
            codigoProduto = _codigoProduto;
            descricaoProduto = _descricaoProduto;
            unidade = _unidade;
            valorCusto = _valorCusto;
            porcentagem = _porcentagem;
            valorVenda = _valorVenda;
            lucro = _lucro;
            precoAtacado = _precoAtacado;
            grupo = _grupo;
            subGrupo = _subGrupo;
            fornecedor = _fornecedor;
            estoqueMinimo = _estoqueMinimo;
            garantia = _garantia;
            marca = _marca;
            referencia = _referencia;
            validade = _validade;
            comissao = _comissao;
            observacao = _observacao;
            primarykey = _primarykey;
        }

        public DadosProduto(decimal _valor, int _mes, int _indice)
        {
            valor = _valor;
            mes = _mes;
            indice = _indice;
        }

        public DadosProduto()
        {
        }
    }
}