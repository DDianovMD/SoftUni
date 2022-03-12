using System;
using System.Collections.Generic;
using System.Text;

namespace EvenTimes
{
    class Program
    {
        static void Main()
        {
            // key - unique number
            // value - times of occurance

            int integersCount = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            StringBuilder userInput = new StringBuilder();

            for (int i = 0; i < integersCount; i++)
            {
                userInput.Append(Console.ReadLine());

                if (numbers.ContainsKey(int.Parse(userInput.ToString())) == false)
                {
                    numbers.Add(int.Parse(userInput.ToString()), 1);
                }
                else
                {
                    numbers[int.Parse(userInput.ToString())] += 1;
                }

                userInput.Clear();
            }

            foreach (var kvp in numbers)
            {
                if (kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
    }
}
