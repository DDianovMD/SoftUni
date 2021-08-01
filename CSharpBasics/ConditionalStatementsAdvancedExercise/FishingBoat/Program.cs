using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBoat
{
    class Program
    {
        public static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int humans = int.Parse(Console.ReadLine());
            double boatPrice;
            double finalBoatPrice;

            if (season == "Spring")
            {
                if (humans <= 6)
                {
                    boatPrice = 3000 - (3000 * 0.10);
                    if (humans % 2 == 0)
                    {
                        finalBoatPrice = boatPrice - (boatPrice * 0.05);
                        if (budget >= finalBoatPrice)
                        {
                            double moneyLeft = budget - finalBoatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - finalBoatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                    else
                    {
                        if (budget >= boatPrice)
                        {
                            double moneyLeft = budget - boatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - boatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                }
                else if (humans >= 7 && humans <= 11)
                {
                    boatPrice = 3000 - (3000 * 0.15);
                    if (humans % 2 == 0)
                    {
                        finalBoatPrice = boatPrice - (boatPrice * 0.05);
                        if (budget >= finalBoatPrice)
                        {
                            double moneyLeft = budget - finalBoatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - finalBoatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                    else
                    {
                        if (budget >= boatPrice)
                        {
                            double moneyLeft = budget - boatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - boatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                }
                else if (humans >= 12)
                {
                    boatPrice = 3000 - (3000 * 0.25);
                    if (humans % 2 == 0)
                    {
                        finalBoatPrice = boatPrice - (boatPrice * 0.05);
                        if (budget >= finalBoatPrice)
                        {
                            double moneyLeft = budget - finalBoatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - finalBoatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                    else
                    {
                        if (budget >= boatPrice)
                        {
                            double moneyLeft = budget - boatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - boatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                if (humans <= 6)
                {
                    boatPrice = 4200 - (4200 * 0.10);
                    if (humans % 2 == 0 && season != "Autumn")
                    {
                        finalBoatPrice = boatPrice - (boatPrice * 0.05);
                        if (budget >= finalBoatPrice)
                        {
                            double moneyLeft = budget - finalBoatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - finalBoatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                    else
                    {
                        if (budget >= boatPrice)
                        {
                            double moneyLeft = budget - boatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - boatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                }
                else if (humans >= 7 && humans <= 11)
                {
                    boatPrice = 4200 - (4200 * 0.15);
                    if (humans % 2 == 0 && season != "Autumn")
                    {
                        finalBoatPrice = boatPrice - (boatPrice * 0.05);
                        if (budget >= finalBoatPrice)
                        {
                            double moneyLeft = budget - finalBoatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - finalBoatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                    else
                    {
                        if (budget >= boatPrice)
                        {
                            double moneyLeft = budget - boatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - boatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                }
                else if (humans >= 12)
                {
                    boatPrice = 4200 - (4200 * 0.25);
                    if (humans % 2 == 0 && season != "Autumn")
                    {
                        finalBoatPrice = boatPrice - (boatPrice * 0.05);
                        if (budget >= finalBoatPrice)
                        {
                            double moneyLeft = budget - finalBoatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - finalBoatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                    else
                    {
                        if (budget >= boatPrice)
                        {
                            double moneyLeft = budget - boatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - boatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                }
            }
            else if (season == "Winter")
            {
                if (humans <= 6)
                {
                    boatPrice = 2600 - (2600 * 0.10);
                    if (humans % 2 == 0)
                    {
                        finalBoatPrice = boatPrice - (boatPrice * 0.05);
                        if (budget >= finalBoatPrice)
                        {
                            double moneyLeft = budget - finalBoatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - finalBoatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                    else
                    {
                        if (budget >= boatPrice)
                        {
                            double moneyLeft = budget - boatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - boatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                }
                else if (humans >= 7 && humans <= 11)
                {
                    boatPrice = 2600 - (2600 * 0.15);
                    if (humans % 2 == 0)
                    {
                        finalBoatPrice = boatPrice - (boatPrice * 0.05);
                        if (budget >= finalBoatPrice)
                        {
                            double moneyLeft = budget - finalBoatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - finalBoatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                    else
                    {
                        if (budget >= boatPrice)
                        {
                            double moneyLeft = budget - boatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - boatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                }
                else if (humans >= 12)
                {
                    boatPrice = 2600 - (2600 * 0.25);
                    if (humans % 2 == 0)
                    {
                        finalBoatPrice = boatPrice - (boatPrice * 0.05);
                        if (budget >= finalBoatPrice)
                        {
                            double moneyLeft = budget - finalBoatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - finalBoatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                    else
                    {
                        if (budget >= boatPrice)
                        {
                            double moneyLeft = budget - boatPrice;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = Math.Abs(budget - boatPrice);
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                }
            }
        }
    }
}