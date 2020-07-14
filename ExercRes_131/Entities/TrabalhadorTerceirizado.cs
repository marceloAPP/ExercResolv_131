using System;
using System.Collections.Generic;
using System.Text;

namespace ExercRes_131.Entities
{
    class TrabalhadorTerceirizado : Trabalhador
    {
        public double CobrancaAdicional { get; set; }

        public TrabalhadorTerceirizado()
        {
        }

        public TrabalhadorTerceirizado(string nome, int horas, double valorHora, double cobrancaAdicional)
            : base(nome, horas, valorHora)
        {
            CobrancaAdicional = cobrancaAdicional;
        }

        public override double Pagamento()
        {
            double valor = ValorHora * Horas;

            valor += valor + (CobrancaAdicional * 110.0) / 100.0;

            return valor;
        }

    }
}
