using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correios.CorreiosServiceReference;
using Exception = System.Exception;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class AtualizacaoNoBanco : ConectarBanco
    {
        private MensagensErro Erro = new MensagensErro();

        #region Atualizar Cliente

        #region Atualizar Cadastro Cliente

        public void AtualizarCadastroCliente(DateTime _dataCadastro, string _nomeCliente, string _tipo, string _cPF_CNPJ,
          string _rG, string _emissor, string _dataEmissao, string _ins_Est, string _cEP, string _endereco, int _numero, string _complemento,
          string _bairro, string _cidade, string _uF, string _naturalidade, string _dataNasc, string _estadoCivil, decimal _credito,
          decimal _saldo, string _bloqueio, string _celular, string _tel_Residencial, string _email, string _observacoes)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_CadastroClientes set cc_data_cadastro=@DataCadastro,cc_nome_cliente=@NomeCliente," +
                        "cc_tipo=@Tipo,cc_rg=@RG,cc_emissor=@Emissor,cc_data_emissao=@DataEmissao,cc_ins_est=@Ins_Est," +
                        "cc_cep=@CEP,cc_endereco=@Endereco,cc_numero=@numero,cc_complemento=@Complemento,cc_bairro=@Bairro," +
                        "cc_cidade=@Cidade,cc_uf=@UF,cc_naturalidade=@Naturalidade,cc_data_nasc=@DataNasc,cc_estado_civil=@EstadoCivil," +
                        "cc_credito=@Credito,cc_saldo=@Saldo,cc_bloqueio=@Bloqueio,cc_celular=@Celular,cc_tel_residencial=@Tel_Residencial," +
                        "cc_email=@Email,cc_observacoes=@Observacoes " +
                        "where cc_cpf_cnpj=@CPF_CNPJ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
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

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Atualizacao();
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

                    AvisoCantoInferiorDireito.Atualizacao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarImagemClienteNoBanco(ex);
            }
        }

        #endregion Atualizar Imagem Cliente

        #endregion Atualizar Cliente

        #region Atualizar Fornecedor

        #region Atualizar Cadastro Fornecedor

        public void AtualizarCadastroFornecedor(string _razaoSocial, string _cnpj, string _nomeFantasia,
                   string _cep, string _endereco, string _complemento, int _numero, string _bairro, string _cidade, string _uf,
                   string _telefone, string _email, string _observacoes)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_CadastroFornecedor set cf_razao_social=@razaoSocial,cf_cnpj=@cnpj," +
                        "cf_nome_fantasia=@nomeFantasia,cf_cep=@cep,cf_endereco=@endereco,cf_complemento=@complemento," +
                        "cf_numero=@numero,cf_bairro=@bairro,cf_cidade=@cidade,cf_uf=@uf,cf_telefone=@telefone," +
                        "cf_email=@email,cf_observacoes=@Observacoes " +
                        "where cf_cnpj=@cnpj";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@razaoSocial", SqlDbType.Date).Value = _razaoSocial;
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

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Atualizacao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarFornecedorNoBanco(ex);
            }
        }

        #endregion Atualizar Cadastro Fornecedor

        #region Atualizar Imagem Fornecedor

        public void AtualizarImagemNoCadastroFornecedor(Image _imagem, int _cf_id)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_ImagemFornecedor set if_imagem=@imagem where if_id = @cf_id ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(_imagem, typeof(byte[]));
                    adapter.SelectCommand.Parameters.Add("@imagem", SqlDbType.Image).Value = arr;
                    adapter.SelectCommand.Parameters.AddWithValue("@cf_id", SqlDbType.VarChar).Value = _cf_id;

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Atualizacao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarImagemFornecedorNoBanco(ex);
            }
        }

        #endregion Atualizar Imagem Fornecedor

        #endregion Atualizar Fornecedor

        #region Atualizar Produto

        #region Atualizar Cadastro Produto

        public void AtualizarCadastroProduto(string _descricao, string _un, decimal _valor_custo, decimal _porcentagem,
        decimal _valor_venda, decimal _lucro, decimal _preco_atacado, string _grupo, string _sub_grupo, string _fonecedor,
        decimal _estoque_minimo, string _garantia, string _marca, string _referencia, DateTime _validade, decimal _comissao,
        string _observacao)

        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_CadastroProdutos set cp_descricao=@descricao,cp_un=@un,cp_valor_custo=@valorCusto," +
                        "cp_porcentagem=@porcentagem,cp_valor_venda=@valorVenda,cp_lucro=@lucro,cp_preco_atacado=@precoAtacado," +
                        "cp_grupo=@grupo,cp_sub_grupo=@subGrupo,cp_fonecedor=@fonecedor,cp_estoque_minimo=@estoqueMinimo," +
                        "cp_garantia=@garantia,cp_marca=@marca,cp_referencia=@referencia,cp_validade=@validade,cp_comissao=@comissao," +
                        "cp_observacao=@observacao " +
                        "where cp_descricao=@descricao";

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

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Atualizacao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarProdutoNoBanco(ex);
            }
        }

        #endregion Atualizar Cadastro Produto

        #region Atualizar Imagem Produto

        public void AtualizarImagemNoCadastroProduto(Image _imagem, int _cp_id)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_ImagemProdutos set ip_imagem=@imagem where ip_id = @cp_id ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(_imagem, typeof(byte[]));
                    adapter.SelectCommand.Parameters.Add("@imagem", SqlDbType.Image).Value = arr;
                    adapter.SelectCommand.Parameters.AddWithValue("@cp_id", SqlDbType.VarChar).Value = _cp_id;

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Atualizacao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarImagemProdutoNoBanco(ex);
            }
        }

        #endregion Atualizar Imagem Produto

        #endregion Atualizar Produto

        #region Atualizar Empresa

        #region Atualizar Cadastro Empresa

        public void AtualizarCadastroEmpresa(string _razaoSocial, string _cnpj, string _nomeFantasia, string _cep, string _endereco, string _complemento,
            string _bairro, string _cidade, string _uf, int _numero, string _telefone, string _email, string _textoPadrao, string _codigoPix,
            string _chavePix, int _ce_id)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_CadastroEmpresa set ce_razao_social=@razaoSocial,ce_cnpj=@cnpj," +
                        "ce_nome_fantasia=@nomeFantasia,ce_cep=@cep,ce_endereco=@endereco,ce_complemento=@complemento," +
                        "ce_bairro=@bairro,ce_cidade=@cidade,ce_uf=@uf,ce_numero=@numero,ce_telefone=@telefone," +
                        "ce_email=@email,ce_texto_padrao=@textoPadrao,ce_codigo_pix=@codigoPix,ce_chave_pix=@chavePix " +
                        "where ce_id = @ce_id ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@razaoSocial", SqlDbType.VarChar).Value = _razaoSocial;
                    adapter.SelectCommand.Parameters.AddWithValue("@cnpj", SqlDbType.VarChar).Value = _cnpj;
                    adapter.SelectCommand.Parameters.AddWithValue("@nomeFantasia", SqlDbType.VarChar).Value = _nomeFantasia;
                    adapter.SelectCommand.Parameters.AddWithValue("@cep", SqlDbType.VarChar).Value = _cep;
                    adapter.SelectCommand.Parameters.AddWithValue("@endereco", SqlDbType.VarChar).Value = _endereco;
                    adapter.SelectCommand.Parameters.AddWithValue("@complemento", SqlDbType.VarChar).Value = _complemento;
                    adapter.SelectCommand.Parameters.AddWithValue("@bairro", SqlDbType.VarChar).Value = _bairro;
                    adapter.SelectCommand.Parameters.AddWithValue("@cidade", SqlDbType.VarChar).Value = _cidade;
                    adapter.SelectCommand.Parameters.AddWithValue("@uf", SqlDbType.VarChar).Value = _uf;
                    adapter.SelectCommand.Parameters.AddWithValue("@numero", SqlDbType.Int).Value = _numero;
                    adapter.SelectCommand.Parameters.AddWithValue("@telefone", SqlDbType.VarChar).Value = _telefone;
                    adapter.SelectCommand.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = _email;
                    adapter.SelectCommand.Parameters.AddWithValue("@textoPadrao", SqlDbType.VarChar).Value = _textoPadrao;
                    adapter.SelectCommand.Parameters.AddWithValue("@codigoPix", SqlDbType.VarChar).Value = _codigoPix;
                    adapter.SelectCommand.Parameters.AddWithValue("@chavePix", SqlDbType.VarChar).Value = _chavePix;
                    adapter.SelectCommand.Parameters.AddWithValue("@ce_id", SqlDbType.Int).Value = _ce_id;

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Atualizacao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarEmpresaNoBanco(ex);
            }
        }

        #endregion Atualizar Cadastro Empresa

        #region Atualizar Imagem Empresa

        public void AtualizarImagemNoCadastroEmpresa(Image _logoEmpresa, Image _qrCode, int _ce_id)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_CadastroEmpresa set ce_logo_empresa = @logoEmpresa, ce_qr_code = @qrCode " +
                        "where ce_id = @ce_id ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    byte[] arr;
                    byte[] err;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(_logoEmpresa, typeof(byte[]));
                    err = (byte[])converter.ConvertTo(_qrCode, typeof(byte[]));
                    adapter.SelectCommand.Parameters.Add("@logoEmpresa", SqlDbType.Image).Value = arr;
                    adapter.SelectCommand.Parameters.Add("@qrCode", SqlDbType.Image).Value = err;
                    adapter.SelectCommand.Parameters.AddWithValue("@ce_id", SqlDbType.VarChar).Value = _ce_id;

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Atualizacao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarImagemEmpresaNoBanco(ex);
            }
        }

        #endregion Atualizar Imagem Empresa

        #endregion Atualizar Empresa

        #region Atualizar Usuario

        public void AtualizarCadastroUsuario(string _usuario, string _senha, string _excluirItem, string _devolucaoTroca,
            string _cancelarVenda, string _cancelarPagamento)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_CadastroUsuario set cu_usuario = @usuario,cu_senha = @senha, " +
                        "cu_excluir_item = @excluirItem," +
                        "cu_devolucao_troca = @devolucaoTroca," +
                        "cu_cancelar_venda = @cancelarVenda," +
                        "cu_cancelar_pagamento = @cancelarPagamento " +
                        "where cu_usuario = @usuario ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@usuario", SqlDbType.VarChar).Value = _usuario;
                    adapter.SelectCommand.Parameters.AddWithValue("@senha", SqlDbType.VarChar).Value = _senha;
                    adapter.SelectCommand.Parameters.AddWithValue("@excluirItem", SqlDbType.VarChar).Value = _excluirItem;
                    adapter.SelectCommand.Parameters.AddWithValue("@devolucaoTroca", SqlDbType.VarChar).Value = _devolucaoTroca;
                    adapter.SelectCommand.Parameters.AddWithValue("@cancelarVenda", SqlDbType.VarChar).Value = _cancelarVenda;
                    adapter.SelectCommand.Parameters.AddWithValue("@cancelarPagamento", SqlDbType.VarChar).Value = _cancelarPagamento;

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Atualizacao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarUsuarioNoBanco(ex);
            }
        }

        #endregion Atualizar Usuario

        #region Atualizar Cadastro Despesa e Custo

        public void AtualizarCadastroDespesa(int _cd_id, string _descricao, string _tipo, string _categoria)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_CadastroDespesaCustos set cd_descricao = @descricao,cd_tipo = @tipo " +
                                   "where cd_id = @cd_id and cd_categoria = @categoria";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@cd_id", SqlDbType.Int).Value = _cd_id;
                    adapter.SelectCommand.Parameters.AddWithValue("@descricao", SqlDbType.VarChar).Value = _descricao;
                    adapter.SelectCommand.Parameters.AddWithValue("@tipo", SqlDbType.VarChar).Value = _tipo;
                    adapter.SelectCommand.Parameters.AddWithValue("@categoria", SqlDbType.VarChar).Value = _categoria;

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Atualizacao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCadastroDespesaCustoNoBanco(ex);
            }
        }

        #endregion Atualizar Cadastro Despesa e Custo

        public void AtualizarQuantidadeEDataEntradaEstoqueProduto(int _quantidade, int _numeroNF)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_EstoqueProduto set ep_quantidade = @quantidade, " +
                                   "ep_data_entrada = GETDATE() where ep_nf_entrada = @ne_numero_nf";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = _quantidade;
                    adapter.SelectCommand.Parameters.AddWithValue("@ne_numero_nf", SqlDbType.VarChar).Value = _numeroNF;

                    adapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarQuantidadeDataEntradaEstoqueProdutoNoBanco(ex);
            }
        }

        #region Atualizar Estoque Produto Quando a Nota Fiscal De Entrada É Cancelada

        public void AtualizarQuantidadeEstoqueProdutoNotaFiscalEntradaCancelada(int _numeroNF)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_EstoqueProduto set ep_quantidade = 0, ep_valor_unitario = 0 , ep_codigo_barras = 0" +
                                   "where ep_nf_entrada = @ep_numero_nf";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@ep_numero_nf", SqlDbType.VarChar).Value = _numeroNF;

                    adapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarQuantidadeEstoqueProdutoNotaFiscalEntradaCanceladaNoBanco(ex);
            }
        }

        #endregion Atualizar Estoque Produto Quando a Nota Fiscal De Entrada É Cancelada

        #region Atualizar Codigo Barras Estoque Produto

        public void AtualizarCodigoBarrasEstoqueProduto(int _ep_codigo_barras, int _numeroNF, int _codigoProduto)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_EstoqueProduto set ep_codigo_barras = @codigoBarras, ep_data_entrada = GETDATE(), " +
                                   "ep_desconto_por_item = 0 " +
                                   "where ep_nf_entrada = @ne_numero_nf and ep_codigo_produto = @codigoProduto";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codigoBarras", SqlDbType.Int).Value = _ep_codigo_barras;
                    adapter.SelectCommand.Parameters.AddWithValue("@ne_numero_nf", SqlDbType.Int).Value = _numeroNF;
                    adapter.SelectCommand.Parameters.AddWithValue("@codigoProduto", SqlDbType.Int).Value = _codigoProduto;

                    adapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCodigoBarrasEstoqueProdutoNoBanco(ex);
            }
        }

        #endregion Atualizar Codigo Barras Estoque Produto

        #region Atualizar Nota Fiscal Entrada

        #region Atualizar Data Lancamento Nota Fiscal Entrada

        public void AtualizarDataLancamentoNotaFiscalEntrada(int _numeroNF)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_NotaFiscalEntrada set ne_data_lancamento = GETDATE() " +
                                   "where ne_numero_nf = @ne_numero_nf";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@ne_numero_nf", SqlDbType.VarChar).Value = _numeroNF;

                    adapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarDataLancamentoNotaFiscalEntradaNoBanco(ex);
            }
        }

        #endregion Atualizar Data Lancamento Nota Fiscal Entrada

        #region Atualizar Data Lancamento Nota Fiscal Entrada Quando Cancelada

        public void AtualizarDataLancamentoNotaFiscalEntradaQuandoCancelada(int _numeroNF)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_NotaFiscalEntrada set ne_data_lancamento = null " +
                                   "where ne_numero_nf = @ne_numero_nf";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@ne_numero_nf", SqlDbType.VarChar).Value = _numeroNF;

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Exclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarDataLancamentoNotaFiscalEntradaQuandoCanceladaNoBanco(ex);
            }
        }

        #endregion Atualizar Data Lancamento Nota Fiscal Entrada Quando Cancelada

        #endregion Atualizar Nota Fiscal Entrada

        #region Atualizar Configuracao Gerencial

        #region Atualizar Desconto Por Grupo de Produto

        public void AtualizarDescontoPorGrupoDeProduto(string _grupo, string _subGrupo, decimal _descontoGrupo)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update e_Produto set ep_desconto_por_item = @descontoGrupo from tb_EstoqueProduto as e_Produto " +
                                   "inner join tb_CadastroProdutos as c_Produto on e_Produto.ep_codigo_produto = c_Produto.cp_id " +
                                   "and c_Produto.cp_grupo = @grupo and c_Produto.cp_sub_grupo = @subGrupo";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@descontoGrupo", SqlDbType.Decimal).Value = _descontoGrupo;
                    adapter.SelectCommand.Parameters.AddWithValue("@grupo", SqlDbType.VarChar).Value = _grupo;
                    adapter.SelectCommand.Parameters.AddWithValue("@subGrupo", SqlDbType.VarChar).Value = _subGrupo;

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Atualizacao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarDescontoPorGrupoNoBanco(ex);
            }
        }

        #endregion Atualizar Desconto Por Grupo de Produto

        #region Atualizar Desconto Avista

        public void AtualizarPagamentoDescontoAvista(decimal _descontoAVista)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_Financeiro set fn_desconto_avista = @descontoAVista where fn_id = 1";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@descontoAVista", SqlDbType.Decimal).Value = _descontoAVista;

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Atualizacao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarDescontoAvistaNoBanco(ex);
            }
        }

        #endregion Atualizar Desconto Avista

        #region Atualizar Juros Carne

        public void JurosPorCarne(int _prazoCarne, decimal _jurosCarne, int _parcelasCarne)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_Financeiro set fn_prazo_carne = @prazoCarne, fn_juros_carne = @jurosCarne," +
                                   "fn_parcelas_carne = @parcelasCarne";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.AddWithValue("@prazoCarne", _prazoCarne);
                    adapter.SelectCommand.Parameters.AddWithValue("@jurosCarne", _jurosCarne);
                    adapter.SelectCommand.Parameters.AddWithValue("@parcelasCarne", _parcelasCarne);

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Atualizacao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarJurosCarneNoBanco(ex);
            }
        }

        #endregion Atualizar Juros Carne

        #region Atualizar Juros Credito

        public void JurosCredito(decimal _jurosCredito, int _parcelasCredito)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_Financeiro set fn_juros_credito = @jurosCredito ,fn_parcelas_credito = @parcelasCredito";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@jurosCredito", _jurosCredito);
                    adapter.SelectCommand.Parameters.AddWithValue("@parcelasCredito", _parcelasCredito);

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Atualizacao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarJurosCreditoNoBanco(ex);
            }
        }

        #endregion Atualizar Juros Credito

        #region Atualizar Comissao

        public void AtualizarComissao(decimal _comissao)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_Financeiro set fn_comissao = @comissao";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@comissao", _comissao);

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Atualizacao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarJurosCreditoNoBanco(ex);
            }
        }

        #endregion Atualizar Comissao

        #endregion Atualizar Configuracao Gerencial

        #region Atualizar Despesa

        public void AtualizarDespesaCusto(string _tipo, string _descricao, string _forncedorTitulo, string _cnpj, DateTime _emissao,
            DateTime _vencimento, string _frequencia, decimal _valor, int _quantidadeParcelas, decimal _valorParcelas,
            string _categoria, int _codigo)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_DespesasCustos set dc_tipo = @tipo,dc_descricao = @descricao,dc_fornecedor_titulo = @fornecedorTitulo," +
                                   "dc_cnpj = @cnpj, dc_emissao = @emissao,dc_vencimento = @vencimento,dc_frequencia = @frequencia," +
                                   "dc_valor = @valor,dc_quantidade_parcelas = @quantidadeParcelas,dc_valor_parcela = @valorParcela," +
                                   "dc_categoria = @categoria " +
                                   "where dc_id = @codigo";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.AddWithValue("@tipo", _tipo);
                    adapter.SelectCommand.Parameters.AddWithValue("@descricao", _descricao);
                    adapter.SelectCommand.Parameters.AddWithValue("@fornecedorTitulo", _forncedorTitulo);
                    adapter.SelectCommand.Parameters.AddWithValue("@cnpj", _cnpj);
                    adapter.SelectCommand.Parameters.AddWithValue("@emissao", _emissao);
                    adapter.SelectCommand.Parameters.AddWithValue("@vencimento", _vencimento);
                    adapter.SelectCommand.Parameters.AddWithValue("@frequencia", _frequencia);
                    adapter.SelectCommand.Parameters.AddWithValue("@valor", _valor);
                    adapter.SelectCommand.Parameters.AddWithValue("@quantidadeParcelas", _quantidadeParcelas);
                    adapter.SelectCommand.Parameters.AddWithValue("@valorParcela", _valorParcelas);
                    adapter.SelectCommand.Parameters.AddWithValue("@categoria", _categoria);
                    adapter.SelectCommand.Parameters.AddWithValue("@codigo", _codigo);

                    adapter.SelectCommand.ExecuteNonQuery();

                    AvisoCantoInferiorDireito.Atualizacao();
                }
            }
            catch (Exception ex)

            {
                Erro.ErroAoAtualizarDespesaCustoNoBanco(ex);
            }
        }

        #endregion Atualizar Despesa

        #region Atualizar Codigo Despesa e Custo

        public void AlterarCodigoDespesaCusto(int _codigo, string _descricao)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_DespesasCustos set dc_codigo = @codigo " +
                                   "where dc_descricao = @descricao";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codigo", _codigo);
                    adapter.SelectCommand.Parameters.AddWithValue("@descricao", _descricao);

                    adapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCodigoDespesaCustoNoBanco(ex);
            }
        }

        #endregion Atualizar Codigo Despesa e Custo

        #region Atualizar Status Pagamento Despesa e Custo

        public void AtualizarPagamento(DateTime _dataPagamento, decimal _descontoTaxas, decimal _jurosMulta,
            decimal _valorPago, int _codigo, string _quantidadeParcelas, string _statusPagamento, Image _imagem)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_DespesasCustos set dc_data_pagamento = @dataPagamento, " +
                                   "dc_desconto_taxas = @descontoTaxas , dc_juros_multa = @jurosMulta, " +
                                   "dc_valor_pago = @valorPago, dc_estatus_pagamento = @statusPagamento, " +
                                   "dc_imagem_pagamento = @imagem " +
                                   "where dc_codigo = @codigo and dc_quantidade_parcelas = @quantidadeParcelas";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(_imagem, typeof(byte[]));

                    adapter.SelectCommand.Parameters.AddWithValue("@dataPagamento", _dataPagamento);
                    adapter.SelectCommand.Parameters.AddWithValue("@descontoTaxas", _descontoTaxas);
                    adapter.SelectCommand.Parameters.AddWithValue("@jurosMulta", _jurosMulta);
                    adapter.SelectCommand.Parameters.AddWithValue("@valorPago", _valorPago);
                    adapter.SelectCommand.Parameters.AddWithValue("@codigo", _codigo);
                    adapter.SelectCommand.Parameters.AddWithValue("@quantidadeParcelas", _quantidadeParcelas);
                    adapter.SelectCommand.Parameters.AddWithValue("@statusPagamento", _statusPagamento);
                    adapter.SelectCommand.Parameters.Add("@imagem", SqlDbType.Image).Value = arr;

                    adapter.SelectCommand.ExecuteReader();

                    AvisoCantoInferiorDireito.Inclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarPagamentoNoBanco(ex);
            }
        }

        #endregion Atualizar Status Pagamento Despesa e Custo

        #region Atualizar Codigo de Despesa e Custos Fixo com Repeticao

        public void AtualziarCodigoDespesaCustosFixoRepeticao(int _codigo)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_DespesasCustos set dc_verificar = 'ok' " +
                                   "where dc_codigo = @codigo ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codigo", _codigo);

                    adapter.SelectCommand.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarCodigoDespesaCustoFixoNoBanco(ex);
            }
        }

        #endregion Atualizar Codigo de Despesa e Custos Fixo com Repeticao

        #region Atualizar Quantidade Estoque Depois da Venda

        public void AtualizarQuantidadeEstoquePosVenda(decimal _quantidade, int _codigoBarras)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_EstoqueProduto set ep_quantidade = (ep_quantidade - @quantidade ) " +
                        "where ep_codigo_barras = @codigoBarras";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@quantidade", _quantidade);
                    adapter.SelectCommand.Parameters.AddWithValue("@codigoBarras", _codigoBarras);

                    adapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarQuantidadeEstoqueProdutoPosVendaNoBanco(ex);
            }
        }

        #endregion Atualizar Quantidade Estoque Depois da Venda

        public void AtualizarQuantidadePosTrocaNotaFiscalSaida(decimal _quantidade, decimal _valorPago, int _numeroNF,
            int _codigoBarras, string _status, string _trocaVendedor, string _motivoTroca, int _id)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_NotaFiscalSaida set " +
                        "ns_quantidade = @quantidade , ns_valor_pago = @valorPago, ns_status = @status , " +
                        "ns_troca_vendedor = @trocaVendedor, ns_motivo_troca = @motivoTroca " +
                        "where ns_numero_nf = @numeroNF and ns_codigo_barras = @codigoBarras and ns_id = @id";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.Add("@quantidade", _quantidade);
                    adapter.SelectCommand.Parameters.Add("@valorPago", _valorPago);
                    adapter.SelectCommand.Parameters.Add("@numeroNF", _numeroNF);
                    adapter.SelectCommand.Parameters.Add("@codigoBarras", _codigoBarras);
                    adapter.SelectCommand.Parameters.Add("@status", _status);
                    adapter.SelectCommand.Parameters.Add("@trocaVendedor", _trocaVendedor);
                    adapter.SelectCommand.Parameters.Add("@motivoTroca", _motivoTroca);
                    adapter.SelectCommand.Parameters.Add("@id", _id);

                    adapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarDadosTrocaoBanco(ex);
            }
        }

        public void AtualizarQuantidadeEstoquePosDevolucao(decimal _quantidade, int _codigoBarras)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_EstoqueProduto set ep_quantidade = (ep_quantidade + @quantidade ) " +
                        "where ep_codigo_barras = @codigoBarras";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@quantidade", _quantidade);
                    adapter.SelectCommand.Parameters.AddWithValue("@codigoBarras", _codigoBarras);

                    adapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarQuantidadeEstoqueProdutoPosVendaNoBanco(ex);
            }
        }

        public void AtuazliarPrazoGarantia(int _numeroNF, DateTime _validadeTroca)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_NotaFiscalSaida set ns_garantia = @validadeTroca " +
                        "where ns_numero_nf = @numeroNF";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.Add("@numeroNF", _numeroNF);
                    adapter.SelectCommand.Parameters.Add("@validadeTroca", _validadeTroca);

                    adapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAtualizarGarantiaTrocaoBanco(ex);
            }
        }
    }
}