using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber < 1 || dayNumber > weekDays.Length)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(weekDays[dayNumber - 1]);
            }
        }
    }
}