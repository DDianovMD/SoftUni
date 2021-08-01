using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        public static void Main()
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double price;
            double sum;

            if (product == "coffee")
            {
                if (city == "Sofia")
                {
                    price = 0.50;
                    sum = count * price;
                    Console.WriteLine(sum);
                }
                else if (city == "Plovdiv")
                {
                    price = 0.40;
                    sum = count * price;
                    Console.WriteLine(sum);
                }
                else if (city == "Varna")
                {
                    price = 0.45;
                    sum = count * price;
                    Console.WriteLine(sum);
                }
            }
            else if (product == "water")
            {
                if (city == "Sofia")
                {
                    price = 0.80;
                    sum = count * price;
                    Console.WriteLine(sum);
                }
                else if (city == "Plovdiv")
                {
                    price = 0.70;
                    sum = count * price;
                    Console.WriteLine(sum);
                }
                else if (city == "Varna")
                {
                    price = 0.70;
                    sum = count * price;
                    Console.WriteLine(sum);
                }
            }
            else if (product == "beer")
            {
                if (city == "Sofia")
                {
                    price = 1.20;
                    sum = count * price;
                    Console.WriteLine(sum);
                }
                else if (city == "Plovdiv")
                {
                    price = 1.15;
                    sum = count * price;
                    Console.WriteLine(sum);
                }
                else if (city == "Varna")
                {
                    price = 1.10;
                    sum = count * price;
                    Console.WriteLine(sum);
                }
            }
            else if (product == "sweets")
            {
                if (city == "Sofia")
                {
                    price = 1.45;
                    sum = count * price;
                    Console.WriteLine(sum);
                }
                else if (city == "Plovdiv")
                {
                    price = 1.30;
                    sum = count * price;
                    Console.WriteLine(sum);
                }
                else if (city == "Varna")
                {
                    price = 1.35;
                    sum = count * price;
                    Console.WriteLine(sum);
                }
            }
            else if (product == "peanuts")
            {
                if (city == "Sofia")
                {
                    price = 1.60;
                    sum = count * price;
                    Console.WriteLine(sum);
                }
                else if (city == "Plovdiv")
                {
                    price = 1.50;
                    sum = count * price;
                    Console.WriteLine(sum);
                }
                else if (city == "Varna")
                {
                    price = 1.55;
                    sum = count * price;
                    Console.WriteLine(sum);
                }
            }
        }
    }
}