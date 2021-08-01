using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hoursAfter30 = hours * 60 + minutes + 30;
            if (hoursAfter30 % 60 < 10)
            {
                if (hoursAfter30 / 60 >= 24)
                {
                    Console.WriteLine($"{hoursAfter30 / 60 - 24}:0{hoursAfter30 % 60}");
                }
                else
                {
                    Console.WriteLine($"{hoursAfter30 / 60}:0{hoursAfter30 % 60}");
                }                
            }
            else
            {
                if (hoursAfter30 / 60 >= 24)
                {
                    Console.WriteLine($"{hoursAfter30 / 60 - 24}:{hoursAfter30 % 60}");
                }
                else
                {
                    Console.WriteLine($"{hoursAfter30 / 60}:{hoursAfter30 % 60}");                   
                }                
            }
        }
    }
}