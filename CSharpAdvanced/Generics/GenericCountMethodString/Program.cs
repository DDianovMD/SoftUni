using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    public class Program
    {
        public static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            List<string> inputs = new List<string>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string userInput = Console.ReadLine();
                inputs.Add(userInput);
            }

            string elementToCompareWith = Console.ReadLine();

            GetGreaterValueElementsCount<string>(inputs, elementToCompareWith);
        }

        public static void GetGreaterValueElementsCount<T>(List<T> list, T comparator)
        {
            int counter = 0;

            foreach (var item in list)
            {
                if (item.ToString().CompareTo(comparator.ToString()) > 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
