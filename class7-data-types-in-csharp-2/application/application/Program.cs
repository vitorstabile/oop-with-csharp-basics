using System;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome1 = "Maria Green"; // string is imutable. Is not a basic type
            String nome2 = "Maria Green";
            Object obj1 = "Alex Brown"; // every class inherite from Object
            Object obj2 = 4.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            int n7 = int.MinValue; // the min value of int
            int n8 = int.MaxValue; // the max value of int
            sbyte n9 = sbyte.MaxValue;
            decimal n10 = decimal.MaxValue;
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
        }
    }
}
