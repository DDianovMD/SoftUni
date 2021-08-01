using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int area = width * length;
            int areaLeft = area;
            int piecesCounter = 0;

            while (areaLeft > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    Console.WriteLine($"{(area - piecesCounter)} pieces are left.");
                    Environment.Exit(0);
                }
                piecesCounter += int.Parse(input);
                areaLeft -= int.Parse(input);
            }
            Console.WriteLine($"No more cake left! You need {(piecesCounter - area)} pieces more.");
        }
    }
}