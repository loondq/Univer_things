using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Fractions f1 = new (24, 12);
            f1.Print();
            Fractions f2 = new (15, 6);
            f2.Print();
        }
    }
}