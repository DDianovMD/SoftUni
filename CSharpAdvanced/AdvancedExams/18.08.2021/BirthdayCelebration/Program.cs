using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebration
{
    public class Program
    {
        public static void Main()
        {

            int[] userInput = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray();


            Queue<int> guestsEatingCapacity = new Queue<int>(userInput);

            userInput = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray();

            Stack<int> plates = new Stack<int>(userInput);

            int wastedFood = 0;

            // Program logic
            while (guestsEatingCapacity.Count > 0 && plates.Count > 0)
            {
                int currentPlate = plates.Pop();
                int currentGuestCapacity = guestsEatingCapacity.Dequeue();

                while (currentGuestCapacity > 0)
                {
                    currentGuestCapacity -= currentPlate;

                    if (currentGuestCapacity <= 0)
                    {
                        wastedFood += Math.Abs(currentGuestCapacity);
                        break;
                    }
                    else
                    {
                        currentPlate = plates.Pop();
                    }
                }
            }

            // Print output
            if (plates.Count > 0)
            {
                Console.WriteLine($"Plates: {string.Join(" ", plates)}");
            }
            else
            {
                Console.WriteLine($"Guests: {string.Join(" ", guestsEatingCapacity)}");
            }

            Console.WriteLine($"Wasted grams of food: {wastedFood}");
        }
    }
}
