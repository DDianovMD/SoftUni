using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostgames = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            int brokenHeadsetsCounter = 0;
            int brokenMousesCounter = 0;
            int brokenKeyboardsCounter = 0;
            int brokenDisplaysCounter = 0;

            for (int i = 1; i <= lostgames; i++)
            {
                if (i % 2 == 0)
                {
                    brokenHeadsetsCounter += 1;
                }
                if (i % 3 == 0)
                {
                    brokenMousesCounter += 1;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    brokenKeyboardsCounter += 1;
                }                                 
            }
            brokenDisplaysCounter = brokenKeyboardsCounter / 2;
            Console.WriteLine($"Rage expenses: {(headsetPrice * brokenHeadsetsCounter + mousePrice * brokenMousesCounter + keyboardPrice * brokenKeyboardsCounter + displayPrice * brokenDisplaysCounter):F2} lv.");
        }
    }
}