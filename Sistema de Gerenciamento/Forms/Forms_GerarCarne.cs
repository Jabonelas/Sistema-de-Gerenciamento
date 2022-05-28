using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gerenciamento.Classes;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_GerarCarne : Form
    {
        private BuscarNoBanco Buscar = new BuscarNoBanco();

        public Forms_GerarCarne()
        {
            InitializeComponent();

            List<DadosCarne> listaCarne = new List<DadosCarne>();

            txtPrazo.Text = listaCarne.[].
        }

        private void Forms_GerarCarne_Load(object sender, EventArgs e)
        {
        }
    }
}