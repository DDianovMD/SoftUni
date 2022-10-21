using System;

namespace Selling
{
    public class Program
    {
        private static char[,] matrix;
        private static int currentRow;
        private static int currentColumn;
        private static int firstPillarRow = int.MinValue;
        private static int firstPillarColumn = int.MinValue;
        private static int secondPillarRow;
        private static int secondPillarColumn;
        private static int collectedMoney;
        private static bool isOutside = false;

        public static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());

            matrix = new char[matrixSize, matrixSize];

            // Fill the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];

                    if (rowData[col] == 'S')
                    {
                        currentRow = row;
                        currentColumn = col;
                    }
                    else if (rowData[col] == 'O' && firstPillarRow == int.MinValue)
                    {
                        firstPillarRow = row;
                        firstPillarColumn = col;
                    }
                    else if (rowData[col] == 'O' && firstPillarRow != int.MinValue)
                    {
                        secondPillarRow = row;
                        secondPillarColumn = col;
                    }
                }
            }

            // Program logic
            while (isOutside == false && collectedMoney < 50)
            {
                string direction = Console.ReadLine();

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
            if (isOutside)
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            else
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }

            Console.WriteLine($"Money: {collectedMoney}");

            PrintMatrix(matrix);
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }

        public static void Move(int increaseRowValue, int increaseColumnValue)
        {
            matrix[currentRow, currentColumn] = '-';
            currentRow += increaseRowValue;
            currentColumn += increaseColumnValue;

            if (isInside(currentRow, currentColumn))
            {
                if (char.IsDigit(matrix[currentRow,currentColumn]))
                {
                    collectedMoney += int.Parse(matrix[currentRow, currentColumn].ToString());
                }
                else if (currentRow == firstPillarRow && currentColumn == firstPillarColumn)
                {
                    matrix[currentRow, currentColumn] = '-';
                    currentRow = secondPillarRow;
                    currentColumn = secondPillarColumn;
                }
                else if (currentRow == secondPillarRow && currentColumn == secondPillarColumn)
                {
                    matrix[currentRow, currentColumn] = '-';
                    currentRow = firstPillarRow;
                    currentColumn = firstPillarColumn;
                }

                matrix[currentRow, currentColumn] = 'S';
            }
            else
            {
                isOutside = true;
            }
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
