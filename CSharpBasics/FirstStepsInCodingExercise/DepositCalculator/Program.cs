using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percents = double.Parse(Console.ReadLine());
            double finalsum = deposit + months * ((deposit * (percents / 100)) / 12);
            Console.WriteLine(finalsum);
        }
    }
}