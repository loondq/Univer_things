using System;

namespace ControlWork
{
    class Program
    {
        static void Main()
        {
            int n = 3;
            int[,] matrix = MakeMatrix(n, n);
            PrintMatrix(matrix);
            WriteMatrixInFile(matrix);
            Console.WriteLine($"макс - {FindMaxAndMinFromMatrix(matrix)[0]}, мин - {FindMaxAndMinFromMatrix(matrix)[1]}");
            PrintMatrix(ReadMatrixFromFile(n));
        }
        static int[,] MakeMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Random r = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = r.Next(1, 100);
                }
            return matrix;
        }
        static int[] FindMaxAndMinFromMatrix(int[,] matrix)
        {
            int index1 = 0, index2 = 0;
            int[] maxAndMin = new int[2];
            maxAndMin[0] = int.MinValue;
            maxAndMin[1] = int.MaxValue;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > maxAndMin[0])
                    {
                        maxAndMin[0] = matrix[i, j];
                        index1 = i;
                    }
                    if (matrix[i, j] < maxAndMin[1])
                    {
                        maxAndMin[1] = matrix[i, j];
                        index2 = j;
                    }
                }
            }
            return maxAndMin;
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],4}");
                Console.WriteLine();
            }
        }
        static void WriteMatrixInFile(int[,] matrix)
        {
            StreamWriter writer = new StreamWriter("D:\\texts\\matrix2.txt");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    writer.Write($"{matrix[i, j],4}");
                writer.WriteLine();
            }
            writer.Close();
        }
        static int[,] ReadMatrixFromFile(int n)
        {
            StreamReader reader = new StreamReader("D:\\texts\\matrix.txt");
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(reader.ReadLine().Split(" ")[j]);
                }
            }
            reader.Close();
            return matrix;
        }
    }
}