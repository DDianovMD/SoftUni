using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : Private, ISpecialisedSoldier
    {
        public Engineer(int iD, string firstName, string lastName, decimal salary, string corp, List<Repair> repairs)
               : base(iD, firstName, lastName, salary)
        {
            Corp = corp;
            Repairs = new List<Repair>();

            foreach (var repair in repairs)
            {
                Repairs.Add(repair);
            }
        }

        public string Corp { get; set; }
        public List<Repair> Repairs { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {ID} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {Corp}");
            sb.AppendLine($"Repairs:");

            foreach (var repair in Repairs)
            {
                sb.AppendLine($"  Part Name: {repair.PartName} Hours Worked: {repair.WorkedHours}");
            }

            return sb.ToString().Trim();
        }
    }
}
