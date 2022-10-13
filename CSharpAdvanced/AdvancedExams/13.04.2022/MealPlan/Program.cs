using System;
using System.Collections.Generic;
using System.Linq;

namespace MealPlan
{
    public class Program
    {
        public static void Main()
        {
            // User input
            string[] mealsInputInfo = Console.ReadLine()
                                             .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[] caloriesPerDayInputInfo = Console.ReadLine()
                                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                   .Select(int.Parse)
                                                   .ToArray();

            // Used variables
            Queue<string> meals = new Queue<string>(mealsInputInfo);
            Stack<int> caloriesPerDay = new Stack<int>(caloriesPerDayInputInfo);
            int mealsCount = 0;

            Dictionary<string, int> caloriesTable = new Dictionary<string, int>();
            caloriesTable.Add("salad", 350);
            caloriesTable.Add("soup", 490);
            caloriesTable.Add("pasta", 680);
            caloriesTable.Add("steak", 790);

            // Program logic
            while (caloriesPerDay.Count > 0 && meals.Count > 0)
            {
                int currentDayTarget = caloriesPerDay.Pop();

                while (currentDayTarget > 0 && meals.Count > 0)
                {
                    string currentMeal = meals.Dequeue();
                    currentDayTarget -= caloriesTable[$"{currentMeal}"];
                    mealsCount++;

                    if (currentDayTarget < 0)
                    {
                        int caloriesForNextDay = Math.Abs(currentDayTarget);

                        if (caloriesPerDay.Count > 0)
                        {
                            caloriesPerDay.Push(caloriesPerDay.Pop() - caloriesForNextDay);
                        }

                        break;
                    }
                }

                if (meals.Count == 0 && currentDayTarget >= 0)
                {
                    caloriesPerDay.Push(currentDayTarget);
                }
            }

            // Print output
            if (meals.Count == 0)
            {
                Console.WriteLine($"John had {mealsCount} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", caloriesPerDay)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {mealsCount} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
            }
        }
    }
}
