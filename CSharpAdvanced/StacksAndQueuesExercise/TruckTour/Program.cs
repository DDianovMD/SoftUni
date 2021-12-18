using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pupmsCount = int.Parse(Console.ReadLine());
            Queue<int> petrolAmount = new Queue<int>();
            Queue<int> distance = new Queue<int>();
            int startIndex = 0;
            int checkpointCounter = 0;

            int fuel = 0;

            for (int i = 0; i < pupmsCount; i++)
            {
                int[] userInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                petrolAmount.Enqueue(userInput[0]);
                distance.Enqueue(userInput[1]);                
            }

            
                
            while (checkpointCounter < pupmsCount)
            {                

                fuel += petrolAmount.Peek();

                if (fuel >= distance.Peek())
                {
                    fuel -= distance.Peek();
                    petrolAmount.Enqueue(petrolAmount.Peek());
                    petrolAmount.Dequeue();
                    distance.Enqueue(distance.Peek());
                    distance.Dequeue();
                                        
                    checkpointCounter++;
                }
                else
                {
                    fuel = 0;
                    petrolAmount.Enqueue(petrolAmount.Peek());
                    petrolAmount.Dequeue();
                    distance.Enqueue(distance.Peek());
                    distance.Dequeue();
                    startIndex = pupmsCount - (pupmsCount - checkpointCounter);
                }
            }

            Console.WriteLine(startIndex);
            
        }
    }
}
