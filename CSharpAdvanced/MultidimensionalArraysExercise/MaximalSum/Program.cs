using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main()
        {
            // Receive userInput with rows and columns sizes;
            int[] rowsAndCols = Console.ReadLine()
                                       .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

            int[,] matrix = new int[rowsAndCols[0], rowsAndCols[1]];

            // Fill matrix rows
            for (int row = 0; row < rowsAndCols[0]; row++)
            {
                int[] currentRow = Console.ReadLine()
                                          .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToArray();

                for (int col = 0; col < rowsAndCols[1]; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            // Search for biggest 3x3 submatrix sum
            int bestSum = int.MinValue;
            int currentSum = 0;
            int rowStartIndex = 0;
            int colStartIndex = 0;
            for (int row = 0; row < rowsAndCols[0] - 2; row++)
            {
                for (int col = 0; col < rowsAndCols[1] - 2; col++)
                {
                    currentSum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                                + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                                + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        rowStartIndex = row;
                        colStartIndex = col;
                    }

                    currentSum = 0;
                }
            }

            // Print result
            Console.WriteLine($"Sum = {bestSum}");
            Console.WriteLine($"{matrix[rowStartIndex, colStartIndex]} {matrix[rowStartIndex, colStartIndex + 1]} {matrix[rowStartIndex, colStartIndex + 2]}");
            Console.WriteLine($"{matrix[rowStartIndex + 1, colStartIndex]} {matrix[rowStartIndex + 1, colStartIndex + 1]} {matrix[rowStartIndex + 1, colStartIndex + 2]}");
            Console.WriteLine($"{matrix[rowStartIndex + 2, colStartIndex]} {matrix[rowStartIndex + 2, colStartIndex + 1]} {matrix[rowStartIndex + 2, colStartIndex + 2]}");
        }
    }
}
