using System;

namespace test
{
    class Project
    {
        static void Main()
        {
            int[,] matrix = DoRandomMatrix(3, 3, 3);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],4}");
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] exponentedMatr = DoExponentiation(matrix, 4);
            for (int i = 0; i < exponentedMatr.GetLength(0); i++)
            {
                for (int j = 0; j < exponentedMatr.GetLength(1); j++)
                    Console.Write($"{exponentedMatr[i, j],4}");
                Console.WriteLine();
            }
        }
        static int[,] DoRandomMatrix(int matrixColumns, int matrixRows, int range)
        {
            int[,] matr = new int[matrixColumns, matrixRows];
            var r = new Random();
            for (int i = 0; i < matr.GetLength(0); i++)
                for (int j = 0; j < matr.GetLength(1); j++)
                    matr[i, j] = r.Next(range);
            return matr;
        }
        static int[,] DoExponentiation(int[,] matr, int count)
        {
            int[,] exponentedMatr = matr;
            if (exponentedMatr.GetLength(0) == exponentedMatr.GetLength(1))
                for (int i = 0; i < count - 1; i++)
                    exponentedMatr = DoMultiplication(exponentedMatr, matr);
            return exponentedMatr;
        }
        static int[,] DoMultiplication(int[,] matr1, int[,] matr2)
        {
            var variable = 0;
            int[,] newMatr = new int[matr1.GetLength(0), matr1.GetLength(1)];
            if (matr1.GetLength(1) == matr2.GetLength(0))
                for (int j = 0; j < newMatr.GetLength(0); j++)
                    for (int k = 0; k < matr1.GetLength(1); k++)
                    {
                        for (int l = 0; l < matr2.GetLength(1); l++)
                            variable += matr1[j, l] * matr2[l, k];
                        newMatr[j, k] = variable;
                        variable = 0;
                    }
            return newMatr;
        }
    }
}
