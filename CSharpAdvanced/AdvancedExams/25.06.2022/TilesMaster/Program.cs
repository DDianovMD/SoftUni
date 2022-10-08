using System;
using System.Collections.Generic;
using System.Linq;

namespace TilesMaster
{
    public class Program
    {
        static void Main()
        {
            // Read user input
            int[] whiteTilesAreas = Console.ReadLine()
                                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                           .ToArray();

            int[] greyTilesAreas = Console.ReadLine()
                                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                           .ToArray();

            // Used variables for program logic
            Queue<int> greyTilesQueue = new Queue<int>(greyTilesAreas);
            Stack<int> whiteTilesStack = new Stack<int>(whiteTilesAreas);

            Dictionary<string, int> tilesForLocation = new Dictionary<string, int>();
            tilesForLocation.Add("Sink", 0);
            tilesForLocation.Add("Oven", 0);
            tilesForLocation.Add("Countertop", 0);
            tilesForLocation.Add("Wall", 0);
            tilesForLocation.Add("Floor", 0);

            // Program logic
            while (greyTilesQueue.Count > 0 && whiteTilesStack.Count > 0)
            {
                int currentGreyTile = greyTilesQueue.Dequeue();
                int currentWhiteTile = whiteTilesStack.Pop();

                if (currentGreyTile == currentWhiteTile)
                {
                    if (currentWhiteTile + currentGreyTile == 40)
                    {
                        tilesForLocation["Sink"]++;
                    }
                    else if (currentWhiteTile + currentGreyTile == 50)
                    {
                        tilesForLocation["Oven"]++;
                    }
                    else if (currentWhiteTile + currentGreyTile == 60)
                    {
                        tilesForLocation["Countertop"]++;
                    }
                    else if (currentWhiteTile + currentGreyTile == 70)
                    {
                        tilesForLocation["Wall"]++;
                    }
                    else
                    {
                        tilesForLocation["Floor"]++;
                    }
                }
                else
                {
                    currentWhiteTile /= 2;
                    whiteTilesStack.Push(currentWhiteTile);
                    greyTilesQueue.Enqueue(currentGreyTile);
                }
            }

            // Print output
            Console.Write("White tiles left: ");
            if (whiteTilesStack.Count == 0)
            {
                Console.WriteLine("none");
            }
            else
            {
                Console.WriteLine(String.Join(", ", whiteTilesStack));
            }

            Console.Write("Grey tiles left: ");
            if (greyTilesQueue.Count == 0)
            {
                Console.WriteLine("none");
            }
            else
            {
                Console.WriteLine(String.Join(", ", greyTilesQueue));
            }

            foreach (var kvp in tilesForLocation.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}
