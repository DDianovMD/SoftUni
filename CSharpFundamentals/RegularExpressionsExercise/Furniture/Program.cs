using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">{2}(?<furniture>[A-Za-z]+[\sA-Za-z]+?)<{2}(?<price>\d+(.\d+)?)!(?<quantity>\d+)";

            Regex regex = new Regex(pattern);

            List<string> furniture = new List<string>();
            decimal totalMoneySpend = 0;
            string userInput = Console.ReadLine();

            // Program logic
            while (userInput != "Purchase")
            {
                Match match = regex.Match(userInput);

                if (match.Captures.Count != 0)
                {
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    if (quantity > 0)
                    {
                        furniture.Add(match.Groups["furniture"].Value);
                    }

                    totalMoneySpend += price * quantity;
                }

                userInput = Console.ReadLine();
            }

            //Print output
            Console.WriteLine("Bought furniture:");
            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalMoneySpend:F2}");
        }
    }
}
