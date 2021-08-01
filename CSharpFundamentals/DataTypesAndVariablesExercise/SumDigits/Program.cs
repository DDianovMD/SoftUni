using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenNumber = Console.ReadLine();
            int sumOfDigits = 0;

            for (int i = 0; i < givenNumber.Length; i++)
            {
                sumOfDigits += int.Parse(givenNumber[i].ToString());            
            }
            Console.WriteLine(sumOfDigits);
        }
    }
}