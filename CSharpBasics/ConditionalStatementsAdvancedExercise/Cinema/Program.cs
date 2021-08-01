using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        public static void Main()
        {
            string typeProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double projectionPrice;
            double income;

            if (typeProjection == "Premiere")
            {
                projectionPrice = 12.00;
                income = rows * columns * projectionPrice;
                Console.WriteLine("{0:F2} leva", income);
            }
            else if (typeProjection == "Normal")
            {
                projectionPrice = 7.50;
                income = rows * columns * projectionPrice;
                Console.WriteLine("{0:F2} leva", income);
            }
            else if (typeProjection == "Discount")
            {
                projectionPrice = 5.00;
                income = rows * columns * projectionPrice;
                Console.WriteLine("{0:F2} leva", income);
            }
        }
    }
}