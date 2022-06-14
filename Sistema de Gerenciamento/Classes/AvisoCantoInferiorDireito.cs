using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Gerenciamento.Forms;

namespace Sistema_de_Gerenciamento.Classes
{
    internal static class AvisoCantoInferiorDireito
    {
        #region Inclusao

        public static void Inclusao()
        {
            Global.tipoDoAlerta = "Inclusao";

            Forms_Aviso buscarCliente = new Forms_Aviso();
            buscarCliente.Show();
        }

        #endregion Inclusao

        #region Atualizacao

        public static void Atualizacao()
        {
            Global.tipoDoAlerta = "Atualizacao";

            Forms_Aviso buscarCliente = new Forms_Aviso();
            buscarCliente.Show();
        }

        #endregion Atualizacao

        #region Exclusao

        public static void Exclusao()
        {
            Global.tipoDoAlerta = "Exclusao";

            Forms_Aviso buscarCliente = new Forms_Aviso();
            buscarCliente.Show();
        }

        #endregion Exclusao
    }
}