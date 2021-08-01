using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int minNumber = int.MaxValue;

            while (command != "Stop")
            {
                if (int.Parse(command) < minNumber)
                {
                    minNumber = int.Parse(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}