using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursAfter15Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 15;
            if (minutes < 60 && hours < 24)
            {
                if (minutes >= 10)
                {
                    Console.WriteLine("{0}:{1}", hours, minutes);
                }
                if (minutes < 10)
                {
                    Console.WriteLine("{0}:0{1}", hours, minutes);
                }
            }
            if (minutes < 60 && hours > 24)
            {
                int days = hours / 24;
                hours = hours - (24 * days);
                if (minutes < 10)
                {
                    Console.WriteLine("{0}:0{1}", hours, minutes);
                }
                if (minutes >= 10)
                {
                    Console.WriteLine("{0}:{1}", hours, minutes);
                }
            }
            if (minutes >= 60) // при надвишаване на кръгъл час нулира минутите
            {
                hours = hours + (minutes / 60); // добавя следващия час към брояча
                minutes = minutes - 60; // изчислява останалите минути
                if (hours == 24 && minutes < 10) // в случай на 24 часа - занулява брояча и изписва 0 пред минутите ако са под 10
                {
                    Console.WriteLine("0:0{0}", minutes);
                }
                if (hours == 24 && minutes >= 10) // в случай на 24 часа - занулява брояча и изписва минутите като са 10 и над 10
                {
                    Console.WriteLine("0:{0}", minutes);
                }
                if (hours > 24)
                {
                    int days = hours / 24;
                    hours = hours - (24 * days);
                    if (hours < 10 && minutes < 10)
                    {
                        Console.WriteLine("{0}:0{1}", hours, minutes);
                    }
                    if (hours >= 10 && hours < 24 && minutes < 10)
                    {
                        Console.WriteLine("{0}:0{1}", hours, minutes);
                    }
                    if (hours >= 10 && hours < 24 && minutes >= 10)
                    {
                        Console.WriteLine("{0}:{1}", hours, minutes);
                    }
                }
                if (hours < 24)
                {
                    if (minutes < 10)
                    {
                        Console.WriteLine("{0}:0{1}", hours, minutes);
                    }
                    if (minutes >= 10)
                    {
                        Console.WriteLine("{0}:{1}", hours, minutes);
                    }
                }
            }
        }
    }
}