using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class VerificacaoDeExistencia : ConectarBanco
    {
        private MensagensErro Erro = new MensagensErro();

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
    }
}