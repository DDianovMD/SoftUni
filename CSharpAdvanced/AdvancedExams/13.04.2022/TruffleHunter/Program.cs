using System;
using System.Linq;

namespace TruffleHunter
{
    public class Program
    {
        private static char[,] matrix;
        private static int row;
        private static int column;
        private static string direction;
        private static int blackTrufflesCount = 0;
        private static int whiteTrufflesCount = 0;
        private static int summerTrufflesCount = 0;
        private static int eatenTrufflesCount = 0;

        public static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());

            matrix = new char[matrixSize, matrixSize];

            // Fill the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(char.Parse)
                                        .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            // Program logic
            while (true)
            {
                string[] userInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = userInput[0];

                if (command == "Stop")
                {
                    break;
                }

                row = int.Parse(userInput[1]);
                column = int.Parse(userInput[2]);

                if (command == "Wild_Boar")
                {
                    direction = userInput[3];

                    MoveBoar(row, column, direction);
                }
                else
                {
                    if (matrix[row, column] == 'B')
                    {
                        blackTrufflesCount++;
                    }
                    else if (matrix[row, column] == 'W')
                    {
                        whiteTrufflesCount++;
                    }
                    else if (matrix[row, column] == 'S')
                    {
                        summerTrufflesCount++;
                    }

                    matrix[row, column] = '-';
                }
            }

            // Print output
            Console.WriteLine($"Peter manages to harvest {blackTrufflesCount} black, {summerTrufflesCount} summer, and {whiteTrufflesCount} white truffles.");
            Console.WriteLine($"The wild boar has eaten {eatenTrufflesCount} truffles.");

            PrintMatrix(matrix);
        }

        // Methods
        public static void MoveBoar(int row, int column, string direction)
        {
            while (row >= 0 && row < matrix.GetLength(0) 
                            && column >= 0
                            && column < matrix.GetLength(1))
            {
                if (matrix[row, column] == 'B' || matrix[row, column] == 'W' || matrix[row, column] == 'S')
                {
                    eatenTrufflesCount++;
                    matrix[row, column] = '-';
                }

                if (direction == "up")
                {
                    row -= 2;
                }
                else if (direction == "down")
                {
                    row += 2;
                }
                else if (direction == "left")
                {
                    column -= 2;
                }
                else if (direction == "right")
                {
                    column += 2;
                }
            }
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col != matrix.GetLength(1) - 1)
                    {
                        Console.Write($"{matrix[row, col]} ");
                    }
                    else
                    {
                        Console.Write($"{matrix[row, col]}");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
