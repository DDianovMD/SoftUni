using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            string reversedUserInput = String.Empty;

            for (int i = userInput.Length - 1; 0 <= i; i--)
            {
                reversedUserInput += userInput[i];
            }

            Console.WriteLine(reversedUserInput);
        }
    }
}