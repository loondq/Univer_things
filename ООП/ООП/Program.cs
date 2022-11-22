using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("|-----------------Complex-----------------|");
            Console.WriteLine();
            Complex c1 = new(5,16);
            Console.WriteLine($"1 комплексное число = {c1}");
            Console.WriteLine($"Аргумент = {c1.GetArg()}");
            Console.WriteLine($"Модуль = {c1.GetMod()}");
            Console.WriteLine();
            Complex c2 = new(6, 8);
            Console.WriteLine($"2 комплексное число = {c2}");
            Console.WriteLine($"Аргумент = {c2.GetArg()}");
            Console.WriteLine($"Модуль = {c2.GetMod()}");
            Console.WriteLine();
            Console.WriteLine($"Сумма = {c1 + c2}");
            Console.WriteLine($"Разность = {c1 - c2}");
            Console.WriteLine($"Умножение = {c1 * c2}");
            Console.WriteLine($"Деление = {c1 / c2}");
            Console.WriteLine();

            Console.WriteLine("|------------------Time-------------------|");
            Console.WriteLine();
            Time t1 = new (22, 58, 58);
            Console.WriteLine($"Время 1: {t1}");
            Time t2 = new(15, 58, 59);
            Console.WriteLine($"Время 2: {t2}");
            Console.WriteLine();
            Console.WriteLine($"Cумма времени = {t1 + t2}");
            Console.WriteLine($"Разность времени = {t1 - t2}");
            Console.WriteLine($"Умножение времени = {t1 * 2}");
            Console.WriteLine($"Деление времени = {t1 / 2}");
        }
    }
}