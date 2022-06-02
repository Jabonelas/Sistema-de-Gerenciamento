using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.UI.WinForms;
using DGVPrinterHelper;

namespace Sistema_de_Gerenciamento.Classes
{
    internal static class Imprimir
    {
        public static void ImprimirGridView(string _nome, BunifuDataGridView _gridView)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = _nome;//Header
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = DateTime.Today.ToString();//Footer
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(_gridView);
        }
    }
}