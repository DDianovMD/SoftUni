using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < numbers; i++)
            {
                int messageCode = int.Parse(Console.ReadLine());
                if (messageCode == 2)
                {
                    message += 'a';
                }
                else if (messageCode == 22)
                {
                    message += 'b';
                }
                else if (messageCode == 222)
                {
                    message += 'c';
                }
                else if (messageCode == 3)
                {
                    message += 'd';
                }
                else if (messageCode == 33)
                {
                    message += 'e';
                }
                else if (messageCode == 333)
                {
                    message += 'f';
                }
                else if (messageCode == 4)
                {
                    message += 'g';
                }
                else if (messageCode == 44)
                {
                    message += 'h';
                }
                else if (messageCode == 444)
                {
                    message += 'i';
                }
                else if (messageCode == 5)
                {
                    message += 'j';
                }
                else if (messageCode == 55)
                {
                    message += 'k';
                }
                else if (messageCode == 555)
                {
                    message += 'l';
                }
                else if (messageCode == 6)
                {
                    message += 'm';
                }
                else if (messageCode == 66)
                {
                    message += 'n';
                }
                else if (messageCode == 666)
                {
                    message += 'o';
                }
                else if (messageCode == 7)
                {
                    message += 'p';
                }
                else if (messageCode == 77)
                {
                    message += 'q';
                }
                else if (messageCode == 777)
                {
                    message += 'r';
                }
                else if (messageCode == 7777)
                {
                    message += 's';
                }
                else if (messageCode == 8)
                {
                    message += 't';
                }
                else if (messageCode == 88)
                {
                    message += 'u';
                }
                else if (messageCode == 888)
                {
                    message += 'v';
                }
                else if (messageCode == 9)
                {
                    message += 'w';
                }
                else if (messageCode == 99)
                {
                    message += 'x';
                }
                else if (messageCode == 999)
                {
                    message += 'y';
                }
                else if (messageCode == 9999)
                {
                    message += 'z';
                }
                else if (messageCode == 0)
                {
                    message += " ";
                }
            }
            Console.WriteLine(message);
        }
    }
}