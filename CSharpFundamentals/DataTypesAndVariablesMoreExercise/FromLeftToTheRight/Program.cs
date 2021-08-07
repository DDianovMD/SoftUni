using System;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();
                string leftNumber = input.Substring(0, input.IndexOf(" "));
                string rightNumber = input.Substring(input.IndexOf(" ") + 1);

                long firstNumber = long.Parse(leftNumber);
                long secondNumber = long.Parse(rightNumber);

                if (firstNumber > secondNumber)
                {
                    if (leftNumber[0] != '-')
                    {
                        for (int j = 0; j < leftNumber.Length; j++)
                        {
                            sum += int.Parse(leftNumber[j].ToString());
                        }
                    }
                    else
                    {
                        for (int j = 1; j < leftNumber.Length; j++)
                        {
                            sum += int.Parse(leftNumber[j].ToString());
                        }
                    }
                }
                else if (firstNumber < secondNumber)
                {
                    if (rightNumber[0] != '-')
                    {
                        for (int j = 0; j < rightNumber.Length; j++)
                        {
                            sum += int.Parse(rightNumber[j].ToString());
                        }
                    }
                    else
                    {
                        for (int j = 1; j < rightNumber.Length; j++)
                        {
                            sum += int.Parse(rightNumber[j].ToString());
                        }
                    }
                }
                else if (firstNumber == secondNumber)
                {
                    if (leftNumber[0] != '-')
                    {
                        for (int j = 0; j < leftNumber.Length; j++)
                        {
                            sum += int.Parse(leftNumber[j].ToString());
                        }
                    }
                    else
                    {
                        for (int j = 1; j < leftNumber.Length; j++)
                        {
                            sum += int.Parse(leftNumber[j].ToString());
                        }
                    }
                }

                Console.WriteLine(sum);
                sum = 0;
            }

            // ANOTHER WORKING DECISION

            //for (int i = 0; i < numberOfInputs; i++)
            //{
            //    string input = Console.ReadLine();
            //    string leftNumber = input.Substring(0, input.IndexOf(" "));
            //    string rightNumber = input.Substring(input.IndexOf(" ") + 1);
            //    
            //    if (leftNumber[0] != '-' && rightNumber[0] == '-') // check if first number is positive and second number is negative
            //    {
            //        for (int j = 0; j < leftNumber.Length; j++)
            //        {
            //            sum += int.Parse(leftNumber[j].ToString());
            //        }
            //    }
            //    else if (leftNumber[0] == '-' && rightNumber[0] != '-') // check if first number is negative and second number is positive
            //    {
            //        for (int j = 0; j < rightNumber.Length; j++)
            //        {
            //            sum += int.Parse(rightNumber[j].ToString());
            //        }
            //    }
            //    else if (leftNumber[0] != '-' && rightNumber[0] != '-') // check if both numbers are positive
            //    {
            //        if (leftNumber.Length > rightNumber.Length) // => first number is bigger
            //        {
            //            for (int j = 0; j < leftNumber.Length; j++)
            //            {
            //                sum += int.Parse(leftNumber[i].ToString());
            //            }                        
            //        }
            //        else if (leftNumber.Length < rightNumber.Length) // => second number is bigger
            //        {
            //            for (int j = 0; j < rightNumber.Length; j++)
            //            {
            //                sum += int.Parse(rightNumber[j].ToString());
            //            }
            //        }
            //        else if (leftNumber.Length == rightNumber.Length)
            //        {
            //            for (int j = 0; j < leftNumber.Length; j++)
            //            {
            //                if (leftNumber[j] > rightNumber[j]) // => first number is bigger
            //                {
            //                    for (int k = 0; k < leftNumber.Length; k++)
            //                    {
            //                        sum += int.Parse(leftNumber[k].ToString());
            //                    }
            //                    break;
            //                }
            //                else if (leftNumber[j] < rightNumber[j]) // => second number is bigger
            //                {
            //                    for (int k = 0; k < rightNumber.Length; k++)
            //                    {
            //                        sum += int.Parse(rightNumber[k].ToString());
            //                    }
            //                    break;
            //                }
            //                else if (leftNumber[j] == rightNumber[j] && j == leftNumber.Length - 1) // => both numbers are equal
            //                {
            //                    for (int k = 0; k < leftNumber.Length; k++)
            //                    {
            //                        sum += int.Parse(leftNumber[k].ToString());
            //                    }
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //    else if (leftNumber[0] == '-' && rightNumber[0] == '-') // check if both numbers are negative
            //    {
            //        if (leftNumber.Length < rightNumber.Length) // => first number is bigger
            //        {
            //            for (int j = 1; j < leftNumber.Length; j++)
            //            {
            //                sum += int.Parse(leftNumber[i].ToString());
            //            }
            //        }
            //        else if (leftNumber.Length > rightNumber.Length) // => second number is bigger
            //        {
            //            for (int j = 1; j < rightNumber.Length; j++)
            //            {
            //                sum += int.Parse(rightNumber[j].ToString());
            //            }
            //        }
            //        else if (leftNumber.Length == rightNumber.Length)
            //        {
            //            for (int j = 1; j < leftNumber.Length; j++)
            //            {
            //                if (leftNumber[j] < rightNumber[j]) // => left number is bigger
            //                {
            //                    for (int k = 1; k < leftNumber.Length; k++)
            //                    {
            //                        sum += int.Parse(leftNumber[i].ToString());
            //                    }
            //                    break;
            //                }
            //                else if (leftNumber[j] > rightNumber[j]) // => right number is bigger
            //                {
            //                    for (int k = 1; k < rightNumber.Length; k++)
            //                    {
            //                        sum += int.Parse(rightNumber[k].ToString());
            //                    }
            //                    break;
            //                }
            //                else if (leftNumber[j] == rightNumber[j] && j == leftNumber.Length - 1) // => both numbers are equal
            //                {
            //                    for (int k = 0; k < leftNumber.Length; k++)
            //                    {
            //                        sum += int.Parse(leftNumber[k].ToString());
            //                    }
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //
            //    Console.WriteLine(sum);
            //    sum = 0;
            //}
        }
    }
}