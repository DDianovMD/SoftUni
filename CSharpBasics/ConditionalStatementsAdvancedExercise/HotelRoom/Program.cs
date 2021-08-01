using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        public static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double price;

            if (month == "May" || month == "October")
            {
                double studioPrice = 50.00;
                double apartmentPrice = 65.00;
                double finalPriceStudio;
                double finalApartmentPrice;
                price = studioPrice * nights;
                if (nights <= 7)
                {
                    finalPriceStudio = studioPrice * nights;
                    finalApartmentPrice = apartmentPrice * nights;
                    Console.WriteLine("Apartment: {0:f2} lv.", finalApartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", finalPriceStudio);
                }
                else if (nights > 7 && nights <= 14)
                {
                    finalPriceStudio = price - (price * 0.05);
                    finalApartmentPrice = apartmentPrice * nights;
                    Console.WriteLine("Apartment: {0:f2} lv.", finalApartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", finalPriceStudio);
                }
                else if (nights > 14)
                {
                    finalPriceStudio = price - (price * 0.30);
                    finalApartmentPrice = ((apartmentPrice * nights) - ((apartmentPrice * nights) * 0.10));
                    Console.WriteLine("Apartment: {0:f2} lv.", finalApartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", finalPriceStudio);
                }
            }
            else if (month == "June" || month == "September")
            {
                double studioPrice = 75.20;
                double apartmentPrice = 68.70;
                double finalPriceStudio;
                double finalApartmentPrice;
                price = studioPrice * nights;
                if (nights <= 14)
                {
                    finalPriceStudio = studioPrice * nights;
                    finalApartmentPrice = apartmentPrice * nights;
                    Console.WriteLine("Apartment: {0:f2} lv.", finalApartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", finalPriceStudio);
                }
                else if (nights > 14)
                {
                    finalPriceStudio = price - (price * 0.20);
                    finalApartmentPrice = ((apartmentPrice * nights) - ((apartmentPrice * nights) * 0.10));
                    Console.WriteLine("Apartment: {0:f2} lv.", finalApartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", finalPriceStudio);
                }
            }
            else if (month == "July" || month == "August")
            {
                double studioPrice = 76.00;
                double apartmentPrice = 77.00;
                double finalPriceStudio;
                double finalApartmentPrice;
                price = studioPrice * nights;
                if (nights <= 14)
                {
                    finalPriceStudio = price;
                    finalApartmentPrice = apartmentPrice * nights;
                    Console.WriteLine("Apartment: {0:f2} lv.", finalApartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", finalPriceStudio);
                }
                else if (nights > 14)
                {
                    finalPriceStudio = price;
                    finalApartmentPrice = ((apartmentPrice * nights) - ((apartmentPrice * nights) * 0.10));
                    Console.WriteLine("Apartment: {0:f2} lv.", finalApartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", finalPriceStudio);
                }
            }
        }
    }
}