using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothesPriceForOne = double.Parse(Console.ReadLine());

            double decor = money * 0.10;
            double discount;
            double neededMoney;
            if (statists > 150)
            {
                discount = clothesPriceForOne * 0.10;
                neededMoney = (statists * (clothesPriceForOne - discount)) + decor;
                if (neededMoney > money)
                {
                    Console.WriteLine("Not enough money!");
                    double wingardNeeds = neededMoney - money;
                    Console.WriteLine("Wingard needs {0:F2} leva more.", wingardNeeds);
                }
                else
                {
                    Console.WriteLine("Action!");
                    double leftmoney = money - neededMoney;
                    Console.WriteLine("Wingard starts filming with {0:F2} leva left.", leftmoney);
                }
            }
            else
            {
                neededMoney = (statists * clothesPriceForOne) + decor;
                if (neededMoney > money)
                {
                    Console.WriteLine("Not enough money!");
                    double wingardNeeds = neededMoney - money;
                    Console.WriteLine("Wingard needs {0:F2} leva more.", wingardNeeds);
                }
                else
                {
                    Console.WriteLine("Action!");
                    double leftmoney = money - neededMoney;
                    Console.WriteLine("Wingard starts filming with {0:F2} leva left.", leftmoney);
                }
            }
        }
    }
}