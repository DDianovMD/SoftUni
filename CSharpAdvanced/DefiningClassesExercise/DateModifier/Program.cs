using System;

namespace DateModifier
{
    public class Program
    {
        public static void Main()
        {
            string[] dates = new string[2];

            for (int i = 0; i < 2; i++)
            {
                dates[i] = Console.ReadLine();
            }

            Console.WriteLine(DateModifier.CompareDates(dates[0], dates[1]));
            
        }
    }
}
