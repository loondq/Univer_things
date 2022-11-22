using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Complex c1 = new(12, 17);
            Console.WriteLine($"c1 = {c1}");
            Console.WriteLine($"Аргумент = {c1.GetArg()}");
            Console.WriteLine($"Модуль = {c1.GetMod()}");
            Complex c2 = new(6, 8);
            Console.WriteLine($"c2 = {c2}");
            c1.Multiplication(c2);
            Console.WriteLine($"умножение C1 на C2 = {c1}");
        }
    }
}