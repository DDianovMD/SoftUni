using System;
using System.Collections.Generic;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiply big numbers without using BigInteger!
            // :(
            // Challenge accepted!

            string bigNumber = Console.ReadLine(); // receive big int as string
            int singleDigitMultiplier = int.Parse(Console.ReadLine()); // receive multiplier

            int remainder = 0; // needed variable for program logic
            int temporaryResult = 0; // needed variable for program logic

            int[] bigNumberAsArray = new int[bigNumber.Length];  

            for (int i = 0; i < bigNumber.Length; i++) // split received big int into single int numbers in array
            {
                bigNumberAsArray[i] = int.Parse(bigNumber[i].ToString());
            }

            if (singleDigitMultiplier != 0) // if user multiplying with number != 0
            {
                List<int> result = new List<int>(); // creating list for result, because we don't know it's length and we can't use array

                for (int i = bigNumberAsArray.Length - 1; i >= 0; i--) // multiply each number with the multiplyer one by one (like doing it with pen on paper) and add the result in List<int>
                {
                    temporaryResult = bigNumberAsArray[i] * singleDigitMultiplier;

                    if (temporaryResult >= 10 && i == bigNumberAsArray.Length - 1)
                    {
                        remainder = temporaryResult / 10;
                        result.Add(temporaryResult % 10);
                    }
                    else if (temporaryResult < 10 && i == bigNumberAsArray.Length - 1)
                    {
                        result.Add(temporaryResult);
                    }
                    else if (temporaryResult >= 10 && i != bigNumberAsArray.Length - 1 && i != 0)
                    {
                        if (remainder == 0)
                        {
                            remainder = temporaryResult / 10;
                            result.Add(temporaryResult % 10);
                        }
                        else
                        {
                            result.Add((temporaryResult + remainder) % 10);
                            remainder = (temporaryResult + remainder) / 10;
                        }
                    }
                    else if (temporaryResult < 10 && i != bigNumberAsArray.Length - 1 && i != 0)
                    {
                        if (remainder == 0)
                        {
                            remainder = temporaryResult / 10;
                            result.Add(temporaryResult % 10);
                        }
                        else
                        {
                            result.Add((temporaryResult + remainder) % 10);
                            remainder = (temporaryResult + remainder) / 10;
                        }
                    }
                    else if (i == 0)
                    {
                        result.Add(temporaryResult + remainder);
                    }
                }

                result.Reverse(); // reverse the list to get the real result

                for (int i = 0; i < result.Count; i++) // print each number concatenated as the final result (can be done with foreach cycle aswell)
                {
                    Console.Write(result[i]);
                }
            }
            else // if user multiply by 0.
            {
                Console.WriteLine(0); // print result
            }
        }
    }
}
