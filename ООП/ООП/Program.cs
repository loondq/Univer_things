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
            f1.Division(f2);
            f1.Print();
        }
    }
}