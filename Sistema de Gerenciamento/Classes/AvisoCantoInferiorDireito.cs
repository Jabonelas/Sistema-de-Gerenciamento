using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Gerenciamento.Forms;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class Aviso
    {
        #region Inclusao

        public void Inclusao()
        {
            Global.tipoDoAlerta = "Inclusao";

            Forms_Aviso buscarCliente = new Forms_Aviso();
            buscarCliente.Show();
        }

        #endregion Inclusao

        #region Atualizacao

        public void Atualizacao()
        {
            Global.tipoDoAlerta = "Atualizacao";

            Forms_Aviso buscarCliente = new Forms_Aviso();
            buscarCliente.Show();
        }

        #endregion Atualizacao

        #region Exclusao

        public void Exclusao()
        {
            Global.tipoDoAlerta = "Exclusao";

            Forms_Aviso buscarCliente = new Forms_Aviso();
            buscarCliente.Show();
        }

        #endregion Exclusao
    }
}