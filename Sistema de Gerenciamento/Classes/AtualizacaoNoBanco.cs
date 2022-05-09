using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class AtualizacaoNoBanco : ConectarBanco
    {
        private MensagensErro Erro = new MensagensErro();

        public void Atualizar(int _codigoCliente, DateTime _dataCadastro, string _nomeCliente, string _tipo, string _cPF_CNPJ,
          string _rG, string _emissor, string _dataEmissao, string _ins_Est, string _cEP, string _endereco, string _complemento,
          string _bairro, string _cidade, string _uF, string _naturalidade, string _dataNasc, string _estadoCivil, decimal _credito,
          decimal _saldo, string _bloqueio, string _celular, string _tel_Residencial, string _email, string _observacoes)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update CadastroClientes set CodigoCliente =@CodigoCliente,DataCadastro=@DataCadastro," +
                        "NomeCliente=@NomeCliente,Tipo=@Tipo," +
                        "RG=@RG,Emissor=@Emissor,DataEmissao=@DataEmissao,Ins_Est=@Ins_Est,CEP=@CEP,Endereco=@Endereco," +
                        "Complemento=@Complemento,Bairro=@Bairro,Cidade=@Cidade,UF=@UF,Naturalidade=@Naturalidade," +
                        "DataNasc=@DataNasc,EstadoCivil=@EstadoCivil,Credito=@Credito,Saldo=@Saldo,Bloqueio=@Bloqueio," +
                        "Celular=@Celular,Tel_Residencial=@Tel_Residencial,Email=@Email,Observacoes=@Observacoes " +
                        "where CPF_CNPJ=@CPF_CNPJ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@CodigoCliente", SqlDbType.Int).Value = _codigoCliente;
                    adapter.SelectCommand.Parameters.AddWithValue("@DataCadastro", SqlDbType.Date).Value = _dataCadastro;
                    adapter.SelectCommand.Parameters.AddWithValue("@NomeCliente", SqlDbType.VarChar).Value = _nomeCliente;
                    adapter.SelectCommand.Parameters.AddWithValue("@Tipo", SqlDbType.VarChar).Value = _tipo;
                    adapter.SelectCommand.Parameters.AddWithValue("@CPF_CNPJ", SqlDbType.VarChar).Value = _cPF_CNPJ;
                    adapter.SelectCommand.Parameters.AddWithValue("@RG", SqlDbType.VarChar).Value = _rG;
                    adapter.SelectCommand.Parameters.AddWithValue("@Emissor", SqlDbType.VarChar).Value = _emissor;
                    adapter.SelectCommand.Parameters.AddWithValue("@DataEmissao", SqlDbType.VarChar).Value = _dataEmissao;
                    adapter.SelectCommand.Parameters.AddWithValue("@Ins_Est", SqlDbType.VarChar).Value = _ins_Est;
                    adapter.SelectCommand.Parameters.AddWithValue("@CEP", SqlDbType.VarChar).Value = _cEP;
                    adapter.SelectCommand.Parameters.AddWithValue("@Endereco", SqlDbType.VarChar).Value = _endereco;
                    adapter.SelectCommand.Parameters.AddWithValue("@Complemento", SqlDbType.VarChar).Value = _complemento;
                    adapter.SelectCommand.Parameters.AddWithValue("@Bairro", SqlDbType.VarChar).Value = _bairro;
                    adapter.SelectCommand.Parameters.AddWithValue("@Cidade", SqlDbType.VarChar).Value = _cidade;
                    adapter.SelectCommand.Parameters.AddWithValue("@UF", SqlDbType.VarChar).Value = _uF;
                    adapter.SelectCommand.Parameters.AddWithValue("@Naturalidade", SqlDbType.VarChar).Value = _naturalidade;
                    adapter.SelectCommand.Parameters.AddWithValue("@DataNasc", SqlDbType.VarChar).Value = _dataNasc;
                    adapter.SelectCommand.Parameters.AddWithValue("@EstadoCivil", SqlDbType.VarChar).Value = _estadoCivil;
                    adapter.SelectCommand.Parameters.AddWithValue("@Credito", SqlDbType.Decimal).Value = _credito;
                    adapter.SelectCommand.Parameters.AddWithValue("@Saldo", SqlDbType.Decimal).Value = _saldo;
                    adapter.SelectCommand.Parameters.AddWithValue("@Bloqueio", SqlDbType.VarChar).Value = _bloqueio;
                    adapter.SelectCommand.Parameters.AddWithValue("@Celular", SqlDbType.VarChar).Value = _celular;
                    adapter.SelectCommand.Parameters.AddWithValue("@Tel_Residencial", SqlDbType.VarChar).Value = _tel_Residencial;
                    adapter.SelectCommand.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = _email;
                    adapter.SelectCommand.Parameters.AddWithValue("@Observacoes", SqlDbType.VarChar).Value = _observacoes;

                    adapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarClienteNoBanco(ex);
            }
        }
    }
}