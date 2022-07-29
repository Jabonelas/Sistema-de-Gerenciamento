using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento.Classes
{
    internal class DadosFinanceiro
    {
        public decimal descontoAvista { get; set; }
        public decimal jurosCredito { get; set; }
        public int parcelasCredito { get; set; }
        public int prazoCarne { get; set; }
        public decimal jurosCarne { get; set; }
        public int parcelasCarne { get; set; }
        public decimal jurosAtrasoCarne { get; set; }
        public decimal multaAtrasoCarne { get; set; }

        public DadosFinanceiro(decimal _descontoAvista, decimal _jurosCredito, int _parcelasCredito, int _prazoCarne,
        decimal _jurosCane, int _parcelasCarne, decimal _jurosAtrasoCarne, decimal _multaAtrasoCarne)
        {
            descontoAvista = _descontoAvista;
            jurosCredito = _jurosCredito;
            parcelasCredito = _parcelasCredito;
            prazoCarne = _prazoCarne;
            jurosCarne = _jurosCane;
            parcelasCarne = _parcelasCarne;
            jurosAtrasoCarne = _jurosAtrasoCarne;
            multaAtrasoCarne = _multaAtrasoCarne;
        }
    }
}