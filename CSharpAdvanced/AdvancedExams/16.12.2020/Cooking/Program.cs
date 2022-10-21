using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    public class Program
    {
        public static void Main()
        {
            // Read input info
            int[] liquidsInput = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();

            int[] ingredientsInput = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();

            // Used variables
            Queue<int> liquids = new Queue<int>(liquidsInput);
            Stack<int> ingredients = new Stack<int>(ingredientsInput);
            // key - food; value - food counter
            Dictionary<string, int> foods = new Dictionary<string, int>();
            foods.Add("Bread", 0);
            foods.Add("Cake", 0);
            foods.Add("Pastry", 0);
            foods.Add("Fruit Pie", 0);
            bool isSuccessful = true;

            // Program logic
            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                int liquid = liquids.Dequeue();
                int ingredient = ingredients.Pop();
                int ingredientsSum = liquid + ingredient;

                if (ingredientsSum == 25)
                {
                    foods["Bread"]++;
                }
                else if (ingredientsSum == 50)
                {
                    foods["Cake"]++;
                }
                else if (ingredientsSum == 75)
                {
                    foods["Pastry"]++;
                }
                else if (ingredientsSum == 100)
                {
                    foods["Fruit Pie"]++;
                }
                else 
                {
                    ingredient += 3;
                    ingredients.Push(ingredient);
                }
            }

            foreach (KeyValuePair<string, int> kvp in foods)
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
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            Console.Write("Liquids left: ");
            if (liquids.Count > 0)
            {
                Console.WriteLine(string.Join(", ", liquids));
            }
            else
            {
                Console.WriteLine("none");
            }

            Console.Write("Ingredients left: ");
            if (ingredients.Count > 0)
            {
                Console.WriteLine(string.Join(", ", ingredients));
            }
            else
            {
                Console.WriteLine("none");
            }

            foreach (KeyValuePair<string, int> kvp in foods.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
