using MilitaryElite.Interfaces;

namespace MilitaryElite
{
    public interface IEngineer:ISpecialisedSoldier
    {
        ICollection<IRepair> Repairs { get; }
        void AddRepair(IRepair repair);
    }
}
