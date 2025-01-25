using System.Text;

namespace Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name, int power) : base(name, power)
        {
        }

        public override string CastAbility()
        {
            StringBuilder result=new StringBuilder();
            result.Append(base.CastAbility());
            result.Append($"healed for {Power}");

            return result.ToString();
        }
    }
}
