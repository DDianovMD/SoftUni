using System;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main()
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int[] liftState = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray();

            for (int i = 0; i < liftState.Length; i++)
            {
                if (liftState[i] < 4)
                {
                    int peopleToAdd = 4 - liftState[i];
                    if (peopleToAdd <= peopleCount)
                    {
                        liftState[i] += peopleToAdd;
                        peopleCount -= peopleToAdd;
                    }
                    else
                    {
                        liftState[i] += peopleCount;
                        peopleCount = 0;
                    }
                    
                }

                if (peopleCount == 0)
                {
                    break;
                }
            }

            bool hasEmptrySpots = false;

            foreach (var wagon in liftState)
            {
                if (wagon < 4)
                {
                    hasEmptrySpots = true;
                    break;
                }
            }

            if (peopleCount == 0 && hasEmptrySpots == true)
            {
                Console.WriteLine("The lift has empty spots!");                
            }
            else if (peopleCount > 0 && hasEmptrySpots == false)
            {
                Console.WriteLine($"There isn't enough space! {peopleCount} people in a queue!");
            }

            Console.WriteLine(string.Join(" ", liftState));
        }
    }
}
