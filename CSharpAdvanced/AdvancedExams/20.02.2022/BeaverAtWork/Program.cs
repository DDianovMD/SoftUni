using System;
using System.Collections.Generic;
using System.Linq;

namespace BeaverAtWork
{
    public class Program
    {
        public static char[,] pond;
        public static int beaverRow;
        public static int beaverColumn;
        public static int availableWoodsCount;
        public static List<char> collectedWoods = new List<char>();

        public static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());
            pond = new char[matrixSize, matrixSize];

            for (int row = 0; row < pond.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(char.Parse)
                                        .ToArray();

                for (int col = 0; col < pond.GetLength(1); col++)
                {
                    pond[row, col] = rowData[col];

                    if (rowData[col] == 'B')
                    {
                        beaverRow = row;
                        beaverColumn = col;
                    }
                    else if (char.IsLower(rowData[col]))
                    {
                        availableWoodsCount++;
                    }
                }
            }

            while (availableWoodsCount > 0)
            {
                string direction = Console.ReadLine();

                if (direction == "end")
                {
                    break;
                }
                else if (direction == "up")
                {
                    Move(-1, 0, direction);
                }
                else if (direction == "down")
                {
                    Move(1, 0, direction);
                }
                else if (direction == "left")
                {
                    Move(0, -1, direction);
                }
                else if (direction == "right")
                {
                    Move(0, 1, direction);
                }
            }

            // Print output
            if (availableWoodsCount == 0)
            {
                Console.WriteLine($"The Beaver successfully collect {collectedWoods.Count} wood branches: {string.Join(", ", collectedWoods)}.");
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {availableWoodsCount} branches left.");
            }

            PrintMatrix(pond);
        }

        public static void PrintMatrix(char[,] pond)
        {
            for (int row = 0; row < pond.GetLength(0); row++)
            {
                for (int col = 0; col < pond.GetLength(1); col++)
                {
                    if (col != pond.GetLength(1) - 1)
                    {
                        Console.Write($"{pond[row, col]} ");
                    }
                    else
                    {
                        Console.Write($"{pond[row, col]}");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Move(int increaseRowValue, int increaceColumnValue, string direction)
        {
            pond[beaverRow, beaverColumn] = '-';
            beaverRow += increaseRowValue;
            beaverColumn += increaceColumnValue;

            if (isInside(beaverRow, beaverColumn))
            {
                if (char.IsLower(pond[beaverRow, beaverColumn]))
                {
                    collectedWoods.Add(pond[beaverRow, beaverColumn]);
                    availableWoodsCount--;
                }
                else if (pond[beaverRow, beaverColumn] == 'F')
                {
                    if (direction == "up")
                    {
                        if (beaverRow == 0)
                        {
                            pond[beaverRow, beaverColumn] = '-';
                            beaverRow = pond.GetLength(0) - 1;
                        }
                        else
                        {
                            beaverRow = 0;
                        }
                    }
                    else if (direction == "down")
                    {
                        if (beaverRow == pond.GetLength(0) - 1)
                        {
                            pond[beaverRow, beaverColumn] = '-';
                            beaverRow = 0;
                        }
                        else
                        {
                            beaverRow = pond.GetLength(0) - 1;
                        }
                    }
                    else if (direction == "left")
                    {
                        if (beaverColumn == 0)
                        {
                            pond[beaverRow, beaverColumn] = '-';
                            beaverColumn = pond.GetLength(1) - 1;
                        }
                        else
                        {
                            beaverColumn = 0;
                        }
                    }
                    else if (direction == "right")
                    {
                        if (beaverColumn == pond.GetLength(1) - 1)
                        {
                            pond[beaverRow, beaverColumn] = '-';
                            beaverColumn = 0;
                        }
                        else
                        {
                            beaverColumn = pond.GetLength(1) - 1;
                        }
                    }

                    if (char.IsLower(pond[beaverRow, beaverColumn]))
                    {
                        collectedWoods.Add(pond[beaverRow, beaverColumn]);
                        availableWoodsCount--;
                    }
                }
            }
            else
            {
                beaverRow -= increaseRowValue;
                beaverColumn -= increaceColumnValue;

                if (collectedWoods.Count > 0)
                {
                    collectedWoods.RemoveAt(collectedWoods.Count - 1);
                }
            }

            pond[beaverRow, beaverColumn] = 'B';
        }

        public static bool isInside(int row, int col)
        {
            if (row >= 0 && row < pond.GetLength(0) && col >= 0 && col < pond.GetLength(1))
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
