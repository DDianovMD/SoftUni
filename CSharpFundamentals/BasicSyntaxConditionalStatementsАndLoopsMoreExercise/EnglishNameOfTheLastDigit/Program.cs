using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {

            string number = Console.ReadLine();

            if (number[number.Length - 1] == '0')
            {
                Console.WriteLine("zero");
            }
            else if (number[number.Length - 1] == '1')
            {
                Console.WriteLine("one");
            }
            else if (number[number.Length - 1] == '2')
            {
                Console.WriteLine("two");
            }
            else if (number[number.Length - 1] == '3')
            {
                Console.WriteLine("three");
            }
            else if (number[number.Length - 1] == '4')
            {
                Console.WriteLine("four");
            }
            else if (number[number.Length - 1] == '5')
            {
                Console.WriteLine("five");
            }
            else if (number[number.Length - 1] == '6')
            {
                Console.WriteLine("six");
            }
            else if (number[number.Length - 1] == '7')
            {
                Console.WriteLine("seven");
            }
            else if (number[number.Length - 1] == '8')
            {
                Console.WriteLine("eight");
            }
            else if (number[number.Length - 1] == '9')
            {
                Console.WriteLine("nine");
            }
        }
    }
}