using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());

            Dictionary<string, int> plantsRarity = new Dictionary<string, int>();
            Dictionary<string, List<int>> plantsRatings = new Dictionary<string, List<int>>();

            for (int i = 0; i < times; i++)
            {
                string[] userInput = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (plantsRarity.ContainsKey(userInput[0]) == false)
                {
                    plantsRarity.Add(userInput[0], int.Parse(userInput[1]));
                    plantsRatings.Add(userInput[0], new List<int>());
                }
                else
                {
                    plantsRarity[userInput[0]] = int.Parse(userInput[1]);
                }

            }

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "Exhibition")
            {

                if (command[0] == "Rate:")
                {
                    plantsRatings[command[1]].Add(int.Parse(command[3]));
                }
                else if (command[0] == "Update:" && plantsRarity[command[1]] != int.Parse(command[3]))
                {
                    plantsRarity[command[1]] = int.Parse(command[3]);
                }
                else if (command[0] == "Reset:")
                {
                    plantsRatings[command[1]].Clear();
                }
                else
                {
                    Console.WriteLine("error");
                }
                        
                    command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            foreach (var plant in plantsRatings)
            {
                if (plant.Value.Count() == 0)
                {
                    plant.Value.Add(0);
                }
            }

            // output

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plantsRarity.OrderByDescending(rarity => rarity.Value).ThenByDescending(w => plantsRatings[w.Key].Average()))
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value}; Rating: {plantsRatings[plant.Key].Average():F2}");
            }

        }
    }
}
