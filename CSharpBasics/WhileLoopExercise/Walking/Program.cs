using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            string steps = "";
            int stepsCounter = 0;
            while (true)
            {
                steps = Console.ReadLine();
                if (steps == "Going home")
                {
                    steps = Console.ReadLine();
                    stepsCounter += int.Parse(steps);
                    if (stepsCounter < 10000)
                    {
                        Console.WriteLine($"{10000 - stepsCounter} more steps to reach goal.");
                        break;
                    }
                    else if (stepsCounter >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{stepsCounter - 10000} steps over the goal!");
                        break;
                    }
                }
                stepsCounter += int.Parse(steps);
                if (stepsCounter >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsCounter - 10000} steps over the goal!");
                    break;
                }
            }
        }
    }
}