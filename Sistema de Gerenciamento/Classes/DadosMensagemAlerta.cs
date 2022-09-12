using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DashboardWin.Design;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using Sistema_de_Gerenciamento.Properties;
using Image = System.Drawing.Image;

namespace Sistema_de_Gerenciamento.Classes
{
    public class DadosMensagemAlerta
    {
        public string titulo { get; set; }
        public string texto { get; set; }
        public Bitmap image { get; set; }
        public string descricao { get; set; }

        public DadosMensagemAlerta(string _tituloAlerta, Bitmap _imagemAlerta)
        {
            this.titulo = _tituloAlerta;
            this.texto = $"\nClick Aqui Para Verificar!";
            this.image = _imagemAlerta;
        }
    }
}