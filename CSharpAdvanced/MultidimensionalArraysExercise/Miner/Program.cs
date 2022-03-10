using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main()
        {
            int matrixSide = int.Parse(Console.ReadLine());

            string[] commands = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .ToArray();

            Queue<string> commandsQueue = new Queue<string>();

            foreach (var command in commands)
            {
                commandsQueue.Enqueue(command);
            }

            string[,] matrix = new string[matrixSide, matrixSide];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] currentMatrixRow = Console.ReadLine()
                                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                             .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentMatrixRow[col];
                }
            }

            int currentRow = int.MinValue;
            int currentCol = int.MinValue;
            int coals = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == "s")
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                    else if (matrix[row, col] == "c")
                    {
                        coals++;
                    }
                }
            }

            int collectedCoals = 0;

            while (commandsQueue.Count > 0)
            {
                string item = string.Empty;

                if (commandsQueue.Peek() == "up")
                {
                    if (currentRow - 1 >= 0)
                    {
                        matrix[currentRow, currentCol] = "*";
                        item = matrix[currentRow - 1, currentCol];
                        currentRow--;
                    }
                }
                else if (commandsQueue.Peek() == "down")
                {
                    if (currentRow + 1 < matrix.GetLength(0))
                    {
                        matrix[currentRow, currentCol] = "*";
                        item = matrix[currentRow + 1, currentCol];
                        currentRow++;
                    }
                }
                else if (commandsQueue.Peek() == "left")
                {
                    if (currentCol - 1 >= 0)
                    {
                        matrix[currentRow, currentCol] = "*";
                        item = matrix[currentRow, currentCol - 1];
                        currentCol--;
                    }
                }
                else if (commandsQueue.Peek() == "right")
                {
                    if (currentCol + 1 < matrix.GetLength(1))
                    {
                        matrix[currentRow, currentCol] = "*";
                        item = matrix[currentRow, currentCol + 1];
                        currentCol++;
                    }
                }                

                if (item == "c")
                {
                    collectedCoals++;
                    if (collectedCoals == coals)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        break;
                    }
                }
                else if (item == "e")
                {
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    break;
                }

                commandsQueue.Dequeue();

                if (commandsQueue.Count == 0)
                {
                    Console.WriteLine($"{coals - collectedCoals} coals left. ({currentRow}, {currentCol})");
                    break;
                }
            }
        }
    }
}
