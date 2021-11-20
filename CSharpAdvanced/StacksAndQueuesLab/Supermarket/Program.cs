using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                if (input == "Paid")
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        Console.WriteLine(names.Peek());
                        names.Dequeue();
                        i--;
                    }
                }
                else
                {
                    names.Enqueue(input);                   
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
