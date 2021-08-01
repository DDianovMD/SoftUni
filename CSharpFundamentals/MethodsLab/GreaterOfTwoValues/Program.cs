using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToUpper();
            if (command == "INT")
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                GetMax(number1, number2);
            }
            else if (command == "CHAR")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
                GetMax(char1, char2);
            }
            else if (command == "STRING")
            {
                string string1 = Console.ReadLine();
                string string2 = Console.ReadLine();
                GetMax(string1, string2);
            }
        }
        static void GetMax(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else if (a < b)
            {
                Console.WriteLine(b);
            }
            else if (a == b)
            {
                Console.WriteLine(a);
            }
        }
        static void GetMax(char char1, char char2)
        {
            int sum1 = (int)char1;
            int sum2 = (int)char2;
            if (sum1 > sum2)
            {
                Console.WriteLine(char1);
            }
            else if (sum1 < sum2)
            {
                Console.WriteLine(char2);
            }
            else if (sum1 == sum2)
            {
                Console.WriteLine(sum1);
            }
        }
        static void GetMax(string string1, string string2)
        {

            for (int i = 0; i < string1.Length; i++)
            {
                if ((int)string1[i] > (int)string2[i])
                {
                    Console.WriteLine(string1);
                    break;
                }
                else if ((int)string1[i] < (int)string2[i])
                {
                    Console.WriteLine(string2);
                    break;
                }
            }

        }
    }
}
