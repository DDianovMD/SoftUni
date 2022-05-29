using System;

namespace Telephony
{
    public class Program
    {
        public static void Main()
        {
            Smartphone smartPhone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            string[] phones = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var phone in phones)
            {
                if (phone.Length == 7)
                {
                    Console.WriteLine(stationaryPhone.Call(phone)); 
                }
                else
                {
                    Console.WriteLine(smartPhone.Call(phone));
                }
            }

            foreach (var url in urls)
            {
                Console.WriteLine(smartPhone.Browse(url));
            }
        }
    }
}
