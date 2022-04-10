using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParty
{
    class Program
    {
        static void Main()
        {
            HashSet<string> partyPeople = new HashSet<string>();

            // Add all invited people.

            while (true)
            {
                string reservationNumber = Console.ReadLine();

                if (reservationNumber.ToLower() == "party")
                {
                    break;
                }

                partyPeople.Add(reservationNumber);
            }

            // Remove all people that came to the party.

            while (true)
            {
                string comingPeople = Console.ReadLine();

                if (comingPeople.ToLower() == "end")
                {
                    break;
                }

                partyPeople.Remove(comingPeople);
            }

            // Extract vip invitations

            HashSet<string> vipPeople = new HashSet<string>();

            foreach (var person in partyPeople)
            {
                char firstSymbol = person[0];

                if ((int)firstSymbol >= 48 && (int)firstSymbol <= 57)
                {
                    vipPeople.Add(person);
                }
            }

            // Remove vips from common list

            foreach (var vip in vipPeople)
            {
                partyPeople.Remove(vip);
            }

            // Print result (people who didn't came to the party and their count)
            // Print VIPs first

            Console.WriteLine(partyPeople.Count + vipPeople.Count);
            foreach (var vip in vipPeople)
            {
                Console.WriteLine(vip);
            }
            foreach (var person in partyPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}
