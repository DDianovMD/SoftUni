using System;
using System.Collections.Generic;
using System.Linq;

namespace WildZoo
{
    public class Program
    {
        static void Main()
        {
            // key -> animal name
            // value -> needed food quantity
            Dictionary<string, int> hungryAnimals = new Dictionary<string, int>();

            // key -> animal name
            // value -> animal area
            Dictionary<string, string> animalsLiving = new Dictionary<string, string>();

            // key -> area
            // value -> number of hungry animals in the area
            Dictionary<string, int> hungryPopulationInArea = new Dictionary<string, int>();


            while (true)
            {
                List<string> userInput = Console.ReadLine()
                                                .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                                                .ToList();

                if (userInput[0] == "EndDay")
                {
                    break;
                }

                List<string> currentAnimalInformation = userInput[1]
                                                            .Split('-', StringSplitOptions.RemoveEmptyEntries)
                                                            .ToList();

                string command = userInput[0];
                string animalName = currentAnimalInformation[0];
                int foodQuantity = int.Parse(currentAnimalInformation[1]);
                if (command == "Add")
                {
                    string livingArea = currentAnimalInformation[2];

                    if (hungryAnimals.ContainsKey(animalName) == false)
                    {
                        hungryAnimals.Add(animalName, foodQuantity);
                        animalsLiving.Add(animalName, livingArea);

                        if (hungryPopulationInArea.ContainsKey(livingArea) == false)
                        {
                            hungryPopulationInArea.Add(livingArea, 1);
                        }
                        else
                        {
                            hungryPopulationInArea[livingArea] += 1;
                        }
                    }
                    else
                    {
                        hungryAnimals[animalName] += foodQuantity;
                    }
                }
                else if (command == "Feed")
                {
                    if (hungryAnimals.ContainsKey(animalName))
                    {
                        hungryAnimals[animalName] -= foodQuantity;

                        if (hungryAnimals[animalName] <= 0)
                        {
                            string curretAnimalLivingArea = animalsLiving[animalName];

                            hungryAnimals.Remove(animalName);
                            hungryPopulationInArea[curretAnimalLivingArea] -= 1;
                            Console.WriteLine($"{animalName} was successfully fed");

                        }
                    }
                }
            }

            // Print output
            Console.WriteLine("Animals:");
            foreach (var kvp in hungryAnimals)
            {
                Console.WriteLine($" {kvp.Key} -> {kvp.Value}g");
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var kvp in hungryPopulationInArea)
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($" {kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}
