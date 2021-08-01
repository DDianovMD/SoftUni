using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Торта - 45 лв.
            //Гофрета - 5.80 лв.
            //Палачинка – 3.20 лв.

            int cakePrice = 45;
            double wafflesPrice = 5.80;
            double pancakesPrice = 3.20;

            //1.Броят на дните, в които тече кампанията – цяло число в интервала[0 … 365]
            //2.Броят на сладкарите – цяло число в интервала[0 … 1000]
            //3.Броят на тортите – цяло число в интервала[0… 2000]
            //4.Броят на гофретите – цяло число в интервала[0 … 2000]
            //5.Броят на палачинките – цяло число в интервала[0 … 2000]

            int days = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakesCount = int.Parse(Console.ReadLine());
            int wafflesCount = int.Parse(Console.ReadLine());
            int pancakesCount = int.Parse(Console.ReadLine());

            int moneyFromCakes = cakesCount * cakePrice;
            double moneyFromWaffles = wafflesCount * wafflesPrice;
            double moneyFromPancakes = pancakesCount * pancakesPrice;

            double sum = moneyFromPancakes + moneyFromCakes + moneyFromWaffles;
            double moneyForOneDay = sum * cooks;
            double moneyForAllDays = moneyForOneDay * days;
            double moneyLeft = moneyForAllDays - (moneyForAllDays / 8);
            Console.WriteLine(moneyLeft);
        }
    }
}