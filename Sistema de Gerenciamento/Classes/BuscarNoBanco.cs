using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.UI.WinForms;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class BuscarNoBanco : ConectarBanco
    {
        private MensagensErro Erro = new MensagensErro();

        //private CadastroCliente cadastroCliente;

        #region Buscar Cliente

        public bool BuscarCadastroCliente(string _cc_id, string _cPF_CNPJ, string _rG, string _nomeCliente, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cc_id,cc_data_cadastro,cc_nome_cliente,cc_tipo,cc_cpf_cnpj,cc_rg,cc_emissor," +
                        "cc_data_emissao,cc_ins_est,cc_cep,cc_endereco,cc_numero,cc_complemento,cc_bairro,cc_cidade,cc_uf," +
                        "cc_naturalidade,cc_data_nasc,cc_estado_civil,cc_credito,cc_saldo,cc_bloqueio,cc_celular,cc_tel_residencial," +
                        "cc_email,cc_observacoes " +
                        "from tb_CadastroClientes where cc_id = @cc_id or cc_cpf_cnpj = @cPF_CNPJ or cc_rg = @rG " +
                        "or cc_nome_cliente like @nomeCliente";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@cc_id", _cc_id);
                    adapter.SelectCommand.Parameters.AddWithValue("@cPF_CNPJ", _cPF_CNPJ);
                    adapter.SelectCommand.Parameters.AddWithValue("@rG", _rG);
                    adapter.SelectCommand.Parameters.AddWithValue("@nomeCliente", string.Format("%{0}%", _nomeCliente));

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    _tabela.DataSource = dataTable;
                    _tabela.Refresh();

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
                Erro.ErroAoBuscsarClienteNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Cliente

        #region Buscar Imagem Cliente

        public Image BuscarImagemCliente(int _cc_id)
        {
            Image a;
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ic_imagem from tb_ImagemCliente where ic_id = @cc_id";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@cc_id", _cc_id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                    }
                    byte[] img = (byte[])(reader["ic_imagem"]);
                    MemoryStream ms = new MemoryStream(img);

                    a = System.Drawing.Image.FromStream(ms);
                    return a;

                    //cadastroCliente.pcbCliente.Image = System.Drawing.Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                return null;
                Erro.ErroAoBuscsarImagemClienteNoBanco(ex);
            }
        }

        #endregion Buscar Imagem Cliente

        #region Buscar Codigo Cliente

        public int BuscarCodigoCliente(string _cPF_CNPJ)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cc_id from tb_CadastroClientes where cc_cpf_cnpj = @cPF_CNPJ ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@cPF_CNPJ", _cPF_CNPJ);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    int x = dr.GetInt32(0);
                    return x;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscsarCodigoClienteNoBanco(ex);
                return 0;
            }
        }

        #endregion Buscar Codigo Cliente

        #region Buscar Fornecedor

        public bool BuscarCadastroFornecedor(string _cf_id, string _cNPJ, string _razaoSocial, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cf_id,cf_razao_social,cf_data_cadastro,cf_cnpj,cf_nome_fantasia,cf_cep,cf_endereco,cf_complemento," +
                        "cf_numero,cf_bairro,cf_cidade,cf_uf,cf_telefone,cf_email,cf_observacoes " +
                        "from tb_CadastroFornecedor where cf_id = @cf_id or cf_cnpj = @cNPJ or cf_razao_social like @razaoSocial";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@cf_id", _cf_id);
                    adapter.SelectCommand.Parameters.AddWithValue("@cNPJ", _cNPJ);
                    adapter.SelectCommand.Parameters.AddWithValue("@razaoSocial", string.Format("%{0}%", _razaoSocial));

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    _tabela.DataSource = dataTable;
                    _tabela.Refresh();

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
                Erro.ErroAoBuscsarFornecedorNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Fornecedor

        #region Buscar Imagem Cliente

        public Image BuscarImagemFornecedor(int _cf_id)
        {
            Image imagem;

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select if_imagem from tb_ImagemFornecedor where if_id = @cf_id";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@cf_id", _cf_id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                    }
                    byte[] img = (byte[])(reader["if_imagem"]);
                    MemoryStream ms = new MemoryStream(img);

                    imagem = System.Drawing.Image.FromStream(ms);
                    return imagem;

                    //cadastroCliente.pcbCliente.Image = System.Drawing.Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                return null;
                Erro.ErroAoBuscsarImagemFornecedorNoBanco(ex);
            }
        }

        #endregion Buscar Imagem Cliente

        #region Buscar Codigo Fornecedor

        public int BuscarCodigoFornecedor(string _cNPJ)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cf_id from tb_CadastroFornecedor where cf_cnpj = @CNPJ ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@CNPJ", _cNPJ);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    int x = dr.GetInt32(0);
                    return x;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscsarCodigoFornecedorNoBanco(ex);
                return 0;
            }
        }

        #endregion Buscar Codigo Fornecedor
    }
}