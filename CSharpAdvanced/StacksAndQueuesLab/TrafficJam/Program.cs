using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPassing = int.Parse(Console.ReadLine());

            Queue<string> carsQueue = new Queue<string>();

            int carsPassedCounter = 0;

            string userCommand = Console.ReadLine();

            while (userCommand.ToLower() != "end")
            {
                if (userCommand.ToLower() == "green")
                {
                    if (carsPassing > carsQueue.Count)
                    {
                        for (int i = 0; i < carsQueue.Count; i++)
                        {
                            Console.WriteLine($"{carsQueue.Peek()} passed!");
                            carsQueue.Dequeue();
                            carsPassedCounter++;
                            i--;
                        }                        
                    }
                    else
                    {
                        for (int i = 0; i < carsPassing; i++)
                        {
                            Console.WriteLine($"{carsQueue.Peek()} passed!");
                            carsQueue.Dequeue();
                            carsPassedCounter++;
                        }
                    }                    
                }
                else
                {
                    carsQueue.Enqueue(userCommand);                    
                }

                userCommand = Console.ReadLine();

            }

            Console.WriteLine($"{carsPassedCounter} cars passed the crossroads.");
        }
    }
}
