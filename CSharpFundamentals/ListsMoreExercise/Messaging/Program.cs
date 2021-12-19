using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<char> secretMessage = Console.ReadLine()
                .ToList();

            StringBuilder decodedMessage = new StringBuilder();

            foreach (var number in numbers)
            {
                int sum = 0;

                for (int i = 0; i < number.Length; i++)
                {
                    sum += int.Parse(number[i].ToString());
                }

                if (sum <= secretMessage.Count)
                {
                    decodedMessage.Append(secretMessage[sum]);
                    secretMessage.RemoveAt(sum);
                }
                else
                {
                    while (sum > secretMessage.Count)
                    {
                        sum -= secretMessage.Count;
                    }

                    decodedMessage.Append(secretMessage[sum]);
                    secretMessage.RemoveAt(sum);
                }
            }

            Console.WriteLine(decodedMessage);

        }
    }
}
