using System;

namespace Recursion
{
    class Program
    {
        static void Main()
        {
            int n = 20;
            int[] mass = DoMass(n);
            //PrintMass(mass);
            int pow = 12;
            Console.WriteLine($"2 в {pow} степени = {FastPow(2, 12)}");
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
        static bool IsPositiveNumber(int[] mass, int end)
        {
            if (end == 0)
                return false;
            return mass[end] > 0 || IsPositiveNumber(mass, end - 1);
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
        static bool IsSymmMass(int[] mass, int start)
        {
            if (start == mass.Length / 2 + 1)
                return true;
            return (mass[start] == mass[^(start + 1)]) ? IsSymmMass(mass, start + 1) : false; 
        }
        static int FastPow(int number, int power)
        {
            if (power == 0)
                return 1;
            int temp = FastPow(number, power / 2);
            return power % 2 == 0 ? temp * temp : number * temp * temp;
        }
    }
}