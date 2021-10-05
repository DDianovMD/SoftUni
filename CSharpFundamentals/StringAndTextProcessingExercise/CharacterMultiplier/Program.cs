using System;
using System.Linq;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(" ")
                .ToArray();

            int result = CharacterMultiplier(strings[0], strings[1]);
            Console.WriteLine(result);

        }

        private static int CharacterMultiplier(string firstString, string secondString)
        {
            int sum = 0;
            string shorterString = string.Empty;
            string longerString = string.Empty;

            if (firstString.Length < secondString.Length)
            {
                shorterString = firstString;
                longerString = secondString;
            }
            else if (firstString.Length >= secondString.Length)
            {
                shorterString = secondString;
                longerString = firstString;
            }

            for (int i = 0; i < shorterString.Length; i++)
            {
                sum += (int)shorterString[i] * (int)longerString[i];
            }

            for (int i = shorterString.Length; i < longerString.Length; i++)
            {
                sum += longerString[i];
            }

            return sum;
        }
    }
}
