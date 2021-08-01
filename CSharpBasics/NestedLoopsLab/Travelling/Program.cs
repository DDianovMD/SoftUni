using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling

{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double sum = 0;
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                double neededMoney = double.Parse(Console.ReadLine());
                while (sum < neededMoney)
                {
                    double input = double.Parse(Console.ReadLine());
                    sum += input;
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}