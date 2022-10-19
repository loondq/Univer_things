using System;

namespace test
{
    class Project
    {
        static void Main()
        {
            //1 вариант
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            var r = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = r.Next(10);
            Console.WriteLine(String.Join(" ", arr));
            Console.WriteLine($"Сумма чисел между максимальным элементом и минимальным = {FindSumBetweenMaxAndMin(arr)}");
        }
        static int FindSumBetweenMaxAndMin(int[] arr)
        {
            var max = int.MinValue;
            var min = int.MaxValue;
            int index1 = 0;
            int index2 = 0;
            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index1 = i;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    index2 = i;
                }
            }
            for (int k = 1; k < Math.Abs(index2 - index1); k++)
                sum += arr[Math.Min(index1, index2) + k];
            return sum;
        }
    }
}