using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                words.Add(command);

                command = Console.ReadLine();
            }

            List<string> reversedString = new List<string>();
            string reversedWord = string.Empty;

            for (int i = 0; i < words.Count; i++)
            {
                for (int j = words[i].Length - 1; j >= 0 ; j--)
                {
                    reversedWord += words[i][j];
                }
                reversedString.Add(reversedWord);
                reversedWord = string.Empty;
            }

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine($"{words[i]} = {reversedString[i]}");
            }
        }
    }
}
