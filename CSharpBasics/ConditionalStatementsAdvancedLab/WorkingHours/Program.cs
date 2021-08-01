using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingHours
{
    class Program
    {
        public static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            string weekDay = Console.ReadLine();

            if (weekDay == "Monday")
            {
                if (hour >= 10 && hour < 18)
                {
                    Console.WriteLine("open");
                }
                else if (hour < 10)
                {
                    Console.WriteLine("closed");
                }
                else if (hour > 18)
                {
                    Console.WriteLine("closed");
                }
            }
            else if (weekDay == "Tuesday")
            {
                if (hour >= 10 && hour < 18)
                {
                    Console.WriteLine("open");
                }
                else if (hour < 10)
                {
                    Console.WriteLine("closed");
                }
                else if (hour > 18)
                {
                    Console.WriteLine("closed");
                }
            }
            else if (weekDay == "Wednesday")
            {
                if (hour >= 10 && hour < 18)
                {
                    Console.WriteLine("open");
                }
                else if (hour < 10)
                {
                    Console.WriteLine("closed");
                }
                else if (hour > 18)
                {
                    Console.WriteLine("closed");
                }
            }
            else if (weekDay == "Thursday")
            {
                if (hour >= 10 && hour < 18)
                {
                    Console.WriteLine("open");
                }
                else if (hour < 10)
                {
                    Console.WriteLine("closed");
                }
                else if (hour > 18)
                {
                    Console.WriteLine("closed");
                }
            }
            else if (weekDay == "Friday")
            {
                if (hour >= 10 && hour < 18)
                {
                    Console.WriteLine("open");
                }
                else if (hour < 10)
                {
                    Console.WriteLine("closed");
                }
                else if (hour > 18)
                {
                    Console.WriteLine("closed");
                }
            }
            else if (weekDay == "Saturday")
            {
                if (hour >= 10 && hour < 18)
                {
                    Console.WriteLine("open");
                }
                else if (hour < 10)
                {
                    Console.WriteLine("closed");
                }
                else if (hour > 18)
                {
                    Console.WriteLine("closed");
                }
            }
            else if (weekDay == "Sunday")
            {
                Console.WriteLine("closed");
            }
        }
    }
}