using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ivanChosMoney = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            decimal lightsabersPrice = decimal.Parse(Console.ReadLine());
            decimal robesPrice = decimal.Parse(Console.ReadLine());
            decimal beltsPrice = decimal.Parse(Console.ReadLine());

            int freeBelts = studentsCount / 6;
            decimal moneyNeeded = (lightsabersPrice * (Math.Ceiling(studentsCount + (studentsCount * 0.1m)))) + (robesPrice * studentsCount) + beltsPrice * (studentsCount - freeBelts);

            if (moneyNeeded <= ivanChosMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(ivanChosMoney - moneyNeeded):F2}lv more.");
            }
        }
    }
}