using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal worldRecord = decimal.Parse(Console.ReadLine());
            decimal metersDistance = decimal.Parse(Console.ReadLine());
            decimal timeForOneMeter = decimal.Parse(Console.ReadLine());

            decimal slowing = Math.Floor(metersDistance / 15m) * 12.50m;
            decimal ivansTime = (metersDistance * timeForOneMeter) + slowing;

            if (ivansTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivansTime:F2} seconds.");
            }
            else
            {
                decimal slowertime = ivansTime - worldRecord;
                Console.WriteLine($"No, he failed! He was {slowertime:F2} seconds slower.");
            }
        }
    }
}