using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double score = double.Parse(Console.ReadLine());

            int judges = int.Parse(Console.ReadLine());

            for (int i = 0; i < judges; i++)
            {
                string currentJudge = Console.ReadLine();
                double judgeGrade = double.Parse(Console.ReadLine());

                score += currentJudge.Length * judgeGrade / 2.0;

                if (score > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {score:F1}!");
                    break;
                }

                if (i == judges - 1 && score < 1250.5)
                {
                    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - score:F1} more!");
                }
            }
        }
    }
}
