using System;
using System.Text;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("|-------------------Weight1------------------|"); Console.ResetColor();
            Console.WriteLine();
            WeightViaGramms wg1 = new(1432);
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"Вы ввели 1 массу через граммы: "); Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(wg1);
            Console.WriteLine();
            WeightViaGramms wg2 = new(756);
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"Вы ввели 2 массу через граммы: "); Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(wg2);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"Cумма: "); Console.ResetColor();
            Console.Write($"\n{wg1 + wg2}");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"Разность: "); Console.ResetColor();
            Console.Write($"\n{wg1 - wg2}");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("|-------------------Weight2------------------|"); Console.ResetColor();
            Console.WriteLine();
            WeightViaPounds wp1 = new(5);
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"Вы ввели 1 массу через фунты: "); Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(wp1);
            Console.WriteLine();
            WeightViaPounds wp2 = new(4);
            Console.ForegroundColor = ConsoleColor.Green;  Console.WriteLine($"Вы ввели 2 массу через фунты: "); Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(wp2);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"Cумма: "); Console.ResetColor();
            Console.Write($"\n{wp1 + wp2}");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"Разность: "); Console.ResetColor();
            Console.Write($"\n{wp1 - wp2}");
            Console.WriteLine();
        }
    }
}