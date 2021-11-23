using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> clothesStack = new Stack<int>();

            foreach (var item in clothes)
            {
                clothesStack.Push(item);
            }

            int initialRackCapacity = int.Parse(Console.ReadLine());
            int rackCapacity = initialRackCapacity;
            int racksCounter = 1;

            for (int i = 0; i < clothesStack.Count; i++)
            {

                if (clothesStack.Peek() <= rackCapacity)
                {
                    rackCapacity -= clothesStack.Peek();
                    clothesStack.Pop();
                    i--;
                }
                else
                {
                    racksCounter++;
                    rackCapacity = initialRackCapacity;
                    rackCapacity -= clothesStack.Peek();
                    clothesStack.Pop();
                    i--;
                }

                if (rackCapacity == 0 && clothesStack.Count > 0)
                {
                    racksCounter++;
                    rackCapacity = initialRackCapacity;
                }
            }

            Console.WriteLine(racksCounter);
        }
    }
}
