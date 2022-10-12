using System;

namespace TheBattleOfTheFiveArmies
{
    public class Program
    {
        public static int armyArmor;
        public static char[][] playfield;
        public static int armyRow;
        public static int armyColumn;
        public static bool isWon = false;

        public static void Main()
        {
            armyArmor = int.Parse(Console.ReadLine());

            int rowsNumber = int.Parse(Console.ReadLine());

            playfield = new char[rowsNumber][];

            // Fill jagged array
            for (int row = 0; row < rowsNumber; row++)
            {
                string rowData = Console.ReadLine();

                playfield[row] = new char[rowData.Length];

                for (int col = 0; col < rowData.Length; col++)
                {
                    playfield[row][col] = rowData[col];

                    if (rowData[col] == 'A')
                    {
                        armyRow = row;
                        armyColumn = col;
                    }
                }
            }

            // Program logic
            while (armyArmor > 0 && isWon == false)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string movingDirection = input[0];
                int spawnRow = int.Parse(input[1]);
                int spawnColumn = int.Parse(input[2]);

                playfield[spawnRow][spawnColumn] = 'O';

                if (movingDirection == "up")
                {
                    Move(-1, 0);
                }
                else if (movingDirection == "down")
                {
                    Move(1, 0);
                }
                else if (movingDirection == "left")
                {
                    Move(0, -1);
                }
                else if (movingDirection == "right")
                {
                    Move(0, 1);
                }
            }

            // Print output
            if (isWon)
            {
                Console.WriteLine($"The army managed to free the Middle World! Armor left: {armyArmor}");
            }
            else
            {
                playfield[armyRow][armyColumn] = 'X';

                Console.WriteLine($"The army was defeated at {armyRow};{armyColumn}.");
            }

            PrintMatrix(playfield);
        }

        // Methods
        public static void Move(int increaseRowValue, int increaseColumnValue)
        {
            armyArmor -= 1;

            if (isInside(armyRow + increaseRowValue, armyColumn + increaseColumnValue))
            {
                playfield[armyRow][armyColumn] = '-';
                armyRow += increaseRowValue;
                armyColumn += increaseColumnValue;

                if (playfield[armyRow][armyColumn] == 'O')
                {
                    armyArmor -= 2;

                    playfield[armyRow][armyColumn] = 'A';

                }
                else if (playfield[armyRow][armyColumn] == 'M')
                {
                    playfield[armyRow][armyColumn] = '-';

                    isWon = true;
                }
                else if (playfield[armyRow][armyColumn] == '-')
                {
                    playfield[armyRow][armyColumn] = 'A';
                }
            }
        }

        public static bool isInside(int row, int column)
        {
            if (row >= 0 && row < playfield.GetLength(0) && column >= 0 && column < playfield[row].Length)
            {
                return true;
            }

            return false;
        }

        public static void PrintMatrix(char[][] map)
        {
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map[row].Length; col++)
                {
                    Console.Write(map[row][col]);
                }

                Console.WriteLine();
            }
        }
    }
}
