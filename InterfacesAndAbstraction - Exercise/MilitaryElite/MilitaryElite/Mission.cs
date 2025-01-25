using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Classes
{
    public class Mission:IMission
    {
        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = TryParseState(state);
        }

        public string CodeName { get; private set; }
        public State State { get; private set; }

        public void CompleteMission()
        {
            if(State==State.Finished)
            {
                throw new ArgumentException("Mission is already completed!");
            }

            State = State.Finished;
        }

        public State TryParseState(string state)
        {
            bool isParsed = Enum.TryParse(state, out State state1);

            if(!isParsed)
            {
                throw new ArgumentException("Invalid mission state!");
            }

            return state1;
        }

        public string PrintMission()
        {
            StringBuilder sb = new();
            sb.AppendLine($"  Code Name: {CodeName} State: {State}");
            return sb.ToString().TrimEnd();
        }
    }
}
