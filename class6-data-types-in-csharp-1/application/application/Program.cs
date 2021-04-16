using System;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            SByte y = 127; // pre-definiton .net variable SByte - System biblio

            Console.WriteLine(x);
            Console.WriteLine(y);

            byte n1 = 126; // can`t use negative values
            int n2 = 1000;
            int n3 = 2147483647; // max value of int
            long n4 = 2147483648;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}
