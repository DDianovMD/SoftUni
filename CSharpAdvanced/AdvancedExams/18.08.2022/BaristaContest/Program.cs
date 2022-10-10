using System;
using System.Collections.Generic;
using System.Linq;

namespace BaristaContest
{
    public class Program
    {
        static void Main()
        {
            // Read user input
            int[] coffeeQuantities = Console.ReadLine()
                                           .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                           .ToArray();

            int[] milkQuantities = Console.ReadLine()
                                           .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                           .ToArray();

            // Used variables for program logic
            Queue<int> coffeeQuantitiesQueue = new Queue<int>(coffeeQuantities);
            Stack<int> milkQuantitiesStack = new Stack<int>(milkQuantities);

            Dictionary<string, int> coffeeDrinks = new Dictionary<string, int>();
            coffeeDrinks.Add("Cortado", 0);
            coffeeDrinks.Add("Espresso", 0);
            coffeeDrinks.Add("Capuccino", 0);
            coffeeDrinks.Add("Americano", 0);
            coffeeDrinks.Add("Latte", 0);

            // Program logic
            while (coffeeQuantitiesQueue.Count > 0 && milkQuantitiesStack.Count > 0)
            {
                int currentCoffeeQuantitie = coffeeQuantitiesQueue.Dequeue();
                int currentMilkQuantitie = milkQuantitiesStack.Pop();

                if (currentMilkQuantitie + currentCoffeeQuantitie == 50)
                {
                    coffeeDrinks["Cortado"]++;
                }
                else if (currentMilkQuantitie + currentCoffeeQuantitie == 75)
                {
                    coffeeDrinks["Espresso"]++;
                }
                else if (currentMilkQuantitie + currentCoffeeQuantitie == 100)
                {
                    coffeeDrinks["Capuccino"]++;
                }
                else if (currentMilkQuantitie + currentCoffeeQuantitie == 150)
                {
                    coffeeDrinks["Americano"]++;
                }
                else if (currentMilkQuantitie + currentCoffeeQuantitie == 200)
                {
                    coffeeDrinks["Latte"]++;
                }
                else
                {
                    currentMilkQuantitie -= 5;
                    milkQuantitiesStack.Push(currentMilkQuantitie);
                }
            }

            // Print output

            if (milkQuantitiesStack.Count == 0 && coffeeQuantitiesQueue.Count == 0)
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }

            Console.Write("Coffee left: ");
            if (coffeeQuantitiesQueue.Count == 0)
            {
                Console.WriteLine("none");
            }
            else
            {
                Console.WriteLine(String.Join(", ", coffeeQuantitiesQueue));
            }

            Console.Write("Milk left: ");
            if (milkQuantitiesStack.Count == 0)
            {
                Console.WriteLine("none");
            }
            else
            {
                Console.WriteLine(String.Join(", ", milkQuantitiesStack));
            }

            foreach (var kvp in coffeeDrinks.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}
