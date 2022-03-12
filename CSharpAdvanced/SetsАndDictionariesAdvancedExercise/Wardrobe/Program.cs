using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main()
        {
            int inputCount = int.Parse(Console.ReadLine());

            // key - color
            // value - Dictionary<item, itemCount>
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < inputCount; i++)
            {
                string[] colorAndClothes = Console.ReadLine()
                                                  .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                                                  .ToArray();

                string[] clothes = colorAndClothes[1].Split(",", StringSplitOptions.RemoveEmptyEntries)
                                                     .ToArray();

                if (wardrobe.ContainsKey(colorAndClothes[0]) == false) // if given color doesn't exist
                {
                    wardrobe.Add(colorAndClothes[0], new Dictionary<string, int>()); // add color

                    for (int j = 0; j < clothes.Length; j++) // add items with this color
                    {
                        wardrobe[colorAndClothes[0]].Add(clothes[j], 1);
                    }
                }
                else
                {
                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if (wardrobe[colorAndClothes[0]].ContainsKey(clothes[j]) == false) // if current item doesn't exist - add item
                        {
                            wardrobe[colorAndClothes[0]].Add(clothes[j], 1);
                        }
                        else
                        {
                            wardrobe[colorAndClothes[0]][clothes[j]] += 1; // else - itemCount++
                        }
                    }
                }
            }

            // Receive from user item to search for in the wardrobe
            string[] searchFor = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();

            // Print result
            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var internalKVP in kvp.Value)
                {
                    if (kvp.Key == searchFor[0] && internalKVP.Key == searchFor[1])
                    {
                        Console.WriteLine($"* {internalKVP.Key} - {internalKVP.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {internalKVP.Key} - {internalKVP.Value}");
                    }
                }
            }
        }
    }
}
