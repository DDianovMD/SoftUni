using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            PrintMiddleCharacter(userInput);
        }

        public static void PrintMiddleCharacter(string userInput)
        {
            int stringLength = userInput.Length;
            int printIndex;

            if (stringLength % 2 == 0)
            {
                printIndex = stringLength / 2;
                Console.WriteLine("{0}{1}", userInput[printIndex - 1], userInput[printIndex]);
            }
            else
            {
                printIndex = stringLength / 2;
                Console.WriteLine(userInput[printIndex]);
            }
        }
    }
}
