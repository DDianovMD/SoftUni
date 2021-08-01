using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            decimal sum = 0;
            while (command != "Start")
            {
                decimal coins = 0;
                decimal.TryParse(command, out coins);

                if (coins == 0.1m || coins == 0.2m || coins == 0.5m || coins == 1m || coins == 5m)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                command = Console.ReadLine();
            }

            string product = string.Empty;

            while (product != "End")
            {
                product = Console.ReadLine();

                if (product == "Nuts")
                {
                    if (sum >= 2m)
                    {
                        sum -= 2m;
                        Console.WriteLine($"Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    
                }
                else if (product == "Water")
                {
                    if (sum >= 0.7m)
                    {
                        sum -= 0.7m;
                        Console.WriteLine($"Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (sum >= 1.5m)
                    {
                        sum -= 1.5m;
                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (sum >= 0.8m)
                    {
                        sum -= 0.8m;
                        Console.WriteLine($"Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }                  
                }
                else if (product == "Coke")
                {
                    if (sum >= 1.0m)
                    {
                        sum -= 1m;
                        Console.WriteLine($"Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }                    
                }
                else
                {
                    if (product != "End")
                    {
                        Console.WriteLine("Invalid product");
                    }                    
                }                
            }
            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}