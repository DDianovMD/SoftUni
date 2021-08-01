using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isntEnd = true;

            while (isntEnd)
            {
                string input = Console.ReadLine();
                if (input.ToUpper() == "END")
                {
                    isntEnd = false;
                    break;
                }
                int integerType = 0;
                float floatingPointType = 0;
                char charType = ' ';
                bool boolType;

                if (int.TryParse(input, out integerType))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out floatingPointType))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out charType))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out boolType))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}