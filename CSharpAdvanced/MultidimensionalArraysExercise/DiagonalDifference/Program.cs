using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                var userInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < userInput.Length; j++)
                {
                    matrix[i, j] = userInput[j];
                }
            }

            int primaryDiagonalSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primaryDiagonalSum += matrix[i, i];
            }

            int secondaryDiagonalSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                secondaryDiagonalSum += matrix[i, matrix.GetLength(0) - 1 - i];
            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}
