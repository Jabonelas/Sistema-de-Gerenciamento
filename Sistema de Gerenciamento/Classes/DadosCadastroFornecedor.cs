using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    public class DadosCadastroFornecedor
    {
        public string razaoSocial { get; set; }
        public DateTime dataCadastro { get; set; }
        public string cnpj { get; set; }
        public string nomeFantasia { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string complemento { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string observacao { get; set; }
        public int codigoFornecedor { get; set; }

        public DadosCadastroFornecedor(string _razaoSocial, DateTime _dataCadastro, string _cnpj, string _nomeFantasia, string _cep, string _endereco, string _complemento, int _numero,
        string _bairro, string _cidade, string _uf, string _telefone, string _email, string _observacao, int _codigoFornecedor)
        {
            razaoSocial = _razaoSocial;
            dataCadastro = _dataCadastro;
            cnpj = _cnpj;
            nomeFantasia = _nomeFantasia;
            cep = _cep;
            endereco = _endereco;
            complemento = _complemento;
            numero = _numero;
            bairro = _bairro;
            cidade = _cidade;
            uf = _uf;
            telefone = _telefone;
            email = _email;
            observacao = _observacao;
            codigoFornecedor = _codigoFornecedor;
        }

        public DadosCadastroFornecedor()
        {
        }
    }
}