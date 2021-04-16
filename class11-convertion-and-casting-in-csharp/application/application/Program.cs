using System;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion

            float x = 4.5f;

            double y = x; // can be convert -> double is bigger than float

            Console.WriteLine(y);

            double a;

            float b;

            a = 5.1;
            // b = a; float is smaller than double. To make this operation you have to make a casting

            b = (float)a; // casting

            Console.WriteLine(b);

            double c;
            int d;

            c = 5.1;
            // d = a; int is smaller than double. To make this operation you have to make a casting, but you will lose information

            d = (int)c; // casting

            Console.WriteLine(d);

            int e = 5;
            int f = 2;

            double result = e / f; // two division with int, dont make a double result. we have to make a casting

            Console.WriteLine(result);

            result = (double) e / f; // casting to result a double from division of two int`s

            Console.WriteLine(result);
        }
    }
}
