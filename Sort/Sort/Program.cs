using System;

namespace Sort
{
    class Program
    {
        static void Main()
        {
            int n = 20;
            int[] mass = DoMass(n);
            //BubbleSort(mass);
            SelectionSort(ref mass);
            PrintMass(mass);
        }
        static void BubbleSort(int[] mass)
        {
            int n = mass.Length;
            var fl = true;
            while (fl)
            {
                fl = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (mass[i] > mass[i + 1])
                    {
                        var t = mass[i];
                        mass[i] = mass[i + 1];
                        mass[i + 1] = t;
                        fl = true;
                    }
                }
            }
        }
        static void SelectionSort(ref int[] mass)
        {
            int n = mass.Length - 1;
            int[] newMass = new int[mass.Length];
            int max = int.MinValue;
            for (int y = n; y > 1; y--)
            {
                for (int i = 0; i < y; i++)
                {
                    if (mass[i] > max)
                    {
                        max = mass[i];
                    }
                }
                newMass[y] = max;
                max = int.MinValue;
            }
            mass = newMass;
        }
        static int[] DoMass(int n)
        {
            int[] mass = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++) 
                mass[i] = r.Next(-100, 100);
            return mass;
        }
        static void PrintMass(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
                Console.Write($"{mass[i]} ");
            Console.WriteLine();
        }
    }
}