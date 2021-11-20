using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] userInput = Console.ReadLine().ToCharArray();

            Stack<int> openingBracketsIndexes = new Stack<int>();
            Queue<int> closingBracketsIndexes = new Queue<int>();


            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == '(')
                {
                    openingBracketsIndexes.Push(i);
                }
                else if (userInput[i] == ')')
                {
                    for (int j = openingBracketsIndexes.Peek(); j <= i; j++)
                    {
                        Console.Write(userInput[j]);
                    }
                    Console.WriteLine();
                    openingBracketsIndexes.Pop();
                }
            }
        }
    }
}
