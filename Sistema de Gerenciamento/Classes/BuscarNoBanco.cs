﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class BuscarNoBanco : ConectarBanco
    {
        private MensagensErro Erro = new MensagensErro();

        //private CadastroCliente cadastroCliente;

        #region Buscar Cliente

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

        public bool BuscarCadastroClienteNome(string _nomeCliente, BunifuDataGridView _tabela)
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
                Erro.ErroAoBuscarImagemClienteNoBanco(ex);
            }
        }

        #endregion Buscar Imagem Cliente

        #region Buscar Codigo Cliente

        public int BuscarCodigoCliente(string _cpf_cnpj)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cc_id from tb_CadastroClientes where cc_cpf_cnpj = @cpf_cnpj ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@cpf_cnpj", _cpf_cnpj);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    int x = dr.GetInt32(0);
                    return x;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarCodigoClienteNoBanco(ex);
                return 0;
            }
        }

        #endregion Buscar Codigo Cliente

        #region Buscar Fornecedor

        #region Buscar Codigo Fornecedor

        public int BuscarCodigoFornecedor(string _cnpj)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cf_id from tb_CadastroFornecedor where cf_cnpj = @cnpj ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@cnpj", _cnpj);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    int x = dr.GetInt32(0);
                    return x;
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoBuscarCodigoFornecedorNoBanco(ex);
                return 0;
            }
        }

        #endregion Buscar Codigo Fornecedor

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
                return null;
                Erro.ErroAoBuscarImagemFornecedorNoBanco(ex);
            }
        }

        #endregion Buscar Imagem Fornecedor

        #endregion Buscar Fornecedor

        #region Buscar Produto

        #region Buscar Codigo Produto

        public int BuscarCodigoProduto(string _descricao)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select cp_id from tb_CadastroProdutos where cp_descricao = @descricao";
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
                Erro.ErroAoBuscarCodigoProdutoNoBanco(ex);
                return 0;
            }
        }

        #endregion Buscar Codigo Produto

        #region Buscar Lista Grupo Produto Para ComboBox

        public List<string> BuscarGrupoProduto()
        {
            try
            {
                List<string> Grupo = new List<string>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select distinct cg_grupo from tb_CadastroGrupoMaterial";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        Grupo.Add(dr.GetString(0));
                    }

                    return Grupo;
                }
            }
            catch (Exception ex)
            {
                return new List<string>();

                Erro.ErroAoBuscarGrupoProdutoNoBanco(ex);
            }
        }

        #endregion Buscar Lista Grupo Produto Para ComboBox

        #region Buscar Lista Sub-Grupo Produto Para ComboBox

        public List<string> BuscarSubGrupoProduto()
        {
            try
            {
                List<string> SubGrupo = new List<string>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select distinct cg_sub_grupo from tb_CadastroGrupoMaterial";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        SubGrupo.Add(dr.GetString(0));
                    }

                    return SubGrupo;
                }
            }
            catch (Exception ex)
            {
                return new List<string>();

                Erro.ErroAoBuscarSubGrupoProdutoNoBanco(ex);
            }
        }

        #endregion Buscar Lista Sub-Grupo Produto Para ComboBox

        #region Buscar Lista Fornecedor Produto Para ComboBox

        public List<string> BuscarListaForcedor()
        {
            try
            {
                List<string> ListaFornecedor = new List<string>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select distinct cf_nome_fantasia from tb_CadastroFornecedor";
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
            Image a;
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

                    a = System.Drawing.Image.FromStream(ms);
                    return a;

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

        #endregion Buscar Produto
    }
}