using System;

namespace HelpAMole
{
    public class Program
    {
        public static char[,] matrix;
        public static int currentRow = -1;
        public static int currentColumn = -1;
        public static int score = 0;
        public static int firstTeleportRow = -1;
        public static int firstTeleportColumn = -1;
        public static int secondTeleportRow = -1;
        public static int secondTeleportColumn = -1;

        public static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());

            matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == 'M')
                    {
                        currentRow = row;
                        currentColumn = col;
                    }
                    else if (matrix[row, col] == 'S' && firstTeleportRow == -1)
                    {
                        firstTeleportRow = row;
                        firstTeleportColumn = col;
                    }
                    else if (matrix[row, col] == 'S' && firstTeleportRow != -1)
                    {
                        secondTeleportRow = row;
                        secondTeleportColumn = col;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End" && score < 25)
            {
                if (command == "up")
                {
                    Move(-1, 0);
                }
                else if (command == "down")
                {
                    Move(1, 0);
                }
                else if (command == "left")
                {
                    Move(0, -1);
                }
                else if (command == "right")
                {
                    Move(0, 1);
                }

                command = Console.ReadLine();
            }

            // Print Output
            if (score >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {score} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {score} points.");
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
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

        public static void Move(int row, int column)
        {
            if (isInsideTheMatrix(currentRow + row, currentColumn + column))
            {
                matrix[currentRow, currentColumn] = '-';
                currentRow += row;
                currentColumn += column;

                char nextPositionChar = matrix[currentRow, currentColumn];

                if (nextPositionChar == 'S')
                {
                    matrix[currentRow, currentColumn] = '-';
                    score -= 3;
                    if (currentRow == firstTeleportRow && currentColumn == firstTeleportColumn)
                    {
                        currentRow = secondTeleportRow;
                        currentColumn = secondTeleportColumn;
                    }
                    else
                    {
                        currentRow = firstTeleportRow;
                        currentColumn = firstTeleportColumn;
                    }
                }
                else if (nextPositionChar != '-')
                {
                    score += int.Parse(nextPositionChar.ToString());
                }

                matrix[currentRow, currentColumn] = 'M';
            }
            else
            {
                Console.WriteLine("Don't try to escape the playing field!");
            }
        }

        public static bool isInsideTheMatrix(int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }

            return false;
        }
    }
}
