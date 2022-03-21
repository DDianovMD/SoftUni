using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{    

    public class Program
    {
        public static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            string command = string.Empty;

            List<string> inputs = new List<string>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                command = Console.ReadLine();
                inputs.Add(command);
            }

            int[] indexes = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            GenericSwapMethodStrings<string>(inputs, indexes[0], indexes[1]);

            foreach (var item in inputs)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

        public static void GenericSwapMethodStrings<T>(List<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }    
}
