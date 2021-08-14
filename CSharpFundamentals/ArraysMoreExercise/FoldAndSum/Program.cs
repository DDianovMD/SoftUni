using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userInputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int counter = 0;

            int[] upperArray = new int[userInputArray.Length / 2];
            int[] lowerArray = new int[userInputArray.Length / 2];

            // filling upper array

            for (int i = 0; i < upperArray.Length; i++)
            {
                if (i < upperArray.Length / 2)
                {
                    upperArray[i] = userInputArray[userInputArray.Length / 4 - (i + 1)];
                }
                else
                {                    
                    upperArray[i] = userInputArray[userInputArray.Length - 1 - counter++];                    
                }
            }

            // filling lower array

            for (int i = 0; i < lowerArray.Length; i++)
            {
                lowerArray[i] = userInputArray[userInputArray.Length / 4 + i];
            }
       
            // filling result array

            int[] resultArray = new int[userInputArray.Length / 2];
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = upperArray[i] + lowerArray[i];
            }

            // printing result

            for (int i = 0; i < resultArray.Length; i++)
            {
                if (i != resultArray.Length - 1)
                {
                    Console.Write(resultArray[i] + " ");
                }
                else
                {
                    Console.WriteLine(resultArray[i]);
                }
            }
        }
    }
}
