using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] notReversedArray = Console.ReadLine()
                .Split()
                .ToArray();

            string[] reversedArray = new string[notReversedArray.Length];
            int counter = 0;
            for (int i = notReversedArray.Length - 1; i >= 0; i--)
            {
                reversedArray[counter] = notReversedArray[i];
                counter++;
            }

            for (int i = 0; i < reversedArray.Length; i++)
            {
                Console.Write(reversedArray[i] + " ");
            }
        }
    }
}