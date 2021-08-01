using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidNumber
{
    class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 100 || number > 200)
            {
                if (number == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }
    }
}