using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            FuelConsumption += 0.9;
        }
        public Car(double fuelConsumption, double tankCapacity)
            : base(fuelConsumption, tankCapacity)
        {
            FuelConsumption += 0.9;
        }

    }
}
