using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumsEvenOddPosition

{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int evenSum;
            int oddSum;

            for (int i = number1; i <= number2; i++)
            {
                string a = i.ToString();
                evenSum = int.Parse(a[0].ToString()) + int.Parse(a[2].ToString()) + int.Parse(a[4].ToString());
                oddSum = int.Parse(a[1].ToString()) + int.Parse(a[3].ToString()) + int.Parse(a[5].ToString());

                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}