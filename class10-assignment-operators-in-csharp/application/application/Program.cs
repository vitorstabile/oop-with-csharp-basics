using System;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";

            Console.WriteLine(s);

            s += "DEF";

            Console.WriteLine(s);

            a = 10;
            a++;
            Console.WriteLine(a);

            a = 10;
            int b = a++; // difference -> b = a and a = 11
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 10;
            b = ++a; // a recive 10 + 1 and b = 11
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
