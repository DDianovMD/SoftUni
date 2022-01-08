using System;

namespace ASCIISumator
{
    class Program
    {
        static void Main(string[] args)
        {
            int ASCIIStartIndex = (int)char.Parse(Console.ReadLine());
            int ASCIIEndIndex = (int)char.Parse(Console.ReadLine());

            string userInput = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                if ((int)userInput[i] > ASCIIStartIndex && (int)userInput[i] < ASCIIEndIndex)
                {
                    sum += (int)userInput[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
