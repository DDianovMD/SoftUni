using System;

namespace GenericBoxOfString
{
    public class Program
    {
        public static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            string command = string.Empty;

            for (int i = 0; i < numberOfInputs; i++)
            {
                command = Console.ReadLine();

                Box<string> currentBox = new Box<string>(command);
                Console.WriteLine(currentBox.ToString());
            }
        }
    }
}
