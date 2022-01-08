using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main()
        {
            int chickenMenusCount = int.Parse(Console.ReadLine());
            int fishMenusCount = int.Parse(Console.ReadLine());
            int vegetarianMenusCount = int.Parse(Console.ReadLine());

            double checkenMenuPrice = 10.35;
            double fishMenuPrice = 12.4;
            double vegetarianMenuPrice = 8.15;

            double desertPrice = (chickenMenusCount * checkenMenuPrice + fishMenusCount * fishMenuPrice + vegetarianMenusCount * vegetarianMenuPrice) * 0.2;

            double moneyNeeded = chickenMenusCount * checkenMenuPrice + fishMenusCount * fishMenuPrice + vegetarianMenusCount * vegetarianMenuPrice + desertPrice + 2.5;

            Console.WriteLine(moneyNeeded);
        }
    }
}
