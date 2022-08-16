﻿using System;
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

        public int InserirCadastroCliente(DadosCliente _dadosCliente)
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
                    adapter.SelectCommand.Parameters.AddWithValue("@DataCadastro", SqlDbType.Date).Value = _dadosCliente.dataCadastro;
                    adapter.SelectCommand.Parameters.AddWithValue("@NomeCliente", SqlDbType.VarChar).Value = _dadosCliente.nome;
                    adapter.SelectCommand.Parameters.AddWithValue("@Tipo", SqlDbType.VarChar).Value = _dadosCliente.tipo;
                    adapter.SelectCommand.Parameters.AddWithValue("@cpf_cnpj", SqlDbType.VarChar).Value = _dadosCliente.cpfCpnjCliente;
                    adapter.SelectCommand.Parameters.AddWithValue("@rg", SqlDbType.VarChar).Value = _dadosCliente.rg;
                    adapter.SelectCommand.Parameters.AddWithValue("@Emissor", SqlDbType.VarChar).Value = _dadosCliente.orgaoEmissor;
                    adapter.SelectCommand.Parameters.AddWithValue("@DataEmissao", SqlDbType.VarChar).Value = _dadosCliente.dataEmissao;
                    adapter.SelectCommand.Parameters.AddWithValue("@Ins_Est", SqlDbType.VarChar).Value = _dadosCliente.insEst;
                    adapter.SelectCommand.Parameters.AddWithValue("@cep", SqlDbType.VarChar).Value = _dadosCliente.cep;
                    adapter.SelectCommand.Parameters.AddWithValue("@Endereco", SqlDbType.VarChar).Value = _dadosCliente.endereco;
                    adapter.SelectCommand.Parameters.AddWithValue("@numero", SqlDbType.Int).Value = _dadosCliente.numero;
                    adapter.SelectCommand.Parameters.AddWithValue("@Complemento", SqlDbType.VarChar).Value = _dadosCliente.complemento;
                    adapter.SelectCommand.Parameters.AddWithValue("@Bairro", SqlDbType.VarChar).Value = _dadosCliente.bairro;
                    adapter.SelectCommand.Parameters.AddWithValue("@Cidade", SqlDbType.VarChar).Value = _dadosCliente.cidade;
                    adapter.SelectCommand.Parameters.AddWithValue("@UF", SqlDbType.VarChar).Value = _dadosCliente.uf;
                    adapter.SelectCommand.Parameters.AddWithValue("@Naturalidade", SqlDbType.VarChar).Value = _dadosCliente.naturalidade;
                    adapter.SelectCommand.Parameters.AddWithValue("@DataNasc", SqlDbType.VarChar).Value = _dadosCliente.dataNascimento;
                    adapter.SelectCommand.Parameters.AddWithValue("@EstadoCivil", SqlDbType.VarChar).Value = _dadosCliente.estadoCivil;
                    adapter.SelectCommand.Parameters.AddWithValue("@Credito", SqlDbType.Decimal).Value = _dadosCliente.credito;
                    adapter.SelectCommand.Parameters.AddWithValue("@Saldo", SqlDbType.Decimal).Value = _dadosCliente.saldo;
                    adapter.SelectCommand.Parameters.AddWithValue("@Bloqueio", SqlDbType.VarChar).Value = _dadosCliente.bloqueio;
                    adapter.SelectCommand.Parameters.AddWithValue("@Celular", SqlDbType.VarChar).Value = _dadosCliente.celular;
                    adapter.SelectCommand.Parameters.AddWithValue("@Tel_Residencial", SqlDbType.VarChar).Value = _dadosCliente.telefone;
                    adapter.SelectCommand.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = _dadosCliente.email;
                    adapter.SelectCommand.Parameters.AddWithValue("@Observacoes", SqlDbType.VarChar).Value = _dadosCliente.observacoes;
                    adapter.SelectCommand.Parameters.AddWithValue("@fk_ic_id", SqlDbType.Int).Value = _dadosCliente.codigoCliente;

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    decimal x = dr.GetDecimal(0);

                    AvisoCantoInferiorDireito.Inclusao();

                    return Convert.ToInt32(x);
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

        public int InserirCadastroFornecedor(DadosCadastroFornecedor _dadosCadastroFornecedor)
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
                    adapter.SelectCommand.Parameters.AddWithValue("@razaoSocial", SqlDbType.VarChar).Value = _dadosCadastroFornecedor.razaoSocial;
                    adapter.SelectCommand.Parameters.AddWithValue("@dataCadastro", SqlDbType.Date).Value = _dadosCadastroFornecedor.dataCadastro;
                    adapter.SelectCommand.Parameters.AddWithValue("@cnpj", SqlDbType.VarChar).Value = _dadosCadastroFornecedor.cnpj;
                    adapter.SelectCommand.Parameters.AddWithValue("@nomeFantasia", SqlDbType.VarChar).Value = _dadosCadastroFornecedor.nomeFantasia;
                    adapter.SelectCommand.Parameters.AddWithValue("@cep", SqlDbType.VarChar).Value = _dadosCadastroFornecedor.cep;
                    adapter.SelectCommand.Parameters.AddWithValue("@endereco", SqlDbType.VarChar).Value = _dadosCadastroFornecedor.endereco;
                    adapter.SelectCommand.Parameters.AddWithValue("@complemento", SqlDbType.VarChar).Value = _dadosCadastroFornecedor.complemento;
                    adapter.SelectCommand.Parameters.AddWithValue("@numero", SqlDbType.VarChar).Value = _dadosCadastroFornecedor.numero;
                    adapter.SelectCommand.Parameters.AddWithValue("@bairro", SqlDbType.VarChar).Value = _dadosCadastroFornecedor.bairro;
                    adapter.SelectCommand.Parameters.AddWithValue("@cidade", SqlDbType.VarChar).Value = _dadosCadastroFornecedor.cidade;
                    adapter.SelectCommand.Parameters.AddWithValue("@uf", SqlDbType.VarChar).Value = _dadosCadastroFornecedor.uf;
                    adapter.SelectCommand.Parameters.AddWithValue("@telefone", SqlDbType.VarChar).Value = _dadosCadastroFornecedor.telefone;
                    adapter.SelectCommand.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = _dadosCadastroFornecedor.email;
                    adapter.SelectCommand.Parameters.AddWithValue("@observacoes", SqlDbType.VarChar).Value = _dadosCadastroFornecedor.observacao;
                    adapter.SelectCommand.Parameters.AddWithValue("@fk_cf_id", SqlDbType.Int).Value = _dadosCadastroFornecedor.codigoFornecedor;

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    decimal x = dr.GetDecimal(0);

                    AvisoCantoInferiorDireito.Inclusao();

                    return Convert.ToInt32(x);
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

                    AvisoCantoInferiorDireito.Inclusao();

                    return Convert.ToInt32(x);
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

        #region Inserir Produto

        #region Cadastro Produto

        public int InserirCadastroProduto(DadosProduto _dadosProduto)
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
                    adapter.SelectCommand.Parameters.AddWithValue("@descricao", SqlDbType.VarChar).Value = _dadosProduto.descricaoProduto;
                    adapter.SelectCommand.Parameters.AddWithValue("@un", SqlDbType.VarChar).Value = _dadosProduto.unidade;
                    adapter.SelectCommand.Parameters.AddWithValue("@valorCusto", SqlDbType.Decimal).Value = _dadosProduto.valorCusto;
                    adapter.SelectCommand.Parameters.AddWithValue("@porcentagem", SqlDbType.Decimal).Value = _dadosProduto.porcentagem;
                    adapter.SelectCommand.Parameters.AddWithValue("@valorVenda", SqlDbType.Decimal).Value = _dadosProduto.valorVenda;
                    adapter.SelectCommand.Parameters.AddWithValue("@lucro", SqlDbType.Decimal).Value = _dadosProduto.lucro;
                    adapter.SelectCommand.Parameters.AddWithValue("@precoAtacado", SqlDbType.Decimal).Value = _dadosProduto.precoAtacado;
                    adapter.SelectCommand.Parameters.AddWithValue("@grupo", SqlDbType.VarChar).Value = _dadosProduto.grupo;
                    adapter.SelectCommand.Parameters.AddWithValue("@subGrupo", SqlDbType.VarChar).Value = _dadosProduto.subGrupo;
                    adapter.SelectCommand.Parameters.AddWithValue("@fonecedor", SqlDbType.VarChar).Value = _dadosProduto.fornecedor;
                    adapter.SelectCommand.Parameters.AddWithValue("@estoqueMinimo", SqlDbType.Decimal).Value = _dadosProduto.estoqueMinimo;
                    adapter.SelectCommand.Parameters.AddWithValue("@garantia", SqlDbType.VarChar).Value = _dadosProduto.garantia;
                    adapter.SelectCommand.Parameters.AddWithValue("@marca", SqlDbType.VarChar).Value = _dadosProduto.marca;
                    adapter.SelectCommand.Parameters.AddWithValue("@referencia", SqlDbType.VarChar).Value = _dadosProduto.referencia;
                    adapter.SelectCommand.Parameters.AddWithValue("@validade", SqlDbType.Date).Value = _dadosProduto.validade;
                    adapter.SelectCommand.Parameters.AddWithValue("@comissao", SqlDbType.Decimal).Value = _dadosProduto.comissao;
                    adapter.SelectCommand.Parameters.AddWithValue("@observacao", SqlDbType.VarChar).Value = _dadosProduto.observacao;
                    adapter.SelectCommand.Parameters.AddWithValue("@fk_ip_id", SqlDbType.Int).Value = _dadosProduto.primarykey;

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    decimal x = dr.GetDecimal(0);

                    AvisoCantoInferiorDireito.Inclusao();

                    return Convert.ToInt32(x);
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

                    AvisoCantoInferiorDireito.Inclusao();

                    return Convert.ToInt32(x);
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarImagemProdutoNoBanco(ex);

                return 0;
            }
        }

        #endregion Inserir Imagem Cadastro Produto

        #endregion Inserir Produto

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

        public void InserirCadastroEmpresa(DadosCadastroEmpresa _dadosCadastroEmpresa, Image _logoEmpresa, Image _qrCode)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_CadastroEmpresa (ce_razao_social,ce_cnpj,ce_nome_fantasia,ce_cep,ce_endereco,ce_complemento," +
                        "ce_bairro,ce_cidade,ce_uf,ce_numero,ce_telefone,ce_email,ce_texto_padrao,ce_logo_empresa,ce_codigo_pix,ce_chave_pix,ce_qr_code)" +
                        " values(@razaoSocial,@cnpj,@nomeFantasia,@cep,@endereco,@complemento,@bairro,@cidade,@uf,@numero,@telefone," +
                        "@email,@textoPadrao,@logoEmpresa,@codigoPix,@chavePix,@qrCode)";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    cmd.Parameters.AddWithValue("@razaoSocial", SqlDbType.VarChar).Value = _dadosCadastroEmpresa.razaoSocial;
                    cmd.Parameters.AddWithValue("@cnpj", SqlDbType.VarChar).Value = _dadosCadastroEmpresa.cnpj;
                    cmd.Parameters.AddWithValue("@nomeFantasia", SqlDbType.VarChar).Value = _dadosCadastroEmpresa.nomeFantasia;
                    cmd.Parameters.AddWithValue("@cep", SqlDbType.VarChar).Value = _dadosCadastroEmpresa.cep;
                    cmd.Parameters.AddWithValue("@endereco", SqlDbType.VarChar).Value = _dadosCadastroEmpresa.endereco;
                    cmd.Parameters.AddWithValue("@complemento", SqlDbType.VarChar).Value = _dadosCadastroEmpresa.complemento;
                    cmd.Parameters.AddWithValue("@bairro", SqlDbType.VarChar).Value = _dadosCadastroEmpresa.bairro;
                    cmd.Parameters.AddWithValue("@cidade", SqlDbType.VarChar).Value = _dadosCadastroEmpresa.cidade;
                    cmd.Parameters.AddWithValue("@uf", SqlDbType.VarChar).Value = _dadosCadastroEmpresa.uf;
                    cmd.Parameters.AddWithValue("@numero", SqlDbType.Int).Value = _dadosCadastroEmpresa.numero;
                    cmd.Parameters.AddWithValue("@telefone", SqlDbType.VarChar).Value = _dadosCadastroEmpresa.telefone;
                    cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = _dadosCadastroEmpresa.email;
                    cmd.Parameters.AddWithValue("@textoPadrao", SqlDbType.VarChar).Value = _dadosCadastroEmpresa.textoPadrao;
                    cmd.Parameters.AddWithValue("@codigoPix", SqlDbType.VarChar).Value = _dadosCadastroEmpresa.codigoQR;
                    cmd.Parameters.AddWithValue("@chavePix", SqlDbType.VarChar).Value = _dadosCadastroEmpresa.chavePix;

                    byte[] arr;
                    byte[] err;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(_logoEmpresa, typeof(byte[]));
                    err = (byte[])converter.ConvertTo(_qrCode, typeof(byte[]));
                    cmd.Parameters.Add("@logoEmpresa", SqlDbType.Image).Value = arr;
                    cmd.Parameters.Add("@qrCode", SqlDbType.Image).Value = err;

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

        public void InserirUsuario(string _usuario, string _senha, string _excluirItem, string _devolucaoTroca,
            string _cancelarVenda, string _cancelarPagamento)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_CadastroUsuario (cu_usuario,cu_senha, cu_excluir_item," +
                        "cu_devolucao_troca,cu_cancelar_venda,cu_cancelar_pagamento) " +
                        "values(@usuario,@senha,@excluirItem,@forms_Troca,@cancelarVenda,@cancelarPagamento)";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@usuario", SqlDbType.VarChar).Value = _usuario;
                    cmd.Parameters.AddWithValue("@senha", SqlDbType.VarChar).Value = _senha;
                    cmd.Parameters.AddWithValue("@excluirItem", SqlDbType.VarChar).Value = _excluirItem;
                    cmd.Parameters.AddWithValue("@forms_Troca", SqlDbType.VarChar).Value = _devolucaoTroca;
                    cmd.Parameters.AddWithValue("@cancelarVenda", SqlDbType.VarChar).Value = _cancelarVenda;
                    cmd.Parameters.AddWithValue("@cancelarPagamento", SqlDbType.VarChar).Value = _cancelarPagamento;

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
            DateTime _vencimento, string _frequencia, decimal _valor, string _quantidadeParcelas, decimal _valorParcelas, string _categoria)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_DespesasCustos ( dc_tipo, dc_descricao, dc_fornecedor_titulo, dc_cnpj, " +
                                   "dc_emissao, dc_vencimento, dc_frequencia, dc_valor, dc_quantidade_parcelas, " +
                                   "dc_valor_parcela, dc_categoria, dc_estatus_pagamento," +
                                   "dc_desconto_taxas, dc_juros_multa, dc_valor_pago,dc_verificar) " +
                                   "values(@tipo,@descricao,@fornecedorTitulo,@cnpj,@emissao,@vencimento,@frequencia," +
                                   "@valor,@quantidadeParcelas,@valorParcelas,@categoria,'Nao Pago',0,0,0,'nok')";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@tipo", SqlDbType.VarChar).Value = _tipo;
                    cmd.Parameters.AddWithValue("@descricao", SqlDbType.VarChar).Value = _descricao;
                    cmd.Parameters.AddWithValue("@fornecedorTitulo", SqlDbType.VarChar).Value = _forncedorTitulo;
                    cmd.Parameters.AddWithValue("@cnpj", SqlDbType.VarChar).Value = _cnpj;
                    cmd.Parameters.AddWithValue("@emissao", SqlDbType.Date).Value = _emissao;
                    cmd.Parameters.AddWithValue("@vencimento", SqlDbType.Date).Value = _vencimento;
                    cmd.Parameters.AddWithValue("@frequencia", SqlDbType.VarChar).Value = _frequencia;
                    cmd.Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = _valor;
                    cmd.Parameters.AddWithValue("@quantidadeParcelas", SqlDbType.VarChar).Value = _quantidadeParcelas;
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

        public void InserirEstoqueProduto(int _ne_numero_nf, int _codigoProduto)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_EstoqueProduto (ep_nf_entrada, ep_codigo_produto,ep_descricao," +
                        "ep_unidade,ep_valor_unitario,ep_quantidade,ep_status,ep_data_entrada) " +
                        "select ne_numero_nf, ne_codigo_produto, ne_descricao_produto, ne_unidade," +
                        "(select cp_valor_venda from tb_CadastroProdutos where cp_id = @codigoProduto), " +
                        "ne_quantidade,'-',GETDATE() " +
                        "from tb_NotaFiscalEntrada where ne_numero_nf = @ne_numero_nf " +
                        "and ne_codigo_produto = @codigoProduto ";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@ne_numero_nf", SqlDbType.Int).Value = _ne_numero_nf;
                    cmd.Parameters.AddWithValue("@codigoProduto", SqlDbType.Int).Value = _codigoProduto;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarEstoqueProdutoNoBanco(ex);
            }
        }

        #endregion Inserir Estoque Produto

        #region InserirImagemStatusPagamento

        public void InserirImagemPagamentoDespesaCusto(Image _imagem, int _codigo, string _statusPagamento)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update tb_DespesasCustos set dc_imagem_pagamento = @imagem, dc_estatus_pagamento = @estatusPagamento " +
                                   "where dc_codigo = @codigo";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(_imagem, typeof(byte[]));
                    adapter.SelectCommand.Parameters.Add("@imagem", SqlDbType.Image).Value = arr;
                    adapter.SelectCommand.Parameters.AddWithValue("@codigo", _codigo);
                    adapter.SelectCommand.Parameters.AddWithValue("@estatusPagamento", _statusPagamento);

                    adapter.SelectCommand.ExecuteReader();

                    AvisoCantoInferiorDireito.Inclusao();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarImagemPagameentoDespesaCustoNoBanco(ex);
            }
        }

        #endregion InserirImagemStatusPagamento

        #region Despesa Custos Fixo Repeticao

        public void DespesaCustosFixoRepeticao(int _codigo, string _tipo, string _descricao, string _fornecedorTitulo, string _cnpj,
            DateTime _emissao, DateTime _vencimento, string _frequencia, decimal _valor, string _quantidadeParcela,
            decimal _valorParcela, string _categoria, Image _imagem)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_DespesasCustos (dc_codigo ,dc_tipo, dc_descricao, dc_fornecedor_titulo,dc_cnpj, " +
                                   "dc_emissao, dc_vencimento, dc_frequencia,dc_valor, dc_quantidade_parcelas, dc_valor_parcela, " +
                                   "dc_categoria, dc_imagem_pagamento, dc_estatus_pagamento, dc_desconto_taxas," +
                                   "dc_juros_multa, dc_valor_pago, dc_verificar) " +
                                   "values (@codigo,@tipo,@descricao,@fornecedorTitulo,@cnpj,@emissao,@vencimento,@frequencia,@valor,@quantidadeParcela," +
                                   "@valorParcela,@categoria,@imagem,'Nao Pago',0,0,0,'nok')";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(_imagem, typeof(byte[]));
                    adapter.SelectCommand.Parameters.AddWithValue("@codigo", _codigo);
                    adapter.SelectCommand.Parameters.AddWithValue("@tipo", _tipo);
                    adapter.SelectCommand.Parameters.AddWithValue("@descricao", _descricao);
                    adapter.SelectCommand.Parameters.AddWithValue("@fornecedorTitulo", _fornecedorTitulo);
                    adapter.SelectCommand.Parameters.AddWithValue("@cnpj", _cnpj);
                    adapter.SelectCommand.Parameters.AddWithValue("@emissao", _emissao);
                    adapter.SelectCommand.Parameters.AddWithValue("@vencimento", _vencimento);
                    adapter.SelectCommand.Parameters.AddWithValue("@frequencia", _frequencia);
                    adapter.SelectCommand.Parameters.AddWithValue("@valor", _valor);
                    adapter.SelectCommand.Parameters.AddWithValue("@quantidadeParcela", _quantidadeParcela);
                    adapter.SelectCommand.Parameters.AddWithValue("@valorParcela", _valorParcela);
                    adapter.SelectCommand.Parameters.AddWithValue("@categoria", _categoria);
                    adapter.SelectCommand.Parameters.Add("@imagem", SqlDbType.Image).Value = arr;

                    adapter.SelectCommand.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarDespesaCustoFixaNoBanco(ex);
            }
        }

        #endregion Despesa Custos Fixo Repeticao

        #region Nota Fiscal Saida

        public void NotaFiscalSaida(string _cpfCpnjCliente, int _numeroNF, int _codigoProduto, string _descricao,
    decimal _quantidade, decimal _valorUnitario, DateTime _emissao, int _codigoBarras, string _vendedor,
    DateTime _garantia, string _nomeCliente, string _tipoPagamento, decimal _valorDesconto, int _quantidadeParcelas,
    decimal _valorJuros, decimal _valorPago, string _unidade,
     string _status, string _trocaVendedor, string _motivoTroca, int _nfEntrada)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_NotaFiscalSaida " +
                        "(ns_cpf_cpnj_cliente, ns_numero_nf,ns_codigo_produto, ns_descricao, ns_quantidade, ns_valor_unitario," +
                        "ns_emissao, ns_codigo_barras, ns_vendedor, ns_garantia,ns_nome_cliente, ns_tipo_pagamento,ns_valor_desconto," +
                        "ns_quantidade_parcelas,ns_valor_juros,ns_valor_pago,ns_unidade,ns_status,ns_troca_vendedor,ns_motivo_troca,ns_nf_entrada) " +
                        "values(  @cpfCpnjCliente, @numeroNF, @codigoProduto, @descricao, @quantidade, " +
                        "@valorUnitario, @emissao, @codigoBarras, @vendedor, @garantia, @nomeCliente, @tipoPagamento,@valorDesconto,@quantidadeParcelas," +
                        "@valorJuros,@valorPago,@unidade,@status,@trocaVendedor,@motivoTroca,@nfEntrada)";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@cpfCpnjCliente", _cpfCpnjCliente);
                    cmd.Parameters.AddWithValue("@numeroNF", _numeroNF);
                    cmd.Parameters.AddWithValue("@codigoProduto", _codigoProduto);
                    cmd.Parameters.AddWithValue("@descricao", _descricao);
                    cmd.Parameters.AddWithValue("@valorUnitario", _valorUnitario);
                    cmd.Parameters.AddWithValue("@quantidade", _quantidade);
                    cmd.Parameters.AddWithValue("@emissao", _emissao);
                    cmd.Parameters.AddWithValue("@codigoBarras", _codigoBarras);
                    cmd.Parameters.AddWithValue("@vendedor", _vendedor);
                    cmd.Parameters.AddWithValue("@garantia", _garantia);
                    cmd.Parameters.AddWithValue("@nomeCliente", _nomeCliente);
                    cmd.Parameters.AddWithValue("@tipoPagamento", _tipoPagamento);
                    cmd.Parameters.AddWithValue("@valorDesconto", _valorDesconto);
                    cmd.Parameters.AddWithValue("@quantidadeParcelas", _quantidadeParcelas);
                    cmd.Parameters.AddWithValue("@valorJuros", _valorJuros);
                    cmd.Parameters.AddWithValue("@valorPago", _valorPago);
                    cmd.Parameters.AddWithValue("@unidade", _unidade);
                    cmd.Parameters.AddWithValue("@status", _status);
                    cmd.Parameters.AddWithValue("@trocaVendedor", _trocaVendedor);
                    cmd.Parameters.AddWithValue("@motivoTroca", _motivoTroca);
                    cmd.Parameters.AddWithValue("@nfEntrada", _nfEntrada);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarNotaFiscalSaidaNoBanco(ex);
            }
        }

        public void NotaFiscalSaida(DadosNotaFiscalSaida _dadosNotaFiscalSaida)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_NotaFiscalSaida " +
                        "(ns_cpf_cpnj_cliente, ns_numero_nf,ns_codigo_produto, ns_descricao, ns_quantidade, ns_valor_unitario," +
                        "ns_emissao, ns_codigo_barras, ns_vendedor, ns_garantia,ns_nome_cliente, ns_tipo_pagamento,ns_valor_desconto," +
                        "ns_quantidade_parcelas,ns_valor_juros,ns_valor_pago,ns_unidade,ns_status,ns_troca_vendedor,ns_motivo_troca,ns_nf_entrada) " +
                        "values(  @cpfCpnjCliente, @numeroNF, @codigoProduto, @descricao, @quantidade, " +
                        "@valorUnitario, @emissao, @codigoBarras, @vendedor, @garantia, @nomeCliente, @tipoPagamento,@valorDesconto,@quantidadeParcelas," +
                        "@valorJuros,@valorPago,@unidade,@status,@trocaVendedor,@motivoTroca,@nfEntrada)";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@cpfCpnjCliente", _dadosNotaFiscalSaida.cpf);
                    cmd.Parameters.AddWithValue("@numeroNF", _dadosNotaFiscalSaida.numeroNF);
                    cmd.Parameters.AddWithValue("@codigoProduto", _dadosNotaFiscalSaida.codigoProduto);
                    cmd.Parameters.AddWithValue("@descricao", _dadosNotaFiscalSaida.descricao);
                    cmd.Parameters.AddWithValue("@valorUnitario", _dadosNotaFiscalSaida.valorUnitario);
                    cmd.Parameters.AddWithValue("@quantidade", _dadosNotaFiscalSaida.quantidade);
                    cmd.Parameters.AddWithValue("@emissao", _dadosNotaFiscalSaida.emissao);
                    cmd.Parameters.AddWithValue("@codigoBarras", _dadosNotaFiscalSaida.codigoBarras);
                    cmd.Parameters.AddWithValue("@vendedor", _dadosNotaFiscalSaida.vendedor);
                    cmd.Parameters.AddWithValue("@garantia", _dadosNotaFiscalSaida.validadeTroca);
                    cmd.Parameters.AddWithValue("@nomeCliente", _dadosNotaFiscalSaida.nomeCliente);
                    cmd.Parameters.AddWithValue("@tipoPagamento", _dadosNotaFiscalSaida.tipoPagamento);
                    cmd.Parameters.AddWithValue("@valorDesconto", _dadosNotaFiscalSaida.valorDesconto);
                    cmd.Parameters.AddWithValue("@quantidadeParcelas", _dadosNotaFiscalSaida.quantidadeParcelas);
                    cmd.Parameters.AddWithValue("@valorJuros", _dadosNotaFiscalSaida.valorJuros);
                    cmd.Parameters.AddWithValue("@valorPago", _dadosNotaFiscalSaida.valorPago);
                    cmd.Parameters.AddWithValue("@unidade", _dadosNotaFiscalSaida.unidade);
                    cmd.Parameters.AddWithValue("@status", _dadosNotaFiscalSaida.status);
                    cmd.Parameters.AddWithValue("@trocaVendedor", _dadosNotaFiscalSaida.trocarVendedor);
                    cmd.Parameters.AddWithValue("@motivoTroca", _dadosNotaFiscalSaida.motivoTroca);
                    cmd.Parameters.AddWithValue("@nfEntrada", _dadosNotaFiscalSaida.nfEntrada);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarNotaFiscalSaidaNoBanco(ex);
            }
        }

        #endregion Nota Fiscal Saida

        #region Adicionar No Estoque Material Segregado

        public void AdicionarNoEstoqueMaterialSegregado(int _nfEntrada, int? _codigoBarras, int _codigoProduto,
            string _descricao, decimal _quantidade, string _unidade, decimal _valorUnitario, DateTime? _dataEntrada,
            decimal? _descontoPorItem, string _status)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_EstoqueProduto (ep_nf_entrada,ep_codigo_barras," +
                        "ep_codigo_produto, ep_descricao, ep_quantidade, ep_unidade,ep_valor_unitario," +
                        " ep_data_entrada, ep_desconto_por_item,ep_status) " +
                        "values(@nfEntrada,@codigoBarras,@codigoProduto,@descricao,@quantidade,@unidade,@valorUnitario," +
                        "@dataEntrada,@descontoPorItem,@status) ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.Add("@nfEntrada", _nfEntrada);
                    adapter.SelectCommand.Parameters.Add("@codigoBarras", _codigoBarras);
                    adapter.SelectCommand.Parameters.Add("@codigoProduto", _codigoProduto);
                    adapter.SelectCommand.Parameters.Add("@descricao", _descricao);
                    adapter.SelectCommand.Parameters.Add("@quantidade", _quantidade);
                    adapter.SelectCommand.Parameters.Add("@unidade", _unidade);
                    adapter.SelectCommand.Parameters.Add("@valorUnitario", _valorUnitario);
                    adapter.SelectCommand.Parameters.Add("@dataEntrada", _dataEntrada);
                    adapter.SelectCommand.Parameters.Add("@descontoPorItem", _descontoPorItem);
                    adapter.SelectCommand.Parameters.Add("@status", _status);

                    adapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarNoEstoqueMaterialSegregadoNoBanco(ex);
            }
        }

        #endregion Adicionar No Estoque Material Segregado

        #region Adicionar Pagamento Carner

        public void AdicionarPagamentoCarner(int _numeroNF, string _cpfCnpjCliente, string _nomeCliente, DateTime _emissao, string _vendedor,
            string _parcela, decimal _valorDesconto, decimal _valorJuros, decimal _valorPago, DateTime _vencimento,
            string _pagamentoVendedor, string _status, decimal _valorParcela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_PagamentoCarne (pc_numero_nf, pc_cpf_cpnj_cliente, pc_nome_cliente, " +
                        "pc_emissao, pc_vendedor, pc_parcela, pc_valor_desconto, pc_valor_juros, pc_valor_pago, " +
                        "pc_vencimento, pc_pagamento_vendedor, pc_status ,pc_valor_parcela) " +
                        "values (@numeroNF, @cpfCnpjCliente, @nomeCliente, @emissao,@vendedor, @parcela, @valorDesconto, " +
                        "@valorJuros, @valorPago, @vencimento, @pagamentoVendedor, @status, @valorParcela)";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                    adapter.SelectCommand.Parameters.AddWithValue("@numeroNF", _numeroNF);
                    adapter.SelectCommand.Parameters.AddWithValue("@cpfCnpjCliente", _cpfCnpjCliente);
                    adapter.SelectCommand.Parameters.AddWithValue("@nomeCliente", _nomeCliente);
                    adapter.SelectCommand.Parameters.AddWithValue("@emissao", _emissao);
                    adapter.SelectCommand.Parameters.AddWithValue("@vendedor", _vendedor);
                    adapter.SelectCommand.Parameters.AddWithValue("@parcela", _parcela);
                    adapter.SelectCommand.Parameters.AddWithValue("@valorDesconto", _valorDesconto);
                    adapter.SelectCommand.Parameters.AddWithValue("@valorJuros", _valorJuros);
                    adapter.SelectCommand.Parameters.AddWithValue("@valorPago", _valorPago);
                    adapter.SelectCommand.Parameters.AddWithValue("@vencimento", _vencimento);
                    adapter.SelectCommand.Parameters.AddWithValue("@pagamentoVendedor", _pagamentoVendedor);
                    adapter.SelectCommand.Parameters.AddWithValue("@status", _status);
                    adapter.SelectCommand.Parameters.AddWithValue("@valorParcela", _valorParcela);

                    adapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarPagamentoCarneNoBanco(ex);
            }
        }

        #endregion Adicionar Pagamento Carner
    }
}