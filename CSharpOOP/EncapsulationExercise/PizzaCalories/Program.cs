using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Program
    {
        static void Main()
        {
            //try
            //{
            //    while (true)
            //    {
            //        string[] userInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //        if (userInput[0].ToUpper() == "END")
            //        {
            //            break;
            //        }
            //        else if (userInput[0] == "Dough")
            //        {
            //            Dough currentDough = new Dough(userInput[1], userInput[2], int.Parse(userInput[3]));
            //            Console.WriteLine($"{currentDough.TotalCalories():F2}");
            //        }
            //        else if (userInput[0] == "Topping")
            //        {
            //            Topping currentDough = new Topping(userInput[1], int.Parse(userInput[2]));
            //            Console.WriteLine($"{currentDough.TotalCalories():F2}");
            //        }
            //    }
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            try
            {
                List<string> command = Console.ReadLine().Split(" ").ToList();
                Pizza currentPizza = new Pizza(command[1]);
                command = Console.ReadLine().Split(" ").ToList();
                Dough currentDough = new Dough(command[1], command[2], int.Parse(command[3]));

                currentPizza.dough = currentDough;

                while (true)
                {
                    command = Console.ReadLine().Split(" ").ToList();

                    if (command[0].ToUpper() == "END")
                    {
                        break;
                    }

                    Topping currentTopping = new Topping(command[1], int.Parse(command[2]));

                    currentPizza.AddTopping(currentTopping);
                }

                Console.WriteLine($"{currentPizza.Name} - { currentPizza.TotalCalories():F2} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
