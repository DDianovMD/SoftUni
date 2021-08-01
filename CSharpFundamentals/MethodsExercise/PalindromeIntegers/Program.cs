using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToUpper();
            while (command != "END")
            {
                bool isTrue = false;
                int num;
                isTrue = int.TryParse(command, out num);
                if (isTrue)
                {
                    bool isFalse = false;
                    for (int i = 0; i < command.ToString().Length / 2; i++)
                    {
                        if (command.ToString()[i] != command.ToString()[command.ToString().Length - 1 - i])
                        {
                            Console.WriteLine("false");
                            isFalse = true;
                            break;
                        }
                        break;
                    }
                    if (isFalse != true)
                    {
                        Console.WriteLine("true");
                    }                  
                }
                else
                {
                    command = Console.ReadLine().ToUpper();
                }

                command = Console.ReadLine().ToUpper();
            }
        }
    }
}
