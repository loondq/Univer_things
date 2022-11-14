using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Fraction f = new Fraction();
            f.SetNum(11);
            f.SetDenom(12);
            f.Print();
            Console.WriteLine($"Fraction - {f.GetNum()} / {f.GetDenum()}");

        }
    }
}