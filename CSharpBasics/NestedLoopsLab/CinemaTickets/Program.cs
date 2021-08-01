using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building

{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            double studentTickets = 0;
            double standardTickets = 0;
            double kidTickets = 0;
            double studentTickets1 = 0;
            double standardTickets1 = 0;
            double kidTickets1 = 0;
            double allTicketsForMovie = 0;
            double allTickets = 0;

            while (flag)
            {
                string movieName = Console.ReadLine();
                if (movieName == "Finish")
                {
                    flag = false;
                    break;
                }

                int freeSpace = int.Parse(Console.ReadLine());
                int freeSpaceCounter = freeSpace;

                while (freeSpaceCounter > 0)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "student")
                    {
                        studentTickets += 1;
                        studentTickets1 += 1;
                        allTickets += 1;
                        freeSpaceCounter -= 1;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets += 1;
                        standardTickets1 += 1;
                        allTickets += 1;
                        freeSpaceCounter -= 1;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTickets += 1;
                        kidTickets1 += 1;
                        allTickets += 1;
                        freeSpaceCounter -= 1;
                    }
                    if (ticketType == "End" || freeSpaceCounter == 0)
                    {
                        allTicketsForMovie = studentTickets + standardTickets + kidTickets;
                        double percent = (allTicketsForMovie / freeSpace) * 100;
                        Console.WriteLine($"{movieName} - {percent:F2}% full.");
                        studentTickets = 0;
                        standardTickets = 0;
                        kidTickets = 0;
                        break;
                    }
                }
            }
            Console.WriteLine($"Total tickets: {allTickets}");
            double studentPercentage = (studentTickets1 / allTickets) * 100;
            Console.WriteLine($"{studentPercentage:F2}% student tickets.");
            double standardPercentage = (standardTickets1 / allTickets) * 100;
            Console.WriteLine($"{standardPercentage:F2}% standard tickets.");
            double kidPercentage = (kidTickets1 / allTickets) * 100;
            Console.WriteLine($"{kidPercentage:F2}% kids tickets.");
        }
    }
}