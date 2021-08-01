using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNumber = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            for (int i = multiplier; i <= 10; i++)
            {
                Console.WriteLine($"{givenNumber} X {i} = {givenNumber * i}");
            }

            if (multiplier > 10)
            {
                Console.WriteLine($"{givenNumber} X {multiplier} = {givenNumber * multiplier}");
            }
        }
    }
}