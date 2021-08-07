using System;

namespace BalancedBrackets
{
    class Program
    {
        public static int J { get; private set; }

        static void Main(string[] args)
        {
            int rowsNumber = int.Parse(Console.ReadLine());
            int openingBracketsCounter = 0;
            int closingBracketsCounter = 0;

            for (int i = 0; i < rowsNumber; i++)
            {
                string userInput = Console.ReadLine();
                for (int j = 0; j < userInput.Length; j++)
                {
                    if (userInput[j] == '(' && openingBracketsCounter == closingBracketsCounter)
                    {
                        openingBracketsCounter++;
                    }
                    else if (userInput[j] == '(' && openingBracketsCounter > closingBracketsCounter)
                    {
                        Console.WriteLine("UNBALANCED");
                        Environment.Exit(0);
                    }
                    else if (userInput[j] == ')')
                    {
                        closingBracketsCounter++;
                    }
                }
            }

            if (openingBracketsCounter == closingBracketsCounter)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
