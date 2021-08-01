using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class Program
    {
        public static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int hour1 = examHour * 60 + examMinutes;
            int hour2 = arriveHour * 60 + arriveMinutes;

            if (hour1 > hour2 && (hour1 - hour2) > 30)
            {
                Console.WriteLine("Early");
                int minutesEarlier = hour1 - hour2;
                if (minutesEarlier < 60)
                {
                    Console.WriteLine($"{Math.Abs(minutesEarlier)} minutes before the start");
                }
                else if (minutesEarlier >= 60)
                {
                    int hours = minutesEarlier / 60;
                    int minutes = minutesEarlier % 60;
                    if (minutes < 10)
                        Console.WriteLine($"{hours}:0{minutes} hours before the start");
                    else if (minutes >= 10)
                        Console.WriteLine($"{hours}:{minutes} hours before the start");
                }
            }
            else if (hour1 == hour2)
            {
                Console.WriteLine("On time");
            }
            else if (hour1 > hour2 && (hour1 - hour2) <= 30)
            {
                Console.WriteLine("On time");
                int minutesEarlier = hour1 - hour2;
                Console.WriteLine($"{Math.Abs(minutesEarlier)} minutes before the start");
            }
            else if (hour2 > hour1)
            {
                Console.WriteLine("Late");
                if ((hour2 - hour1) < 60)
                {
                    int minutes = hour2 - hour1;
                    Console.WriteLine($"{minutes} minutes after the start");
                }
                else if ((hour2 - hour1) >= 60)
                {
                    int hours = (hour2 - hour1) / 60;
                    int minutes = (hour2 - hour1) % 60;
                    if (minutes < 10)
                        Console.WriteLine($"{hours}:0{minutes} hours after the start");
                    else if (minutes >= 10)
                        Console.WriteLine($"{hours}:{minutes} hours after the start");
                }
            }
        }
    }
}