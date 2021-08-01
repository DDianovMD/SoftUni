using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket
{
    class Program
    {
        public static void Main()
        {
            string weekDay = Console.ReadLine();
            int ticketprice;

            if (weekDay == "Monday")
            {
                ticketprice = 12;
                Console.WriteLine(ticketprice);
            }
            else if (weekDay == "Tuesday")
            {
                ticketprice = 12;
                Console.WriteLine(ticketprice);
            }
            else if (weekDay == "Wednesday")
            {
                ticketprice = 14;
                Console.WriteLine(ticketprice);
            }
            else if (weekDay == "Thursday")
            {
                ticketprice = 14;
                Console.WriteLine(ticketprice);
            }
            else if (weekDay == "Friday")
            {
                ticketprice = 12;
                Console.WriteLine(ticketprice);
            }
            else if (weekDay == "Saturday")
            {
                ticketprice = 16;
                Console.WriteLine(ticketprice);
            }
            else if (weekDay == "Sunday")
            {
                ticketprice = 16;
                Console.WriteLine(ticketprice);
            }
        }
    }
}