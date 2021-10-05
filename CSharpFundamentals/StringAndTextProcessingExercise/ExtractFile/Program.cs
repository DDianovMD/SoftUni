using System;
using System.Linq;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userInput = Console.ReadLine()
                .Split("\\", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string fileName = userInput[userInput.Length - 1];

            string[] splittedFile = fileName
                .Split(".", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Console.WriteLine($"File name: {splittedFile[0]}");
            Console.WriteLine($"File extension: {splittedFile[1]}");
        }
    }
}
