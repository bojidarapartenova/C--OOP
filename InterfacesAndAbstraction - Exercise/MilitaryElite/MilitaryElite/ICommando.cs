using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Interfaces
{
    public interface ICommando:ISpecialisedSoldier
    {
        ICollection<IMission> Missions { get; }

        void AddMission(IMission mission);
    }
}
