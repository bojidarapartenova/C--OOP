using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Mission: IMission
    {
        public Mission(string codeName,  string state)
        {
            CodeName = codeName;
            State = TryParseState(state);
        }

        public string CodeName { get; private set; }
        public State State { get; private set; }

        public void CompleteMission()
        {
        }

        public string PrintMission()
        {
            StringBuilder sb = new();
            sb.AppendLine($"  Code Name: {CodeName} State: {State}");
            return sb.ToString().TrimEnd();
        }

        public State TryParseState(string stateStr)
        {
            bool parsed = Enum.TryParse(stateStr, out State state);
            if (!parsed)
            {
                throw new ArgumentException("Invalid mission state!");
            }

            return state;
        }
    }
}
