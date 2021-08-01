using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int productsNumber = int.Parse(Console.ReadLine());
            List<string> products = new List<string>(productsNumber);
            for (int i = 0; i < productsNumber; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}." + products[i]);
            }
        }
    }
}
