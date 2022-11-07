using System;

namespace Recursion
{
    class Program
    {
        static void Main()
        {
            int n = 20;
            int[] mass = DoMass(n);
            PrintMass(mass);
            
        }
        static int SumMass(int[] mass, int end)
        {
            if (end == 0)
                return mass[0];
            return mass[end] + SumMass(mass, end - 1);
        }
        static int MassMax(int[] mass, int end)
        {
            if (end == 0)
                return mass[0];
            int oldMax = MassMax(mass, end - 1);
            return (oldMax < mass[end]) ? mass[end] : oldMax;
        }
        static bool FindIntRec(int[] mass, int a, int b, int x)
        {
            int c = (a + b) / 2;
            if (mass[c] == x)
                return true;
            if (a > b)
                return false;
            if (mass[c] < x)
                return FindIntRec(mass, c + 1, b, x);
            return FindIntRec(mass, a, c - 1, x);
        }
        static bool Is
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