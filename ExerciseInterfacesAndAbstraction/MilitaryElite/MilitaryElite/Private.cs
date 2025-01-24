using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Classes
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            Salary = salary;
        }

        public decimal Salary { get; private set; }

        public override string ToString()
        {
            StringBuilder result=new StringBuilder();
            result.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            return result.ToString().TrimEnd();
        }
    }
}
