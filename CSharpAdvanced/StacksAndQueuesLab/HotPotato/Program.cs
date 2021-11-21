using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receive players from user.
            List<string> players = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            // Receive step from user.
            int potato = int.Parse(Console.ReadLine()); 

            // Create circle.
            Queue<string> playersCircle = new Queue<string>();

            // Fill players circle.
            foreach (var player in players)
            {
                playersCircle.Enqueue(player);
            }

            // Create temporary queues to split main circle in two halves.
            Queue<string> firstHalf = new Queue<string>();
            Queue<string> secondHalf = new Queue<string>();            

            // Program logic:

            while (playersCircle.Count > 1)
            {
                // If step is bigger than total count of players in the game.
                if (potato > playersCircle.Count)
                {
                    int removeAtIndex = potato % playersCircle.Count;

                    if (removeAtIndex == 0) // => complete circle and last player hold the potato => last player is out of the game.
                    {
                        // Set index to remove last player before start next round.
                        removeAtIndex = playersCircle.Count;
                        SaveFirstHalfPlayers(removeAtIndex, playersCircle, firstHalf);
                    }
                    else if (removeAtIndex > 0) // => not complete circle and losing player is somewhere in the middle. We must save players before and after the losing player. 
                    {
                        SaveFirstHalfPlayers(removeAtIndex, playersCircle, firstHalf);
                    }
                    AnnounceLosingPlayer(playersCircle);                    
                    SaveSecondHalfPlayers(playersCircle, secondHalf);
                    CreateNewCircle(firstHalf, secondHalf, playersCircle);
                    
                }
                // Else if step is lower than total count of players in the game.
                else if (potato < playersCircle.Count)
                {
                    int removeAtIndex = potato;
                    SaveFirstHalfPlayers(removeAtIndex, playersCircle, firstHalf);
                    AnnounceLosingPlayer(playersCircle);
                    SaveSecondHalfPlayers(playersCircle, secondHalf);
                    CreateNewCircle(firstHalf, secondHalf, playersCircle);
                }
                // Else if step is equal to total count of players in the game.
                else if (potato == playersCircle.Count)
                {
                    int removeAtIndex = playersCircle.Count;
                    SaveFirstHalfPlayers(removeAtIndex, playersCircle, firstHalf);
                    AnnounceLosingPlayer(playersCircle);
                    SaveSecondHalfPlayers(playersCircle, secondHalf);
                    CreateNewCircle(firstHalf, secondHalf, playersCircle);
                }
            }

            //Announce last player who is winning the game.
            Console.WriteLine($"Last is {playersCircle.Peek()}");
        }        

        // Methods        

        internal static void SaveFirstHalfPlayers(int removeAtIndex, Queue<string> playersCircle, Queue<string> firstHalf)
        {
            // Save players before losing player.
            for (int i = 1; i < removeAtIndex; i++)
            {
                firstHalf.Enqueue(playersCircle.Peek());
                playersCircle.Dequeue();
            }
        }

        internal static void AnnounceLosingPlayer(Queue<string> playersCircle)
        {
            // Announce losing player and remove it from the circle.
            Console.WriteLine($"Removed {playersCircle.Peek()}");
            playersCircle.Dequeue();
        }

        internal static void SaveSecondHalfPlayers(Queue<string> playersCircle, Queue<string> secondHalf)
        {
            // Save players after losing player
            for (int i = 0; i < playersCircle.Count; i++)
            {
                secondHalf.Enqueue(playersCircle.Peek());
                playersCircle.Dequeue();
                i--;
            }
        }

        internal static void CreateNewCircle(Queue<string> firstHalf, Queue<string> secondHalf, Queue<string> playersCircle)
        {
            // Group all left players (players before and players after the losing one) in a single queue.
            // Next round starts from player next to the losing one so we get 2nd half players first.
            for (int i = 0; i < secondHalf.Count; i++)
            {
                playersCircle.Enqueue(secondHalf.Peek());
                secondHalf.Dequeue();
                i--;
            }

            for (int i = 0; i < firstHalf.Count; i++)
            {
                playersCircle.Enqueue(firstHalf.Peek());
                firstHalf.Dequeue();
                i--;
            }
        }

    }
}
