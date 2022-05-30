using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class DadosGrupoMaterial
    {
        public string grupo { get; set; }

        public string sub_grupo { get; set; }

        public DadosGrupoMaterial(string _grupo, string _sub_grupo)
        {
            grupo = _grupo;
            sub_grupo = _sub_grupo;
        }
    }
}