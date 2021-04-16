using System;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            int x;

            Console.WriteLine(x);
            
            Wrong: you need to put a value in this variable to use

             */

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(x);

            /*

            double preco = double.Parse(Console.ReadLine());
            if (preco > 100.0)
            {
                double desconto = preco * 0.1;
            }
            
            // Console.WriteLine(desconto); Wrong -> The variable desconto is in the scope of if

            */

            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;
            if (preco > 100.0)
            {
                desconto = preco * 0.1;
            }
            Console.WriteLine(desconto);
        }
    }
}
