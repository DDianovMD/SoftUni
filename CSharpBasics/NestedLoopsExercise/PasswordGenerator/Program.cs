using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers

{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            string alphabet = "abcdefghijklmopqrstuvwxyz";

            for (int i = 1; i < number1; i++)
            {

                for (int j = 1; j < number1; j++)
                {

                    for (int k = 0; k < number2; k++)
                    {

                        for (int l = 0; l < number2; l++)
                        {

                            for (int m = 1; m <= number1; m++)
                            {
                                if (m <= i || m <= j)
                                {
                                    if (i >= j)
                                    {
                                        m = i + 1;
                                        Console.Write($"{i}{j}{alphabet[k]}{alphabet[l]}{m} ");
                                    }
                                    else
                                    {
                                        m = j + 1;
                                        Console.Write($"{i}{j}{alphabet[k]}{alphabet[l]}{m} ");
                                    }
                                }
                                else if (m > i && m > j)
                                {
                                    Console.Write($"{i}{j}{alphabet[k]}{alphabet[l]}{m} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}