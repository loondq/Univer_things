using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Complex c1 = new(0, 1);
            Console.WriteLine($"c1 = {c1}");
            Console.WriteLine($"Аргумент = {c1.GetArg()}");
            Console.WriteLine($"Модуль = {c1.GetMod()}");
            Complex c2 = new(6, 8);
            Console.WriteLine($"c2 = {c2}");
            c1.Division(c2);
            Console.WriteLine($"деление C1 на C2 = {c1}");
        }
    }
}