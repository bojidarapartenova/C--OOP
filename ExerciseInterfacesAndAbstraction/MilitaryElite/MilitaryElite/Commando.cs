using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Classes
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            Missions=new List<IMission>();
        }

        public ICollection<IMission> Missions { get; private set; }

        public void AddMission(IMission mission)
        {
            Missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            result.AppendLine($"Corps: {Corps}");
            result.AppendLine("Missions:");

            foreach(var mission in Missions)
            {
                result.AppendLine($"  {mission.PrintMission()}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
