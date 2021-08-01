using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int leftsum = 0;
            int rightsum = 0;

            bool isTrue = true;

            while (isTrue)
            {
                if (inputArray.Length == 1)
                {
                    Console.WriteLine(0);
                    isTrue = false;
                    break;
                }
                else
                {
                    for (int i = 0; i < inputArray.Length; i++)
                    {

                        for (int j = 0; j < i; j++)
                        {
                            leftsum += inputArray[j];
                        }

                        if (i != inputArray.Length - 1)
                        {
                            for (int k = i + 1; k < inputArray.Length; k++)
                            {
                                rightsum += inputArray[k];
                            }
                        }

                        if (leftsum == rightsum)
                        {
                            Console.WriteLine(i);
                            isTrue = false;
                            break;
                        }
                        else if (leftsum != rightsum && i != inputArray.Length - 1)
                        {
                            leftsum = 0;
                            rightsum = 0;
                        }
                        else if (leftsum != rightsum && i == inputArray.Length - 1)
                        {
                            Console.WriteLine("no");
                            isTrue = false;
                            break;
                        }
                    }
                }
            }
        }
    }
}