using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();            

            while (true)
            {
                string[] command = Console.ReadLine()
                                          .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                if (command[0].ToLower() == "revision")
                {
                    break;
                }

                string shop = command[0];
                string product = command[1];
                double price = double.Parse(command[2]);

                if (shops.ContainsKey(shop) == false)
                {
                    shops.Add(shop, new Dictionary<string, double>());
                    shops[shop].Add(product, price);
                }
                else
                {
                    if (shops[shop].ContainsKey(product) == false)
                    {
                        shops[shop].Add(product, price);
                    }
                    else
                    {
                        shops[shop][product] = price;
                    }
                }
            }

            foreach (var kvp in shops)
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach (var kvp2 in kvp.Value)
                {
                    Console.WriteLine($"Product: {kvp2.Key}, Price: {kvp2.Value}");
                }
            }
        }
    }
}
