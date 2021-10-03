using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] order = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string product = order[0];
            decimal price = decimal.Parse(order[1]);
            int quantity = int.Parse(order[2]);

            var products = new Dictionary<string, decimal>();
            var totalQuantity = new Dictionary<string, int>();

            while (product.ToLower() != "buy")
            {
                if (products.ContainsKey(product) == false)
                {
                    products.Add(product, price);
                    totalQuantity.Add(product, quantity);
                }
                else
                {
                    if (products[product] != price)
                    {
                        products[product] = price;
                        totalQuantity[product] += quantity;
                    }
                    else
                    {
                        totalQuantity[product] += quantity;
                    }
                }

                order = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                if (order[0] != "buy")
                {
                    product = order[0];
                    price = decimal.Parse(order[1]);
                    quantity = int.Parse(order[2]);
                }
                else
                {
                    product = order[0];
                }
                
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value * totalQuantity[item.Key]:F2}");
            }
            
        }
    }
}
