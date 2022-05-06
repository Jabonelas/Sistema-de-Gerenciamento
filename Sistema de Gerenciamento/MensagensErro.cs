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
    }
}