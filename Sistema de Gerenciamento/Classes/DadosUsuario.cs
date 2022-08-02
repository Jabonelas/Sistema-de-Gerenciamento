using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class DadosUsuario
    {
        public string usuario { get; set; }

        public DadosUsuario(string _usuario)
        {
            usuario = _usuario;
        }
    }
}