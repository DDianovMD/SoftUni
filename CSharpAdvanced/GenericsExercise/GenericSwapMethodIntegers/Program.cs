using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodIntegers
{

    public class Program
    {
        public static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            string command = string.Empty;

            List<int> inputs = new List<int>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                command = Console.ReadLine();
                inputs.Add(int.Parse(command));
            }

            int[] indexes = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            GenericSwapMethodIntegers<int>(inputs, indexes[0], indexes[1]);

            foreach (var item in inputs)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

        public static void GenericSwapMethodIntegers<T>(List<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
