using System;

namespace test
{
    class Project
    {
        static void Main()
        {
            int[,] matr = DoRandomMatrix(3, 3);
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                    Console.Write($"{matr[i, j],4}");
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] matr2 = DoExponentiation(matr, 3);
            for (int i = 0; i < matr2.GetLength(0); i++)
            {
                for (int j = 0; j < matr2.GetLength(1); j++)
                    Console.Write($"{matr2[i, j],4}");
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] matr3 = DoExponentiation(matr, 4);
            for (int i = 0; i < matr2.GetLength(0); i++)
            {
                for (int j = 0; j < matr2.GetLength(1); j++)
                    Console.Write($"{matr3[i, j],4}");
                Console.WriteLine();
            }
        }
        static int[,] DoRandomMatrix(int matrixLength, int matrixWidth)
        {
            int[,] matr = new int[matrixLength, matrixWidth];
            var r = new Random();
            for (int i = 0; i < matr.GetLength(0); i++)
                for (int j = 0; j < matr.GetLength(1); j++)
                    matr[i, j] = r.Next(1, 5);
            return matr;
        }
        static int[,] DoExponentiation(int[,] matr, int count)
        {
            var variable = 0;
            int[,] exponentedMatr = matr;
            if (exponentedMatr.GetLength(0) == exponentedMatr.GetLength(1))
                for (int i = 0; i < count - 1; i++)
                    exponentedMatr = DoMultiplication(exponentedMatr);
            return exponentedMatr;
        }
        static int[,] DoMultiplication(int[,] matr)
        {
            var variable = 0;
            int[,] newMatr = new int[matr.GetLength(0), matr.GetLength(1)];
            for (int j = 0; j < newMatr.GetLength(0); j++)
                for (int k = 0; k < newMatr.GetLength(0); k++)
                {
                    for (int l = 0; l < newMatr.GetLength(0); l++)
                        variable += matr[j, l] * matr[l, k];
                    newMatr[j, k] = variable;
                    variable = 0;
                }
            return newMatr;
        }
    }
}
