using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento
{
    internal class AdicionarNoBanco : ConectarBanco
    {
        public void Inseir(int _codigoCliente, DateTime _dataCadastro, string _nomeCliente, string _tipo, string _cPF_CNPJ,
           string _rG, string _emissor, DateTime _dataEmissao, string _ins_Est, string _cEP, string _endereco, string _complemento,
           string _bairro, string _cidade, string _uF, string _naturalidade, DateTime _dataNasc, string _estadoCivil, decimal _credito,
           decimal _saldo, string _bloqueio, string _celular, string _tel_Residencial, string _email, string _observacoes)
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "insert into CadastroClientes (CodigoCliente,DataCadastro,NomeCliente,Tipo,CPF_CNPJ," +
                    "RG,Emissor,DataEmissao,Ins_Est,CEP,Endereco,Complemento,Bairro,Cidade,UF,Naturalidade," +
                    "DataNasc,EstadoCivil,Credito,Saldo,Bloqueio,Celular,Tel_Residencial,Email,Observacoes) " +
                    "values (@CodigoCliente,@DataCadastro,@NomeCliente,@Tipo,@CPF_CNPJ," +
                    "@RG,@Emissor,@DataEmissao,@Ins_Est,@CEP,@Endereco,@Complemento,@Bairro,@Cidade,@UF,@Naturalidade," +
                    "@DataNasc,@EstadoCivil,@Credito,@Saldo,@Bloqueio,@Celular,@Tel_Residencial,@Email,@Observacoes)";

                SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                cmd.Parameters.AddWithValue("@CodigoCliente", SqlDbType.Int).Value = _codigoCliente;
                cmd.Parameters.AddWithValue("@DataCadastro", SqlDbType.Date).Value = _dataCadastro;
                cmd.Parameters.AddWithValue("@NomeCliente", SqlDbType.VarChar).Value = _nomeCliente;
                cmd.Parameters.AddWithValue("@Tipo", SqlDbType.VarChar).Value = _tipo;
                cmd.Parameters.AddWithValue("@CPF_CNPJ", SqlDbType.VarChar).Value = _cPF_CNPJ;
                cmd.Parameters.AddWithValue("@RG", SqlDbType.VarChar).Value = _rG;
                cmd.Parameters.AddWithValue("@Emissor", SqlDbType.VarChar).Value = _emissor;
                cmd.Parameters.AddWithValue("@DataEmissao", SqlDbType.Date).Value = _dataEmissao;
                cmd.Parameters.AddWithValue("@Ins_Est", SqlDbType.VarChar).Value = _ins_Est;
                cmd.Parameters.AddWithValue("@CEP", SqlDbType.VarChar).Value = _cEP;
                cmd.Parameters.AddWithValue("@Endereco", SqlDbType.VarChar).Value = _endereco;
                cmd.Parameters.AddWithValue("@Complemento", SqlDbType.VarChar).Value = _complemento;
                cmd.Parameters.AddWithValue("@Bairro", SqlDbType.VarChar).Value = _bairro;
                cmd.Parameters.AddWithValue("@Cidade", SqlDbType.VarChar).Value = _cidade;
                cmd.Parameters.AddWithValue("@UF", SqlDbType.VarChar).Value = _uF;
                cmd.Parameters.AddWithValue("@Naturalidade", SqlDbType.VarChar).Value = _naturalidade;
                cmd.Parameters.AddWithValue("@DataNasc", SqlDbType.Date).Value = _dataNasc;
                cmd.Parameters.AddWithValue("@EstadoCivil", SqlDbType.VarChar).Value = _estadoCivil;
                cmd.Parameters.AddWithValue("@Credito", SqlDbType.Decimal).Value = _credito;
                cmd.Parameters.AddWithValue("@Saldo", SqlDbType.Decimal).Value = _saldo;
                cmd.Parameters.AddWithValue("@Bloqueio", SqlDbType.VarChar).Value = _bloqueio;
                cmd.Parameters.AddWithValue("@Celular", SqlDbType.VarChar).Value = _celular;
                cmd.Parameters.AddWithValue("@Tel_Residencial", SqlDbType.VarChar).Value = _tel_Residencial;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = _email;
                cmd.Parameters.AddWithValue("@Observacoes", SqlDbType.VarChar).Value = _observacoes;

                cmd.ExecuteNonQuery();
            }
        }
    }
}