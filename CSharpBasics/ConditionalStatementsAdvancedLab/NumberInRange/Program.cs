using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRange
{
    class Program
    {
        public static void Main()
        {
            double randomNumber = double.Parse(Console.ReadLine());
            if (randomNumber >= -100 && randomNumber <= 100)
            {
                if (randomNumber == 0)
                {
                    Console.WriteLine("No");
                }
                else if (randomNumber != 0)
                {
                    Console.WriteLine("Yes");
                }
            }
            else if (randomNumber < -100)
            {
                Console.WriteLine("No");
            }
            else if (randomNumber > 100)
            {
                Console.WriteLine("No");
            }
        }
    }
}