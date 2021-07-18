using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class MatrixAddition
    {
        public void MatrixAdd()
        {
            int[,] a = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] b = new int[,] { { 7, 9, 4 }, { 1, 2, 4 }, { 4, 2, 1 } };
            int[,] c = new int[a.Length, b.Length];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void MatrixMul()
        {
            int[,] a = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] b = new int[,] { { 2, 1, 4 }, { 1, 2, 4 }, { 4, 2, 1 } };
            int[,] c = new int[a.Length, b.Length];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
