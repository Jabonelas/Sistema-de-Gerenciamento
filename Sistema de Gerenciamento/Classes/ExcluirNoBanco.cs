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

        #region Excluir Cliente

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

                    AvisoCantoInferiorDireito.Exclusao();
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

                    AvisoCantoInferiorDireito.Exclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirImagemClienteNoBanco(ex);
            }
        }

        #endregion Excluir Imagem Cliente

        #endregion Excluir Cliente

        #region Excluir Forncedor

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

                    AvisoCantoInferiorDireito.Exclusao();
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

                    AvisoCantoInferiorDireito.Exclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirImagemFornecedorNoBanco(ex);
            }
        }

        #endregion Excluir Imagem Fornecedor

        #endregion Excluir Forncedor

        #region Excluir Produto

        #region Excluir Cadastro Produto

        public void ExcluirCadastroProduto(string _descricao)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "delete tb_CadastroProdutos where cp_descricao = @descricao";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    cmd.Parameters.AddWithValue("@descricao", SqlDbType.VarChar).Value = _descricao;

                    cmd.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Exclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirCadastroProdutoNoBanco(ex);
            }
        }

        #endregion Excluir Cadastro Produto

        #region Excluir Imagem Produto

        public void ExcluirImagemProduto(int _codigo)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "delete tb_ImagemProdutos where ip_id = @codigo";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    cmd.Parameters.AddWithValue("@codigo", SqlDbType.VarChar).Value = _codigo;

                    cmd.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Exclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirImagemProdutoNoBanco(ex);
            }
        }

        #endregion Excluir Imagem Produto

        #endregion Excluir Produto

        #region Excluir Grupo Material

        public void ExcluirCadastroGrupoMaterial(string _grupo, string _subGrupo)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "delete tb_CadastroGrupoMaterial where cg_grupo = @grupo and cg_sub_grupo = @subGrupo";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    cmd.Parameters.AddWithValue("@grupo", SqlDbType.VarChar).Value = _grupo;
                    cmd.Parameters.AddWithValue("@subGrupo", SqlDbType.VarChar).Value = _subGrupo;

                    cmd.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Exclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirCadastroGrupoMaterialNoBanco(ex);
            }
        }

        #endregion Excluir Grupo Material

        #region Excluir Cadastro Despesa

        public void ExcluirCadastroDespesa(int _cd_id, string _descricao)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "delete tb_CadastroDespesaCustos where cd_id = @cd_id and cd_descricao = @descricao";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    cmd.Parameters.AddWithValue("@cd_id", SqlDbType.VarChar).Value = _cd_id;
                    cmd.Parameters.AddWithValue("@descricao", SqlDbType.VarChar).Value = _descricao;

                    cmd.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Exclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirCadastroDespesaNoBanco(ex);
            }
        }

        #endregion Excluir Cadastro Despesa

        #region Excluir Despesa

        public void ExcluirDespesaCusto(int _codigo)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    //string query = "delete tb_DespesasCustos where dc_id = @codigo";
                    string query = "update tb_DespesasCustos set dc_estatus_pagamento = '-', dc_verificar = '-'" +
                        "where dc_codigo = @codigo and dc_vencimento >= (SELECT DATEADD(dd, 0, DATEDIFF(dd, 0, GETDATE())))";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    cmd.Parameters.AddWithValue("@codigo", _codigo);

                    cmd.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Exclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoExluirDespesaCustoNoBanco(ex);
            }
        }

        #endregion Excluir Despesa
    }
}