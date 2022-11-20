using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Fractions f1 = new (24, 12);
            Console.WriteLine(f1);
            Fractions f2 = new (15, 6);
            Console.WriteLine(f2);
            f1.Sum(f2);
            Console.WriteLine(f1);

            Console.WriteLine();

            Complex c1 = new(12, 5);
            Complex c2 = new(5, 17);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            c1.Multiplication(c1);
            Console.WriteLine(c1);
        }
    }
}