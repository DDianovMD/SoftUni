using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();

            if (string1 == "mm")
            {
                if (string2 == "cm")
                {
                    length = length / 10;
                    Console.WriteLine("{0:F3}", length);
                }
                if (string2 == "m")
                {
                    length = length / 1000;
                    Console.WriteLine("{0:F3}", length);
                }
            }
            if (string1 == "cm")
            {
                if (string2 == "mm")
                {
                    length = length * 10;
                    Console.WriteLine("{0:F3}", length);
                }
                if (string2 == "m")
                {
                    length = length / 100;
                    Console.WriteLine("{0:F3}", length);
                }
            }
            if (string1 == "m")
            {
                if (string2 == "mm")
                {
                    length = length * 1000;
                    Console.WriteLine("{0:F3}", length);
                }
                if (string2 == "cm")
                {
                    length = length * 100;
                    Console.WriteLine("{0:F3}", length);
                }
            }
        }
    }
}