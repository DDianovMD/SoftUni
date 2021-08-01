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

            int peopleGoing = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            decimal priceForStudents;
            decimal priceForBusiness;
            decimal priceForRegular;
            decimal totalPrice;

            if (groupType == "Students" && day == "Friday")
            {
                priceForStudents = 8.45m;
                totalPrice = peopleGoing * priceForStudents;
                if (peopleGoing >= 30)
                {
                    totalPrice = totalPrice - (totalPrice * 0.15m);
                }
                Console.WriteLine($"Total price: {totalPrice:F2}");
            }
            else if (groupType == "Students" && day == "Saturday")
            {
                priceForStudents = 9.80m;
                totalPrice = peopleGoing * priceForStudents;
                if (peopleGoing >= 30)
                {
                    totalPrice = totalPrice - (totalPrice * 0.15m);
                }
                Console.WriteLine($"Total price: {totalPrice:F2}");
            }
            else if (groupType == "Students" && day == "Sunday")
            {
                priceForStudents = 10.46m;
                totalPrice = peopleGoing * priceForStudents;
                if (peopleGoing >= 30)
                {
                    totalPrice = totalPrice - (totalPrice * 0.15m);
                }
                Console.WriteLine($"Total price: {totalPrice:F2}");
            }

            if (groupType == "Business" && day == "Friday")
            {
                priceForBusiness = 10.90m;
                totalPrice = peopleGoing * priceForBusiness;
                if (peopleGoing >= 100)
                {
                    totalPrice = totalPrice - (10 * priceForBusiness);
                }
                Console.WriteLine($"Total price: {totalPrice:F2}");
            }
            else if (groupType == "Business" && day == "Saturday")
            {
                priceForBusiness = 15.60m;
                totalPrice = peopleGoing * priceForBusiness;
                if (peopleGoing >= 100)
                {
                    totalPrice = totalPrice - (10 * priceForBusiness);
                }
                Console.WriteLine($"Total price: {totalPrice:F2}");
            }
            else if (groupType == "Business" && day == "Sunday")
            {
                priceForBusiness = 16.00m;
                totalPrice = peopleGoing * priceForBusiness;
                if (peopleGoing >= 100)
                {
                    totalPrice = totalPrice - (10 * priceForBusiness);
                }
                Console.WriteLine($"Total price: {totalPrice:F2}");
            }

            if (groupType == "Regular" && day == "Friday")
            {
                priceForRegular = 15.00m;
                totalPrice = peopleGoing * priceForRegular;
                if (peopleGoing >= 10 && peopleGoing <= 20)
                {
                    totalPrice = totalPrice - (totalPrice * 0.05m);
                }
                Console.WriteLine($"Total price: {totalPrice:F2}");
            }
            else if (groupType == "Regular" && day == "Saturday")
            {
                priceForRegular = 20.00m;
                totalPrice = peopleGoing * priceForRegular;
                if (peopleGoing >= 10 && peopleGoing <= 20)
                {
                    totalPrice = totalPrice - (totalPrice * 0.05m);
                }
                Console.WriteLine($"Total price: {totalPrice:F2}");
            }
            else if (groupType == "Regular" && day == "Sunday")
            {
                priceForRegular = 22.50m;
                totalPrice = peopleGoing * priceForRegular;
                if (peopleGoing >= 10 && peopleGoing <= 20)
                {
                    totalPrice = totalPrice - (totalPrice * 0.05m);
                }
                Console.WriteLine($"Total price: {totalPrice:F2}");
            }
        }
    }
}