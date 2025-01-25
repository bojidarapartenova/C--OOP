namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            FuelConsumption += 1.6;
        } 
        
        public Truck(double fuelConsumption, double tankCapacity)
            : base(fuelConsumption, tankCapacity)
        {
            FuelConsumption += 1.6;
        }


        public override void Refuel(double fuel)
        {
            double fuelToAdd = fuel * 0.95;

            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }

            else if (fuelToAdd + FuelQuantity > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                return;
            }

            FuelQuantity += fuelToAdd;
        }
    }
}
