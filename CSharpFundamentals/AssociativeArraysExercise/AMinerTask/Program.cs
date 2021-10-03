using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] materialsAndQuantity = new string[2];
            materialsAndQuantity[0] = Console.ReadLine();
            materialsAndQuantity[1] = Console.ReadLine();

            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (materialsAndQuantity[0] != "stop")
            {                

                if (resources.ContainsKey(materialsAndQuantity[0]))
                {
                    resources[materialsAndQuantity[0]] += int.Parse(materialsAndQuantity[1]);
                }
                else
                {
                    resources.Add(materialsAndQuantity[0], int.Parse(materialsAndQuantity[1]));
                }

                materialsAndQuantity[0] = Console.ReadLine();
                materialsAndQuantity[1] = Console.ReadLine();

            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
