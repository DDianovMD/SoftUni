using System;
using System.Linq;

namespace MatrixShuffling
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

            // Fill matrix rows
            for (int row = 0; row < rowsAndCols[0]; row++)
            {
                string[] currentRow = Console.ReadLine()
                                             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                             .ToArray();

                for (int col = 0; col < rowsAndCols[1]; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine()
                                          .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                if (command[0].ToUpper() == "END")
                {
                    break;
                }

                if (command[0].ToLower() != "swap" || command.Length != 5
                                                   || int.Parse(command[1]) < 0 || int.Parse(command[1]) > rowsAndCols[0]
                                                   || int.Parse(command[2]) < 0 || int.Parse(command[2]) > rowsAndCols[1]
                                                   || int.Parse(command[3]) < 0 || int.Parse(command[3]) > rowsAndCols[0]
                                                   || int.Parse(command[4]) < 0 || int.Parse(command[4]) > rowsAndCols[1])
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string temp = matrix[int.Parse(command[1]), int.Parse(command[2])];
                    matrix[int.Parse(command[1]), int.Parse(command[2])] = matrix[int.Parse(command[3]), int.Parse(command[4])];
                    matrix[int.Parse(command[3]), int.Parse(command[4])] = temp;

                    for (int row = 0; row < rowsAndCols[0]; row++)
                    {
                        for (int col = 0; col < rowsAndCols[1]; col++)
                        {
                            if (col < rowsAndCols[1] - 1)
                            {
                                Console.Write($"{matrix[row, col]} ");
                            }
                            else
                            {
                                Console.WriteLine($"{matrix[row, col]}");
                            }
                        }
                    }
                }
            }
        }
    }
}
