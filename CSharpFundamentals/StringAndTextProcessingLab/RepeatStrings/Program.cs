using System;
using System.Linq;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                string tempString = string.Empty;

                for (int j = 0; j < words[i].Length; j++)
                {
                    tempString += words[i];
                }
                words[i] = tempString;
            }

            Console.WriteLine(string.Join("", words));
        }
    }
}
