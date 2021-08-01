using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayer = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int winningCard;
            int losingCard;
            int sum = 0;

            while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
            {

                if (firstPlayer[0] > secondPlayer[0])
                {
                    winningCard = firstPlayer[0];
                    losingCard = secondPlayer[0];

                    firstPlayer.Add(winningCard);
                    firstPlayer.Add(losingCard);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else if (firstPlayer[0] < secondPlayer[0])
                {
                    winningCard = secondPlayer[0];
                    losingCard = firstPlayer[0];

                    secondPlayer.Add(winningCard);
                    secondPlayer.Add(losingCard);
                    secondPlayer.RemoveAt(0);
                    firstPlayer.RemoveAt(0);
                }
                else
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }

            }

            if (firstPlayer.Count != 0)
            {
                for (int i = 0; i < firstPlayer.Count; i++)
                {
                    sum += firstPlayer[i];
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                for (int i = 0; i < secondPlayer.Count; i++)
                {
                    sum += secondPlayer[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
