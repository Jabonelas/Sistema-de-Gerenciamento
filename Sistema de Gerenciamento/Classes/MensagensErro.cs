using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento
{
    internal class MensagensErro
    {
        #region Cadastro Cliente

        public void ErroAoCadastroCliente(Exception _e)
        {
            MessageBox.Show($"(CAD-CL01) Erro ao Cadastrar Cliente \n\nErro: {_e}", "Erro Cadastro Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Cadastro Cliente

        #region Inserir No Banco

        public void ErroAoAdicionarClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(INS-CL01) Erro ao Inserir Cadastro Cliente \n\nErro: {_e}", "Erro Inserir Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Inserir No Banco

        #region Atualizacao Do Banco

        public void ErroAoAtualizarClienteNoBanco(Exception _e)
        {
            MessageBox.Show($"(ATU-CL01) Erro ao Atualizar Cadastro Cliente \n\nErro: {_e}", "Erro Atualizar Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Atualizacao Do Banco
    }
}