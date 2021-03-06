﻿namespace ExercRes_131.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorHora { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, int horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        public virtual double Pagamento() {

            return ValorHora * Horas;
        }

    }
}
