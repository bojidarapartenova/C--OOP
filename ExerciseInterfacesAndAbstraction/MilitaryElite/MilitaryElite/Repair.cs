using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Classes
{
    public class Repair:IRepair
    {
        public Repair(string partName, int hoursWorked)
        {
            PartName = partName;
            HoursWorked = hoursWorked;
        }

        public string PartName { get; }
        public int HoursWorked { get; }

        public string PrintRepair()
        {
            StringBuilder sb = new();
            sb.AppendLine($"  Part Name: {PartName} Hours Worked: {HoursWorked}");
            return sb.ToString().TrimEnd();
        }
    }
}
