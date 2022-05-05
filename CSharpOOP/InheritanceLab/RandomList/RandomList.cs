using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random randomInt = new Random();

            // Generating random index inside the bounds of the list
            int index = randomInt.Next(0, this.Count - 1);

            // Save element on that index and remove it from the list
            string randomString = this[index];
            this.RemoveAt(index);

            // Return removed element
            return randomString;
        }
    }
}
