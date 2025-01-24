using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Classes
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary)
        {
            Corps=TryParseCorps(corps);
        }

        public Corps Corps { get; private set; }

        public Corps TryParseCorps(string corps)
        {
            bool isParsed=Enum.TryParse(corps, out Corps corps1);

            if(!isParsed)
            {
                throw new ArgumentException("Invalid corps!");
            }

            return corps1;
        }
    }
}
