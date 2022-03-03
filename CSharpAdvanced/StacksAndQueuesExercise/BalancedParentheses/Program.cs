using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Stack<char> openParenthesis = new Stack<char>();
            bool isBalanced = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    openParenthesis.Push(input[i]);
                }
                else
                {
                    if (openParenthesis.Count > 0)
                    {
                        if (openParenthesis.Peek() == '(' && input[i] == ')')
                        {
                            isBalanced = true;
                            openParenthesis.Pop();
                        }
                        else if (openParenthesis.Peek() == '[' && input[i] == ']')
                        {
                            isBalanced = true;
                            openParenthesis.Pop();
                        }
                        else if (openParenthesis.Peek() == '{' && input[i] == '}')
                        {
                            isBalanced = true;
                            openParenthesis.Pop();
                        }
                        else
                        {
                            isBalanced = false;
                        }
                    }
                    else
                    {
                        isBalanced = false;                        
                    }
                }

                if (isBalanced == false)
                {
                    Console.WriteLine("NO");
                    break;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
