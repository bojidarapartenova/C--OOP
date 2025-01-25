using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Interfaces;

namespace MilitaryElite
{
    public interface ICommando:ISpecialisedSoldier
    {
        ICollection<IMission> Missions { get; }
        void AddMission(IMission mission);
    }
}
