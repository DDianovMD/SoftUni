using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTheTrainers

{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            int presentationsCounter = 0;
            decimal allScores = 0;

            bool isTrue = true;

            while (isTrue)
            {

                string presentationName = Console.ReadLine();

                decimal scoreSum = 0;


                if (presentationName == "Finish")
                {
                    isTrue = false;
                    Console.WriteLine($"Student's final assessment is {(allScores / (jury * presentationsCounter)):F2}.");
                    break;
                }
                presentationsCounter += 1;

                for (int i = 0; i < jury; i++)
                {
                    decimal score = decimal.Parse(Console.ReadLine());
                    scoreSum += score;
                    allScores += score;
                }
                Console.WriteLine($"{presentationName} - {(scoreSum / jury):F2}.");
            }
        }
    }
}
