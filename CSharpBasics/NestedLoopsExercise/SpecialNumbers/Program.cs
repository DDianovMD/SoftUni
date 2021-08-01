using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers

{
    class Program
    {
        static void Main(string[] args)
        {
            int usersNumber = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                string currentNumber = i.ToString();

                int number1 = int.Parse(currentNumber[0].ToString());
                int number2 = int.Parse(currentNumber[1].ToString());
                int number3 = int.Parse(currentNumber[2].ToString());
                int number4 = int.Parse(currentNumber[3].ToString());

                if (number1 != 0 && number2 != 0 && number3 != 0 && number4 != 0)
                {
                    if (usersNumber % number1 == 0 && usersNumber % number2 == 0 && usersNumber % number3 == 0 && usersNumber % number4 == 0)
                    {
                        Console.Write($"{currentNumber} ");
                    }
                }
            }

        }
    }
}