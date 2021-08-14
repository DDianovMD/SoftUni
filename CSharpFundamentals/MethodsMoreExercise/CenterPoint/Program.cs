using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());
            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());

            PrintClosestPointCoordinates(x1, y1, x2, y2);
            
        }

        private static void PrintClosestPointCoordinates(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            if (Math.Abs(x1) + Math.Abs(y1) < Math.Abs(x2) + Math.Abs(y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (Math.Abs(x1) + Math.Abs(y1) > Math.Abs(x2) + Math.Abs(y2))
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (Math.Abs(x1) + Math.Abs(y1) == Math.Abs(x2) + Math.Abs(y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
