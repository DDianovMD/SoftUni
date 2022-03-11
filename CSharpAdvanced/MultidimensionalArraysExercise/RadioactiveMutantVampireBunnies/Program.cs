using System;
using System.Collections.Generic;
using System.Linq;

namespace RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main()
        {
            // Receive matrix's size from user
            int[] matrixRowsAndColumns = Console.ReadLine()
                                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse)
                                                .ToArray();

            // Initialize matrix and fill it up
            string[,] matrix = new string[matrixRowsAndColumns[0], matrixRowsAndColumns[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentMatrixRow = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentMatrixRow[col].ToString();
                }
            }

            // Read commands from user
            string commands = Console.ReadLine();
            Queue<string> commandsQueue = new Queue<string>();

            foreach (var command in commands)
            {
                commandsQueue.Enqueue(command.ToString());
            }

            // Initialize variables for tracking player's current position
            int currentRow = int.MinValue;
            int currentCol = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == "P")
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            bool isDead = false;
            List<int> bunniesCoordinates = new List<int>();

            while (commandsQueue.Count > 0 && isDead == false)
            {
                if (commandsQueue.Peek() == "U")
                {
                    if (currentRow - 1 >= 0)
                    {
                        if (matrix[currentRow - 1, currentCol] == "B")
                        {
                            currentRow--;
                            GetBunniesCoordinates(matrix, bunniesCoordinates);
                            isDead = MultiplyBunnies(matrix, isDead, bunniesCoordinates, currentRow, currentCol);
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = ".";
                            matrix[currentRow - 1, currentCol] = "P";
                            currentRow--;
                            GetBunniesCoordinates(matrix, bunniesCoordinates);
                            isDead = MultiplyBunnies(matrix, isDead, bunniesCoordinates, currentRow, currentCol);
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = ".";
                        GetBunniesCoordinates(matrix, bunniesCoordinates);
                        isDead = MultiplyBunnies(matrix, isDead, bunniesCoordinates, currentRow, currentCol);
                    }
                }
                else if (commandsQueue.Peek() == "D")
                {
                    if (currentRow + 1 < matrix.GetLength(0))
                    {
                        if (matrix[currentRow + 1, currentCol] == "B")
                        {
                            currentRow++;
                            GetBunniesCoordinates(matrix, bunniesCoordinates);
                            isDead = MultiplyBunnies(matrix, isDead, bunniesCoordinates, currentRow, currentCol);
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = ".";
                            matrix[currentRow + 1, currentCol] = "P";
                            currentRow++;
                            GetBunniesCoordinates(matrix, bunniesCoordinates);
                            isDead = MultiplyBunnies(matrix, isDead, bunniesCoordinates, currentRow, currentCol);
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = ".";
                        GetBunniesCoordinates(matrix, bunniesCoordinates);
                        isDead = MultiplyBunnies(matrix, isDead, bunniesCoordinates, currentRow, currentCol);
                    }
                }
                else if (commandsQueue.Peek() == "L")
                {
                    if (currentCol - 1 >= 0)
                    {
                        if (matrix[currentRow, currentCol - 1] == "B")
                        {
                            currentCol--;
                            GetBunniesCoordinates(matrix, bunniesCoordinates);
                            isDead = MultiplyBunnies(matrix, isDead, bunniesCoordinates, currentRow, currentCol);
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = ".";
                            matrix[currentRow, currentCol - 1] = "P";
                            currentCol--;
                            GetBunniesCoordinates(matrix, bunniesCoordinates);
                            isDead = MultiplyBunnies(matrix, isDead, bunniesCoordinates, currentRow, currentCol);
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = ".";
                        GetBunniesCoordinates(matrix, bunniesCoordinates);
                        isDead = MultiplyBunnies(matrix, isDead, bunniesCoordinates, currentRow, currentCol);
                    }
                }
                else if (commandsQueue.Peek() == "R")
                {
                    if (currentCol + 1 < matrix.GetLength(1))
                    {
                        if (matrix[currentRow, currentCol + 1] == "B")
                        {
                            currentCol++;
                            GetBunniesCoordinates(matrix, bunniesCoordinates);
                            isDead = MultiplyBunnies(matrix, isDead, bunniesCoordinates, currentRow, currentCol);
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = ".";
                            matrix[currentRow, currentCol + 1] = "P";
                            currentCol++;
                            GetBunniesCoordinates(matrix, bunniesCoordinates);
                            isDead = MultiplyBunnies(matrix, isDead, bunniesCoordinates, currentRow, currentCol);
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = ".";
                        GetBunniesCoordinates(matrix, bunniesCoordinates);
                        isDead = MultiplyBunnies(matrix, isDead, bunniesCoordinates, currentRow, currentCol);
                    }
                }

                commandsQueue.Dequeue();
            }

            // Print result
            PrintMatrix(matrix);
            if (isDead)
            {
                Console.WriteLine($"dead: {currentRow} {currentCol}");
            }
            else
            {               
                Console.WriteLine($"won: {currentRow} {currentCol}");
            }
        }

        // Methods
        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }

        private static void GetBunniesCoordinates(string[,] matrix, List<int> bunniesCoordinates)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == "B")
                    {
                        bunniesCoordinates.Add(row);
                        bunniesCoordinates.Add(col);
                    }
                }
            }
        }

        private static bool MultiplyBunnies(string[,] matrix, bool isDead, List<int> bunniesCoordinates, int currentRow, int currentCol)
        {
            for (int i = 0; i < bunniesCoordinates.Count; i += 2)
            {
                int row = bunniesCoordinates[i];
                int col = bunniesCoordinates[i + 1];

                if (row - 1 >= 0)
                {
                    matrix[row - 1, col] = "B";
                }

                if (row + 1 < matrix.GetLength(0))
                {
                    matrix[row + 1, col] = "B";
                }

                if (col - 1 >= 0)
                {
                    matrix[row, col - 1] = "B";
                }

                if (col + 1 < matrix.GetLength(1))
                {
                    matrix[row, col + 1] = "B";
                }
            }

            if (matrix[currentRow, currentCol] == "B")
            {
                isDead = true;
            }

            bunniesCoordinates.Clear();
            return isDead;
        }
    }
}
