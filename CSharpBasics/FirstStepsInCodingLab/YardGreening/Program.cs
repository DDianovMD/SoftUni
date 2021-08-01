using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareMeters = double.Parse(Console.ReadLine());
            double fullPrice = squareMeters * 7.61;
            double discount = fullPrice * 0.18;
            double finalPrice = fullPrice - discount;
            Console.WriteLine("The final price is: {0} lv.", finalPrice);
            Console.WriteLine("The discount is: {0} lv.", discount);
        }
    }
}