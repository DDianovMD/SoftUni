using System;
using System.Linq;

namespace RallyRacing
{
    public class Program
    {
        private static char[,] matrix;
        private static int currentRow = 0;
        private static int currentColumn = 0;
        private static int firstTunnelRow;
        private static int firstTunnelColumn;
        private static int secondTunnelRow;
        private static int secondTunnelColumn;
        private static bool isSet = false;
        private static bool hasFinished = false;
        private static int distanceTraveled = 0;

        public static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());
            string racingNumber = Console.ReadLine();

            matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                // Fill the matrix
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(rowData[col]);

                    if (rowData[col] == "T" && isSet == false)
                    {
                        firstTunnelRow = row;
                        firstTunnelColumn = col;
                        isSet = true;
                    }
                    else if (rowData[col] == "T" && isSet == true)
                    {
                        secondTunnelRow = row;
                        secondTunnelColumn = col;
                    }
                }
            }
            // Program logic
            while (hasFinished == false)
            {
                string direction = Console.ReadLine();

                if (direction == "End")
                {
                    break;
                }
                else if (direction == "up")
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

            matrix[currentRow, currentColumn] = 'C';

            // Print output
            if (hasFinished)
            {
                Console.WriteLine($"Racing car {racingNumber} finished the stage!");
            }
            else
            {
                Console.WriteLine($"Racing car {racingNumber} DNF.");
            }

            Console.WriteLine($"Distance covered {distanceTraveled} km.");

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
            matrix[currentRow, currentColumn] = '.';
            currentRow += increaseRowValue;
            currentColumn += increaseColumnValue;

            if (isInside(currentRow, currentColumn))
            {
                if (matrix[currentRow, currentColumn] == '.')
                {
                    distanceTraveled += 10;
                }
                else if (matrix[currentRow, currentColumn] == 'T' &&
                         currentRow == firstTunnelRow &&
                         currentColumn == firstTunnelColumn)
                {
                    matrix[currentRow, currentColumn] = '.';
                    currentRow = secondTunnelRow;
                    currentColumn = secondTunnelColumn;
                    distanceTraveled += 30;
                }
                else if (matrix[currentRow, currentColumn] == 'T' &&
                         currentRow == secondTunnelRow &&
                         currentColumn == secondTunnelColumn)
                {
                    matrix[currentRow, currentColumn] = '.';
                    currentRow = firstTunnelRow;
                    currentColumn = firstTunnelColumn;
                    distanceTraveled += 30;
                }
                else if (matrix[currentRow, currentColumn] == 'F')
                {
                    distanceTraveled += 10;
                    hasFinished = true;
                }
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
