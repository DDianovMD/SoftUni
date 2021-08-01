using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double moneyWon = (puzzles * 2.60) + (dolls * 3) + (bears * 4.10) + (minions * 8.20) + (trucks * 2);
            int toysCount = puzzles + dolls + bears + minions + trucks;
            double finalMoneyLeft;
            if (toysCount >= 50)
            {
                double discount = moneyWon * 0.25;
                double moneyAfterDiscount = moneyWon - discount;
                double rent = moneyAfterDiscount * 0.10;
                finalMoneyLeft = moneyAfterDiscount - rent;

                if (finalMoneyLeft >= vacationPrice)
                {
                    double moneyForVacation = finalMoneyLeft - vacationPrice;

                    Console.WriteLine("Yes! {0:F2} lv left.", moneyForVacation);
                }
                else
                {
                    double neededMoney = vacationPrice - finalMoneyLeft;

                    Console.WriteLine("Not enough money! {0:F2} lv needed.", neededMoney);
                }

            }
            else // toysCount < 50 =>> no discount in this case.
            {
                double rent = moneyWon * 0.10;
                finalMoneyLeft = moneyWon - rent;

                if (finalMoneyLeft >= vacationPrice)
                {
                    double moneyForVacation = finalMoneyLeft - vacationPrice;

                    Console.WriteLine("Yes! {0:F2} lv left.", moneyForVacation);
                }
                else
                {
                    double neededMoney = vacationPrice - finalMoneyLeft;

                    Console.WriteLine("Not enough money! {0:F2} lv needed.", neededMoney);
                }
            }
        }
    }
}