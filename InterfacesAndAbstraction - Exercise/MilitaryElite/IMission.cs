using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public enum State
    {
        inProgress,
        Finished
    }
    public interface IMission
    {
        string CodeName { get; }
        State State { get; }

        void CompleteMission();
        string PrintMission();
    }
}
