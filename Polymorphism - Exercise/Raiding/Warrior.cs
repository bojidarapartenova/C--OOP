using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class Warrior : BaseHero
    {
        public Warrior(string name, int power) : base(name, power)
        {
        }

        public override string CastAbility()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.CastAbility());
            result.Append($"hit for {Power} damage");

            return result.ToString();
        }
    }
}
