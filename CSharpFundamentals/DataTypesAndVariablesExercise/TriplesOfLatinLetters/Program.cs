using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLetters; i++)
            {
                char firstChar = (char)('a' + i);
                for (int j = 0; j < numberOfLetters; j++)
                {
                    char secondChar = (char)('a' + j);
                    for (int k = 0; k < numberOfLetters; k++)
                    {
                        char thirdChar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}