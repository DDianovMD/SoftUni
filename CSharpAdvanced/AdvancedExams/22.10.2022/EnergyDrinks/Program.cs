using System;
using System.Collections.Generic;
using System.Linq;

namespace EnergyDrinks
{
    public class Program
    {
        public static void Main()
        {
            int[] caffeineMilligramsInfo = Console.ReadLine()
                                                  .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(int.Parse)
                                                  .ToArray();

            int[] energyDrinksInfo = Console.ReadLine()
                                                  .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(int.Parse)
                                                  .ToArray();

            Stack<int> caffeineMiligramsStack = new Stack<int>(caffeineMilligramsInfo);
            Queue<int> energyDrinksQueue = new Queue<int>(energyDrinksInfo);
            int drankCaffeine = 0;

            while (caffeineMiligramsStack.Count > 0 && energyDrinksQueue.Count > 0)
            {
                int currentCaffeineMiligrams = caffeineMiligramsStack.Pop();
                int currentEnergyDrink = energyDrinksQueue.Dequeue();

                int caffeine = currentCaffeineMiligrams * currentEnergyDrink;

                if (drankCaffeine + caffeine <= 300)
                {
                    drankCaffeine += caffeine;
                }
                else
                {
                    energyDrinksQueue.Enqueue(currentEnergyDrink);

                    if (drankCaffeine - 30 > 0)
                    {
                        drankCaffeine -= 30;
                    }
                    else
                    {
                        drankCaffeine = 0;
                    }
                }
            }

            // Print output
            if (energyDrinksQueue.Count > 0)
            {
                Console.Write("Drinks left: ");
                Console.WriteLine(string.Join(", ", energyDrinksQueue));
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {drankCaffeine} mg caffeine.");
        }
    }
}
