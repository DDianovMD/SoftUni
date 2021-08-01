using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyIncome = double.Parse(Console.ReadLine());
            double score = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialStipendy = minSalary * 0.35;
            socialStipendy = Math.Floor(socialStipendy);
            double excellentScoreStipendy = score * 25;
            excellentScoreStipendy = Math.Floor(excellentScoreStipendy);

            if (moneyIncome >= minSalary) // няма право за социална стипендия
            {
                if (score >= 5.50) // има право за стипендия за отличен успех
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", excellentScoreStipendy);
                }
                if (score < 5.50) // няма право за стипендия за отличен успех
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            if (moneyIncome < minSalary) // има право за социална стипендия
            {
                if (score >= 5.50) // има право за стипендия за отличен успех
                {
                    if (socialStipendy < excellentScoreStipendy) // ако парите за отличен успех са повече - получава стипендия за отличен успех
                    {
                        Console.WriteLine("You get a scholarship for excellent results {0} BGN", excellentScoreStipendy);
                    }
                    else if (socialStipendy == excellentScoreStipendy) // ако парите от двете стипендии са равни -> получава за отличен успех
                    {
                        Console.WriteLine("You get a scholarship for excellent results {0} BGN", excellentScoreStipendy);
                    }
                    else // ако парите за отличен успех са по-малко - получава социална стипендия
                    {
                        Console.WriteLine("You get a Social scholarship {0} BGN", socialStipendy);
                    }
                }
                if (score > 4.50 && score < 5.50) // няма успех за стипендия за отличен, но има за социална -> получава социална стипендия
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", socialStipendy);
                }
                if (score <= 4.50) // няма успех за социална стипендия и правото му да получи отпада => не получава стипендия
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
        }
    }
}