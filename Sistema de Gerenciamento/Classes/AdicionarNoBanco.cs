﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento
{
    internal class AdicionarNoBanco : ConectarBanco
    {
        private MensagensErro Erro = new MensagensErro();

        #region Inserir Cadastro Cliente

        public void InserirCadastroCliente(DateTime _dataCadastro, string _nomeCliente, string _tipo, string _cPF_CNPJ,
        string _rG, string _emissor, string _dataEmissao, string _ins_Est, string _cEP, string _endereco, int _numero, string _complemento,
        string _bairro, string _cidade, string _uF, string _naturalidade, string _dataNasc, string _estadoCivil, decimal _credito,
        decimal _saldo, string _bloqueio, string _celular, string _tel_Residencial, string _email, string _observacoes)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_CadastroClientes (cc_data_cadastro,cc_nome_cliente," +
                        "cc_tipo,cc_cpf_cnpj,cc_rg,cc_emissor,cc_data_emissao,cc_ins_est,cc_cep,cc_endereco," +
                        "cc_numero,cc_complemento,cc_bairro,cc_cidade,cc_uf,cc_naturalidade,cc_data_nasc," +
                        "cc_estado_civil,cc_credito,cc_saldo,cc_bloqueio,cc_celular,cc_tel_residencial,cc_email,cc_observacoes) " +
                        "values (@DataCadastro,@NomeCliente,@Tipo,@CPF_CNPJ," +
                        "@RG,@Emissor,@DataEmissao,@Ins_Est,@CEP,@Endereco,@numero,@Complemento,@Bairro,@Cidade,@UF,@Naturalidade," +
                        "@DataNasc,@EstadoCivil,@Credito,@Saldo,@Bloqueio,@Celular,@Tel_Residencial,@Email,@Observacoes)";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@DataCadastro", SqlDbType.Date).Value = _dataCadastro;
                    cmd.Parameters.AddWithValue("@NomeCliente", SqlDbType.VarChar).Value = _nomeCliente;
                    cmd.Parameters.AddWithValue("@Tipo", SqlDbType.VarChar).Value = _tipo;
                    cmd.Parameters.AddWithValue("@CPF_CNPJ", SqlDbType.VarChar).Value = _cPF_CNPJ;
                    cmd.Parameters.AddWithValue("@RG", SqlDbType.VarChar).Value = _rG;
                    cmd.Parameters.AddWithValue("@Emissor", SqlDbType.VarChar).Value = _emissor;
                    cmd.Parameters.AddWithValue("@DataEmissao", SqlDbType.VarChar).Value = _dataEmissao;
                    cmd.Parameters.AddWithValue("@Ins_Est", SqlDbType.VarChar).Value = _ins_Est;
                    cmd.Parameters.AddWithValue("@CEP", SqlDbType.VarChar).Value = _cEP;
                    cmd.Parameters.AddWithValue("@Endereco", SqlDbType.VarChar).Value = _endereco;
                    cmd.Parameters.AddWithValue("@numero", SqlDbType.Int).Value = _numero;
                    cmd.Parameters.AddWithValue("@Complemento", SqlDbType.VarChar).Value = _complemento;
                    cmd.Parameters.AddWithValue("@Bairro", SqlDbType.VarChar).Value = _bairro;
                    cmd.Parameters.AddWithValue("@Cidade", SqlDbType.VarChar).Value = _cidade;
                    cmd.Parameters.AddWithValue("@UF", SqlDbType.VarChar).Value = _uF;
                    cmd.Parameters.AddWithValue("@Naturalidade", SqlDbType.VarChar).Value = _naturalidade;
                    cmd.Parameters.AddWithValue("@DataNasc", SqlDbType.VarChar).Value = _dataNasc;
                    cmd.Parameters.AddWithValue("@EstadoCivil", SqlDbType.VarChar).Value = _estadoCivil;
                    cmd.Parameters.AddWithValue("@Credito", SqlDbType.Decimal).Value = _credito;
                    cmd.Parameters.AddWithValue("@Saldo", SqlDbType.Decimal).Value = _saldo;
                    cmd.Parameters.AddWithValue("@Bloqueio", SqlDbType.VarChar).Value = _bloqueio;
                    cmd.Parameters.AddWithValue("@Celular", SqlDbType.VarChar).Value = _celular;
                    cmd.Parameters.AddWithValue("@Tel_Residencial", SqlDbType.VarChar).Value = _tel_Residencial;
                    cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = _email;
                    cmd.Parameters.AddWithValue("@Observacoes", SqlDbType.VarChar).Value = _observacoes;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarClienteNoBanco(ex);
            }
        }

        #endregion Inserir Cadastro Cliente

        #region Inserir Imagem Cadastro Cliente

        public void InserirImagemNoCadastroCliente(Image _imagem)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_ImagemCliente (ic_imagem) values (@imagem)";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(_imagem, typeof(byte[]));
                    cmd.Parameters.Add("@imagem", SqlDbType.Image).Value = arr;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarImagemClienteNoBanco(ex);
            }
        }

        #endregion Inserir Imagem Cadastro Cliente

        #region Cadastro Fornecedor

        public void InserirCadastroForncedor(string _razaoSocial, DateTime _dataCadastro, string _cnpj, string _nomeFantasia,
                    string _cep, string _endereco, string _complemento, int _numero, string _bairro, string _cidade, string _uf,
                    string _telefone, string _email, string _observacoes)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_CadastroFornecedor (cf_razao_social,cf_data_cadastro,cf_cnpj,cf_nome_fantasia,cf_cep," +
                        "cf_endereco,cf_complemento,cf_numero,cf_bairro,cf_cidade,cf_uf,cf_telefone,cf_email,cf_observacoes) " +
                        "values (@razaoSocial,@dataCadastro,@cnpj,@nomeFantasia,@cep,@endereco,@complemento,@numero,@bairro,@cidade," +
                        "@uf,@telefone,@email,@observacoes)";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@razaoSocial", SqlDbType.Date).Value = _razaoSocial;
                    cmd.Parameters.AddWithValue("@dataCadastro", SqlDbType.Date).Value = _dataCadastro;
                    cmd.Parameters.AddWithValue("@cnpj", SqlDbType.VarChar).Value = _cnpj;
                    cmd.Parameters.AddWithValue("@nomeFantasia", SqlDbType.VarChar).Value = _nomeFantasia;
                    cmd.Parameters.AddWithValue("@cep", SqlDbType.VarChar).Value = _cep;
                    cmd.Parameters.AddWithValue("@endereco", SqlDbType.VarChar).Value = _endereco;
                    cmd.Parameters.AddWithValue("@complemento", SqlDbType.VarChar).Value = _complemento;
                    cmd.Parameters.AddWithValue("@numero", SqlDbType.VarChar).Value = _numero;
                    cmd.Parameters.AddWithValue("@bairro", SqlDbType.VarChar).Value = _bairro;
                    cmd.Parameters.AddWithValue("@cidade", SqlDbType.VarChar).Value = _cidade;
                    cmd.Parameters.AddWithValue("@uf", SqlDbType.VarChar).Value = _uf;
                    cmd.Parameters.AddWithValue("@telefone", SqlDbType.Int).Value = _telefone;
                    cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = _email;
                    cmd.Parameters.AddWithValue("@observacoes", SqlDbType.VarChar).Value = _observacoes;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoAdicionarFornecedorNoBanco(ex);
            }
        }

        #endregion Cadastro Fornecedor

        #region Inserir Imagem Cadastro Fornecedor

        public void InserirImagemNoCadastroFornecedor(Image _imagem)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "insert into tb_ImagemFornecedor (if_imagem) values (@imagem)";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(_imagem, typeof(byte[]));
                    cmd.Parameters.Add("@imagem", SqlDbType.Image).Value = arr;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Erro.ErroAoCadastroFornecedor(ex);
            }
        }

        #endregion Inserir Imagem Cadastro Fornecedor
    }
}