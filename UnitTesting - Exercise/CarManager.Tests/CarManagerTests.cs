namespace CarManager.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class CarManagerTests
    {
        private Car car;
        [SetUp]
        public void SetUp()
        {
            car = new Car("BMW", "X5", 10, 100);
        }

        [Test]
        public void ConstructorShouldWork()
        {
            Assert.That(car.Make, Is.EqualTo("BMW"));
            Assert.That(car.Model, Is.EqualTo("X5"));
            Assert.That(car.FuelConsumption, Is.EqualTo(10));
            Assert.That(car.FuelCapacity, Is.EqualTo(100));
            Assert.That(car.FuelAmount, Is.EqualTo(0));
        }

        [TestCase(null)]
        [TestCase("")]
        public void MakeShouldNotBeNullOrEmpty(string make)
        {
           Assert.Throws<ArgumentException>(()=>new Car(make, "model", 10, 100));
        }

        [TestCase(null)]
        [TestCase("")]
        public void ModelShouldNotBeNullOrEmpty(string model)
        {
            Assert.Throws<ArgumentException>(() => new Car("Make", model, 10, 100));
        }

        [TestCase(0)]
        [TestCase(-10)]
        public void FuelConsumptionShouldNotBeZeroOrNegative(double fuelConsumption)
        {
            Assert.Throws<ArgumentException>(() => new Car("make", "model", fuelConsumption, 100));
        }

        [TestCase(-100)]
        public void FuelAmountShouldNotBeNegative(double fuelAmount)
        {
            Assert.Throws<ArgumentException>(() => new Car("make", "model", 10, fuelAmount));
        }

        [TestCase(0)]
        [TestCase(-10)]
        public void FuelCapacityShouldNotBeZeroOrNegative(double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car("make", "model", 10, fuelCapacity));
        }

        [Test]
        public void RefuelShouldIncreaseFuelAmount()
        {
            car.Refuel(50);
            Assert.That(car.FuelAmount, Is.EqualTo(50));
        }

        [Test]
        public void RefuelShouldNotBeMoreThanCapacity()
        {
            car.Refuel(150);
            Assert.That(car.FuelAmount, Is.EqualTo(100));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void RefuelFuelShouldNotBeZeroOrNegative(double fuelToRefuel)
        {
            Assert.Throws<ArgumentException>(()=>car.Refuel(fuelToRefuel));
        }

        [Test]
        public void DriveShouldReduceFuel()
        {
            car.Refuel(50);
            car.Drive(100);
            Assert.That(car.FuelAmount, Is.EqualTo(40));
        }

        [Test]
        public void DriveShouldThrowAnExceptionIfItNeedsTooMuchFuel()
        {
            Assert.Throws<InvalidOperationException>(()=>car.Drive(5));
        }
    }
}