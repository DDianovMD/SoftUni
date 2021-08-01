using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double gamesInSofia = (48 - h) * 0.75;
            double holidayGames = p * (2.0 / 3.0);
            double allGames = gamesInSofia + holidayGames + h;

            if (year == "leap")
            {
                double additionalGames = allGames * (15.0 / 100.0);
                double sum = allGames + additionalGames;
                Console.WriteLine(Math.Floor(sum));
            }
            else if (year == "normal")
            {
                Console.WriteLine(Math.Floor(allGames));
            }
            Console.ReadLine();
        }
    }
}