using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public bool VerificarExistenciaDeCNPJFornecedor(string _cnpj)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    bool isExist = false;
                    string query = "select cf_cnpj from tb_CadastroFornecedor where cf_cnpj = @cnpj";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@cnpj", _cnpj);
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
                    string query = "select cp_descricao from tb_CadastroProdutos where cp_descricao = @descricao";
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

        #region Cadastro Grupo Material

        public bool VerificarExistenciaSubGrupo(string _subGrupo)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    bool isExist = false;
                    string query = "select cg_sub_grupo from tb_CadastroGrupoMaterial where cg_sub_grupo = @subGrupo";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@subGrupo", _subGrupo);
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

        #endregion Cadastro Grupo Material

        #region Cadastro Usuario

        public bool VerificarExistenciaDoUsuario(string _usuario)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    bool isExist = false;
                    string query = "select cu_usuario from tb_CadastroUsuario where cu_usuario = @usuario";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@usuario", _usuario);
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
                Erro.ErroAoVerificarExistenciaDeUsuarioNoBanco(ex);

                return false;
            }
        }

        #endregion Cadastro Usuario

        #region Cadastro Despesas

        public bool VerificarExistenciaDeDespesa(string _descricao)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    bool isExist = false;
                    string query = "select cd_descricao from tb_CadastroDespesaCustos where cd_descricao = @cd_descricao";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@cd_descricao", _descricao);
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

        #endregion Cadastro Despesas

        #region Estoque Produto Verificar Se Já Foi Excluido

        public int VerificarSeEstoqueFoiConsumido(int _numeroNF)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select count (p.ep_quantidade) " +
                                   "from tb_EstoqueProduto as p inner join tb_NotaFiscalEntrada pe " +
                                   "on p.ep_quantidade = pe.ne_quantidade and " +
                                   "p.ep_codigo_produto = pe.ne_codigo_produto " +
                                   "where p.ep_nf_entrada = @numeroNF ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@numeroNF", _numeroNF);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    int x = dr.GetInt32(0);

                    return x;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoVerificarSeEstoqueFoiConsumidoNoBanco(ex);

                return 0;
            }
        }

        #endregion Estoque Produto Verificar Se Já Foi Excluido

        #region Estoque Produto Verificar Se Já Foi Dado Entrada

        public bool VerificarSeEstoqueFoiConsumidoSalvar(int _numeroNF)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select ep_quantidade " +
                        "from tb_EstoqueProduto " +
                        "where ep_quantidade >= 1 and ep_nf_entrada = @numeroNF";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@numeroNF", _numeroNF);

                    SqlDataReader reader;
                    reader = adapter.SelectCommand.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoVerificarSeEstoqueFoiConsumidoNoBanco(ex);

                return false;
            }
        }

        #endregion Estoque Produto Verificar Se Já Foi Dado Entrada
    }
}