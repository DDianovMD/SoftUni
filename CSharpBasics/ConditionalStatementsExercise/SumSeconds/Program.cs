using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int summedTime = firstTime + secondTime + thirdTime;
            int minutes = summedTime / 60;
            int seconds = summedTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine("{0}:0{1}", minutes, seconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minutes, seconds);
            }
        }
    }
}