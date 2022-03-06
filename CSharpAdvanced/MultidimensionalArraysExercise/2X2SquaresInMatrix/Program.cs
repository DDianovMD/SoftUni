using System;
using System.Linq;

namespace _2X2SquaresInMatrix
{
    class Program
    {
        static void Main()
        {
            int[] rowsAndCols = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            string[,] matrix = new string[rowsAndCols[0], rowsAndCols[1]];

            for (int row = 0; row < rowsAndCols[0]; row++)
            {
                string[] currentDimension = Console.ReadLine()
                                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                            .ToArray();

                for (int col = 0; col < currentDimension.Length; col++)
                {
                    matrix[row, col] = currentDimension[col];
                }
            }

            int counter = 0;

            for (int row = 0; row < rowsAndCols[0] - 1; row++)
            {
                for (int col = 0; col < rowsAndCols[1] - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row + 1, col] == matrix[row + 1, col + 1] && matrix[row, col] == matrix[row + 1, col])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
