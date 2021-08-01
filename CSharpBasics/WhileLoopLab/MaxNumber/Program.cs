using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int maxNumber = int.MinValue;

            while (command != "Stop")
            {
                if (int.Parse(command) > maxNumber)
                {
                    maxNumber = int.Parse(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}