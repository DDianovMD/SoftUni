using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenNumber = Console.ReadLine();
            string singleNumber = string.Empty;
            int factoriel = 1;
            int sum = 0;

            for (int i = 0; i <= givenNumber.Length - 1; i++)
            {
                singleNumber += givenNumber[i];
                for (int j = 1; j <= int.Parse(singleNumber); j++)
                {
                    factoriel *= j;
                }
                sum += factoriel;
                factoriel = 1;
                singleNumber = string.Empty;
            }

            if (sum == int.Parse(givenNumber))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}