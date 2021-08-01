using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //цената на малините е на половина по - ниска от тази на ягодите;
            //цената на портокалите е с 40 % по - ниска от цената на малините;
            //цената на бананите е с 80 % по - ниска от цената на малините.

            //Вход
            //От конзолата се четат 5 реда:
            //1.Цена на ягодите в лева – реално число в интервала[0.00 … 10000.00]
            //2.Количество на бананите в килограми – реално число в интервала[0.00 … 1 0000.00]
            //3.Количество на портокалите в килограми – реално число в интервала[0.00 … 10000.00]
            //4.Количество на малините в килограми – реално число в интервала[0.00 … 10000.00]
            //5.Количество на ягодите в килограми – реално число в интервала[0.00 … 10000.00]

            double strawberriesPrice = double.Parse(Console.ReadLine());
            double kgBananaCount = double.Parse(Console.ReadLine());
            double kgOrangeCount = double.Parse(Console.ReadLine());
            double kgMaliniCount = double.Parse(Console.ReadLine());
            double kgStrawberriesCount = double.Parse(Console.ReadLine());

            double maliniPrice = strawberriesPrice / 2;
            double orangePrice = maliniPrice - (maliniPrice * 0.4);
            double bananaPrice = maliniPrice - (maliniPrice * 0.8);

            double moneyForMalini = kgMaliniCount * maliniPrice;
            double moneyForOranges = kgOrangeCount * orangePrice;
            double moneyForBananas = kgBananaCount * bananaPrice;
            double moneyForStrawberries = kgStrawberriesCount * strawberriesPrice;

            double allMoneyNeeded = moneyForBananas + moneyForMalini + moneyForOranges + moneyForStrawberries;
            Console.WriteLine("{0}:F2", allMoneyNeeded);
        }
    }
}