using System;

namespace Repainting
{
    class Program
    {
        static void Main()
        {
            int nylon = int.Parse(Console.ReadLine()) + 2;
            double paintVolume = double.Parse(Console.ReadLine()) * 1.1;
            int diluentVolume = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double materialsPrice = nylon * 1.5 + paintVolume * 14.5 + diluentVolume * 5 + 0.4;

            double moneyForHour = materialsPrice * 0.30;

            double neededMoney = materialsPrice + moneyForHour * hours;

            Console.WriteLine(neededMoney);            
        }
    }
}
