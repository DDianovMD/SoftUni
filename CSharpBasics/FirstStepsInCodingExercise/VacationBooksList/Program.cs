using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int daysToReadAll = int.Parse(Console.ReadLine());

            double timeToReadTheBook = pages / pagesPerHour;
            double hoursPerDay = timeToReadTheBook / daysToReadAll;
            Console.WriteLine(hoursPerDay);
        }
    }
}