using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine().ToUpper();
            string numberPattern = @"\d+";
            string wordPattern = @"\D+";

            var words = Regex.Matches(userInput, wordPattern);
            var numbers = Regex.Matches(userInput, numberPattern);

            StringBuilder rageString = new StringBuilder();  
            
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = int.Parse(numbers[i].ToString()); j > 0; j--)
                {
                    rageString.Append(words[i]);
                }
            }

            int uniqueSymbolsCount = rageString.ToString().Distinct().Count();

            // Print output
            Console.WriteLine($"Unique symbols used: {uniqueSymbolsCount}");
            Console.WriteLine(rageString);
        }
    }
}
