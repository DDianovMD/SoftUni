using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            decimal totalSpend = 0;

            while (game != "Game Time")
            {
                
                if (game == "OutFall 4")
                {
                    if (money >= 39.99m)
                    {
                        money -= 39.99m;
                        totalSpend += 39.99m;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "CS: OG")
                {
                    if (money >= 15.99m)
                    {
                        money -= 15.99m;
                        totalSpend += 15.99m;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    if (money >= 19.99m)
                    {
                        money -= 19.99m;
                        totalSpend += 19.99m;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "Honored 2")
                {
                    if (money >= 59.99m)
                    {
                        money -= 59.99m;
                        totalSpend += 59.99m;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "RoverWatch")
                {
                    if (money >= 29.99m)
                    {
                        money -= 29.99m;
                        totalSpend += 29.99m;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (money >= 39.99m)
                    {
                        money -= 39.99m;
                        totalSpend += 39.99m;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }


                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    Environment.Exit(0);
                }

                game = Console.ReadLine();

            }
            Console.WriteLine($"Total spent: ${totalSpend:F2}. Remaining: ${money:F2}");
        }
    }
}