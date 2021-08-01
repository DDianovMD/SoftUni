using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        public static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    double moneyWasted = budget * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", moneyWasted);
                }
                else if (season == "winter")
                {
                    double moneyWasted = budget * 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", moneyWasted);
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    double moneyWasted = budget * 0.40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", moneyWasted);
                }
                else if (season == "winter")
                {
                    double moneyWasted = budget * 0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", moneyWasted);
                }
            }
            else if (budget > 1000)
            {
                if (season == "summer")
                {
                    double moneyWasted = budget * 0.90;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", moneyWasted);
                }
                else if (season == "winter")
                {
                    double moneyWasted = budget * 0.90;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", moneyWasted);
                }
            }
        }
    }
}