using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum

{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum += num;
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum += num;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else if (leftSum > rightSum)
            {
                int a = leftSum - rightSum;
                Console.WriteLine($"No, diff = {a}");
            }
            else if (leftSum < rightSum)
            {
                int a = rightSum - leftSum;
                Console.WriteLine($"No, diff = {a}");
            }
        }
    }
}