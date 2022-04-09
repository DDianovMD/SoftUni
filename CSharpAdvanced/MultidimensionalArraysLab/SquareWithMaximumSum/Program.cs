using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main()
        {
            // Receive matrix's rows and cols

            int[] rowsAndCols = Console.ReadLine()
                                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            // Create matrix

            int[,] matrix = new int[rowsAndCols[0], rowsAndCols[1]];

            // Fill matrix

            for (int rows = 0; rows < rowsAndCols[0]; rows++)
            {
                int[] currentDimension = Console.ReadLine()
                                                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse)
                                                .ToArray();

                for (int col = 0; col < rowsAndCols[1]; col++)
                {
                    matrix[rows, col] = currentDimension[col];
                }
            }

            int squareSum = 0;
            int bestSum = 0;
            int bestSquareInitialRow = int.MinValue;
            int bestSquareInitialCol = int.MinValue;

            // Find 2x2 square from matrix with biggest sum

            for (int row = 0; row < rowsAndCols[0]; row++)
            {
                for (int col = 0; col < rowsAndCols[1]; col++)
                {
                    if (row + 1 < rowsAndCols[0] && col + 1 < rowsAndCols[1])
                    {
                        squareSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    }

                    if (squareSum > bestSum)
                    {
                        bestSum = squareSum;
                        bestSquareInitialRow = row;
                        bestSquareInitialCol = col;
                    }
                }
            }

            // Print result

            Console.WriteLine($"{matrix[bestSquareInitialRow, bestSquareInitialCol]} {matrix[bestSquareInitialRow, bestSquareInitialCol + 1]}");
            Console.WriteLine($"{matrix[bestSquareInitialRow + 1, bestSquareInitialCol]} {matrix[bestSquareInitialRow + 1, bestSquareInitialCol + 1]}");
            Console.WriteLine(bestSum);
        }
    }
}
