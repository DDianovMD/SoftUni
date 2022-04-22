using System;
using System.Collections.Generic;

namespace GenericCountMethodDoubles

{
    public class Program
    {
        public static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            List<double> inputs = new List<double>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string userInput = Console.ReadLine();
                inputs.Add(double.Parse(userInput));
            }

            string elementToCompareWith = Console.ReadLine();

            GetGreaterValueElementsCount<double>(inputs, double.Parse(elementToCompareWith));
        }

        public static void GetGreaterValueElementsCount<T>(List<T> list, T comparator) where T : IComparable
        {
            int counter = 0;

            foreach (var item in list)
            {
                if (item.CompareTo(comparator) > 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
