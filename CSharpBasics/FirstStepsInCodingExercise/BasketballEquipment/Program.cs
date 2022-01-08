using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main()
        {
            int priceForOneYear = int.Parse(Console.ReadLine());

            double trainersPrice = priceForOneYear - (priceForOneYear * 0.4);
            double outfitPrice = trainersPrice - (trainersPrice * 0.2);
            double ballPrice = outfitPrice * 0.25;
            double accessoriesPrice = ballPrice * 0.2;

            double moneyNeeded = priceForOneYear + trainersPrice + outfitPrice + ballPrice + accessoriesPrice;

            Console.WriteLine(moneyNeeded);
        }
    }
}
