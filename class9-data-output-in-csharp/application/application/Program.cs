using System;
using System.Globalization;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            String nome = "Maria";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("---------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); // two decimal
            Console.WriteLine(saldo.ToString("F4")); // four decimal
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // use dot(.) to decimal

            // Use of Place holders, concatenation or interpolation

            int idade2 = 32;
            double saldo2 = 10.35784;
            String nome2 = "Maria";
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome2, idade2, saldo2); // placeholder
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo2:F2} reais"); //concatenation
            Console.WriteLine(nome2 + " tem " + idade2 + " anos e tem saldo igual a "+ saldo2.ToString("F2", CultureInfo.InvariantCulture) + " reais"); // interpolation


        }
    }
}
