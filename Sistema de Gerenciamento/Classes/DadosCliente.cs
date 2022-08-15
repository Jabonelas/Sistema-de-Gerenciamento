using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class DadosCliente
    {
        public DateTime dataCadastro { get; set; }
        public string nome { get; set; }

        public string tipo { get; set; }

        public string cpfCpnjCliente { get; set; }

        public string rg { get; set; }

        public string orgaoEmissor { get; set; }

        public string dataEmissao { get; set; }

        public string insEst { get; set; }

        public string cep { get; set; }

        public string endereco { get; set; }

        public int numero { get; set; }

        public string complemento { get; set; }

        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string naturalidade { get; set; }
        public string dataNascimento { get; set; }
        public string estadoCivil { get; set; }
        public decimal credito { get; set; }
        public decimal saldo { get; set; }

        public string bloqueio { get; set; }
        public string celular { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string observacoes { get; set; }

        public int codigoCliente { get; set; }

        public int id { get; set; }
        public string status { get; set; }

        public DadosCliente(string _nome, int _id, string _cpfCpnjCliente)
        {
            nome = _nome;
            id = _id;
            cpfCpnjCliente = _cpfCpnjCliente;
        }

        public DadosCliente(string _nome, int _id, string _cpfCpnjCliente, decimal _credito, decimal _saldo, string _status)
        {
            nome = _nome;
            id = _id;
            cpfCpnjCliente = _cpfCpnjCliente;
            credito = _credito;
            saldo = _saldo;
            status = _status;
        }

        public DadosCliente(DateTime _dataCadastro, string _nome, string _tipo, string _cpfCpnjCliente, string _rg, string _orgaoEmissor, string _dataEmissao,
            string _insEst, string _cep, string _endereco, int _numero, string _complemento, string _bairro, string _cidade, string _uf, string _naturalidade,
            string _dataNascimento, string _estadoCivil, decimal _credito, decimal _saldo, string _bloqueio, string _celular, string _telefone,
            string _email, string _observacoes, int _codigoCliente)
        {
            dataCadastro = _dataCadastro;
            nome = _nome;
            tipo = _tipo;
            cpfCpnjCliente = _cpfCpnjCliente;
            rg = _rg;
            orgaoEmissor = _orgaoEmissor;
            dataEmissao = _dataEmissao;
            insEst = _insEst;
            cep = _cep;
            endereco = _endereco;
            numero = _numero;
            complemento = _complemento;
            bairro = _bairro;
            cidade = _cidade;
            uf = _uf;
            naturalidade = _naturalidade;
            dataNascimento = _dataNascimento;
            estadoCivil = _estadoCivil;
            credito = _credito;
            saldo = _saldo;
            bloqueio = _bloqueio;
            celular = _celular;
            telefone = _telefone;
            email = _email;
            observacoes = _observacoes;
            codigoCliente = _codigoCliente;
        }

        public DadosCliente()
        {
        }
    }
}