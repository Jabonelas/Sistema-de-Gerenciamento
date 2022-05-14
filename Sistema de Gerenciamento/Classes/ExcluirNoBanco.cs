using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class ExcluirNoBanco : ConectarBanco
    {
        private MensagensErro Erro = new MensagensErro();

        #region Excluir Cadastro Cliente

        public void ExcluirCadastroCliente(string _cPF_CNPJ)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "delete tb_CadastroClientes where cc_cpf_cnpj = @CPF_CNPJ";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    cmd.Parameters.AddWithValue("@CPF_CNPJ", SqlDbType.VarChar).Value = _cPF_CNPJ;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirCadastroClienteNoBanco(ex);
            }
        }

        #endregion Excluir Cadastro Cliente

        #region Excluir Imagem Cliente

        public void ExcluirImagemCliente(int _codigo)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "delete tb_ImagemClientes where ic_id = @codigo";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    cmd.Parameters.AddWithValue("@codigo", SqlDbType.VarChar).Value = _codigo;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirImagemClienteNoBanco(ex);
            }
        }

        #endregion Excluir Imagem Cliente

        #region Excluir Cadastro Fornecedor

        public void ExcluirCadastroFornecedor(string _cNPJ)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "delete tb_CadastroFornecedor where cf_cnpj = @CNPJ";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    cmd.Parameters.AddWithValue("@CNPJ", SqlDbType.VarChar).Value = _cNPJ;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirCadastroFornecedorNoBanco(ex);
            }
        }

        #endregion Excluir Cadastro Fornecedor

        #region Excluir Imagem Fornecedor

        public void ExcluirImagemFornecedor(int _codigo)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "delete tb_ImagemFornecedor where if_id = @codigo";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    cmd.Parameters.AddWithValue("@codigo", SqlDbType.VarChar).Value = _codigo;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirImagemFornecedorNoBanco(ex);
            }
        }

        #endregion Excluir Imagem Fornecedor
    }
}