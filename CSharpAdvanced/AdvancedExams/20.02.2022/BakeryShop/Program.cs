using System;
using System.Collections.Generic;
using System.Linq;

namespace BakeryShop
{
    public class Program
    {
        public static void Main()
        {
            double[] waterInfoInput = Console.ReadLine()
                                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                             .Select(double.Parse)
                                             .ToArray();

            double[] flourInfoInput = Console.ReadLine()
                                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                             .Select(double.Parse)
                                             .ToArray();

            Queue<double> waterQueue = new Queue<double>(waterInfoInput);
            Stack<double> flourStack = new Stack<double>(flourInfoInput);

            // key - product name
            // value - number of baked products (default: 0)
            Dictionary<string, int> bakedProducts = new Dictionary<string, int>();
            bakedProducts.Add("Croissant", 0);
            bakedProducts.Add("Muffin", 0);
            bakedProducts.Add("Baguette", 0);
            bakedProducts.Add("Bagel", 0);

            while (waterQueue.Count > 0 && flourStack.Count > 0)
            {
                double water = waterQueue.Dequeue();
                double flour = flourStack.Pop();

                double waterPercentage = water * 100 / (water + flour);

                if (waterPercentage == 50)
                {
                    bakedProducts["Croissant"]++;
                }
                else if (waterPercentage == 40)
                {
                    bakedProducts["Muffin"]++;
                }
                else if (waterPercentage == 30)
                {
                    bakedProducts["Baguette"]++;
                }
                else if (waterPercentage == 20)
                {
                    bakedProducts["Bagel"]++;
                }
                else
                {
                    bakedProducts["Croissant"]++;
                    flourStack.Push(flour - water);
                }
            }

            // Print result
            foreach (KeyValuePair<string, int> kvp in bakedProducts.Where(x => x.Value > 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            if (waterQueue.Count == 0)
            {
                Console.WriteLine("Water left: None");
            }
            else
            {
                Console.WriteLine($"Water left: {string.Join(", ", waterQueue)}");
            }

            if (flourStack.Count == 0)
            {
                Console.WriteLine("Flour left: None");
            }
            else
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flourStack)}");
            }
        }
    }
}
