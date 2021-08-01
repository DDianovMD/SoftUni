using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            if (country == "England" || country == "USA")
            {
                Console.WriteLine("English");
            }
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}