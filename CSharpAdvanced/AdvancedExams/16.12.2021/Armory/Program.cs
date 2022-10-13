using System;

namespace Armory
{
    public class Program
    {
        private static char[,] matrix;
        private static int officerRow;
        private static int officerColumn;
        private static bool isOutside = false;
        private static int firstMirrorRow = int.MaxValue; // initial value used for if clause on row 35
        private static int firstMirrorColumn;
        private static int secondMirrorRow;
        private static int secondMirrorColumn;
        private static int spentMoney = 0;

        public static void Main(string[] args)
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

                    if (rowData[col] == 'A')
                    {
                        officerRow = row;
                        officerColumn = col;
                    }
                    else if (rowData[col] == 'M' && firstMirrorRow == int.MaxValue)
                    {
                        firstMirrorRow = row;
                        firstMirrorColumn = col;
                    }
                    else if (rowData[col] == 'M' && firstMirrorRow != int.MaxValue)
                    {
                        secondMirrorRow = row;
                        secondMirrorColumn = col;
                    }
                }
            }

            // Program logic
            while (isOutside == false && spentMoney <= 65)
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
                Console.WriteLine("I do not need more swords!");
            }
            else
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
            }

            Console.WriteLine($"The king paid {spentMoney} gold coins.");

            PrintMatrix(matrix);
        }

        // Methods
        public static void Move(int increaseRowValue, int increaseColumnValue)
        {
            matrix[officerRow, officerColumn] = '-';
            officerRow += increaseRowValue;
            officerColumn += increaseColumnValue;

            if (isInside(officerRow, officerColumn))
            {
                if (char.IsDigit(matrix[officerRow,officerColumn]))
                {
                    spentMoney += int.Parse(matrix[officerRow, officerColumn].ToString());
                }
                else if (matrix[officerRow, officerColumn] == 'M')
                {
                    matrix[officerRow, officerColumn] = '-';

                    if (officerRow == firstMirrorRow && officerColumn == firstMirrorColumn)
                    {
                        officerRow = secondMirrorRow;
                        officerColumn = secondMirrorColumn;
                    }
                    else
                    {
                        officerRow = firstMirrorRow;
                        officerColumn = firstMirrorColumn;
                    }
                }

                matrix[officerRow, officerColumn] = 'A';
            }
        }

        public static bool isInside(int officerRow, int officerColumn)
        {
            if (officerRow >= 0 && officerRow < matrix.GetLength(0) && officerColumn >= 0 && officerColumn < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                isOutside = true;
                return false;
            }
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
    }
}
