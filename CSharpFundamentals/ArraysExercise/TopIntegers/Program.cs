using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i != inputArray.Length - 1)
                {
                    int counter = i + 1;
                    while (inputArray[i] > inputArray[counter])
                    {                      
                        if (counter == inputArray.Length - 1)
                        {
                            Console.Write(inputArray[i] + " ");
                            break;
                        }
                        counter++;
                    }
                }

                if (i == inputArray.Length - 1)
                {
                    Console.WriteLine(inputArray[inputArray.Length - 1]);
                }
            }
        }
    }
}
