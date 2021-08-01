using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine().ToUpper();
            double quantity = double.Parse(Console.ReadLine());
            CalculateOrderPrice(order, quantity);
            
        }
        static void CalculateOrderPrice(string order, double quantity)
        {
            double price = 0;
            if (order == "COFFEE")
            {
                price = 1.50;
            }
            else if (order == "COKE")
            {
                price = 1.40;
            }
            else if (order == "WATER")
            {
                price = 1.00;
            }
            else if (order == "SNACKS")
            {
                price = 2.00;
            }
            double result = quantity * price;
            Console.WriteLine($"{result:F2}");
        }
    }
}
