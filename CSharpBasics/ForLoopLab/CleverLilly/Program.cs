using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int lillysAge = int.Parse(Console.ReadLine()); // годините на Лили
            double washingMachinePrice = double.Parse(Console.ReadLine()); // цената на пералнята
            int toysPrice = int.Parse(Console.ReadLine()); // цена за продажба на играчка
            double birthdayMoney = 0; // получени пари за четните рождени дни
            int toysCounter = 0; // брояч за получените играчки
            double finalmoney = 0; // крайна сума след продажба на играчките и взетите пари от брата.

            for (int i = 1; i <= lillysAge; i++)
            {
                if (i % 2 != 0)
                {
                    toysCounter += 1; // +1 играчка на всеки нечетен рожден ден.
                }
                else if (i % 2 == 0)
                {
                    int money = (i / 2) * 10;
                    birthdayMoney += money; // сумата от пари, получени за четните рождени дни.
                }
            }

            finalmoney = birthdayMoney + (toysCounter * toysPrice) - (lillysAge - toysCounter);
            // всички пари = парите от четните рождени дни + (парите от продадени играчки) - (броя пъти, в които брат й е вземал по 1лв).

            if (washingMachinePrice <= finalmoney)
            {
                double moneyLeft = finalmoney - washingMachinePrice;
                Console.WriteLine($"Yes! {moneyLeft:F2}");
            }
            else
            {
                double moneyNeeded = washingMachinePrice - finalmoney;
                Console.WriteLine($"No! {moneyNeeded:F2}");
            }
        }
    }
}