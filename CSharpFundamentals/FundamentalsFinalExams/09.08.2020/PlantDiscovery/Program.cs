using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    public class Plant
    {
        public string name { get; set; }
        public int rarity { get; set; }
        public List<double> ratings { get; set; }

        public Plant(string name, int rarity)
        {
            this.name = name;
            this.rarity = rarity;
            this.ratings = new List<double>();
        }
    }
    class Program
    {
        static void Main()
        {
            int times = int.Parse(Console.ReadLine());
            List<Plant> plants = new List<Plant>();

            for (int i = 0; i < times; i++)
            {
                string[] userInput = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                bool isExisting = false;

                if (plants.Count == 0)
                {
                    Plant currentPlant = new Plant(userInput[0], int.Parse(userInput[1]));
                    plants.Add(currentPlant);
                }
                else
                {
                    for (int j = 0; j < plants.Count; j++)
                    {
                        if (userInput[0] == plants[j].name)
                        {
                            isExisting = true;
                            plants[j].rarity = int.Parse(userInput[1]);
                            break;
                        }

                        if (isExisting == false && j == plants.Count - 1)
                        {
                            Plant currentPlant = new Plant(userInput[0], int.Parse(userInput[1]));
                            plants.Add(currentPlant);
                        }
                    }
                }                
            }

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0].ToLower() != "exhibition")
            {
                bool nameIsValid = true;

                foreach (var plant in plants)
                {
                    if (plant.name == command[1])
                    {
                        nameIsValid = true;
                        break;
                    }
                    else
                    {
                        nameIsValid = false;
                    }
                }

                if (nameIsValid)
                {
                    if (command[0] == "Rate:")
                    {
                        foreach (var plant in plants)
                        {
                            if (plant.name == command[1])
                            {
                                plant.ratings.Add(double.Parse(command[3]));
                                break;
                            }
                        }
                    }
                    else if (command[0] == "Update:")
                    {
                        foreach (var plant in plants)
                        {
                            if (plant.name == command[1])
                            {
                                plant.rarity = int.Parse(command[3]);
                                break;
                            }
                        }
                    }
                    else if (command[0] == "Reset:")
                    {
                        foreach (var plant in plants)
                        {
                            if (plant.name == command[1])
                            {
                                plant.ratings.Clear();
                                break;
                            }
                        }
                    }
                }               
                else
                {
                    Console.WriteLine("error");
                }

                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var plant in plants)
            {
                if (plant.ratings.Count() == 0)
                {
                    plant.ratings.Add(0);
                }
            }

            // output

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants.OrderByDescending(x => x.rarity).ThenByDescending(x => x.ratings.Average()))
            {
                Console.WriteLine($"- {plant.name}; Rarity: {plant.rarity}; Rating: {plant.ratings.Average():F2}");
            }
        }
    }
}
