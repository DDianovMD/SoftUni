using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            Stack<char> charStack = new Stack<char>();

            for (int i = 0; i < userInput.Length; i++)
            {                
                charStack.Push(userInput[i]);
            }

            while (charStack.Count != 0)
            {
                Console.Write(charStack.Peek());
                charStack.Pop();
            }
        }
    }
}
