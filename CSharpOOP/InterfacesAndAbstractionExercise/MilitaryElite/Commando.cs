using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Commando : Private, ISpecialisedSoldier
    {
        public Commando(int iD, string firstName, string lastName, decimal salary, string corp, List<Mission> missions)
            : base(iD, firstName, lastName, salary)
        {
            Corp = corp;
            Missions = new List<Mission>();

            foreach (var mission in missions)
            {
                if (mission.State == "inProgress" || mission.State == "Finished")
                {
                    Missions.Add(mission);
                }
            }

        }

        public List<Mission> Missions { get; private set; }
        public string Corp { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {ID} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {Corp}");
            sb.AppendLine($"Missions:");

            foreach (var mission in Missions)
            {
                sb.AppendLine($"  Code Name: {mission.CodeName} State: {mission.State}");
            }

            return sb.ToString().Trim();
        }
    }
}
