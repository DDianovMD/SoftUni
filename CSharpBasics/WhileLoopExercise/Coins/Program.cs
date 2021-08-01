using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int coinsCounter = 0;
            if (change == 0)
            {
                Console.WriteLine(coinsCounter);
                Environment.Exit(0);
            }

            while (change != 0)
            {

                change = change - 2;
                coinsCounter += 1;
                if (change < 0)
                {
                    change = change + 2;
                    if (coinsCounter > 0)
                    {
                        coinsCounter -= 1;
                    }
                    while (change > 0)
                    {
                        change = change - 1;
                        coinsCounter += 1;
                        if (change < 0)
                        {
                            change = change + 1;
                            if (coinsCounter > 0)
                            {
                                coinsCounter -= 1;
                            }
                            while (change > 0)
                            {
                                change = change - 0.5m;
                                coinsCounter += 1;
                                if (change < 0)
                                {
                                    change = change + 0.5m;
                                    if (coinsCounter > 0)
                                    {
                                        coinsCounter -= 1;
                                    }
                                    while (change > 0)
                                    {
                                        change = change - 0.2m;
                                        coinsCounter += 1;
                                        if (change < 0)
                                        {
                                            change = change + 0.2m;
                                            if (coinsCounter > 0)
                                            {
                                                coinsCounter -= 1;
                                            }
                                            while (change > 0)
                                            {
                                                change = change - 0.1m;
                                                coinsCounter += 1;
                                                if (change < 0)
                                                {
                                                    change = change + 0.1m;
                                                    if (coinsCounter > 0)
                                                    {
                                                        coinsCounter -= 1;
                                                    }
                                                    while (change > 0)
                                                    {
                                                        change = change - 0.05m;
                                                        coinsCounter += 1;
                                                        if (change < 0)
                                                        {
                                                            change = change + 0.05m;
                                                            if (coinsCounter > 0)
                                                            {
                                                                coinsCounter -= 1;
                                                            }
                                                            while (change > 0)
                                                            {
                                                                change = change - 0.02m;
                                                                coinsCounter += 1;
                                                                if (change < 0)
                                                                {
                                                                    change = change + 0.02m;
                                                                    if (coinsCounter > 0)
                                                                    {
                                                                        coinsCounter -= 1;
                                                                    }
                                                                    while (change > 0)
                                                                    {
                                                                        change = change - 0.01m;
                                                                        coinsCounter += 1;
                                                                        if (change == 0)
                                                                        {
                                                                            Console.WriteLine(coinsCounter);
                                                                            Environment.Exit(0);
                                                                        }
                                                                    }
                                                                }
                                                                else if (change == 0)
                                                                {
                                                                    Console.WriteLine(coinsCounter);
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (change == 0)
                                                        {
                                                            Console.WriteLine(coinsCounter);
                                                            break;
                                                        }
                                                    }
                                                }
                                                else if (change == 0)
                                                {
                                                    Console.WriteLine(coinsCounter);
                                                    break;
                                                }
                                            }
                                        }
                                        else if (change == 0)
                                        {
                                            Console.WriteLine(coinsCounter);
                                            break;
                                        }
                                    }
                                }
                                else if (change == 0)
                                {
                                    Console.WriteLine(coinsCounter);
                                    break;
                                }
                            }
                        }
                        else if (change == 0)
                        {
                            Console.WriteLine(coinsCounter);
                            break;
                        }
                    }
                }
                else if (change == 0)
                {
                    Console.WriteLine(coinsCounter);
                    break;
                }

            }
        }
    }
}