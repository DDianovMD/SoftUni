using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        public static void Main()
        {
            string fruit = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double price;
            double sum;

            if (fruit == "banana")
            {
                switch (weekDay)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 2.50;
                        sum = price * count;
                        Console.WriteLine("{0:F2}", sum);
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 2.70;
                        sum = price * count;
                        Console.WriteLine("{0:F2}", sum);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "apple")
            {
                switch (weekDay)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 1.20;
                        sum = price * count;
                        Console.WriteLine("{0:F2}", sum);
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 1.25;
                        sum = price * count;
                        Console.WriteLine("{0:F2}", sum);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "orange")
            {
                switch (weekDay)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 0.85;
                        sum = price * count;
                        Console.WriteLine("{0:F2}", sum);
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 0.90;
                        sum = price * count;
                        Console.WriteLine("{0:F2}", sum);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "grapefruit")
            {
                switch (weekDay)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 1.45;
                        sum = price * count;
                        Console.WriteLine("{0:F2}", sum);
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 1.60;
                        sum = price * count;
                        Console.WriteLine("{0:F2}", sum);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "kiwi")
            {
                switch (weekDay)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 2.70;
                        sum = price * count;
                        Console.WriteLine("{0:F2}", sum);
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 3.00;
                        sum = price * count;
                        Console.WriteLine("{0:F2}", sum);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "pineapple")
            {
                switch (weekDay)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 5.50;
                        sum = price * count;
                        Console.WriteLine("{0:F2}", sum);
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 5.60;
                        sum = price * count;
                        Console.WriteLine("{0:F2}", sum);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "grapes")
            {
                switch (weekDay)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 3.85;
                        sum = price * count;
                        Console.WriteLine("{0:F2}", sum);
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 4.20;
                        sum = price * count;
                        Console.WriteLine("{0:F2}", sum);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}