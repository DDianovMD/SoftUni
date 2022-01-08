using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main()
        {
            int pensCount = int.Parse(Console.ReadLine());
            int markersCount = int.Parse(Console.ReadLine());
            int sanitizerVolume = int.Parse(Console.ReadLine());
            int percentsDiscount = int.Parse(Console.ReadLine());

            double price = pensCount * 5.80 + markersCount * 7.20 + sanitizerVolume * 1.20;

            Console.WriteLine(price - (price * percentsDiscount / 100));


        }
    }
}
