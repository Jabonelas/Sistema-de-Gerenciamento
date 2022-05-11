using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class AtualizacaoNoBanco : ConectarBanco
    {
        private MensagensErro Erro = new MensagensErro();

        #region Atualizar Cadastro Cliente

        public void AtualizarCadastroCliente(int _codigoCliente, DateTime _dataCadastro, string _nomeCliente, string _tipo, string _cPF_CNPJ,
          string _rG, string _emissor, string _dataEmissao, string _ins_Est, string _cEP, string _endereco, string _complemento,
          string _bairro, string _cidade, string _uF, string _naturalidade, string _dataNasc, string _estadoCivil, decimal _credito,
          decimal _saldo, string _bloqueio, string _celular, string _tel_Residencial, string _email, string _observacoes)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_CadastroClientes set " +
                        "cc_codigo_cliente=@CodigoCliente," +
                        "cc_data_cadastro=@DataCadastro," +
                        "cc_nome_cliente=@NomeCliente," +
                        "cc_tipo=@Tipo," +
                        "cc_rg=@RG," +
                        "cc_emissor=@Emissor," +
                        "cc_data_emissao=@DataEmissao," +
                        "cc_ins_est=@Ins_Est," +
                        "cc_cep=@CEP," +
                        "cc_endereco=@Endereco," +
                        "cc_complemento=@Complemento," +
                        "cc_bairro=@Bairro," +
                        "cc_cidade=@Cidade," +
                        "cc_uf=@UF," +
                        "cc_naturalidade=@Naturalidade," +
                        "cc_data_nasc=@DataNasc," +
                        "cc_estado_civil=@EstadoCivil," +
                        "cc_credito=@Credito," +
                        "cc_saldo=@Saldo," +
                        "cc_bloqueio=@Bloqueio," +
                        "cc_celular=@Celular," +
                        "cc_tel_residencial=@Tel_Residencial," +
                        "cc_email=@Email," +
                        "cc_observacoes=@Observacoes " +
                        "where cc_cpf_cnpj=@CPF_CNPJ";

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

        #endregion Atualizar Cadastro Cliente

        #region Atualizar Imagem Cliente

        public void AtualizarImagemNoCadastroCliente(Image _imagem, int _cc_id)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_ImagemCliente set ic_imagem=@imagem where ic_id = @cc_id ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(_imagem, typeof(byte[]));
                    adapter.SelectCommand.Parameters.Add("@imagem", SqlDbType.Image).Value = arr;
                    adapter.SelectCommand.Parameters.AddWithValue("@cc_id", SqlDbType.VarChar).Value = _cc_id;

                    adapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarImagemClienteNoBanco(ex);
            }
        }

        #endregion Atualizar Imagem Cliente
    }
}