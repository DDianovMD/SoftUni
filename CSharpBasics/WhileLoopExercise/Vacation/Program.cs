using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int days = 0;
            int daysSpending = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                days++;
                if (action == "spend")
                {
                    money = money - amount;
                    if (money <= 0)
                    {
                        money = 0;
                    }
                    daysSpending += 1;
                    if (daysSpending >= 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }
                }
                else if (action == "save")
                {
                    daysSpending = 0;
                    money = money + amount;
                    if (money >= neededMoney)
                    {
                        Console.WriteLine($"You saved the money for {days}" + " days.");
                        break;
                    }
                }
            }
        }
    }
}