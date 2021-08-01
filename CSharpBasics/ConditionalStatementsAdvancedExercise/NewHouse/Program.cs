using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHouse
{
    class Program
    {
        public static void Main()
        {
            string typeFlowers = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double discount;
            double price;
            double finalPrice;
            double moneyleft;
            double moneyneeded;

            if (typeFlowers == "Roses")
            {
                if (numberFlowers > 80)
                {
                    price = numberFlowers * 5.00;
                    discount = price * 0.10;
                    finalPrice = price - discount;
                    if (finalPrice <= budget)
                    {
                        moneyleft = budget - finalPrice;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", numberFlowers, typeFlowers, moneyleft);
                    }
                    else if (finalPrice > budget)
                    {
                        moneyleft = budget - finalPrice;
                        moneyneeded = Math.Abs(moneyleft);
                        Console.WriteLine("Not enough money, you need {0:F2} leva more.", moneyneeded);
                    }
                }
                else if (numberFlowers <= 80)
                {
                    price = numberFlowers * 5.00;
                    if (price <= budget)
                    {
                        moneyleft = budget - price;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", numberFlowers, typeFlowers, moneyleft);
                    }
                    else if (price > budget)
                    {
                        moneyleft = budget - price;
                        moneyneeded = Math.Abs(moneyleft);
                        Console.WriteLine("Not enough money, you need {0:F2} leva more.", moneyneeded);
                    }
                }

            }
            else if (typeFlowers == "Dahlias")
            {
                if (numberFlowers > 90)
                {
                    price = numberFlowers * 3.80;
                    discount = price * 0.15;
                    finalPrice = price - discount;
                    if (finalPrice <= budget)
                    {
                        moneyleft = budget - finalPrice;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", numberFlowers, typeFlowers, moneyleft);
                    }
                    else if (finalPrice > budget)
                    {
                        moneyleft = budget - finalPrice;
                        moneyneeded = Math.Abs(moneyleft);
                        Console.WriteLine("Not enough money, you need {0:F2} leva more.", moneyneeded);
                    }
                }
                else if (numberFlowers <= 90)
                {
                    price = numberFlowers * 3.80;
                    if (price <= budget)
                    {
                        moneyleft = budget - price;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", numberFlowers, typeFlowers, moneyleft);
                    }
                    else if (price > budget)
                    {
                        moneyleft = budget - price;
                        moneyneeded = Math.Abs(moneyleft);
                        Console.WriteLine("Not enough money, you need {0:F2} leva more.", moneyneeded);
                    }
                }
            }
            else if (typeFlowers == "Tulips")
            {
                if (numberFlowers > 80)
                {
                    price = numberFlowers * 2.80;
                    discount = price * 0.15;
                    finalPrice = price - discount;
                    if (finalPrice <= budget)
                    {
                        moneyleft = budget - finalPrice;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", numberFlowers, typeFlowers, moneyleft);
                    }
                    else if (finalPrice > budget)
                    {
                        moneyleft = budget - finalPrice;
                        moneyneeded = Math.Abs(moneyleft);
                        Console.WriteLine("Not enough money, you need {0:F2} leva more.", moneyneeded);
                    }
                }
                else if (numberFlowers <= 80)
                {
                    price = numberFlowers * 2.80;
                    if (price <= budget)
                    {
                        moneyleft = budget - price;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", numberFlowers, typeFlowers, moneyleft);
                    }
                    else if (price > budget)
                    {
                        moneyleft = budget - price;
                        moneyneeded = Math.Abs(moneyleft);
                        Console.WriteLine("Not enough money, you need {0:F2} leva more.", moneyneeded);
                    }
                }
            }
            else if (typeFlowers == "Narcissus")
            {
                if (numberFlowers < 120)
                {
                    price = numberFlowers * 3.00;
                    discount = price * 0.15;
                    finalPrice = price + discount;
                    if (finalPrice <= budget)
                    {
                        moneyleft = budget - finalPrice;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", numberFlowers, typeFlowers, moneyleft);
                    }
                    else if (finalPrice > budget)
                    {
                        moneyleft = budget - finalPrice;
                        moneyneeded = Math.Abs(moneyleft);
                        Console.WriteLine("Not enough money, you need {0:F2} leva more.", moneyneeded);
                    }
                }
                else if (numberFlowers >= 120)
                {
                    price = numberFlowers * 3.00;
                    if (price <= budget)
                    {
                        moneyleft = budget - price;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", numberFlowers, typeFlowers, moneyleft);
                    }
                    else if (price > budget)
                    {
                        moneyleft = budget - price;
                        moneyneeded = Math.Abs(moneyleft);
                        Console.WriteLine("Not enough money, you need {0:F2} leva more.", moneyneeded);
                    }
                }
            }
            else if (typeFlowers == "Gladiolus")
            {
                if (numberFlowers < 80)
                {
                    price = numberFlowers * 2.50;
                    discount = price * 0.20;
                    finalPrice = price + discount;
                    if (finalPrice <= budget)
                    {
                        moneyleft = budget - finalPrice;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", numberFlowers, typeFlowers, moneyleft);
                    }
                    else if (finalPrice > budget)
                    {
                        moneyleft = budget - finalPrice;
                        moneyneeded = Math.Abs(moneyleft);
                        Console.WriteLine("Not enough money, you need {0:F2} leva more.", moneyneeded);
                    }
                }
                else if (numberFlowers >= 80)
                {
                    price = numberFlowers * 2.50;
                    if (price <= budget)
                    {
                        moneyleft = budget - price;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", numberFlowers, typeFlowers, moneyleft);
                    }
                    else if (price > budget)
                    {
                        moneyleft = budget - price;
                        moneyneeded = Math.Abs(moneyleft);
                        Console.WriteLine("Not enough money, you need {0:F2} leva more.", moneyneeded);
                    }
                }
            }
        }
    }
}