using System;
using System.Linq;

namespace SumMatrixColumns
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
                                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse)
                                                .ToArray();

                for (int col = 0; col < rowsAndCols[1]; col++)
                {
                    matrix[rows, col] = currentDimension[col];
                }
            }

            // Calculate each column's sum

            int[] sums = new int[rowsAndCols[1]];

            for (int col = 0; col < rowsAndCols[1]; col++)
            {
                int currentColSum = 0;

                for (int row = 0; row < rowsAndCols[0]; row++)
                {
                    currentColSum += matrix[row, col];
                }

                sums[col] = currentColSum;
            }

            // Print result

            foreach (var item in sums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
