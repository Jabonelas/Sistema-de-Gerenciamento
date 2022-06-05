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
                    string query = "select cc_id,cc_data_cadastro,cc_nome_cliente,cc_tipo,cc_cpf_cnpj,cc_rg,cc_emissor," +
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
                    string query = "select cc_id,cc_data_cadastro,cc_nome_cliente,cc_tipo,cc_cpf_cnpj,cc_rg,cc_emissor," +
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
                    string query = "select cc_id,cc_data_cadastro,cc_nome_cliente,cc_tipo,cc_cpf_cnpj,cc_rg,cc_emissor," +
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
                    string query = "select cc_nome_cliente,cc_id from tb_CadastroClientes where cc_nome_cliente like @nomeCliente";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@nomeCliente", string.Format("%{0}%", _nomeCliente));

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        listaCliente.Add(new DadosCliente(dr.GetString(0), dr.GetInt32(1)));
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
                    string query = "select cf_id,cf_razao_social,cf_data_cadastro,cf_cnpj,cf_nome_fantasia,cf_cep,cf_endereco,cf_complemento," +
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
                    string query = "select cf_id,cf_razao_social,cf_data_cadastro,cf_cnpj,cf_nome_fantasia,cf_cep,cf_endereco,cf_complemento," +
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
                    string query = "select cf_id,cf_razao_social,cf_data_cadastro,cf_cnpj,cf_nome_fantasia,cf_cep,cf_endereco,cf_complemento," +
                                   "cf_numero,cf_bairro,cf_cidade,cf_uf,cf_telefone,cf_email,cf_observacoes " +
                                   "from tb_CadastroFornecedor where cf_nome_fantasia like @nomeFantasia";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@nomeFantasia", string.Format("%{0}%", _nomeFantasia));

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
                    string query = "select cf_id,cf_razao_social,cf_data_cadastro,cf_cnpj,cf_nome_fantasia,cf_cep,cf_endereco,cf_complemento," +
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
                    string query =
                        "select cp_id," +
                        "cp_descricao," +
                        "cp_un," +
                        "cp_valor_custo," +
                        "cp_porcentagem," +
                        "cp_valor_venda," +
                        "cp_lucro," +
                        "cp_preco_atacado," +
                         "cp_grupo," +
                        "cp_sub_grupo," +
                        "cp_fonecedor," +
                        "cp_estoque_minimo," +
                        "cp_garantia," +
                        "cp_marca," +
                        "cp_referencia," +
                        "cp_validade," +
                        "cp_comissao," +
                        "cp_observacao " +
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
                Erro.ErroAoBuscarProdutoNoBanco(ex);

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
                    string query =
                        "select cp_id," +
                        "cp_descricao," +
                        "cp_un," +
                        "cp_valor_custo," +
                        "cp_porcentagem," +
                        "cp_valor_venda," +
                        "cp_lucro," +
                        "cp_preco_atacado," +
                         "cp_grupo," +
                        "cp_sub_grupo," +
                        "cp_fonecedor," +
                        "cp_estoque_minimo," +
                        "cp_garantia," +
                        "cp_marca," +
                        "cp_referencia," +
                        "cp_validade," +
                        "cp_comissao," +
                        "cp_observacao " +
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
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarProdutoNoBanco(ex);

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
                    string query =
                        "select cp_id," +
                        "cp_descricao," +
                        "cp_un," +
                        "cp_valor_custo," +
                        "cp_porcentagem," +
                        "cp_valor_venda," +
                        "cp_lucro," +
                        "cp_preco_atacado," +
                         "cp_grupo," +
                        "cp_sub_grupo," +
                        "cp_fonecedor," +
                        "cp_estoque_minimo," +
                        "cp_garantia," +
                        "cp_marca," +
                        "cp_referencia," +
                        "cp_validade," +
                        "cp_comissao," +
                        "cp_observacao " +
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
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarProdutoNoBanco(ex);

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
                    string query =
                        "select cp_id," +
                        "cp_descricao," +
                        "cp_un," +
                        "cp_valor_custo," +
                        "cp_porcentagem," +
                        "cp_valor_venda," +
                        "cp_lucro," +
                        "cp_preco_atacado," +
                         "cp_grupo," +
                        "cp_sub_grupo," +
                        "cp_fonecedor," +
                        "cp_estoque_minimo," +
                        "cp_garantia," +
                        "cp_marca," +
                        "cp_referencia," +
                        "cp_validade," +
                        "cp_comissao," +
                        "cp_observacao " +
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
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarProdutoNoBanco(ex);

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
                    string query =
                        "select cp_id," +
                        "cp_descricao," +
                        "cp_un," +
                        "cp_valor_custo," +
                        "cp_porcentagem," +
                        "cp_valor_venda," +
                        "cp_lucro," +
                        "cp_preco_atacado," +
                         "cp_grupo," +
                        "cp_sub_grupo," +
                        "cp_fonecedor," +
                        "cp_estoque_minimo," +
                        "cp_garantia," +
                        "cp_marca," +
                        "cp_referencia," +
                        "cp_validade," +
                        "cp_comissao," +
                        "cp_observacao " +
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
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarProdutoNoBanco(ex);

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
                    string query =
                        "select cp_id," +
                        "cp_descricao," +
                        "cp_un," +
                        "cp_valor_custo," +
                        "cp_porcentagem," +
                        "cp_valor_venda," +
                        "cp_lucro," +
                        "cp_preco_atacado," +
                        "cp_grupo," +
                        "cp_sub_grupo," +
                        "cp_fonecedor," +
                        "cp_estoque_minimo," +
                        "cp_garantia," +
                        "cp_marca," +
                        "cp_referencia," +
                        "cp_validade," +
                        "cp_comissao," +
                        "cp_observacao " +
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
                        return true;
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

        public List<DadosProduto> BuscarProdutos()

        {
            List<DadosProduto> listaProduto = new List<DadosProduto>();

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ep_codigo_produto,ep_descricao,ep_quantidade,ep_unidade,ep_valor_unitario,ep_desconto_por_item,ep_codigo_barras " +
                                   "from tb_EstoqueProduto";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        listaProduto.Add(new DadosProduto(dr.GetInt32(0), dr.GetString(1),
                            dr.GetDecimal(2), dr.GetString(3), dr.GetDecimal(4), dr.GetDecimal(5), dr.GetInt32(6)));
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
                    string query = "select distinct ep_desconto_por_item from tb_EstoqueProduto where ep_descricao = @descricaoProduto";
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

        #endregion Buscar Produto

        #region Buscar Empresa

        #region Buscar Cadastro Empresa

        public bool BuscarCadastroEmpresa(int _ce_id, BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ce_razao_social,ce_cnpj,ce_nome_fantasia,ce_cep,ce_endereco,ce_complemento," +
                                   "ce_bairro,ce_cidade,ce_uf,ce_numero,ce_telefone,ce_email,ce_texto_padrao_os " +
                                   "from tb_CadastroEmpresa where ce_id = @ce_id";

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

        public Image BuscarImagemEmpresa(int _ce_id)
        {
            Image imagem;
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ce_imagem from tb_CadastroEmpresa where ce_id = @ce_id";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@ce_id", _ce_id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                    }
                    byte[] img = (byte[])(reader["ce_imagem"]);
                    MemoryStream ms = new MemoryStream(img);

                    imagem = System.Drawing.Image.FromStream(ms);
                    return imagem;
                }
            }
            catch (Exception ex)
            {
                return null;
                Erro.ErroAoBuscarImagemEmpresaNoBanco(ex);
            }
        }

        #endregion Buscar Imagem Empresa

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

        #region Buscar Despesa

        #region Buscar Codigo Despesa

        public int BuscarCodigoDespesa(string _descricao)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cd_id from tb_CadastroDespesa where cd_descricao = @descricao";
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
                    string query = "select cd_id,cd_descricao,cd_tipo " +
                                   "from tb_CadastroDespesa where cd_id = @cd_id";

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
                    string query = "select cd_id,cd_descricao,cd_tipo " +
                                   "from tb_CadastroDespesa where cd_descricao like @descricao";

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
                    string query = "select cd_id,cd_descricao,cd_tipo " +
                                   "from tb_CadastroDespesa where cd_tipo like @tipo";

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

        #region Buscar Tudo Despesa

        public bool BuscarCadastroTudoDespesa(BunifuDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cd_id,cd_descricao,cd_tipo " +
                                   "from tb_CadastroDespesa";

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

        #endregion Buscar Despesa

        #region Buscar Vendas

        #region Buscar Numero de Nota Fiscal de Saida

        public string ContarNFSaidaGerando()
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "select NF_Saida from NF_Saida where NF_Saida = (select max(NF_Saida) from NF_Saida)";
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

        #region Buscar Estoque Produto

        public bool BuscarEstoqueProdutoPorCodigo(string ep_codigo_barras)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "select * from tb_EstoqueProduto where ep_codigo_barras = @codigoBarras ";

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

        #endregion Buscar Estoque Produto

        #region Buscar Financeiro

        public List<DadosFinanceiro> BuscarFinanceiro()

        {
            List<DadosFinanceiro> listaFinanceiro = new List<DadosFinanceiro>();

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select fn_desconto_avista,fn_juros_credito,fn_parcelas_credito,fn_prazo_carne,fn_juros_carne,fn_parcelas_carne " +
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
                Erro.ErroAoBuscarProdutoPorPesquisaNoBanco(ex);
            }

            return listaFinanceiro;
        }

        #endregion Buscar Financeiro

        #endregion Buscar Vendas

        #region Buscar Compra

        #region Buscar Nota Fiscal Entrada

        public List<DadosNotaFiscalEntrada> BuscarNotaFiscalEntrada(int _numeroNF, BunifuDataGridView _tabela)
        {
            List<DadosNotaFiscalEntrada> listaNotaFiscalEntrada = new List<DadosNotaFiscalEntrada>();

            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    //string query = "select * from tb_NotaFiscalEntrada " +
                    //               "where ne_numero_nf = @numeroNF";

                    string query = "select ne_numero_nf,ne_cnpj,ne_razao_social,ne_codigo_produto,ne_descricao_produto," +
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

                    while (dr.Read())
                    {
                        listaNotaFiscalEntrada.Add(new DadosNotaFiscalEntrada(
                            dr.GetInt32(0), dr.GetString(1), dr.GetString(2),
                            dr.GetInt32(3), dr.GetString(4), dr.GetDecimal(5),
                             dr.GetString(6), dr.GetDecimal(7), dr.GetDecimal(8),
                             dr.GetDateTime(9), dr.GetDateTime(10)));

                        //listaNotaFiscalEntrada.Add(new DadosNotaFiscalEntrada(dr.GetInt32(0),
                        //    dr.GetInt32(1), dr.GetString(2), dr.GetString(3),
                        //    dr.GetInt32(4), dr.GetString(5), dr.GetDecimal(6),
                        //    dr.GetString(7), dr.GetDecimal(8), dr.GetDecimal(9),
                        //    dr.GetDateTime(10), dr.GetDateTime(11)));
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

        #region Buscar a Quantidade de Itens na Nota Fiscal

        public int BuscarQuantidadeDeItensNotaFiscalEntrada(int _numeroNF)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    //string query = "select ne_numero_nf from tb_NotaFiscalEntrada where ne_numero_nf = @numeroNF ";
                    string query = "select count (ne_numero_nf) from tb_NotaFiscalEntrada where ne_numero_nf = @numeroNF";
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

        #region Buscar Quantidade de Cada Item da Nota Fiscal de Entrada

        public int BuscarQuantidadeDeCadaItemNotaFiscalEntrada(int _numeroNF, int _indice)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select ne_quantidade from tb_NotaFiscalEntrada where ne_numero_nf = @numeroNF and ne_indice = @indice ";
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

        #endregion Buscar Compra
    }
}