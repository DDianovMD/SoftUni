using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] length = new int[nums.Length];

            int length = int.MinValue;
            int bestLength = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                
                
            }

        }
    }
}
