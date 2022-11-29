using System;
using System.Text;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("|-----------------Complex-----------------|");
            Console.WriteLine();
            Complex c1 = new(5, 16);
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

            Console.WriteLine("|-------------------Time-------------------|");
            Console.WriteLine();
            Time t1 = new(22, 58, 58);
            Console.WriteLine($"Время 1: {t1}");
            Time t2 = new(15, 58, 59);
            Console.WriteLine($"Время 2: {t2}");
            Console.WriteLine();
            Console.WriteLine($"Cумма времени = {t1 + t2}");
            Console.WriteLine($"Разность времени = {t1 - t2}");
            Console.WriteLine($"Умножение времени = {t1 * 2}");
            Console.WriteLine($"Деление времени = {t1 / 2}");
            Console.WriteLine();

            Console.WriteLine("|-------------------Weight1------------------|");
            Console.WriteLine();
            WeightViaGramms wg1 = new(10, 0);    
            Console.WriteLine($"{wg1.Gramms} грамм");
            Console.WriteLine($"{wg1.Pounds} фунтов");
            Console.WriteLine($"{wg1.Ounce} унций");
            Console.WriteLine();
            WeightViaGramms wg2 = new(34.959);
            Console.WriteLine($"вторая масса - {wg2} грамм");
            Console.WriteLine($"сумма = {wg1 + wg2} грамм");
            Console.WriteLine($"разность = {wg1 - wg2} грамм");
            Console.WriteLine();

            Console.WriteLine("|-------------------Weight2------------------|");
            Console.WriteLine();
            WeightViaPounds wp1 = new(5);
            Console.WriteLine($"{wp1.Gramms} грамм");
            Console.WriteLine($"{wp1.Pounds} фунтов");
            Console.WriteLine($"{wp1.Ounce} унций");
            Console.WriteLine();
            WeightViaPounds wp2 = new(4);
            Console.WriteLine($"вторая масса - {wp2} фунтов");
            Console.WriteLine($"сумма = {wp1 + wp2} фунтов");
            Console.WriteLine($"разность = {wp1 - wp2} фунтов");
        }
    }
}