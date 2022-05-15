using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class VerificacaoDeExistencia : ConectarBanco
    {
        private MensagensErro Erro = new MensagensErro();

        #region Cadastro Cliente

        public bool VerificarExistenciaDeCPF_CNPJ_Cliente(string _cPF_CNPJ)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    bool isExist = false;
                    string query = "select cc_cpf_cnpj from tb_CadastroClientes where cc_cpf_cnpj = @CPF_CNPJ";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@CPF_CNPJ", _cPF_CNPJ);
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows == true)
                    {
                        isExist = true;
                    }
                    else
                    {
                        isExist = false;
                    }

                    return isExist;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoVerificarExistenciaDeClienteNoBanco(ex);

                return false;
            }
        }

        #endregion Cadastro Cliente

        #region Cadastro Fornecedor

        public bool VerificarExistenciaDeCNPJFornecedor(string _cNPJ)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    bool isExist = false;
                    string query = "select cf_cnpj from tb_CadastroFornecedor where cf_cnpj = @CNPJ";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@CNPJ", _cNPJ);
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows == true)
                    {
                        isExist = true;
                    }
                    else
                    {
                        isExist = false;
                    }

                    return isExist;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoVerificarExistenciaDeFornecedorNoBanco(ex);

                return false;
            }
        }

        #endregion Cadastro Fornecedor

        #region Cadastro Produto

        public bool VerificarExistenciaDeDescricaoProduto(string _descricao)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    bool isExist = false;
                    string query = "select cp_descricao from tb_CadastroProdutos where cp_descricao = @descicao";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@descricao", _descricao);
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows == true)
                    {
                        isExist = true;
                    }
                    else
                    {
                        isExist = false;
                    }

                    return isExist;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoVerificarExistenciaDeProdutoNoBanco(ex);

                return false;
            }
        }

        #endregion Cadastro Produto
    }
}