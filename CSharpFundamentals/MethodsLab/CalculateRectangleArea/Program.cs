using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double area = CalculateRectangleArea(width, hight);
            Console.WriteLine(area);
        }
        static double CalculateRectangleArea(double width, double hight)
        {
            double area = width * hight;
            return area;
        }
    }
}
