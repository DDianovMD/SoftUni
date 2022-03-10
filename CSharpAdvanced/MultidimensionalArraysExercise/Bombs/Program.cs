using System;
using System.Linq;

namespace Bombs
{
    class Program
    {

        static void Main()
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[squareMatrixSize, squareMatrixSize];

            for (int row = 0; row < squareMatrixSize; row++)
            {
                int[] currentRow = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToArray();


                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            string[] bombs = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            for (int i = 0; i < bombs.Length; i++)
            {
                int[] currentBomb = bombs[i].Split(',').Select(int.Parse).ToArray();

                int row = currentBomb[0];
                int col = currentBomb[1];
                int damage = matrix[row, col];

                if (matrix[row, col] > 0)
                {
                    matrix[row, col] -= damage;

                    // up - [row - 1, col]
                    if (row - 1 >= 0)
                    {
                        if (matrix[row - 1, col] > 0)
                        {
                            matrix[row - 1, col] -= damage;
                        }
                    }

                    // up and left - [row - 1, col - 1]
                    if (row - 1 >= 0 && col - 1 >= 0)
                    {
                        if (matrix[row - 1, col - 1] > 0)
                        {
                            matrix[row - 1, col - 1] -= damage;
                        }
                    }

                    // up and right - [row - 1, col + 1]
                    if (row - 1 >= 0 && col + 1 < matrix.GetLength(1))
                    {
                        if (matrix[row - 1, col + 1] > 0)
                        {
                            matrix[row - 1, col + 1] -= damage;
                        }
                    }

                    // left - [row, col - 1]
                    if (col - 1 >= 0)
                    {
                        if (matrix[row, col - 1] > 0)
                        {
                            matrix[row, col - 1] -= damage;
                        }
                    }

                    // right - [row, col + 1]
                    if (col + 1 < matrix.GetLength(1))
                    {
                        if (matrix[row, col + 1] > 0)
                        {
                            matrix[row, col + 1] -= damage;
                        }
                    }

                    // down - [row + 1, col]
                    if (row + 1 < matrix.GetLength(0))
                    {
                        if (matrix[row + 1, col] > 0)
                        {
                            matrix[row + 1, col] -= damage;
                        }
                    }

                    // down and left - [row + 1, col - 1]
                    if (row + 1 < matrix.GetLength(0) && col - 1 >= 0)
                    {
                        if (matrix[row + 1, col - 1] > 0)
                        {
                            matrix[row + 1, col - 1] -= damage;
                        }
                    }

                    // down and right - [row + 1, col + 1]
                    if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1))
                    {
                        if (matrix[row + 1, col + 1] > 0)
                        {
                            matrix[row + 1, col + 1] -= damage;
                        }
                    }
                }
            }

            int aliveCells = 0;
            int sum = 0;

            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[j, k] > 0)
                    {
                        aliveCells++;
                        sum += matrix[j, k];
                    }
                }
            }

            // Print result
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write(matrix[j, k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
