using System;

namespace ReVolt
{
    public class Program
    {
        private static char[,] matrix;
        private static int playerRow;
        private static int playerColumn;
        private static bool isWon = false;

        public static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());
            matrix = new char[matrixSize, matrixSize];

            int numberOfCommands = int.Parse(Console.ReadLine());

            // Fill the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];

                    if (rowData[col] == 'f')
                    {
                        playerRow = row;
                        playerColumn = col;
                    }
                }
            }

            // Program logic
            while (numberOfCommands > 0 && isWon == false)
            {
                string direction = Console.ReadLine();
                numberOfCommands--;

                if (direction == "up")
                {
                    Move(-1, 0);
                }
                else if (direction == "down")
                {
                    Move(1, 0);
                }
                else if (direction == "left")
                {
                    Move(0, -1);
                }
                else if (direction == "right")
                {
                    Move(0, 1);
                }
            }

            // Print output
            if (isWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            PrintMatrix(matrix);
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static void Move(int increaseRowValue, int increseColumnValue)
        {
            if (matrix[playerRow, playerColumn] != 'B')
            {
                matrix[playerRow, playerColumn] = '-';
            }

            playerRow += increaseRowValue;
            playerColumn += increseColumnValue;

            IndexOutOfRangeGuard(playerRow, playerColumn);

            if (matrix[playerRow, playerColumn] == 'B')
            {
                Move(increaseRowValue, increseColumnValue);
            }
            else if (matrix[playerRow, playerColumn] == 'T')
            {
                playerRow -= increaseRowValue;
                playerColumn -= increseColumnValue;
            }
            else if (matrix[playerRow, playerColumn] == 'F')
            {
                isWon = true;
            }

            matrix[playerRow, playerColumn] = 'f';
        }

        public static void IndexOutOfRangeGuard(int row, int column)
        {
            if (row < 0)
            {
                playerRow = matrix.GetLength(0) - 1;
            }
            else if (row >= matrix.GetLength(0))
            {
                playerRow = 0;
            }
            else if (column < 0)
            {
                playerColumn = matrix.GetLength(1) - 1;
            }
            else if (column >= matrix.GetLength(1))
            {
                playerColumn = 0;
            }
        }
    }
}
