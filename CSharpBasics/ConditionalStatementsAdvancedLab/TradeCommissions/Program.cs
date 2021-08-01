using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCommissions
{
    class Program
    {
        public static void Main()
        {
            string city = Console.ReadLine();
            double sellings = double.Parse(Console.ReadLine());
            double commission;

            switch (city)
            {
                case "Sofia":
                    if (sellings >= 0 && sellings <= 500)
                    {
                        commission = sellings * 0.05;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (sellings > 500 && sellings <= 1000)
                    {
                        commission = sellings * 0.07;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (sellings > 1000 && sellings <= 10000)
                    {
                        commission = sellings * 0.08;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (sellings > 10000)
                    {
                        commission = sellings * 0.12;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (sellings >= 0 && sellings <= 500)
                    {
                        commission = sellings * 0.045;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (sellings > 500 && sellings <= 1000)
                    {
                        commission = sellings * 0.075;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (sellings > 1000 && sellings <= 10000)
                    {
                        commission = sellings * 0.10;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (sellings > 10000)
                    {
                        commission = sellings * 0.13;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (sellings >= 0 && sellings <= 500)
                    {
                        commission = sellings * 0.055;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (sellings > 500 && sellings <= 1000)
                    {
                        commission = sellings * 0.08;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (sellings > 1000 && sellings <= 10000)
                    {
                        commission = sellings * 0.12;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else if (sellings > 10000)
                    {
                        commission = sellings * 0.145;
                        Console.WriteLine("{0:F2}", commission);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}