using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Repair: IRepair
    {
        public Repair(string partName, int hours)
        {
            PartName = partName;
            Hours = hours;
        }

        public string PartName { get; private set; }
        public int Hours { get; private set; }

        public string PrintRepair()
        {
            StringBuilder sb = new();
            sb.AppendLine($"  Part Name: {PartName} Hours Worked: {Hours}");
            return sb.ToString().TrimEnd();
        }
    }
}
