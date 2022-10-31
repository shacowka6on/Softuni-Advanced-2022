using System;
using System.Linq;
using System.Collections.Generic;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            int leftSkip = 0;
            int rightSkip = n - 1;

            int sumLeft = 0;
            int sumRight = 0;
            FillMatrix(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumLeft += matrix[i, leftSkip];
                leftSkip++;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumRight += matrix[i, rightSkip];
                rightSkip--;
            }
            Console.WriteLine(Math.Abs(sumLeft - sumRight));
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
        }
    }
}