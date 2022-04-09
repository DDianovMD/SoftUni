using System;
using System.Linq;

namespace SumMatrixElements
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

            int sum = 0;

            foreach (var item in matrix)
            {
                sum += item;
            }

            // Print result
            Console.WriteLine(rowsAndCols[0]);
            Console.WriteLine(rowsAndCols[1]);
            Console.WriteLine(sum);
        }
    }
}
