using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenNumber = int.Parse(Console.ReadLine());

            while (Math.Abs(evenNumber) % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                evenNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {Math.Abs(evenNumber)}");

        }
    }
}