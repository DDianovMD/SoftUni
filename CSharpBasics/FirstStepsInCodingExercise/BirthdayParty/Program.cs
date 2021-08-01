using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double naem = double.Parse(Console.ReadLine());
            double cakePrice = naem * 0.2;
            double juices = cakePrice - (cakePrice * 0.45);
            double animator = naem / 1 / 3;
            double neededBudget = naem + cakePrice + juices + animator;
            Console.WriteLine(neededBudget);
        }
    }
}