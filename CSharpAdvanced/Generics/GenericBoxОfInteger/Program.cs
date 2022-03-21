using System;

namespace GenericBoxOfInteger
{
    public class Program
    {
        public static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int command = int.MinValue;

            for (int i = 0; i < numberOfInputs; i++)
            {
                command = int.Parse(Console.ReadLine());

                Box<int> currentBox = new Box<int>(command);
                Console.WriteLine(currentBox.ToString());
            }
        }
    }
}
