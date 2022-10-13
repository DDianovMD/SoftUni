using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    public class Program
    {
        public static void Main()
        {
            // Read input info
            int[] firstLootboxInfo = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();

            int[] secondLootboxInfo = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();

            // Used variables
            Queue<int> firstLootbox = new Queue<int>(firstLootboxInfo);
            Stack<int> secondLootbox = new Stack<int>(secondLootboxInfo);
            int claimedItems = 0;

            // Program logic
            while (firstLootbox.Count > 0 && secondLootbox.Count > 0)
            {
                int firstItem = firstLootbox.Peek();
                int secondItem = secondLootbox.Pop();

                int itemsSum = firstItem + secondItem;

                if (itemsSum % 2 == 0)
                {
                    claimedItems += itemsSum;
                    firstLootbox.Dequeue();
                }
                else
                {
                    firstLootbox.Enqueue(secondItem);
                }
            }

            // Print output
            if (firstLootbox.Count == 0)
            {
                Console.WriteLine($"First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (claimedItems >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems}");
            }
        }
    }
}
