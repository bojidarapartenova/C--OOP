using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }
        public Bus(double fuelConsumption, double tankCapacity)
            : base(fuelConsumption, tankCapacity)
        {

        }

        public override void Drive(double distance)
        {
            FuelConsumption += 1.4;
            base.Drive(distance);
        }

        public void DriveEmpty(double distance)
        {
            base.Drive(distance);
        }
    }
}
