using System;
using System.Collections.Generic;
using System.Text;

namespace ExercRes_131.Entities
{
    class FuncionarioTerceirizado : Funcionario
    {
        public double CobrancaAdicional { get; set; }

        public FuncionarioTerceirizado()
        {
        }

        public FuncionarioTerceirizado(string nome, int horas, double valorHora, double cobrancaAdicional)
            : base(nome, horas, valorHora)
        {
            CobrancaAdicional = cobrancaAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * CobrancaAdicional;
        }

    }
}
