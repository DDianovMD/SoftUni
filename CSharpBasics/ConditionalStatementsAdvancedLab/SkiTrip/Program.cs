using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiTrip
{
    class Program
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string grade = Console.ReadLine();
            int nights = days - 1;
            double roomPrice;
            double price;
            double discount;
            double priceAfterDiscount;
            double moneyForPositive;
            double moneyForNegative;
            double finalPrice;

            if (room == "room for one person")
            {
                roomPrice = 18;
                price = nights * roomPrice;
                if (grade == "positive")
                {
                    moneyForPositive = price * 0.25;
                    finalPrice = price + moneyForPositive;
                    Console.WriteLine("{0:F2}", finalPrice);
                }
                else if (grade == "negative")
                {
                    moneyForNegative = price * 0.1;
                    finalPrice = price - moneyForNegative;
                    Console.WriteLine("{0:F2}", finalPrice);
                }
            }
            else if (room == "apartment")
            {
                roomPrice = 25;
                price = nights * roomPrice;
                if (days < 10)
                {
                    discount = price * 0.3;
                    priceAfterDiscount = price - discount;
                    if (grade == "positive")
                    {
                        moneyForPositive = priceAfterDiscount * 0.25;
                        finalPrice = priceAfterDiscount + moneyForPositive;
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                    else if (grade == "negative")
                    {
                        moneyForNegative = priceAfterDiscount * 0.1;
                        finalPrice = priceAfterDiscount - moneyForNegative;
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = price * 0.35;
                    priceAfterDiscount = price - discount;
                    if (grade == "positive")
                    {
                        moneyForPositive = priceAfterDiscount * 0.25;
                        finalPrice = priceAfterDiscount + moneyForPositive;
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                    else if (grade == "negative")
                    {
                        moneyForNegative = priceAfterDiscount * 0.1;
                        finalPrice = priceAfterDiscount - moneyForNegative;
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                }
                else if (days > 15)
                {
                    discount = price * 0.5;
                    priceAfterDiscount = price - discount;
                    if (grade == "positive")
                    {
                        moneyForPositive = priceAfterDiscount * 0.25;
                        finalPrice = priceAfterDiscount + moneyForPositive;
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                    else if (grade == "negative")
                    {
                        moneyForNegative = priceAfterDiscount * 0.1;
                        finalPrice = priceAfterDiscount - moneyForNegative;
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                }
            }
            else if (room == "president apartment")
            {
                roomPrice = 35;
                price = nights * roomPrice;
                if (days < 10)
                {
                    discount = price * 0.1;
                    priceAfterDiscount = price - discount;
                    if (grade == "positive")
                    {
                        moneyForPositive = priceAfterDiscount * 0.25;
                        finalPrice = priceAfterDiscount + moneyForPositive;
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                    else if (grade == "negative")
                    {
                        moneyForNegative = priceAfterDiscount * 0.1;
                        finalPrice = priceAfterDiscount - moneyForNegative;
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = price * 0.15;
                    priceAfterDiscount = price - discount;
                    if (grade == "positive")
                    {
                        moneyForPositive = priceAfterDiscount * 0.25;
                        finalPrice = priceAfterDiscount + moneyForPositive;
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                    else if (grade == "negative")
                    {
                        moneyForNegative = priceAfterDiscount * 0.1;
                        finalPrice = priceAfterDiscount - moneyForNegative;
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                }
                else if (days > 15)
                {
                    discount = price * 0.2;
                    priceAfterDiscount = price - discount;
                    if (grade == "positive")
                    {
                        moneyForPositive = priceAfterDiscount * 0.25;
                        finalPrice = priceAfterDiscount + moneyForPositive;
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                    else if (grade == "negative")
                    {
                        moneyForNegative = priceAfterDiscount * 0.1;
                        finalPrice = priceAfterDiscount - moneyForNegative;
                        Console.WriteLine("{0:F2}", finalPrice);
                    }
                }
            }
        }
    }
}