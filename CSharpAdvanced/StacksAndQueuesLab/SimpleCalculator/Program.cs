using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] equation = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Stack<int> result = new Stack<int>();

            for (int i = 0; i < int.Parse(equation[0]); i++)
            {
                result.Push(1);
            }

            for (int i = 0; i < equation.Length; i++)
            {
                if (equation[i] == "+")
                {
                    for (int j = 0; j < int.Parse(equation[i + 1]); j++)
                    {
                        result.Push(1);
                    }
                }
                else if (equation[i] == "-")
                {
                    for (int k = 0; k < int.Parse(equation[i + 1]); k++)
                    {
                        result.Pop();
                    }
                }
            }

            Console.WriteLine(result.Count());
        }
    }
}
