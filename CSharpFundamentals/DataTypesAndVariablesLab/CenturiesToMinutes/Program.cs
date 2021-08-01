using System;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {

            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            decimal days = years * 365.2422m;
            int hours = (int)days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centuries } centuries = {years} years = {(int)days} days = {hours} hours = {minutes} minutes");

        }
    }
}