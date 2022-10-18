using System;
using System.Collections.Generic;
using System.Linq;

namespace Warships
{
    public class Program
    {
        public static char[,] matrix;
        public static int firstPlayerShipsCount;
        public static int secondPlayerShipsCount;
        public static int totalSunkShipsCounter;
        public static bool isWon = false;

        public static void Main()
        {
            // Read input info
            int matrixSize = int.Parse(Console.ReadLine());
            List<string> coordinatesInput = Console.ReadLine()
                                                   .Split(',', StringSplitOptions.RemoveEmptyEntries)
                                                   .ToList();

            // Extract coordinates as numbers
            List<int> attackCoordinates = new List<int>();
            foreach (string item in coordinatesInput)
            {
                string[] coordinates = item.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                attackCoordinates.Add(int.Parse(coordinates[0]));
                attackCoordinates.Add(int.Parse(coordinates[1]));
            }

            // Initialize and fill the matrix
            matrix = new char[matrixSize, matrixSize];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < rowData.Length; col++)
                {
                    char currentCharacter = char.Parse(rowData[col]);
                    matrix[row, col] = currentCharacter;

                    if (currentCharacter == '<')
                    {
                        firstPlayerShipsCount++;
                    }
                    else if (currentCharacter == '>')
                    {
                        secondPlayerShipsCount++;
                    }
                }
            }

            // Program logic
            while (attackCoordinates.Count > 0 &&
                   firstPlayerShipsCount > 0 &&
                   secondPlayerShipsCount > 0)
            {
                int row = attackCoordinates.ElementAt(0);
                attackCoordinates.RemoveAt(0);
                int col = attackCoordinates.ElementAt(0);
                attackCoordinates.RemoveAt(0);

                if (isInside(row, col))
                {
                    if (matrix[row, col] == '<' || matrix[row, col] == '>')
                    {
                        DestroyShip(row, col);
                    }
                    else if (matrix[row, col] == '#')
                    {
                        // Destroy sea mine on current coordinate
                        matrix[row, col] = 'X';

                        DestroyShipsOnAdjacentCoordinates(row, col);
                    }
                }
            }

            // Print output
            if (secondPlayerShipsCount == 0)
            {
                Console.WriteLine($"Player One has won the game! {totalSunkShipsCounter} ships have been sunk in the battle.");
            }
            else if (firstPlayerShipsCount == 0)
            {
                Console.WriteLine($"Player Two has won the game! {totalSunkShipsCounter} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {firstPlayerShipsCount} ships left. Player Two has {secondPlayerShipsCount} ships left.");
            }
        }

        // Methods
        public static void DestroyShip(int row, int col)
        {
            if (isInside(row, col) &&
                matrix[row, col] != '*' &&
                matrix[row, col] != '#' &&
                matrix[row, col] != 'X')
            {
                if (matrix[row, col] == '<')
                {
                    firstPlayerShipsCount--;
                }
                else if (matrix[row, col] == '>')
                {
                    secondPlayerShipsCount--;
                }

                matrix[row, col] = 'X';
                totalSunkShipsCounter += 1;
            }
        }

        public static void DestroyShipsOnAdjacentCoordinates(int row, int col)
        {
            // destroy upper left adjacent coordinate
            DestroyShip(row - 1, col - 1);

            // destroy upper adjacent coordinate
            DestroyShip(row - 1, col);

            // destroy upper right adjacent coordinate
            DestroyShip(row - 1, col + 1);

            // destroy left adjacent coordinate
            DestroyShip(row, col - 1);

            // destroy right adjacent coordinate
            DestroyShip(row, col + 1);

            // destroy down left adjacent coordinate
            DestroyShip(row + 1, col - 1);

            // destroy down adjacent coodinate
            DestroyShip(row + 1, col);

            // destroy down right adjacent coordinate
            DestroyShip(row + 1, col + 1);
        }

        public static bool isInside(int row, int col)
        {
            if (row >= 0 &&
                row < matrix.GetLength(0) &&
                col >= 0 &&
                col < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
