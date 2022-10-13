using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacksmith
{
    public class Program
    {
        public static void Main()
        {
            // Read input info
            int[] steelInfo = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();

            int[] carbonInfo = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();

            // Used variables
            Queue<int> steelQueue = new Queue<int>(steelInfo);
            Stack<int> carbonStack = new Stack<int>(carbonInfo);
            int forgedSwordsTotalCount = 0;
            // key - sword type
            // value - count of forged swords
            Dictionary<string, int> forgedSwords = new Dictionary<string, int>();
            forgedSwords.Add("Gladius", 0);
            forgedSwords.Add("Shamshir", 0);
            forgedSwords.Add("Katana", 0);
            forgedSwords.Add("Sabre", 0);
            forgedSwords.Add("Broadsword", 0);

            // Program logic
            while (steelQueue.Count > 0 && carbonStack.Count > 0)
            {
                int steel = steelQueue.Dequeue();
                int carbon = carbonStack.Pop();

                int sum = steel + carbon;

                forgedSwordsTotalCount++;

                if (sum == 70)
                {
                    forgedSwords["Gladius"]++;
                }
                else if (sum == 80)
                {
                    forgedSwords["Shamshir"]++;
                }
                else if (sum == 90)
                {
                    forgedSwords["Katana"]++;
                }
                else if (sum == 110)
                {
                    forgedSwords["Sabre"]++;
                }
                else if (sum == 150)
                {
                    forgedSwords["Broadsword"]++;
                }
                else
                {
                    carbon += 5;
                    carbonStack.Push(carbon);
                    forgedSwordsTotalCount--;
                }
            }

            // Print output
            if (forgedSwords.Where(x => x.Value > 0).Count() > 0)
            {
                Console.WriteLine($"You have forged {forgedSwordsTotalCount} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }

            if (steelQueue.Count == 0)
            {
                Console.WriteLine($"Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steelQueue)}");
            }

            if (carbonStack.Count == 0)
            {
                Console.WriteLine($"Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbonStack)}");
            }

            foreach (var kvp in forgedSwords.Where(x => x.Value > 0).OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
