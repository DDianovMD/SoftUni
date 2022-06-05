using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int iD, string firstName, string lastName, decimal salary)
            : base(iD, firstName, lastName, salary)
        {
            Privates = new List<Private>();
        }

        public List<Private> Privates { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {ID} Salary: {Salary:F2}");
            sb.AppendLine("Privates:");

            foreach (var soldier in Privates)
            {
                sb.AppendLine($"  {soldier}");
            }

            return sb.ToString().Trim();
        }
    }
}
