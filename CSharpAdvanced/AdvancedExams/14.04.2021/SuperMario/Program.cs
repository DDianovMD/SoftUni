using System;

namespace SuperMario
{
    public class Program
    {
        private static int livesLeft;
        private static char[][] jaggedArray;
        private static int marioRow;
        private static int marioColumn;
        private static bool isSaved = false;

        public static void Main()
        {
            // Read input info
            livesLeft = int.Parse(Console.ReadLine());
            int rowsNumber = int.Parse(Console.ReadLine());
            jaggedArray = new char[rowsNumber][];

            // Fill jaggedArray
            for (int row = 0; row < rowsNumber; row++)
            {
                string rowData = Console.ReadLine();
                jaggedArray[row] = new char[rowData.Length];

                for (int col = 0; col < rowData.Length; col++)
                {
                    jaggedArray[row][col] = rowData[col];

                    if (rowData[col] == 'M')
                    {
                        marioRow = row;
                        marioColumn = col;
                    }
                }
            }

            // Program logic
            while (livesLeft > 0 && isSaved == false)
            {
                string[] inputInfo = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string direction = inputInfo[0];
                int bowserRow = int.Parse(inputInfo[1]);
                int bowserColumn = int.Parse(inputInfo[2]);

                SpawnBowser(bowserRow, bowserColumn);

                if (direction == "W")
                {
                    Move(-1, 0);
                }
                else if (direction == "S")
                {
                    Move(1, 0);
                }
                else if (direction == "A")
                {
                    Move(0, -1);
                }
                else if (direction == "D")
                {
                    Move(0, 1);
                }
            }

            // Print output
            if (isSaved)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {livesLeft}");
            }
            else
            {
                Console.WriteLine($"Mario died at {marioRow};{marioColumn}.");
            }

            PrintMatrix(jaggedArray);
        }

        // Methods
        public static void PrintMatrix(char[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(string.Join("", jaggedArray[row]));
            }
        }

        public static void Move(int increaseRowValue, int increaseColumnValue)
        {
            jaggedArray[marioRow][marioColumn] = '-';
            livesLeft--;

            if (isInside(marioRow + increaseRowValue, marioColumn + increaseColumnValue))
            {
                marioRow += increaseRowValue;
                marioColumn += increaseColumnValue;

                if (jaggedArray[marioRow][marioColumn] == 'B')
                {
                    livesLeft -= 2;
                }
                else if (jaggedArray[marioRow][marioColumn] == 'P')
                {
                    isSaved = true;
                }
            }

            if (livesLeft <= 0 && isSaved == false)
            {
                jaggedArray[marioRow][marioColumn] = 'X';
            }
            else if (livesLeft > 0 && isSaved)
            {
                jaggedArray[marioRow][marioColumn] = '-';
            }
            else
            {
                jaggedArray[marioRow][marioColumn] = 'M';
            }
        }

        public static bool isInside(int row, int col)
        {
            if (row >= 0 &&
                row < jaggedArray.Length &&
                col >= 0 &&
                col < jaggedArray[row].Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void SpawnBowser(int row, int column)
        {
            jaggedArray[row][column] = 'B';
        }
    }
}
