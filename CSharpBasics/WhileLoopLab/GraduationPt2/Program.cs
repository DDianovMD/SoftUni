using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int schoolClass = 1;
            double grades = 0.00;

            while (true)
            {
                double score = double.Parse(Console.ReadLine());
                if (score >= 4.00)
                {
                    schoolClass += 1;
                    grades += score;
                }
                else if (score < 4.00)
                {
                    score = double.Parse(Console.ReadLine());
                    if (score < 4.00)
                    {
                        Console.WriteLine($"{name} has been excluded at {schoolClass} grade");
                        break;
                    }
                }
                if (schoolClass == 13)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {(grades / 12):F2}");
                    break;
                }
            }
        }
    }
}