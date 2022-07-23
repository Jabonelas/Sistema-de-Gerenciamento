using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;
using Bunifu.UI.WinForms;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class BuscarNoBanco : ConectarBanco
    {
        private MensagensErro Erro = new MensagensErro();

        #region Buscar Cliente

        #region Buscar Cliente Por Codigo

        public bool BuscarCadastroClientePorCodigo(string _cc_id, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select cc_id,cc_data_cadastro,cc_nome_cliente,cc_tipo,cc_cpf_cnpj,cc_rg,cc_emissor," +
                        "cc_data_emissao,cc_ins_est,cc_cep,cc_endereco,cc_numero,cc_complemento,cc_bairro,cc_cidade,cc_uf," +
                        "cc_naturalidade,cc_data_nasc,cc_estado_civil,cc_credito,cc_saldo,cc_bloqueio,cc_celular,cc_tel_residencial," +
                        "cc_email,cc_observacoes " +
                        "from tb_CadastroClientes where cc_id = @cc_id ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@cc_id", _cc_id);

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
                Erro.ErroAoBuscarClienteNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Cliente Por Codigo

        #region Buscar Cliente Por  CPF/CNPJ

        public bool BuscarCadastroClienteCPF_CNPJ(string _cpf_cnpj, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cc_id,cc_data_cadastro,cc_nome_cliente,cc_tipo,cc_cpf_cnpj,cc_rg,cc_emissor," +
                        "cc_data_emissao,cc_ins_est,cc_cep,cc_endereco,cc_numero,cc_complemento,cc_bairro,cc_cidade,cc_uf," +
                        "cc_naturalidade,cc_data_nasc,cc_estado_civil,cc_credito,cc_saldo,cc_bloqueio,cc_celular,cc_tel_residencial," +
                        "cc_email,cc_observacoes " +
                        "from tb_CadastroClientes where cc_cpf_cnpj = @cpf_cnpj";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@cpf_cnpj", _cpf_cnpj);

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
                Erro.ErroAoBuscarClienteNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Cliente Por  CPF/CNPJ

        #region Buscar Cliente Por RG

        public bool BuscarCadastroClienteRG(string _rg, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select cc_id,cc_data_cadastro,cc_nome_cliente,cc_tipo,cc_cpf_cnpj,cc_rg,cc_emissor," +
                        "cc_data_emissao,cc_ins_est,cc_cep,cc_endereco,cc_numero,cc_complemento,cc_bairro,cc_cidade,cc_uf," +
                        "cc_naturalidade,cc_data_nasc,cc_estado_civil,cc_credito,cc_saldo,cc_bloqueio,cc_celular,cc_tel_residencial," +
                        "cc_email,cc_observacoes " +
                        "from tb_CadastroClientes where cc_rg = @rg";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@rg", _rg);

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
                Erro.ErroAoBuscarClienteNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Cliente Por RG

        #region Buscar Cliente Por Nome

        public bool BuscarCadastroClientePorNome(string _nomeCliente, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select cc_id,cc_data_cadastro,cc_nome_cliente,cc_tipo,cc_cpf_cnpj,cc_rg,cc_emissor," +
                        "cc_data_emissao,cc_ins_est,cc_cep,cc_endereco,cc_numero,cc_complemento,cc_bairro,cc_cidade,cc_uf," +
                        "cc_naturalidade,cc_data_nasc,cc_estado_civil,cc_credito,cc_saldo,cc_bloqueio,cc_celular,cc_tel_residencial," +
                        "cc_email,cc_observacoes " +
                        "from tb_CadastroClientes where cc_nome_cliente like @nomeCliente";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
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
                Erro.ErroAoBuscarClienteNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Cliente Por Nome

        #region Buscar Codigo de Cliente Por Nome

        public int BuscarIdClientePorNome(string _nomeCliente)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cc_id from tb_CadastroClientes where cc_nome_cliente like @nomeCliente";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@nomeCliente", string.Format("%{0}%", _nomeCliente));

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    int x = dr.GetInt32(0);
                    return x;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarClienteNoBanco(ex);

                return 0;
            }
        }

        #endregion Buscar Codigo de Cliente Por Nome

        #region Buscar Tudo Cliente

        public bool BuscarCadastroClienteTudo(BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select cc_id,cc_data_cadastro,cc_nome_cliente,cc_tipo,cc_cpf_cnpj,cc_rg,cc_emissor," +
                        "cc_data_emissao,cc_ins_est,cc_cep,cc_endereco,cc_numero,cc_complemento,cc_bairro,cc_cidade,cc_uf," +
                        "cc_naturalidade,cc_data_nasc,cc_estado_civil,cc_credito,cc_saldo,cc_bloqueio,cc_celular,cc_tel_residencial," +
                        "cc_email,cc_observacoes " +
                        "from tb_CadastroClientes";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

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
                Erro.ErroAoBuscarClienteNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Tudo Cliente

        #region Buscar Imagem Cliente

        public Image BuscarImagemCliente(int _cc_id)
        {
            Image imagem;
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

                    imagem = System.Drawing.Image.FromStream(ms);
                    return imagem;

                    //cadastroCliente.pcbCliente.Image = System.Drawing.Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                return null;
                Erro.ErroAoBuscarImagemClienteNoBanco(ex);
            }
        }

        #endregion Buscar Imagem Cliente

        #region Buscar Lista de Cliente

        public List<string> BuscarListaCliente()

        {
            try
            {
                List<string> ListaCliente = new List<string>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cc_nome_cliente from tb_CadastroClientes order by cc_nome_cliente desc";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        ListaCliente.Add(dr.GetString(0));
                    }

                    return ListaCliente;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarListaClienteNoBanco(ex);

                return new List<string>();
            }
        }

        #endregion Buscar Lista de Cliente

        #region Buscar Cliente Por Pesquisa

        public List<DadosCliente> BuscarClientePorPesquisa(string _nomeCliente)

        {
            List<DadosCliente> listaCliente = new List<DadosCliente>();
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select cc_nome_cliente, cc_id, cc_cpf_cnpj from tb_CadastroClientes" +
                        " where cc_nome_cliente like @nomeCliente";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@nomeCliente", string.Format("%{0}%", _nomeCliente));

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        listaCliente.Add(new DadosCliente(dr.GetString(0), dr.GetInt32(1), dr.GetString(2)));
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarListaClienteNoBanco(ex);
            }

            return listaCliente;
        }

        #endregion Buscar Cliente Por Pesquisa

        #endregion Buscar Cliente

        #region Buscar Fornecedor

        #region Buscar Fornecedor Por Codigo

        public bool BuscarCadastroFornecedorPorCodigo(string _cf_id, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select cf_id,cf_razao_social,cf_data_cadastro,cf_cnpj,cf_nome_fantasia,cf_cep,cf_endereco,cf_complemento," +
                        "cf_numero,cf_bairro,cf_cidade,cf_uf,cf_telefone,cf_email,cf_observacoes " +
                        "from tb_CadastroFornecedor where cf_id = @cf_id";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@cf_id", _cf_id);

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
                Erro.ErroAoBuscarFornecedorNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Fornecedor Por Codigo

        #region Buscar Forncedor Por CNPJ

        public bool BuscarCadastroFornecedorPorCNPJ(string _cnpj, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select cf_id,cf_razao_social,cf_data_cadastro,cf_cnpj,cf_nome_fantasia,cf_cep,cf_endereco,cf_complemento," +
                        "cf_numero,cf_bairro,cf_cidade,cf_uf,cf_telefone,cf_email,cf_observacoes " +
                        "from tb_CadastroFornecedor where cf_cnpj = @cnpj";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@cnpj", _cnpj);

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
                Erro.ErroAoBuscarFornecedorNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Forncedor Por CNPJ

        #region Buscar Fornecedor Por Nome Fantasia

        public bool BuscarCadastroFornecedorPorNomeFantasia(string _nomeFantasia, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select cf_id,cf_razao_social,cf_data_cadastro,cf_cnpj,cf_nome_fantasia,cf_cep,cf_endereco,cf_complemento," +
                        "cf_numero,cf_bairro,cf_cidade,cf_uf,cf_telefone,cf_email,cf_observacoes " +
                        "from tb_CadastroFornecedor where cf_nome_fantasia like @nomeFantasia";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@nomeFantasia",
                        string.Format("%{0}%", _nomeFantasia));

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
                Erro.ErroAoBuscarFornecedorNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Fornecedor Por Nome Fantasia

        #region Buscar Tudo Fornecedor

        public bool BuscarCadastroFornecedorTudo(BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select cf_id,cf_razao_social,cf_data_cadastro,cf_cnpj,cf_nome_fantasia,cf_cep,cf_endereco,cf_complemento," +
                        "cf_numero,cf_bairro,cf_cidade,cf_uf,cf_telefone,cf_email,cf_observacoes " +
                        "from tb_CadastroFornecedor";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

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
                Erro.ErroAoBuscarFornecedorNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Tudo Fornecedor

        #region Buscar Imagem Fornecedor

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
                Erro.ErroAoBuscarImagemFornecedorNoBanco(ex);
                return null;
            }
        }

        #endregion Buscar Imagem Fornecedor

        #endregion Buscar Fornecedor

        #region Buscar Produto

        #region Buscar Lista Grupo Produto Para ComboBox

        public List<DadosGrupoMaterial> BuscarGrupoProduto()
        {
            try
            {
                List<DadosGrupoMaterial> listaGrupo = new List<DadosGrupoMaterial>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select distinct cg_grupo from tb_CadastroGrupoMaterial";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        listaGrupo.Add(new DadosGrupoMaterial(dr.GetString(0)));
                    }

                    return listaGrupo;
                }
            }
            catch (Exception ex)
            {
                return new List<DadosGrupoMaterial>();

                Erro.ErroAoBuscarGrupoProdutoNoBanco(ex);
            }
        }

        #endregion Buscar Lista Grupo Produto Para ComboBox

        #region Buscar Lista De Sug-Grupo Produto Para ComboBox

        public List<DadosSubGrupoMaterial> BuscarSubGrupoProduto(string _grupo)
        {
            try
            {
                List<DadosSubGrupoMaterial> listaGrupo = new List<DadosSubGrupoMaterial>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select distinct cg_sub_grupo from tb_CadastroGrupoMaterial where cg_grupo = @grupo";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@grupo", _grupo);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        listaGrupo.Add(new DadosSubGrupoMaterial(dr.GetString(0)));
                    }

                    return listaGrupo;
                }
            }
            catch (Exception ex)
            {
                return new List<DadosSubGrupoMaterial>();

                Erro.ErroAoBuscarSubGrupoProdutoNoBanco(ex);
            }
        }

        #endregion Buscar Lista De Sug-Grupo Produto Para ComboBox

        #region Buscar Lista Fornecedor Produto Para ComboBox

        public List<string> BuscarListaForcedor()
        {
            try
            {
                List<string> ListaFornecedor = new List<string>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cf_nome_fantasia from tb_CadastroFornecedor";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        ListaFornecedor.Add(dr.GetString(0));
                    }

                    return ListaFornecedor;
                }
            }
            catch (Exception ex)
            {
                return new List<string>();

                Erro.ErroAoBuscarListaFornecedorNoBanco(ex);
            }
        }

        #endregion Buscar Lista Fornecedor Produto Para ComboBox

        #region Buscar Produto Por Codigo

        public bool BuscarCadastroProdutoPorCodigo(int _cp_id, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cp_id,cp_descricao,cp_un,cp_valor_custo,cp_porcentagem,cp_valor_venda," +
                                   "cp_lucro,cp_preco_atacado,cp_grupo,cp_sub_grupo,cp_fonecedor,cp_estoque_minimo," +
                                   "cp_garantia,cp_marca,cp_referencia,cp_validade,cp_comissao,cp_observacao " +
                                   "from tb_CadastroProdutos " +
                                   "where cp_id = @cp_id";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@cp_id", _cp_id);

                    adapter.SelectCommand.ExecuteNonQuery();

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
                Erro.ErroAoBuscarCadastroProdutoPorCodigoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Produto Por Codigo

        #region Buscar Produto Por Descricao

        public bool BuscarCadastroProdutoPorDescricao(string _descricao, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cp_id,cp_descricao,cp_un,cp_valor_custo,cp_porcentagem,cp_valor_venda," +
                                   "cp_lucro,cp_preco_atacado,cp_grupo,cp_sub_grupo,cp_fonecedor,cp_estoque_minimo," +
                                   "cp_garantia,cp_marca,cp_referencia,cp_validade,cp_comissao,cp_observacao " +
                                   "from tb_CadastroProdutos " +
                                   "where cp_descricao like @descricao";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@descricao", string.Format("%{0}%", _descricao));

                    adapter.SelectCommand.ExecuteNonQuery();

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
                Erro.ErroAoBuscarCadastroProdutoPorDescricaoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Produto Por Descricao

        #region Buscar Produto Por Grupo

        public bool BuscarCadastroProdutoPorGrupo(string _grupo, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cp_id,cp_descricao,cp_un,cp_valor_custo,cp_porcentagem,cp_valor_venda," +
                                   "cp_lucro,cp_preco_atacado,cp_grupo,cp_sub_grupo,cp_fonecedor,cp_estoque_minimo," +
                                   "cp_garantia,cp_marca,cp_referencia,cp_validade,cp_comissao,cp_observacao " +
                                   "from tb_CadastroProdutos " +
                                   "where cp_grupo like @grupo";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@grupo", string.Format("%{0}%", _grupo));

                    adapter.SelectCommand.ExecuteNonQuery();

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
                Erro.ErroAoBuscarCadastroProdutoPorGrupoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Produto Por Grupo

        #region Buscar Produto Por Sub-Grupo

        public bool BuscarCadastroProdutoPorSubGrupo(string _subGrupo, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cp_id,cp_descricao,cp_un,cp_valor_custo,cp_porcentagem,cp_valor_venda,cp_lucro," +
                                   "cp_preco_atacado,cp_grupo,cp_sub_grupo,cp_fonecedor,cp_estoque_minimo,cp_garantia,cp_marca," +
                                   "cp_referencia,cp_validade,cp_comissao,cp_observacao " +
                                   "from tb_CadastroProdutos " +
                                   "where cp_sub_grupo like @subGrupo";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@subGrupo", string.Format("%{0}%", _subGrupo));

                    adapter.SelectCommand.ExecuteNonQuery();

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
                Erro.ErroAoBuscarCadastroProdutoPorSubGrupoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Produto Por Sub-Grupo

        #region Buscar Produto Por Marca

        public bool BuscarCadastroProdutoPorMarca(string _marca, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cp_id,cp_descricao,cp_un,cp_valor_custo,cp_porcentagem,cp_valor_venda," +
                                   "cp_lucro,cp_preco_atacado,cp_grupo,cp_sub_grupo,cp_fonecedor,cp_estoque_minimo," +
                                   "cp_garantia,cp_marca,cp_referencia,cp_validade,cp_comissao,cp_observacao " +
                                   "from tb_CadastroProdutos " +
                                   "where cp_marca like @marca";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@marca", string.Format("%{0}%", _marca));

                    adapter.SelectCommand.ExecuteNonQuery();

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
                Erro.ErroAoBuscarCadastroProdutoPorMarcaNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Produto Por Marca

        #region Buscar Tudo Produto

        public bool BuscarCadastroProdutoTudo(BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cp_id,cp_descricao,cp_un,cp_valor_custo,cp_porcentagem,cp_valor_venda," +
                                   "cp_lucro,cp_preco_atacado,cp_grupo,cp_sub_grupo,cp_fonecedor,cp_estoque_minimo," +
                                   "cp_garantia,cp_marca,cp_referencia,cp_validade,cp_comissao,cp_observacao " +
                                   "from tb_CadastroProdutos ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.ExecuteNonQuery();

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
                Erro.ErroAoBuscarProdutoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Tudo Produto

        #region Buscar Imagem Produto

        public Image BuscarImagemProduto(int _cp_id)
        {
            Image imagem;
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ip_imagem from tb_ImagemProdutos where ip_id = @cp_id";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@cp_id", _cp_id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                    }

                    byte[] img = (byte[])(reader["ip_imagem"]);
                    MemoryStream ms = new MemoryStream(img);

                    imagem = System.Drawing.Image.FromStream(ms);
                    return imagem;

                    //cadastroCliente.pcbCliente.Image = System.Drawing.Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                return null;
                Erro.ErroAoBuscarImagemProdutoNoBanco(ex);
            }
        }

        #endregion Buscar Imagem Produto

        #region Buscar Produto Por Pesquisa

        public List<DadosProduto> BuscarListaProdutos()

        {
            List<DadosProduto> listaProduto = new List<DadosProduto>();

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ep_codigo_produto,ep_descricao,ep_quantidade,ep_unidade," +
                        "ep_valor_unitario,ep_desconto_por_item,ep_codigo_barras,ep_nf_entrada  " +
                        "from tb_EstoqueProduto where ep_quantidade >= 0";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        listaProduto.Add(new DadosProduto(dr.GetInt32(0), dr.GetString(1),
                            dr.GetDecimal(2), dr.GetString(3), dr.GetDecimal(4), dr.GetDecimal(5),
                            dr.GetInt32(6), dr.GetInt32(7)));
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarProdutoPorPesquisaNoBanco(ex);
            }

            return listaProduto;
        }

        #endregion Buscar Produto Por Pesquisa

        #region Buscar O Desconto Por Item

        public decimal BuscarDesontoPorItem(string _produto)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select distinct ep_desconto_por_item " +
                                   "from tb_EstoqueProduto " +
                                   "where ep_descricao = @descricaoProduto";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@descricaoProduto", _produto);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    decimal x = dr.GetDecimal(0);
                    return x;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarDescontoProdutoNoBanco(ex);
                return 0;
            }
        }

        #endregion Buscar O Desconto Por Item

        #region Buscar Comissao

        public decimal Comissao()
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select fn_comissao from tb_Financeiro";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    dr.Read();

                    decimal x = dr.GetDecimal(0);

                    return x;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarComissaoProdutoNoBanco(ex);
                return 0;
            }
        }

        #endregion Buscar Comissao

        #region Buscar Codigo de Barras

        public bool BuscarCodigoBarras(int _codigoBarras)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ep_codigo_barras " +
                                   "from tb_EstoqueProduto " +
                                   "where ep_codigo_barras = @codigoBarras";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codigoBarras", _codigoBarras);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    dr.Read();

                    if (dr.HasRows == true)
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
                Erro.ErroAoBuscarCodigoBarrasProdutoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Codigo de Barras

        public bool BuscarExistenciaCodigoBarrasCadastrado(int _codigoBarras)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ep_codigo_barras " +
                                   "from tb_EstoqueProduto " +
                                   "where ep_codigo_barras = @codigoBarras ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.AddWithValue("@codigoBarras", _codigoBarras);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    dr.Read();

                    if (dr.HasRows == true)
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
                Erro.ErroAoBuscarExistenciaCodigoBarrasProdutoNoBanco(ex);

                return false;
            }
        }

        public bool BuscarExistenciaCodigoBarrasComMesmoCodigoProduto(int _codigoBarras, int _codigoProduto)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ep_codigo_barras " +
                                   "from tb_EstoqueProduto " +
                                   "where ep_codigo_barras = @codigoBarras and ep_codigo_produto = @codigoProduto";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.AddWithValue("@codigoBarras", _codigoBarras);
                    adapter.SelectCommand.Parameters.AddWithValue("@codigoProduto", _codigoProduto);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    dr.Read();

                    if (dr.HasRows == true)
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
                Erro.ErroAoBuscarCodigoBarrasDoMesmoProdutoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Produto

        #region Buscar Empresa

        #region Buscar Cadastro Empresa

        public bool BuscarCadastroEmpresa(int _ce_id, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    //string query ="select ce_razao_social,ce_cnpj,ce_nome_fantasia,ce_cep,ce_endereco,ce_complemento," +
                    //    "ce_bairro,ce_cidade,ce_uf,ce_numero,ce_telefone,ce_email,ce_texto_padrao_os " +
                    //    "from tb_CadastroEmpresa where ce_id = @ce_id";

                    string query = "select * from tb_CadastroEmpresa where ce_id = @ce_id";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@ce_id", _ce_id);

                    adapter.SelectCommand.ExecuteNonQuery();

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
                Erro.ErroAoBuscarEmpresaNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Cadastro Empresa

        #region Buscar Imagem Empresa

        public Image BuscarLogoEmpresa(int _ce_id)
        {
            Image logoEmpresa;
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ce_logo_empresa from tb_CadastroEmpresa where ce_id = @ce_id";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@ce_id", _ce_id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                    }

                    byte[] img = (byte[])(reader["ce_logo_empresa"]);
                    MemoryStream ms = new MemoryStream(img);

                    logoEmpresa = System.Drawing.Image.FromStream(ms);
                    return logoEmpresa;
                }
            }
            catch (Exception ex)
            {
                return null;
                Erro.ErroAoBuscarImagemEmpresaNoBanco(ex);
            }
        }

        #endregion Buscar Imagem Empresa

        #region Buscar QRCode Pix

        public Image BuscarQrCodePix(int _ce_id)
        {
            Image qrCode;
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ce_qr_code from tb_CadastroEmpresa where ce_id = @ce_id";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@ce_id", _ce_id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                    }

                    byte[] img = (byte[])(reader["ce_qr_code"]);
                    MemoryStream ms = new MemoryStream(img);

                    qrCode = System.Drawing.Image.FromStream(ms);
                    return qrCode;
                }
            }
            catch (Exception ex)
            {
                return null;
                Erro.ErroAoBuscarQRCodeNoBanco(ex);
            }
        }

        #endregion Buscar QRCode Pix

        #region BuscarChavePix

        public string BuscarChavePix()
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ce_chave_pix from tb_CadastroEmpresa";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    //adapter.SelectCommand.Parameters.AddWithValue("@ce_id", _ce_id);

                    adapter.SelectCommand.ExecuteNonQuery();

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    string x = dr.GetString(0);
                    return x;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion BuscarChavePix

        #endregion Buscar Empresa

        #region Buscar Usuario

        public bool BuscarUsuario(string _usuario, string _senha)
        {
            try
            {
                bool isExist;

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select * from tb_CadastroUsuario where cu_usuario = @usuario and cu_senha = @senha";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    SqlDataReader reader;
                    cmd.Parameters.AddWithValue("@usuario", _usuario);
                    cmd.Parameters.AddWithValue("@senha", _senha);

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
                Erro.ErroAoBuscarUsuarioNoBanco(ex);
                return false;
            }
        }

        #endregion Buscar Usuario

        #region Buscar Cadastro Despesa/Custo

        #region Buscar Codigo Despesa

        public int BuscarCodigoDespesa(string _descricao)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cd_id from tb_CadastroDespesaCustos where cd_descricao = @descricao";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@descricao", _descricao);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    int x = dr.GetInt32(0);
                    return x;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarCodigoDespesaNoBanco(ex);
                return 0;
            }
        }

        #endregion Buscar Codigo Despesa

        #region Buscar Despesa Por Codigo

        public bool BuscarCadastroDespesaPorCodigo(int _cd_id, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select * " +
                                   "from ttb_CadastroDespesaCustos where cd_id = @cd_id";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.AddWithValue("@cd_id", _cd_id);

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
                Erro.ErroAoBuscarCadastroDespesaPorCodigoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Despesa Por Codigo

        #region Buscar Despesa Por Descrição

        public bool BuscarCadastroDespesaPorDescricao(string _descricao, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select * " +
                                   "from tb_CadastroDespesaCustos where cd_descricao like @descricao";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.AddWithValue("@descricao", string.Format("%{0}%", _descricao));

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
                Erro.ErroAoBuscarCadastroDespesaPorDescricaoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Despesa Por Descrição

        #region Buscar Despesa Por Tipo

        public bool BuscarCadastroDespesaPorTipo(string _tipo, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select * " +
                                   "from tb_CadastroDespesaCustos where cd_tipo like @tipo";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.AddWithValue("@tipo", string.Format("%{0}%", _tipo));

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
                Erro.ErroAoBuscarCadastroDespesaPorTipoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Despesa Por Tipo

        #region Buscar Despesa Por Categoria

        public bool BuscarCadastroDespesaPorCategoria(string _categoria, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select * " +
                                   "from tb_CadastroDespesaCustos where cd_categoria = @categoria";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.AddWithValue("@Categoria", _categoria);

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
                Erro.ErroAoBuscarCadastroDespesaPorTipoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Despesa Por Categoria

        #region Buscar Tudo Despesa

        public bool BuscarCadastroTudoDespesa(BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select * " +
                                   "from tb_CadastroDespesaCustos";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

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
                Erro.ErroAoBuscarCadastroTudoDespesa(ex);

                return false;
            }
        }

        #endregion Buscar Tudo Despesa

        #region Buscar Lista Despesa

        public List<string> BuscarListaDespesa(string _categoria)
        {
            List<string> listaDespesa = new List<string>();

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select distinct cd_tipo " +
                                   "from tb_CadastroDespesaCustos " +
                                   "where cd_categoria = @categoria";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@categoria", _categoria);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        listaDespesa.Add(dr.GetString(0));
                    }
                }

                return listaDespesa;
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarListaDespesa(ex);

                return listaDespesa;
            }
        }

        #endregion Buscar Lista Despesa

        #region Buscar Lista Despesa Por Tipo

        public List<DadosCadastroDespesasCusto> BuscarListaDespesaPorTipo(string _tipo, string _categoria)
        {
            List<DadosCadastroDespesasCusto> listaDespesas = new List<DadosCadastroDespesasCusto>();

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select * " +
                                   "from tb_CadastroDespesaCustos " +
                                   "where cd_tipo like @tipo and cd_categoria = @categoria " +
                                   "order by cd_descricao asc";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.AddWithValue("@tipo", string.Format("%{0}%", _tipo));
                    adapter.SelectCommand.Parameters.AddWithValue("@categoria", _categoria);

                    SqlDataReader dr;
                    dr = adapter.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        listaDespesas.Add(new DadosCadastroDespesasCusto(dr.GetInt32(0), dr.GetString(1),
                            dr.GetString(2), dr.GetString(3)));
                    }
                }

                return listaDespesas;
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarCadastroDespesaPorTipoNoBanco(ex);

                return listaDespesas;
            }
        }

        #endregion Buscar Lista Despesa Por Tipo

        #endregion Buscar Cadastro Despesa/Custo

        #region Buscar Despesa/Custo

        #region Buscar Despesa Por Codigo

        public bool BuscarDespesaPorCogigo(int _codigo, string _categoria, BunifuDataGridView _tabela, string _statusPagamento)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select distinct dc_codigo, dc_tipo, dc_descricao, dc_fornecedor_titulo, dc_cnpj, dc_emissao, " +
                                   "dc_vencimento, dc_frequencia,dc_valor, dc_quantidade_parcelas, dc_valor_parcela, " +
                                   "dc_categoria, dc_estatus_pagamento " +
                                   "from tb_DespesasCustos " +
                                   "where dc_id = @codigo and dc_categoria = @categoria and dc_id = dc_codigo " +
                                   "and dc_estatus_pagamento = @estatusPagamento";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codigo", _codigo);
                    adapter.SelectCommand.Parameters.AddWithValue("@categoria", _categoria);
                    adapter.SelectCommand.Parameters.AddWithValue("@estatusPagamento", _statusPagamento);

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
                Erro.ErroAoBuscarDespesaPorCodigoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Despesa Por Codigo

        #region Buscar Despesa Por Tipo

        public bool BuscarDespesaPorTipo(string _tipo, string _categoria, BunifuDataGridView _tabela, string _statusPagamento)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select distinct dc_codigo, dc_tipo, dc_descricao, dc_fornecedor_titulo, dc_cnpj, dc_emissao, dc_vencimento, dc_frequencia," +
                                   "dc_valor, dc_quantidade_parcelas, dc_valor_parcela, dc_categoria, dc_estatus_pagamento " +
                                   "from tb_DespesasCustos " +
                                   "where dc_tipo = @tipo and dc_categoria = @categoria and dc_id = dc_codigo " +
                                   "and dc_estatus_pagamento = @estatusPagamento";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@tipo", _tipo);
                    adapter.SelectCommand.Parameters.AddWithValue("@categoria", _categoria);
                    adapter.SelectCommand.Parameters.AddWithValue("@estatusPagamento", _statusPagamento);

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
                Erro.ErroAoBuscarDespesaPorTipoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Despesa Por Tipo

        #region Buscar Despesa Por Titulo

        public bool BuscarDespesaPorTitulo(string _titulo, string _categoria, BunifuDataGridView _tabela, string _statusPagamento)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select distinct dc_codigo, dc_tipo, dc_descricao, dc_fornecedor_titulo, dc_cnpj, dc_emissao, dc_vencimento, dc_frequencia," +
                                   "dc_valor, dc_quantidade_parcelas, dc_valor_parcela, dc_categoria, dc_estatus_pagamento " +
                                   "from tb_DespesasCustos " +
                                   "where dc_fornecedor_titulo like @titulo and dc_categoria = @categoria and dc_id = dc_codigo " +
                                   "and dc_estatus_pagamento = @estatusPagamento";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.AddWithValue("@titulo", string.Format("%{0}%", _titulo));
                    adapter.SelectCommand.Parameters.AddWithValue("@categoria", _categoria);
                    adapter.SelectCommand.Parameters.AddWithValue("@estatusPagamento", _statusPagamento);

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
                Erro.ErroAoBuscarDespesaPorTituloNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Despesa Por Titulo

        #region Buscar Despesa Por Descricao

        public bool BuscarDespesaPorDescricao(string _descricao, string _categoria, BunifuDataGridView _tabela, string _statusPagamento)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select distinct dc_codigo, dc_tipo, dc_descricao, dc_fornecedor_titulo, dc_cnpj, dc_emissao, dc_vencimento, dc_frequencia," +
                                   "dc_valor, dc_quantidade_parcelas, dc_valor_parcela, dc_categoria, dc_estatus_pagamento " +
                                   "from tb_DespesasCustos " +
                                   "where dc_descricao like @descricao and dc_categoria = @categoria and dc_id = dc_codigo " +
                                   "and dc_estatus_pagamento = @estatusPagamento";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@descricao", string.Format("%{0}%", _descricao));
                    adapter.SelectCommand.Parameters.AddWithValue("@categoria", _categoria);
                    adapter.SelectCommand.Parameters.AddWithValue("@estatusPagamento", _statusPagamento);

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
                Erro.ErroAoBuscarDespesaPorDescricaoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Despesa Por Descricao

        #region Buscar Despesa

        public bool BuscarDespesa(string _categoria, BunifuDataGridView _tabela, string _statusPagamento)
        {
            //dc_quantidade_parcelas != 0 and

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select dc_codigo, dc_tipo, dc_descricao, dc_fornecedor_titulo, dc_cnpj, dc_emissao, dc_vencimento, dc_frequencia," +
                                   "dc_valor, dc_quantidade_parcelas, dc_valor_parcela, dc_categoria, dc_estatus_pagamento " +
                                   "from tb_DespesasCustos " +
                                   "where dc_categoria = @categoria and  dc_id = dc_codigo " +
                                   "and dc_estatus_pagamento = @estatusPagamento";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@categoria", _categoria);
                    adapter.SelectCommand.Parameters.AddWithValue("@estatusPagamento", _statusPagamento);

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
                Erro.ErroAoBuscarDespesaNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Despesa

        #region Buscar Despesa Codigo

        public int BuscarCodigo(string _descricao)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select dc_id from tb_DespesasCustos where dc_descricao = @descricao";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.AddWithValue("@descricao", _descricao);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    int x = dr.GetInt32(0);
                    return x;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarDespesaCodigoNoBanco(ex);

                return 0;
            }
        }

        #endregion Buscar Despesa Codigo

        #region Buscar Lista Despesa

        public List<DadosDespesaCusto> BuscarListaDespesaCusto(string _tipo, string _categoria)
        {
            List<DadosDespesaCusto> listaDespesas = new List<DadosDespesaCusto>();

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select dc_codigo, dc_tipo, dc_descricao, dc_fornecedor_titulo, dc_cnpj, dc_emissao, dc_vencimento," +
                                   "dc_frequencia,dc_valor,dc_quantidade_parcelas,dc_valor_parcela,dc_categoria, dc_verificar, dc_estatus_pagamento " +
                                   "from tb_DespesasCustos " +
                                   "where dc_tipo = @tipo and dc_categoria = @categoria";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.AddWithValue("@tipo", _tipo);
                    adapter.SelectCommand.Parameters.AddWithValue("@categoria", _categoria);

                    SqlDataReader dr;
                    dr = adapter.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        listaDespesas.Add(new DadosDespesaCusto(dr.GetInt32(0), dr.GetString(1),
                            dr.GetString(2), dr.GetString(3), dr.GetString(4),
                            dr.GetDateTime(5), dr.GetDateTime(6), dr.GetString(7),
                            dr.GetDecimal(8), dr.GetString(9), dr.GetDecimal(10),
                            dr.GetString(11), dr.GetString(12), dr.GetString(13)));
                    }
                }

                return listaDespesas;
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarListaDespesaNoBanco(ex);

                return listaDespesas;
            }
        }

        #endregion Buscar Lista Despesa

        #region Buscar Despesa/Custo Por Codigo

        public bool BuscarDespesaCustoPorCogigo(int _codigo, BunifuDataGridView _tabela, DateTime _dataInicial, DateTime _dataFinal)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select * " +
                                   "from tb_DespesasCustos " +
                                   "where dc_codigo = @codigo and dc_emissao >= @dataInicial and dc_vencimento <= @dataFinal " +
                                   "order by dc_vencimento asc ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codigo", _codigo);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataInicial", _dataInicial);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataFinal", _dataFinal);

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
                Erro.ErroAoBuscarDespesaCustoPorCodigoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Despesa/Custo Por Codigo

        public List<DadosDespesaCusto> BuscarListaDespesaCustoFixa()
        {
            List<DadosDespesaCusto> listaDespesas = new List<DadosDespesaCusto>();

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select dc_codigo,dc_tipo, dc_descricao, dc_fornecedor_titulo, dc_cnpj, dc_emissao, dc_vencimento," +
                                   "dc_frequencia,dc_valor,dc_quantidade_parcelas,dc_valor_parcela,dc_categoria,dc_verificar, dc_estatus_pagamento " +
                                   "from tb_DespesasCustos " +
                                   "where dc_tipo = 'Fixa'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    SqlDataReader dr;
                    dr = adapter.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        listaDespesas.Add(new DadosDespesaCusto(dr.GetInt32(0), dr.GetString(1),
                            dr.GetString(2), dr.GetString(3), dr.GetString(4),
                            dr.GetDateTime(5), dr.GetDateTime(6), dr.GetString(7),
                            dr.GetDecimal(8), dr.GetString(9), dr.GetDecimal(10),
                            dr.GetString(11), dr.GetString(12), dr.GetString(13)));
                    }
                }

                return listaDespesas;
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarDespesaCustoFixaNoBanco(ex);

                return listaDespesas;
            }
        }

        #region Buscar Lista Com Titulo Despesa e Custo

        public List<string> BuscarTitulo(string _categoria, string _tipo)
        {
            List<string> listaTitulo = new List<string>();

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select distinct dc_fornecedor_titulo " +
                                   "from tb_DespesasCustos " +
                                   "where dc_categoria = @categoria and dc_tipo = @tipo ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@categoria", _categoria);
                    adapter.SelectCommand.Parameters.AddWithValue("@tipo", _tipo);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows == true)
                    {
                        listaTitulo.Add(dr.GetString(0));
                    }
                    else
                    {
                    }
                }

                return listaTitulo;
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarListaTituloDespesaCustoNoBanco(ex);

                return listaTitulo;
            }
        }

        #endregion Buscar Lista Com Titulo Despesa e Custo

        #region Buscar Despesa Por Categoria/Tipo/Titulo

        public bool BuscarDespesaCustoPorTitulo(string _titulo, BunifuDataGridView _tabela, DateTime _dataInicial, DateTime _dataFinal)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select dc_id,dc_codigo, dc_tipo, dc_fornecedor_titulo, dc_descricao, dc_cnpj, dc_emissao, " +
                                   "dc_vencimento, dc_frequencia,dc_valor, dc_quantidade_parcelas, dc_valor_parcela, " +
                                   "dc_categoria,dc_estatus_pagamento, dc_imagem_pagamento,dc_data_pagamento, dc_desconto_taxas," +
                                   "dc_juros_multa, dc_valor_pago " +
                                   "from tb_DespesasCustos " +
                                   "where dc_fornecedor_titulo = @titulo and dc_vencimento >= @dataInicial and dc_vencimento <= @dataFinal " +
                                   "order by dc_vencimento asc ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@titulo", _titulo);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataInicial", _dataInicial);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataFinal", _dataFinal);

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
                Erro.ErroAoBuscarDespesaCustoPorTituloNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Despesa Por Categoria/Tipo/Titulo

        #region Buscar Despesa Por Descricao

        public bool BuscarDespesaCustoPorDescricao(string _descricao, BunifuDataGridView _tabela,
           DateTime _dataInicial, DateTime _dataFinal)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select dc_id,dc_codigo, dc_tipo, dc_fornecedor_titulo, dc_descricao, dc_cnpj, dc_emissao, " +
                                   "dc_vencimento, dc_frequencia,dc_valor, dc_quantidade_parcelas, dc_valor_parcela, " +
                                   "dc_categoria,dc_estatus_pagamento, dc_imagem_pagamento,dc_data_pagamento, dc_desconto_taxas," +
                                   "dc_juros_multa, dc_valor_pago " +
                                   "from tb_DespesasCustos " +
                                   "where dc_descricao like @descricao and dc_vencimento >= @dataInicial and dc_vencimento <= @dataFinal " +
                                   "order by dc_vencimento asc ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@descricao", string.Format("%{0}%", _descricao));
                    adapter.SelectCommand.Parameters.AddWithValue("@dataInicial", _dataInicial);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataFinal", _dataFinal);

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
                Erro.ErroAoBuscarDespesaCustoPorDescricaoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Despesa Por Descricao

        #region Buscar Despesa Por Status de Pagamentos

        public bool BuscarDespesaCustoPorStatusPagamento(string _statusPagamento, BunifuDataGridView _tabela,
            DateTime _dataInicial, DateTime _dataFinal)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select dc_id,dc_codigo, dc_tipo, dc_fornecedor_titulo, dc_descricao, dc_cnpj, dc_emissao, " +
                                   "dc_vencimento, dc_frequencia,dc_valor, dc_quantidade_parcelas, dc_valor_parcela, " +
                                   "dc_categoria,dc_estatus_pagamento, dc_imagem_pagamento,dc_data_pagamento, dc_desconto_taxas," +
                                   "dc_juros_multa, dc_valor_pago " +
                                   "from tb_DespesasCustos " +
                                   "where dc_estatus_pagamento = @estatusPagamento and dc_vencimento >= @dataInicial and dc_vencimento <= @dataFinal " +
                                   "order by dc_vencimento asc ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@estatusPagamento", _statusPagamento);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataInicial", _dataInicial);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataFinal", _dataFinal);

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
                Erro.ErroAoBuscarDespesaCustoStatusPagamentoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Despesa Por Status de Pagamentos

        #region Buscar Despesa e Custos

        public bool BuscarDespesaCusto(BunifuDataGridView _tabela, DateTime _dataInicial, DateTime _dataFinal)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select dc_id,dc_codigo, dc_tipo, dc_fornecedor_titulo, dc_descricao, dc_cnpj, dc_emissao, " +
                                   "dc_vencimento, dc_frequencia,dc_valor, dc_quantidade_parcelas, dc_valor_parcela, " +
                                   "dc_categoria,dc_estatus_pagamento, dc_imagem_pagamento,dc_data_pagamento, dc_desconto_taxas," +
                                   "dc_juros_multa, dc_valor_pago " +
                                   "from tb_DespesasCustos " +
                                   "where dc_vencimento >= @dataInicial and dc_vencimento <= @dataFinal " +
                                   "order by dc_vencimento asc ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataInicial", _dataInicial);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataFinal", _dataFinal);

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
                Erro.ErroAoBuscarDespesaCustoStatusNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Despesa e Custos

        #region Buscar Contas Pagas Por Data

        public decimal BuscarValorDespesaCustoPagas(DateTime _dataInicial, DateTime _dataFinal)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select sum(dc_valor_pago) " +
                                   "from tb_DespesasCustos " +
                                   "where dc_vencimento >= @dataInicial and dc_vencimento <= @dataFinal and " +
                                   "dc_estatus_pagamento = 'Pago'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataInicial", _dataInicial);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataFinal", _dataFinal);

                    SqlDataReader reader;
                    reader = adapter.SelectCommand.ExecuteReader();

                    reader.Read();

                    if (reader.IsDBNull(0) == true)
                    {
                        return 0;
                    }

                    decimal x = reader.GetDecimal(0);

                    return x;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarDespesaCustoValorPagoNoBanco(ex);

                return 0;
            }
        }

        #endregion Buscar Contas Pagas Por Data

        #region Buscar Valor Total de Contas Pagas

        public decimal BuscarValorTotalDespesaCustoPagas()
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select sum(dc_valor_pago) " +
                                   "from tb_DespesasCustos " +
                                   "where dc_estatus_pagamento = 'Pago'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    SqlDataReader reader;

                    reader = adapter.SelectCommand.ExecuteReader();

                    reader.Read();

                    if (reader.IsDBNull(0) == true)
                    {
                        return 0;
                    }

                    decimal x = reader.GetDecimal(0);

                    return x;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarDespesaCustoValorPagoTotalNoBanco(ex);

                return 0;
            }
        }

        #endregion Buscar Valor Total de Contas Pagas

        #region Buscar Contas Nao Pagas Por Data

        public decimal BuscarValorDespesaCustoNaoPagas(DateTime _dataInicial, DateTime _dataFinal)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select sum(dc_valor_parcela) " +
                                   "from tb_DespesasCustos " +
                                   "where dc_emissao >= @dataInicial and dc_vencimento <= @dataFinal and " +
                                   "dc_estatus_pagamento = 'Nao Pago'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataInicial", _dataInicial);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataFinal", _dataFinal);

                    SqlDataReader reader;
                    reader = adapter.SelectCommand.ExecuteReader();

                    reader.Read();

                    if (reader.IsDBNull(0) == true)
                    {
                        return 0;
                    }

                    decimal x = reader.GetDecimal(0);

                    return x;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarDespesaCustoValorNaoPagoNoBanco(ex);

                return 0;
            }
        }

        #endregion Buscar Contas Nao Pagas Por Data

        #region Buscar Contas Vencidas

        public decimal BuscarValorDespesaCustoVencidas(DateTime _dataInicial, DateTime _dataFinal)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select sum(dc_valor_parcela) " +
                                   "from tb_DespesasCustos " +
                                   "where dc_vencimento <= DATEADD(dd, 0, DATEDIFF(dd, 0, GETDATE())) and " +
                                   "dc_estatus_pagamento = 'Nao Pago'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataInicial", _dataInicial);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataFinal", _dataFinal);

                    SqlDataReader reader;
                    reader = adapter.SelectCommand.ExecuteReader();

                    reader.Read();

                    if (reader.IsDBNull(0) == true)
                    {
                        return 0;
                    }

                    decimal x = reader.GetDecimal(0);

                    return x;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarDespesaCustoVencidasNoBanco(ex);

                return 0;
            }
        }

        #endregion Buscar Contas Vencidas

        #endregion Buscar Despesa/Custo

        #region Buscar Vendas

        #region Buscar Numero de Nota Fiscal de Saida

        public string BuscarUltimaNotaFiscalSaida()
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "select ns_numero_nf from tb_NotaFiscalSaida " +
                    "where ns_numero_nf = (select max(ns_numero_nf) from tb_NotaFiscalSaida)";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                dr.Read();

                int x = dr.GetInt32(0);
                return (x + 1).ToString();
            }
        }

        public string ContarNFSaidaContinuacao()
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "select NF_Saida from NF_Saida where NF_Saida = (select max(NF_Saida) from NF_Saida)";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                dr.Read();

                int x = dr.GetInt32(0);
                return x.ToString();
            }
        }

        #endregion Buscar Numero de Nota Fiscal de Saida

        #region Buscar Estoque Produto Por Codigo De Barras

        public bool BuscarEstoqueProdutoPorCodigo(string ep_codigo_barras)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select * from tb_EstoqueProduto where ep_codigo_barras = @codigoBarras ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codigoBarras", ep_codigo_barras);

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
                Erro.ErroAoBuscarEstoqueProdutoNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Estoque Produto Por Codigo De Barras

        #region Buscar Financeiro

        public List<DadosFinanceiro> BuscarListaFinanceiro()

        {
            List<DadosFinanceiro> listaFinanceiro = new List<DadosFinanceiro>();

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select fn_desconto_avista,fn_juros_credito,fn_parcelas_credito,fn_prazo_carne,fn_juros_carne,fn_parcelas_carne " +
                        "from tb_Financeiro ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        listaFinanceiro.Add(new DadosFinanceiro(dr.GetDecimal(0), dr.GetDecimal(1),
                            dr.GetInt32(2), dr.GetInt32(3), dr.GetDecimal(4), dr.GetInt32(5)));
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarListaEstoqueProdutoNoBanco(ex);
            }

            return listaFinanceiro;
        }

        #endregion Buscar Financeiro

        #endregion Buscar Vendas

        #region Buscar Compra

        #region Buscar Nota Fiscal Entrada

        public List<DadosNotaFiscalEntrada> BuscarNotaFiscalEntrada(int _numeroNF)
        {
            List<DadosNotaFiscalEntrada> listaNotaFiscalEntrada = new List<DadosNotaFiscalEntrada>();

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select ne_indice,ne_numero_nf,ne_cnpj,ne_razao_social,ne_codigo_produto,ne_descricao_produto," +
                        "ne_quantidade,ne_unidade,ne_valor_unitario,ne_valor_total,ne_data_emissao,ne_data_lancamento " +
                        "from tb_NotaFiscalEntrada " +
                        "where ne_numero_nf = @numeroNF";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@numeroNF", _numeroNF);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        if (dr.IsDBNull(10) == true)
                        {
                            listaNotaFiscalEntrada.Add(new DadosNotaFiscalEntrada(
                                dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetString(3),
                                dr.GetInt32(4), dr.GetString(5), dr.GetDecimal(6),
                                dr.GetString(7), dr.GetDecimal(8), dr.GetDecimal(9),
                                null, dr.GetDateTime(11)));
                        }

                        if (dr.IsDBNull(11) == true)
                        {
                            listaNotaFiscalEntrada.Add(new DadosNotaFiscalEntrada(
                                dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetString(3),
                                dr.GetInt32(4), dr.GetString(5), dr.GetDecimal(6),
                                dr.GetString(7), dr.GetDecimal(8), dr.GetDecimal(9),
                                dr.GetDateTime(10), null));
                        }

                        if (dr.IsDBNull(10) == false && dr.IsDBNull(11) == false)
                        {
                            listaNotaFiscalEntrada.Add(new DadosNotaFiscalEntrada(
                                dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetString(3),
                                dr.GetInt32(4), dr.GetString(5), dr.GetDecimal(6),
                                dr.GetString(7), dr.GetDecimal(8), dr.GetDecimal(9),
                                dr.GetDateTime(10), dr.GetDateTime(11)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarNotaFiscalEntradaNoBanco(ex);
            }

            return listaNotaFiscalEntrada;
        }

        #endregion Buscar Nota Fiscal Entrada

        #region Buscar Nota Fiscal Entrada Para Preencher GridView

        public void BuscarNotaFiscalEntradaPreencherGridView(int _numeroNF, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select ne_indice,ne_numero_nf,ne_cnpj,ne_razao_social,ne_codigo_produto,ne_descricao_produto," +
                        "ne_quantidade,ne_unidade,ne_valor_unitario,ne_valor_total,ne_data_emissao,ne_data_lancamento " +
                        "from tb_NotaFiscalEntrada " +
                        "where ne_numero_nf = @numeroNF";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@numeroNF", _numeroNF);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    _tabela.DataSource = dataTable;
                    _tabela.Refresh();

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarNotaFiscalEntradaNoBanco(ex);
            }
        }

        #endregion Buscar Nota Fiscal Entrada Para Preencher GridView

        #region Buscar a Quantidade de Itens na Nota Fiscal

        public int BuscarQuantidadeDeItensNotaFiscalEntrada(int _numeroNF)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select count (ne_numero_nf) from tb_NotaFiscalEntrada where ne_numero_nf = @numeroNF";
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
                Erro.ErroAoBuscarNotaFiscalEntradaNoBanco(ex);

                return 0;
            }
        }

        #endregion Buscar a Quantidade de Itens na Nota Fiscal

        #region Valor Total da Nota Fiscal

        public decimal BuscarValorTotalNotaFiscalEntrada(int _numeroNF)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select SUM(ne_valor_total) " +
                                   "from tb_NotaFiscalEntrada " +
                                   "where ne_numero_nf = @numeroNF";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@numeroNF", _numeroNF);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    decimal x = dr.GetDecimal(0);

                    return x;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarValorTotalNotaFiscalEntradaNoBanco(ex);

                return 0;
            }
        }

        #endregion Valor Total da Nota Fiscal

        #region Buscar Quantidade de Cada Item da Nota Fiscal de Entrada

        public int BuscarQuantidadeDeCadaItemNotaFiscalEntrada(int _numeroNF, int _indice)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select ne_quantidade from tb_NotaFiscalEntrada where ne_numero_nf = @numeroNF and ne_indice = @indice ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@numeroNF", _numeroNF);
                    adapter.SelectCommand.Parameters.AddWithValue("@indice", _indice);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    decimal x = dr.GetDecimal(0);
                    return Convert.ToInt32(x);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarNotaFiscalEntradaNoBanco(ex);

                return 0;
            }
        }

        #endregion Buscar Quantidade de Cada Item da Nota Fiscal de Entrada

        #region Preencher Lista Estoque Produto

        public List<DadosEstoqueProduto> BuscarEstoqueProdutoListaProduto(int _numeroNF)
        {
            List<DadosEstoqueProduto> listaEstoqueProduto = new List<DadosEstoqueProduto>();

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ep_nf_entrada,ep_codigo_barras,ep_codigo_produto,ep_descricao," +
                                   "ep_quantidade,ep_unidade,ep_valor_unitario,ep_data_entrada,ep_desconto_por_item " +
                                   "from tb_EstoqueProduto " +
                                   "where ep_nf_entrada = @numeroNF";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@numeroNF", _numeroNF);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        if (dr.IsDBNull(1) == null && dr.IsDBNull(7) == null && dr.IsDBNull(8) == null)
                        {
                            listaEstoqueProduto.Add(new DadosEstoqueProduto(
                                dr.GetInt32(0), null, dr.GetInt32(2),
                                dr.GetString(3), dr.GetDecimal(4), dr.GetString(5),
                                dr.GetDecimal(6), null, null));
                        }
                        else if (dr.IsDBNull(1) != null && dr.IsDBNull(7) != null && dr.IsDBNull(8) != null)
                        {
                            listaEstoqueProduto.Add(new DadosEstoqueProduto(
                                dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2),
                                dr.GetString(3), dr.GetDecimal(4), dr.GetString(5),
                                dr.GetDecimal(6), dr.GetDateTime(7), dr.GetDecimal(8)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarNotaFiscalEntradaNoBanco(ex);
            }

            return listaEstoqueProduto;
        }

        #endregion Preencher Lista Estoque Produto

        #region PreencherGridView Com Dados do Estoque Produto

        public void BuscarEstoqueProdutoPreencherGridView(int _numeroNF, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ep_nf_entrada,ep_codigo_barras,ep_codigo_produto,ep_descricao," +
                                   "ep_quantidade,ep_unidade,ep_valor_unitario,ep_data_entrada,ep_desconto_por_item " +
                                   "from tb_EstoqueProduto " +
                                   "where ep_nf_entrada = @numeroNF and ep_quantidade >0";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@numeroNF", _numeroNF);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    _tabela.DataSource = dataTable;
                    _tabela.Refresh();

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarNotaFiscalEntradaNoBanco(ex);
            }
        }

        #endregion PreencherGridView Com Dados do Estoque Produto

        public List<DadosEstoqueProduto> BuscarListaEstoqueProdutoPorCodigoBarras(int _codigoBarras)
        {
            List<DadosEstoqueProduto> listaDadosEstoqueProdutos = new List<DadosEstoqueProduto>();

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ep_nf_entrada,ep_codigo_barras,ep_codigo_produto,ep_descricao," +
                                   "ep_quantidade,ep_unidade,ep_valor_unitario,ep_data_entrada,ep_desconto_por_item " +
                                   "from tb_EstoqueProduto " +
                                   "where ep_codigo_barras = @codigoBarras and ep_status = '-'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.Add("@codigoBarras", _codigoBarras);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        listaDadosEstoqueProdutos.Add(new DadosEstoqueProduto(dr.GetInt32(0), dr.GetInt32(1),
                            dr.GetInt32(2), dr.GetString(3), dr.GetDecimal(4), dr.GetString(5), dr.GetDecimal(6),
                            dr.GetDateTime(7), dr.GetDecimal(8)));
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarListaEstoqueProdutoPorCodidoBarrasNoBanco(ex);
            }

            return listaDadosEstoqueProdutos;
        }

        #endregion Buscar Compra

        #region Buscar Cliente Tela PDV

        public string BuscarClienteTelaPDVPorCPF(string _cpf)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cc_nome_cliente " +
                        "from tb_CadastroClientes " +
                        "where cc_cpf_cnpj = @cpf ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@cpf", _cpf);

                    adapter.SelectCommand.ExecuteNonQuery();

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    string x;

                    while (dr.Read())
                    {
                        if (dr.IsDBNull(0) == null)
                        {
                            x = "CLIENTE";
                            return x;
                        }
                        else if (dr.IsDBNull(0) != null)
                        {
                            x = dr.GetString(0);
                            return x;
                        }
                    }
                }
                return "CLIENTE";
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarClientePorCPFTelaPDVNoBanco(ex);

                return string.Empty;
            }
        }

        #endregion Buscar Cliente Tela PDV

        #region Buscar Produto Por Codigo

        public bool BuscarProdutoPorCodigo(int _codigoProduto)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())

                {
                    string query = "select * from tb_EstoqueProduto where ep_codigo_produto = @codigoProduto";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codigoProduto", _codigoProduto);

                    SqlDataReader reader = adapter.SelectCommand.ExecuteReader();

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
                Erro.ErroAoBuscarProdutoPorCodigoTelaPDVNoBanco(ex);

                return false;
            }
        }

        #endregion Buscar Produto Por Codigo

        //public bool BuscarVendaPorNotaFiscalSaida(int _notaFiscalSaida, BunifuDataGridView _tabela)
        public bool BuscarVendaPorNotaFiscalSaida(int _notaFiscalSaida)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select * from tb_NotaFiscalSaida where ns_numero_nf = @numeroNotaFiscalSaida";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.AddWithValue("@numeroNotaFiscalSaida", _notaFiscalSaida);

                    adapter.SelectCommand.ExecuteNonQuery();

                    //DataTable dataTable = new DataTable();

                    //adapter.Fill(dataTable);
                    //_tabela.DataSource = dataTable;
                    //_tabela.Refresh();

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
                Erro.ErroAoBuscarNotaFiscalSaidaNoBanco(ex);

                return false;
            }
        }

        #region Lista Nota Fiscal Saida

        public List<DadosNotaFiscalSaida> BuscarListaNotaFiscalSaidaParcial(int _numeroNotaFiscalSaida)
        {
            List<DadosNotaFiscalSaida> listaDadosNotaFiscalSaidaParcial = new List<DadosNotaFiscalSaida>();

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ns_vendedor, ns_garantia, ns_nome_cliente, ns_codigo_barras, ns_codigo_produto, " +
                        "ns_descricao, ns_quantidade, ns_unidade, ns_valor_pago, ns_valor_unitario " +
                        "from tb_NotaFiscalSaida where ns_numero_nf = @numeroNotaFiscalSaida ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@numeroNotaFiscalSaida", _numeroNotaFiscalSaida);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        listaDadosNotaFiscalSaidaParcial.Add(new DadosNotaFiscalSaida(dr.GetString(0), dr.GetDateTime(1),
                            dr.GetString(2), dr.GetInt32(3), dr.GetInt32(4), dr.GetString(5), dr.GetDecimal(6), dr.GetString(7),
                            dr.GetDecimal(8), dr.GetDecimal(9)));
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarListaNotaFiscalSaidaNoBanco(ex);
            }

            return listaDadosNotaFiscalSaidaParcial;
        }

        #endregion Lista Nota Fiscal Saida

        public List<DadosNotaFiscalSaida> BuscarListaNotaFiscalSaidaCompleto(int _numeroNotaFiscalSaida)
        {
            List<DadosNotaFiscalSaida> listadadosNotaFiscalSaidasCompleta = new List<DadosNotaFiscalSaida>();

            try
            {
                using (SqlConnection conexeSQL = AbrirConexao())
                {
                    string query = "select * from tb_NotaFiscalSaida where ns_numero_nf = @numeroNotaFiscalSaida";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexeSQL);

                    adapter.SelectCommand.Parameters.AddWithValue("@numeroNotaFiscalSaida", _numeroNotaFiscalSaida);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        listadadosNotaFiscalSaidasCompleta.Add(new DadosNotaFiscalSaida(
                            dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4), dr.GetString(5), dr.GetDateTime(6),
                            dr.GetInt32(7), dr.GetString(8), dr.GetDateTime(9), dr.GetDecimal(10), dr.GetDecimal(11), dr.GetString(12), dr.GetString(13),
                            dr.GetInt32(14), dr.GetDecimal(15), dr.GetDecimal(16), dr.GetDecimal(17), dr.GetString(18), dr.GetString(19), dr.GetString(20),
                            false, dr.GetInt32(21)));
                    }
                }

                return listadadosNotaFiscalSaidasCompleta;
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarListaPermissoesNotaFiscalSaidaCompetaNoBanco(ex);

                return listadadosNotaFiscalSaidasCompleta;
            }
        }

        public List<DadosPermissoes> BuscarListaPermissoes(string _usuario)
        {
            List<DadosPermissoes> listaPermissoes = new List<DadosPermissoes>();
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cu_excluir_item, cu_devolucao_troca, cu_cancelar_venda, cu_cancelar_pagamento " +
                        "from tb_CadastroUsuario where cu_usuario = @usuario";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@usuario", _usuario);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        listaPermissoes.Add(new DadosPermissoes(dr.GetString(0), dr.GetString(1),
                            dr.GetString(2), dr.GetString(3)));
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarListaPermissoesNotaFiscalSaidaNoBanco(ex);
            }
            return listaPermissoes;
        }
    }
}