using System;
using System.Collections.Generic;
using System.Globalization;
using ExercRes_131.Entities;

namespace ExercRes_131
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Funcionario> func = new List<Funcionario>();

            Console.Write("\nDigite o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nDados do funcionário nº {i}:");
                Console.Write("Terceirizado (S / N)?");
                char sn = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Horas: ");
                int hora = int.Parse(Console.ReadLine());

                Console.Write("Valor por Hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (sn == 's')
                {
                    Console.Write("Cobrança adicional: ");
                    double valorAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    func.Add(new FuncionarioTerceirizado(nome, hora, valorPorHora, valorAdicional));
                }
                else
                {
                    func.Add(new Funcionario(nome, hora, valorPorHora));
                }

            }

            Console.WriteLine("\nPAGAMENTOS");

            foreach (var item in func)
            {
                Console.WriteLine(item.Nome + " R$ " + item.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
