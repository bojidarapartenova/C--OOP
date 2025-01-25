namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] carData = Console.ReadLine().Split();
            double fuelQuantityCar = double.Parse(carData[1]);
            double fuelConsumptionCar = double.Parse(carData[2]);
            double tankCpacityCar = double.Parse(carData[3]);
            Vehicle car = new Car(fuelQuantityCar, fuelConsumptionCar, tankCpacityCar);

            if(tankCpacityCar<fuelQuantityCar)
            {
                car = new Car(fuelConsumptionCar, tankCpacityCar);
            }

            string[] truckData = Console.ReadLine().Split();
            double fuelQuantityTruck = double.Parse(truckData[1]);
            double fuelConsumptionTruck = double.Parse(truckData[2]);
            double tankCapacityTruck = double.Parse(truckData[3]);
            Vehicle truck = new Truck(fuelQuantityTruck, fuelConsumptionTruck, tankCapacityTruck);

            if(tankCapacityTruck<fuelQuantityTruck)
            {
                truck = new Truck(fuelConsumptionTruck, tankCapacityTruck);
            }

            string[] busData = Console.ReadLine().Split();
            double fuelQuantityBus = double.Parse(busData[1]);
            double fuelConsumptionBus = double.Parse(busData[2]);
            double tankCapacityBus = double.Parse(busData[3]);
            Vehicle bus = new Bus(fuelQuantityBus, fuelConsumptionBus, tankCapacityBus);

            if(tankCapacityBus<fuelQuantityBus)
            {
                bus = new Bus(fuelConsumptionBus, tankCapacityBus);
            }


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Drive" && command[1] == "Car")
                {
                    car.Drive(double.Parse(command[2]));
                }
                else if (command[0] == "Drive" && command[1] == "Truck")
                {
                    truck.Drive(double.Parse(command[2]));
                }
                else if (command[0] == "Drive" && command[1] == "Bus")
                {
                    bus.Drive(double.Parse(command[2]));
                }
                else if (command[0] == "DriveEmpty")
                {
                    ((Bus)bus).DriveEmpty(double.Parse(command[2]));
                }
                else if (command[0] == "Refuel" && command[1] == "Car")
                {
                    car.Refuel(double.Parse(command[2]));
                }
                else if (command[0] == "Refuel" && command[1] == "Truck")
                {
                    truck.Refuel(double.Parse(command[2]));
                }
                else if (command[0] == "Refuel" && command[1] == "Bus")
                {
                    bus.Refuel(double.Parse(command[2]));
                }

            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}