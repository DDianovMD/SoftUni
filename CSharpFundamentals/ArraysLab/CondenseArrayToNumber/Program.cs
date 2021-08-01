using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] condensed = new int[num.Length - 1];
            if (num.Length == 1)
            {
                Console.WriteLine(num[0]);
            }
            else
            {
                for (int i = 0; i < num.Length - 1; i++)
                {
                    for (int k = 0; k < condensed.Length; k++)
                    {
                        condensed[k] = num[k] + num[k + 1];
                    }
                    Array.Copy(condensed, num, condensed.Length);
                }
                Console.WriteLine(condensed[0]);
            }
        }
    }
}