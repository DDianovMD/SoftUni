using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area;
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;

                Console.WriteLine("{0:F3}", area);
            }
            if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;

                Console.WriteLine("{0:F3}", area);
            }
            if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = r * r * Math.PI;

                Console.WriteLine("{0:F3}", area);
            }
            if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                area = (a * ha) / 2;

                Console.WriteLine("{0:F3}", area);
            }
        }
    }
}