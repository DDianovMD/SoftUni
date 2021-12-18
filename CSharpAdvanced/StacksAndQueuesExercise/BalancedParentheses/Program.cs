using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> leftSide = new Stack<string>();
            Queue<string> rightSide = new Queue<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "(" || input[i].ToString() == "{" || input[i].ToString() == "[")
                {
                    leftSide.Push(input[i].ToString());
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == ")" || input[i].ToString() == "}" || input[i].ToString() == "]")
                {
                    rightSide.Enqueue(input[i].ToString());
                }
            }

            bool isBalanced = true;
            
            while (isBalanced && leftSide.Count > 0 && rightSide.Count > 0)
            {
                if (leftSide.Peek() == "(" && rightSide.Peek() == ")")
                {
                    leftSide.Pop();
                    rightSide.Dequeue();
                }
                else if (leftSide.Peek() == "[" && rightSide.Peek() == "]")
                {
                    leftSide.Pop();
                    rightSide.Dequeue();
                }
                else if (leftSide.Peek() == "{" && rightSide.Peek() == "}")
                {
                    leftSide.Pop();
                    rightSide.Dequeue();
                }
                else
                {
                    isBalanced = false;                    
                }
            }

            if (isBalanced && leftSide.Count == 0 && rightSide.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
