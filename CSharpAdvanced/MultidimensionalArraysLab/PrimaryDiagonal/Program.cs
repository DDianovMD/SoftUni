using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main()
        {
            // Receive matrix's rows and cols

            int rowsAndCols = int.Parse(Console.ReadLine());
                                

            // Create matrix

            int[,] matrix = new int[rowsAndCols, rowsAndCols];

            // Fill matrix

            for (int rows = 0; rows < rowsAndCols; rows++)
            {
                int[] currentDimension = Console.ReadLine()
                                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse)
                                                .ToArray();

                for (int col = 0; col < rowsAndCols; col++)
                {
                    matrix[rows, col] = currentDimension[col];
                }
            }

            // Calculate primary diagonal

            int primaryDiagonalSum = 0;

            for (int row = 0; row < rowsAndCols; row++)
            {
                primaryDiagonalSum += matrix[row, row];
            }

            // Print result

            Console.WriteLine(primaryDiagonalSum);
        }
    }
}
