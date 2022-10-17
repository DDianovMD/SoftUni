using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    public class Program
    {
        public static void Main()
        {
            // Read input info
            int[] ingredientsInfo = Console.ReadLine()
                                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                           .ToArray();

            int[] freshnessLevelInfo = Console.ReadLine()
                                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                           .ToArray();

            // Used variables
            Queue<int> ingredients = new Queue<int>(ingredientsInfo);
            Stack<int> freshnessLevel = new Stack<int>(freshnessLevelInfo);
            Dictionary<string, int> dishesCounter = new Dictionary<string, int>();
            dishesCounter.Add("Dipping sauce", 0);
            dishesCounter.Add("Green salad", 0);
            dishesCounter.Add("Chocolate cake", 0);
            dishesCounter.Add("Lobster", 0);

            // Program logic
            while (ingredients.Count > 0 && freshnessLevel.Count > 0)
            {
                int currentIngredient = ingredients.Dequeue();

                if (currentIngredient != 0)
                {
                    int currentFreshnessLevel = freshnessLevel.Pop();
                    int totalFreshness = currentIngredient * currentFreshnessLevel;

                    if (totalFreshness == 150)
                    {
                        dishesCounter["Dipping sauce"]++;
                    }
                    else if (totalFreshness == 250)
                    {
                        dishesCounter["Green salad"]++;
                    }
                    else if (totalFreshness == 300)
                    {
                        dishesCounter["Chocolate cake"]++;
                    }
                    else if (totalFreshness == 400)
                    {
                        dishesCounter["Lobster"]++;
                    }
                    else
                    {
                        currentIngredient += 5;
                        ingredients.Enqueue(currentIngredient);
                    }
                }
            }

            bool isSuccessful = true;

            foreach (KeyValuePair<string, int> kvp in dishesCounter)
            {
                if (kvp.Value == 0)
                {
                    isSuccessful = false;
                    break;
                }
            }

            // Print output
            if (isSuccessful)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            foreach (KeyValuePair<string, int> kvp in dishesCounter.Where(x => x.Value > 0)
                                                                   .OrderByDescending(x => x.Value)
                                                                   .ThenBy(x => x.Key))
            {
                Console.WriteLine($" # {kvp.Key} --> {kvp.Value}");
            }
        }
    }
}
