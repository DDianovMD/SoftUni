using System;
using System.Linq;

namespace Survivor
{
    public class Program
    {
        public static char[][] jaggedArray;
        public static int collectedTokensCounter = 0;
        public static int opponentsCollectedTokensCounter = 0;

        public static void Main()
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            jaggedArray = new char[numberOfRows][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Gong")
                {
                    break;
                }

                int row = int.Parse(command[1]);
                int column = int.Parse(command[2]);

                if (command[0] == "Find")
                {
                    collectedTokensCounter = CheckForTokens(row, column, collectedTokensCounter);

                }
                else if (command[0] == "Opponent")
                {
                    string direction = command[3];

                    if (direction == "up")
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            opponentsCollectedTokensCounter = CheckForTokens(row, column, opponentsCollectedTokensCounter);

                            row--;
                        }
                    }
                    else if (direction == "down")
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            opponentsCollectedTokensCounter = CheckForTokens(row, column, opponentsCollectedTokensCounter);

                            row++;
                        }
                    }
                    else if (direction == "left")
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            opponentsCollectedTokensCounter = CheckForTokens(row, column, opponentsCollectedTokensCounter);

                            column--;
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            opponentsCollectedTokensCounter = CheckForTokens(row, column, opponentsCollectedTokensCounter);

                            column++;
                        }
                    }
                }
            }

            // Print output
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[row]));
            }

            Console.WriteLine($"Collected tokens: {collectedTokensCounter}");
            Console.WriteLine($"Opponent's tokens: {opponentsCollectedTokensCounter}");
        }

        // Methods
        public static int CheckForTokens(int row, int column, int tokensCounter)
        {
            if (isInside(row, column))
            {
                if (jaggedArray[row][column] == 'T')
                {
                    jaggedArray[row][column] = '-';
                    tokensCounter++;
                }
            }

            return tokensCounter;
        }

        public static bool isInside(int row, int column)
        {
            if (row >= 0 &&
                row < jaggedArray.Length &&
                column >= 0 &&
                column < jaggedArray[row].Length)
            {
                return true;
            }

            return false;
        }
    }
}