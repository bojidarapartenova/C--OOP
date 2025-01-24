using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Classes
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            Privates = new List<IPrivate>();
        }

        public ICollection<IPrivate> Privates { get; private set;}

        public void AddPrivate(IPrivate @private)
        {
            Privates.Add(@private);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            result.AppendLine("Privates:");

            foreach(var @private in Privates)
            {
                result.AppendLine($"  {@private.ToString()}"); 
            }

            return result.ToString().TrimEnd();
        }
    }
}
