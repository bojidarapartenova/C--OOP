using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Classes
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            Repairs=new List<IRepair>();
        }

        public ICollection<IRepair> Repairs { get; private set; }

        public void AddRepair(IRepair repair)
        {
            Repairs.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            result.AppendLine($"Corps: {Corps}");
            result.AppendLine("Repairs:");

            foreach(var repair in Repairs)
            {
                result.AppendLine($"  {repair.PrintRepair()}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
