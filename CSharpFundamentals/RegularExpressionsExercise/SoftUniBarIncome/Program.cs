using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%(?:[^\|\$\%\.]+)?<(?<product>\w+)>(?:[^\|\$\%\.]+)?\|(?<count>\d+)\|(?:[^\|\$\%\.0-9]+)?(?<price>\d+.?\d+?)\$";
            string userInput = Console.ReadLine();
            decimal totalIncome = 0;

            while (userInput.ToLower() != "end of shift")
            {
                if (Regex.IsMatch(userInput, pattern))
                {
                    Match match = Regex.Match(userInput, pattern);
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    decimal totalPrice = int.Parse(match.Groups["count"].Value) * decimal.Parse(match.Groups["price"].Value);

                    Console.WriteLine($"{customer}: {product} - {totalPrice:F2}");

                    totalIncome += totalPrice;
                }
                
                userInput = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
