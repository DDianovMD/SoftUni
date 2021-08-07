using System;

namespace RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code to be refactored.

            // int ___Do___ = int.Parse(Console.ReadLine());
            // for (int takoa = 2; takoa <= ___Do___; takoa++)
            // {
            //     bool takovalie = true;
            //     for (int cepitel = 2; cepitel < takoa; cepitel++)
            //     {
            //         if (takoa % cepitel == 0)
            //         {
            //             takovalie = false;
            //             break;
            //         }
            //     }
            //     Console.WriteLine("{0} -> {1}", takoa, takovalie);
            // }
            
            // Task decision

            int givenRange = int.Parse(Console.ReadLine());
            for (int numbersInRange = 2; numbersInRange <= givenRange; numbersInRange++) // from 2...givenRange
            {
                bool isPrime = true;

                for (int dividingNumber = 2; dividingNumber < numbersInRange; dividingNumber++)
                {
                    if (numbersInRange % dividingNumber == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                string primeOrNot = string.Empty;

                if (isPrime)
                {
                    primeOrNot = "true";
                }
                else
                {
                    primeOrNot = "false";
                }
                Console.WriteLine("{0} -> {1}", numbersInRange, primeOrNot);
            }

        }
    }
}
