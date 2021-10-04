using System;
using System.Collections.Generic;
using System.Linq;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] inputCharArray = new char[input.Length];

            List<int> indexesOfRepeatedChars = new List<int>();

            for (int i = 0; i < input.Length; i++) // split input string into chars in array
            {
                inputCharArray[i] = input[i];
            }

            for (int i = 0; i < inputCharArray.Length - 1; i++) // remember indexes where stands repeated char
            {
                if (inputCharArray[i] == inputCharArray[i + 1])
                {
                    indexesOfRepeatedChars.Add(i + 1);
                }
            }

            List<char> resultList = new List<char>(inputCharArray.Length - indexesOfRepeatedChars.Count);

            for (int i = 0; i < inputCharArray.Length; i++) // fill result list with unique chars
            {
                if (indexesOfRepeatedChars.Contains(i) == false)
                {
                    resultList.Add(inputCharArray[i]);
                }
            }

            foreach (var item in resultList) // print result
            {
                Console.Write(item);
            }
        }
    }
}
