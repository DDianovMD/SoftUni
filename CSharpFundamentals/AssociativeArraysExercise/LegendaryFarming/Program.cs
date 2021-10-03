using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            // bool isTrue = true;

            while (true)
            {
                if (keyMaterials["shards"] < 250 &&
                    keyMaterials["fragments"] < 250 &&
                    keyMaterials["motes"] < 250)
                {

                    string[] farmedMaterials = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    for (int i = 1; i < farmedMaterials.Length; i += 2)
                    {

                        if (farmedMaterials[i].ToLower() == "shards" ||
                            farmedMaterials[i].ToLower() == "fragments" ||
                            farmedMaterials[i].ToLower() == "motes")
                        {
                            keyMaterials[farmedMaterials[i].ToLower()] += int.Parse(farmedMaterials[i - 1]);

                            if (keyMaterials["shards"] >= 250 ||
                                keyMaterials["fragments"] >= 250 ||
                                keyMaterials["motes"] >= 250)
                            {
                                break;
                            }

                        }
                        else
                        {
                            if (junkMaterials.ContainsKey(farmedMaterials[i].ToLower()) == false)
                            {
                                junkMaterials.Add(farmedMaterials[i].ToLower(), int.Parse(farmedMaterials[i - 1]));
                            }
                            else
                            {
                                junkMaterials[farmedMaterials[i].ToLower()] += int.Parse(farmedMaterials[i - 1]);
                            }
                        }

                    }
                }
                else
                {
                    if (keyMaterials["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        keyMaterials["shards"] -= 250;

                        foreach (var material in keyMaterials.OrderByDescending(value => value.Value).ThenBy(key => key.Key))
                        {
                            Console.WriteLine($"{material.Key}: {material.Value}");
                        }

                        foreach (var material in junkMaterials.OrderBy(key => key.Key))
                        {
                            Console.WriteLine($"{material.Key}: {material.Value}");
                        }

                        break;
                    }
                    else if (keyMaterials["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        keyMaterials["fragments"] -= 250;

                        foreach (var material in keyMaterials.OrderByDescending(value => value.Value).ThenBy(key => key.Key))
                        {
                            Console.WriteLine($"{material.Key}: {material.Value}");
                        }

                        foreach (var material in junkMaterials.OrderBy(key => key.Key))
                        {
                            Console.WriteLine($"{material.Key}: {material.Value}");
                        }

                        break;
                    }
                    else if (keyMaterials["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        keyMaterials["motes"] -= 250;

                        foreach (var material in keyMaterials.OrderByDescending(value => value.Value).ThenBy(key => key.Key))
                        {
                            Console.WriteLine($"{material.Key}: {material.Value}");
                        }

                        foreach (var material in junkMaterials.OrderBy(key => key.Key))
                        {
                            Console.WriteLine($"{material.Key}: {material.Value}");
                        }

                        break;
                    }
                }
            }
        }
    }
}
