using System;
using System.Text;

namespace Sort
{
    class Program
    {
        static void Main()
        {
            int n = 10;
            int[] mass = DoMass(n);
            //BubbleSort(mass);
            //SelectionSort(ref mass);
            PrintMass(mass);
            QuickSort(mass, 0, n-1);
            PrintMass(mass);
            //Console.WriteLine(FindIntRec(mass, 0, n, 5));

        }
        static int[] DoMass(int n)
        {
            int[] mass = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                mass[i] = r.Next(1, 10);
            return mass;
        }
        static void PrintMass(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
                Console.Write($"{mass[i]} ");
            Console.WriteLine();
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
        static void SelectionSort(int[] mass)
        {
            for (int i = 0; i < mass.Length - 1; i++)
            {
                var min = i;
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[j] < mass[min])
                    {
                        min = j;
                    }
                }
                var tempVar = mass[min];
                mass[min] = mass[i];
                mass[i] = tempVar;
            }
        }
        
        static void MergeSort(int[] mass, int a, int b)
        {
            if (b - a < 1)
                return;
            int c = (a + b) / 2;
            MergeSort(mass, a, c);
            MergeSort(mass, c + 1, b);
            int[] mergeArray = new int[b - a + 1];
            int i = a, j = c + 1;
            for (int k = 0; k < mergeArray.Length; k++)
            {
                if (i > c) // ended 1 mass
                    mergeArray[k] = mass[j++];
                else if (j > b) // ended 2 mass
                    mergeArray[k] = mass[i++];
                else if (mass[i] < mass[j])
                    mergeArray[k] = mass[i++];
                else 
                    mergeArray[k] = mass[j++];
            }
            i = a;
            for (int u = 0; u <  mergeArray.Length; u++)
                mass[i++] = mergeArray[u];
        }
        static void QuickSort(int[] mass, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            int centre = mass[leftIndex];
            while (i <= j)
            {
                while (mass[i] < centre)
                    i++;
                while (mass[j] > centre)
                    j--;
            
                if (i <= j)
                {
                    Swap(mass, i, j);
                    i++;
                    j--;
                }
             }
            if (leftIndex < j)
                QuickSort(mass, leftIndex, j);
            if (i < rightIndex)
                QuickSort(mass, i, rightIndex);
         }
        static void Swap(int[] mass, int position, int newPosition)
        {
            int temp = mass[newPosition];
            mass[newPosition] = mass[position];
            mass[position] = temp;
        }
    }
}