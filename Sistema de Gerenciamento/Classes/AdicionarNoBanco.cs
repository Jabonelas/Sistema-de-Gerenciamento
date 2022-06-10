using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Gerenciamento.Classes;

namespace Sistema_de_Gerenciamento
{
    internal class AdicionarNoBanco : ConectarBanco
    {
        private MensagensErro Erro = new MensagensErro();

        //private VerificacaoDeExistencia VerificarExistencia = new VerificacaoDeExistencia();

        #region Inserir Cliente

        #region Inserir Cadastro Cliente

        public int InserirCadastroCliente(DateTime _dataCadastro, string _nomeCliente, string _tipo, string _cpf_cnpj,
        string _rg, string _emissor, string _dataEmissao, string _ins_Est, string _cep, string _endereco, int _numero, string _complemento,
        string _bairro, string _cidade, string _uF, string _naturalidade, string _dataNasc, string _estadoCivil, decimal _credito,
        decimal _saldo, string _bloqueio, string _celular, string _tel_Residencial, string _email, string _observacoes, int _fk_ic_id)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_CadastroClientes (cc_data_cadastro,cc_nome_cliente," +
                        "cc_tipo,cc_cpf_cnpj,cc_rg,cc_emissor,cc_data_emissao,cc_ins_est,cc_cep,cc_endereco," +
                        "cc_numero,cc_complemento,cc_bairro,cc_cidade,cc_uf,cc_naturalidade,cc_data_nasc," +
                        "cc_estado_civil,cc_credito,cc_saldo,cc_bloqueio,cc_celular,cc_tel_residencial,cc_email,cc_observacoes,fk_ic_id) " +
                        "values (@DataCadastro,@NomeCliente,@Tipo,@cpf_cnpj," +
                        "@rg,@Emissor,@DataEmissao,@Ins_Est,@cep,@Endereco,@numero,@Complemento,@Bairro,@Cidade,@UF,@Naturalidade," +
                        "@DataNasc,@EstadoCivil,@Credito,@Saldo,@Bloqueio,@Celular,@Tel_Residencial,@Email,@Observacoes,@fk_ic_id) " +
                        "select scope_identity()";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@DataCadastro", SqlDbType.Date).Value = _dataCadastro;
                    adapter.SelectCommand.Parameters.AddWithValue("@NomeCliente", SqlDbType.VarChar).Value = _nomeCliente;
                    adapter.SelectCommand.Parameters.AddWithValue("@Tipo", SqlDbType.VarChar).Value = _tipo;
                    adapter.SelectCommand.Parameters.AddWithValue("@cpf_cnpj", SqlDbType.VarChar).Value = _cpf_cnpj;
                    adapter.SelectCommand.Parameters.AddWithValue("@rg", SqlDbType.VarChar).Value = _rg;
                    adapter.SelectCommand.Parameters.AddWithValue("@Emissor", SqlDbType.VarChar).Value = _emissor;
                    adapter.SelectCommand.Parameters.AddWithValue("@DataEmissao", SqlDbType.VarChar).Value = _dataEmissao;
                    adapter.SelectCommand.Parameters.AddWithValue("@Ins_Est", SqlDbType.VarChar).Value = _ins_Est;
                    adapter.SelectCommand.Parameters.AddWithValue("@cep", SqlDbType.VarChar).Value = _cep;
                    adapter.SelectCommand.Parameters.AddWithValue("@Endereco", SqlDbType.VarChar).Value = _endereco;
                    adapter.SelectCommand.Parameters.AddWithValue("@numero", SqlDbType.Int).Value = _numero;
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
                    adapter.SelectCommand.Parameters.AddWithValue("@fk_ic_id", SqlDbType.Int).Value = _fk_ic_id;

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    decimal x = dr.GetDecimal(0);

                    return Convert.ToInt32(x);

                    AvisoCantoInferiorDireito.Inclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarClienteNoBanco(ex);

                return 0;
            }
        }

        #endregion Inserir Cadastro Cliente

        #region Inserir Imagem Cadastro Cliente

        public int InserirImagemNoCadastroCliente(Image _imagem)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_ImagemCliente (ic_imagem) values (@imagem) select scope_identity()";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(_imagem, typeof(byte[]));
                    adapter.SelectCommand.Parameters.Add("@imagem", SqlDbType.Image).Value = arr;

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    decimal x = dr.GetDecimal(0);

                    return Convert.ToInt32(x);

                    AvisoCantoInferiorDireito.Inclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarImagemClienteNoBanco(ex);

                return 0;
            }
        }

        #endregion Inserir Imagem Cadastro Cliente

        #endregion Inserir Cliente

        #region Inserir Fornecedor

        #region Cadastro Fornecedor

        public int InserirCadastroForncedor(string _razaoSocial, DateTime _dataCadastro, string _cnpj, string _nomeFantasia,
                    string _cep, string _endereco, string _complemento, int _numero, string _bairro, string _cidade, string _uf,
                    string _telefone, string _email, string _observacoes, int _fk_cf_id)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_CadastroFornecedor (cf_razao_social,cf_data_cadastro,cf_cnpj,cf_nome_fantasia,cf_cep," +
                        "cf_endereco,cf_complemento,cf_numero,cf_bairro,cf_cidade,cf_uf,cf_telefone,cf_email,cf_observacoes,fk_cf_id) " +
                        "values (@razaoSocial,@dataCadastro,@cnpj,@nomeFantasia,@cep,@endereco,@complemento,@numero,@bairro,@cidade," +
                        "@uf,@telefone,@email,@observacoes,@fk_cf_id) select scope_identity()";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@razaoSocial", SqlDbType.Date).Value = _razaoSocial;
                    adapter.SelectCommand.Parameters.AddWithValue("@dataCadastro", SqlDbType.Date).Value = _dataCadastro;
                    adapter.SelectCommand.Parameters.AddWithValue("@cnpj", SqlDbType.VarChar).Value = _cnpj;
                    adapter.SelectCommand.Parameters.AddWithValue("@nomeFantasia", SqlDbType.VarChar).Value = _nomeFantasia;
                    adapter.SelectCommand.Parameters.AddWithValue("@cep", SqlDbType.VarChar).Value = _cep;
                    adapter.SelectCommand.Parameters.AddWithValue("@endereco", SqlDbType.VarChar).Value = _endereco;
                    adapter.SelectCommand.Parameters.AddWithValue("@complemento", SqlDbType.VarChar).Value = _complemento;
                    adapter.SelectCommand.Parameters.AddWithValue("@numero", SqlDbType.VarChar).Value = _numero;
                    adapter.SelectCommand.Parameters.AddWithValue("@bairro", SqlDbType.VarChar).Value = _bairro;
                    adapter.SelectCommand.Parameters.AddWithValue("@cidade", SqlDbType.VarChar).Value = _cidade;
                    adapter.SelectCommand.Parameters.AddWithValue("@uf", SqlDbType.VarChar).Value = _uf;
                    adapter.SelectCommand.Parameters.AddWithValue("@telefone", SqlDbType.Int).Value = _telefone;
                    adapter.SelectCommand.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = _email;
                    adapter.SelectCommand.Parameters.AddWithValue("@observacoes", SqlDbType.VarChar).Value = _observacoes;
                    adapter.SelectCommand.Parameters.AddWithValue("@fk_cf_id", SqlDbType.Int).Value = _fk_cf_id;

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    decimal x = dr.GetDecimal(0);

                    return Convert.ToInt32(x);

                    AvisoCantoInferiorDireito.Inclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarFornecedorNoBanco(ex);

                return 0;
            }
        }

        #endregion Cadastro Fornecedor

        #region Inserir Imagem Cadastro Fornecedor

        public int InserirImagemNoCadastroFornecedor(Image _imagem)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_ImagemFornecedor (if_imagem) values (@imagem) select scope_identity()";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(_imagem, typeof(byte[]));
                    adapter.SelectCommand.Parameters.Add("@imagem", SqlDbType.Image).Value = arr;

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    decimal x = dr.GetDecimal(0);

                    return Convert.ToInt32(x);

                    AvisoCantoInferiorDireito.Inclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarImagemFornecedorNoBanco(ex);

                return 0;
            }
        }

        #endregion Inserir Imagem Cadastro Fornecedor

        #endregion Inserir Fornecedor

        #region Inserir

        #region Cadastro Produto

        public int InserirCadastroProduto(string _descricao, string _un, decimal _valor_custo, decimal _porcentagem,
        decimal _valor_venda, decimal _lucro, decimal _preco_atacado, string _grupo, string _sub_grupo, string _fonecedor,
        decimal _estoque_minimo, string _garantia, string _marca, string _referencia, DateTime _validade, decimal _comissao,
        string _observacao, int _fk_ip_id)

        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_CadastroProdutos (cp_descricao,cp_un,cp_valor_custo,cp_porcentagem," +
                        "cp_valor_venda,cp_lucro,cp_preco_atacado,cp_grupo,cp_sub_grupo,cp_fonecedor,cp_estoque_minimo," +
                        "cp_garantia,cp_marca,cp_referencia,cp_validade,cp_comissao,cp_observacao,fk_ip_id) " +
                        "values (@descricao,@un,@valorCusto,@porcentagem,@valorVenda,@lucro,@precoAtacado,@grupo," +
                        "@subGrupo,@fonecedor,@estoqueMinimo,@garantia,@marca,@referencia,@validade,@comissao," +
                        "@observacao,@fk_ip_id) select scope_identity()";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@descricao", SqlDbType.VarChar).Value = _descricao;
                    adapter.SelectCommand.Parameters.AddWithValue("@un", SqlDbType.VarChar).Value = _un;
                    adapter.SelectCommand.Parameters.AddWithValue("@valorCusto", SqlDbType.Decimal).Value = _valor_custo;
                    adapter.SelectCommand.Parameters.AddWithValue("@porcentagem", SqlDbType.Decimal).Value = _porcentagem;
                    adapter.SelectCommand.Parameters.AddWithValue("@valorVenda", SqlDbType.Decimal).Value = _valor_venda;
                    adapter.SelectCommand.Parameters.AddWithValue("@lucro", SqlDbType.Decimal).Value = _lucro;
                    adapter.SelectCommand.Parameters.AddWithValue("@precoAtacado", SqlDbType.Decimal).Value = _preco_atacado;
                    adapter.SelectCommand.Parameters.AddWithValue("@grupo", SqlDbType.VarChar).Value = _grupo;
                    adapter.SelectCommand.Parameters.AddWithValue("@subGrupo", SqlDbType.VarChar).Value = _sub_grupo;
                    adapter.SelectCommand.Parameters.AddWithValue("@fonecedor", SqlDbType.VarChar).Value = _fonecedor;
                    adapter.SelectCommand.Parameters.AddWithValue("@estoqueMinimo", SqlDbType.Decimal).Value = _estoque_minimo;
                    adapter.SelectCommand.Parameters.AddWithValue("@garantia", SqlDbType.VarChar).Value = _garantia;
                    adapter.SelectCommand.Parameters.AddWithValue("@marca", SqlDbType.VarChar).Value = _marca;
                    adapter.SelectCommand.Parameters.AddWithValue("@referencia", SqlDbType.VarChar).Value = _referencia;
                    adapter.SelectCommand.Parameters.AddWithValue("@validade", SqlDbType.Date).Value = _validade;
                    adapter.SelectCommand.Parameters.AddWithValue("@comissao", SqlDbType.Decimal).Value = _comissao;
                    adapter.SelectCommand.Parameters.AddWithValue("@observacao", SqlDbType.VarChar).Value = _observacao;
                    adapter.SelectCommand.Parameters.AddWithValue("@fk_ip_id", SqlDbType.Int).Value = _fk_ip_id;

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    decimal x = dr.GetDecimal(0);

                    return Convert.ToInt32(x);

                    AvisoCantoInferiorDireito.Inclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarProdutoNoBanco(ex);

                return 0;
            }
        }

        #endregion Cadastro Produto

        #region Inserir Imagem Cadastro Produto

        public int InserirImagemNoCadastroProduto(Image _imagem)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_ImagemProdutos (ip_imagem) values (@imagem) select scope_identity()";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(_imagem, typeof(byte[]));
                    adapter.SelectCommand.Parameters.Add("@imagem", SqlDbType.Image).Value = arr;

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    decimal x = dr.GetDecimal(0);

                    return Convert.ToInt32(x);

                    AvisoCantoInferiorDireito.Inclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarImagemProdutoNoBanco(ex);

                return 0;
            }
        }

        #endregion Inserir Imagem Cadastro Produto

        #endregion Inserir

        #region Inserir Grupo de Material

        public void InserirGrupoMaterial(string _grupo, string _subGrupo)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_CadastroGrupoMaterial (cg_grupo,cg_sub_grupo) values(@grupo,@subGrupo)";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@grupo", SqlDbType.Date).Value = _grupo;
                    cmd.Parameters.AddWithValue("@subGrupo", SqlDbType.VarChar).Value = _subGrupo;

                    cmd.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Inclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarGrupoMaterialNoBanco(ex);
            }
        }

        #endregion Inserir Grupo de Material

        #region Inserir Empresa

        public void InserirCadastroEmpresa(string _razaoSocial, string _cnpj, string _nomeFantasia, string _cep, string _endereco, string _complemento,
        string _bairro, string _cidade, string _uf, int _numero, string _telefone, string _email, string _textoPadraoSO, Image _imagem)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query =
                        "insert into tb_CadastroEmpresa (ce_razao_social,ce_cnpj,ce_nome_fantasia,ce_cep,ce_endereco,ce_complemento," +
                        "ce_bairro,ce_cidade,ce_uf,ce_numero,ce_telefone,ce_email,ce_texto_padrao_os,ce_imagem)" +
                        " values(@razaoSocial,@cnpj,@nomeFantasia,@cep,@endereco,@complemento,@bairro,@cidade,@uf,@numero,@telefone," +
                        "@email,@textoPadraoSO,@imagem)";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    cmd.Parameters.AddWithValue("@razaoSocial", SqlDbType.VarChar).Value = _razaoSocial;
                    cmd.Parameters.AddWithValue("@cnpj", SqlDbType.VarChar).Value = _cnpj;
                    cmd.Parameters.AddWithValue("@nomeFantasia", SqlDbType.VarChar).Value = _nomeFantasia;
                    cmd.Parameters.AddWithValue("@cep", SqlDbType.VarChar).Value = _cep;
                    cmd.Parameters.AddWithValue("@endereco", SqlDbType.VarChar).Value = _endereco;
                    cmd.Parameters.AddWithValue("@complemento", SqlDbType.VarChar).Value = _complemento;
                    cmd.Parameters.AddWithValue("@bairro", SqlDbType.VarChar).Value = _bairro;
                    cmd.Parameters.AddWithValue("@cidade", SqlDbType.VarChar).Value = _cidade;
                    cmd.Parameters.AddWithValue("@uf", SqlDbType.VarChar).Value = _uf;
                    cmd.Parameters.AddWithValue("@numero", SqlDbType.Int).Value = _numero;
                    cmd.Parameters.AddWithValue("@telefone", SqlDbType.VarChar).Value = _telefone;
                    cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = _email;
                    cmd.Parameters.AddWithValue("@textoPadraoSO", SqlDbType.VarChar).Value = _textoPadraoSO;

                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(_imagem, typeof(byte[]));
                    cmd.Parameters.Add("@imagem", SqlDbType.Image).Value = arr;

                    cmd.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Inclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarEmpresaNoBanco(ex);
            }
        }

        #endregion Inserir Empresa

        #region Inserir Usuario

        public void InserirUsuario(string _usuario, string _senha)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_CadastroUsuario (cu_usuario,cu_senha) values(@usuario,@senha)";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@usuario", SqlDbType.Date).Value = _usuario;
                    cmd.Parameters.AddWithValue("@senha", SqlDbType.VarChar).Value = _senha;

                    cmd.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Inclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarUsuarioNoBanco(ex);
            }
        }

        #endregion Inserir Usuario

        #region Inserir Despesa

        #region Inserir Cadastro de Despesas e Custo

        public void InserirCadastroDespesa(string _descricao, string _tipo, string _categoria)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_CadastroDespesaCustos (cd_descricao,cd_tipo,cd_categoria) " +
                                   "values(@descricao,@tipo,@categoria)";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@descricao", SqlDbType.VarChar).Value = _descricao;
                    cmd.Parameters.AddWithValue("@tipo", SqlDbType.VarChar).Value = _tipo;
                    cmd.Parameters.AddWithValue("@categoria", SqlDbType.VarChar).Value = _categoria;

                    cmd.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Inclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarDespesaCustoNoBanco(ex);
            }
        }

        #endregion Inserir Cadastro de Despesas e Custo

        #region Inserir Despesas

        public void InserirDespesaCusto(string _tipo, string _descricao, string _forncedorTitulo, string _cnpj, DateTime _emissao,
            DateTime _vencimento, string _frequencia, decimal _valor, int _quantidadeParcelas, decimal _valorParcelas, string _categoria)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_DespesasCustos ( dc_tipo, dc_descricao, dc_fornecedor_titulo, dc_cnpj, " +
                                   "dc_emissao, dc_vencimento, dc_frequencia, dc_valor, dc_quantidade_parcelas, " +
                                   "dc_valor_parcela, dc_categoria) " +
                                   "values(@tipo,@descricao,@fornecedorTitulo,@cnpj,@emissao,@vencimento,@frequencia," +
                                   "@valor,@quantidadeParcelas,@valorParcelas,@categoria)";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@tipo", SqlDbType.VarChar).Value = _tipo;
                    cmd.Parameters.AddWithValue("@descricao", SqlDbType.VarChar).Value = _descricao;
                    cmd.Parameters.AddWithValue("@fornecedorTitulo", SqlDbType.VarChar).Value = _forncedorTitulo;
                    cmd.Parameters.AddWithValue("@cnpj", SqlDbType.VarChar).Value = _cnpj;
                    cmd.Parameters.AddWithValue("@emissao", SqlDbType.Date).Value = _emissao;
                    cmd.Parameters.AddWithValue("@vencimento", SqlDbType.Date).Value = _vencimento;
                    cmd.Parameters.AddWithValue("@frequencia", SqlDbType.VarChar).Value = _frequencia;
                    cmd.Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = _valor;
                    cmd.Parameters.AddWithValue("@quantidadeParcelas", SqlDbType.Int).Value = _quantidadeParcelas;
                    cmd.Parameters.AddWithValue("@valorParcelas", SqlDbType.Decimal).Value = _valorParcelas;
                    cmd.Parameters.AddWithValue("@categoria", SqlDbType.VarChar).Value = _categoria;
                    cmd.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Inclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarDespesaNoBanco(ex);
            }
        }

        #endregion Inserir Despesas

        #endregion Inserir Despesa

        #region Inserir Estoque Produto

        public void InserirEstoqueProduto(int _ne_numero_nf)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_EstoqueProduto (ep_nf_entrada,ep_codigo_produto,ep_descricao," +
                                   "ep_unidade,ep_valor_unitario,ep_quantidade) " +
                                   "select ne_numero_nf,ne_codigo_produto,ne_descricao_produto,ne_unidade," +
                                   "ne_valor_unitario,ne_quantidade " +
                                   "from tb_NotaFiscalEntrada where ne_numero_nf = @ne_numero_nf";
                    //and ne_indice = @indice";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    //cmd.Parameters.AddWithValue("@indice", SqlDbType.Int).Value = _indice;
                    cmd.Parameters.AddWithValue("@ne_numero_nf", SqlDbType.Int).Value = _ne_numero_nf;
                    //cmd.Parameters.AddWithValue("@ep_codigo_barras", SqlDbType.Int).Value = _ep_codigo_barras;

                    cmd.ExecuteNonQuery();

                    //AvisoCantoInferiorDireito.Inclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarEstoqueProdutoNoBanco(ex);
            }
        }

        #endregion Inserir Estoque Produto
    }
}