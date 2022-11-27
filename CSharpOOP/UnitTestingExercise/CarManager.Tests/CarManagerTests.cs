namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        [TestCase(null)]
        [TestCase("")]
        public void MakeCanNotBeNullOrEmpty(string make)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car(make, "Corola", 5, 65);
            },
            "Make cannot be null or empty!");
        }

        [Test]
        public void MakeIsSetWithCorrectDataGiven()
        {
            Car car = new Car("Toyota", "Corola", 5, 65);

            Assert.That(car.Make, Is.EqualTo("Toyota"));
        }

        [TestCase(null)]
        [TestCase("")]
        public void ModelCanNotBeNullOrEmpty(string model)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Toyota", model, 5, 65);
            },
            "Model cannot be null or empty!");
        }

        [Test]
        public void ModelIsSetWithCorrectDataGiven()
        {
            Car car = new Car("Toyota", "Corola", 5, 65);

            Assert.That(car.Model, Is.EqualTo("Corola"));
        }

        [TestCase(0)]
        [TestCase(int.MinValue)]
        public void FuelConsumptionCanNotBeZeroOrLess(double fuelConsumption)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Toyota", "Corola", fuelConsumption, 65);
            },
            "Fuel consumption cannot be zero or negative!");
        }

        [Test]
        public void FuelConsumptionIsSetWithCorrectDataGiven()
        {
            Car car = new Car("Toyota", "Corola", 5, 65);

            Assert.That(car.FuelConsumption, Is.EqualTo(5));
        }

        [TestCase(0)]
        [TestCase(-5)]
        [TestCase(int.MinValue)]
        public void FuelCapacityCanNotBeZeroOrNegativeNumber(double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Toyota", "Corola", 5, fuelCapacity);
            },
            "Fuel capacity cannot be zero or negative!");
        }

        [Test]
        public void FuelCapacityIsSetWithCorrectDataGiven()
        {
            Car car = new Car("Toyota", "Corola", 5, 65);

            Assert.That(car.FuelCapacity, Is.EqualTo(65));
        }

        [Test]
        public void DefaultFuelAmountIsSetToZero()
        {
            Car car = new Car("Toyota", "Corola", 5, 65);

            Assert.That(car.FuelAmount, Is.EqualTo(0));
        }

        [TestCase(0)]
        [TestCase(-5)]
        [TestCase(int.MinValue)]
        public void CanNotRefuelZeroOrNegativeAmount(double fuelToRefuel)
        {
            Car car = new Car("Toyota", "Corola", 5, 65);

            Assert.Throws<ArgumentException>(() =>
            {
                car.Refuel(fuelToRefuel);
            },
            "Fuel amount cannot be zero or negative!");
        }

        [Test]
        public void RefuelIsWorkingProperlyWithCorrectAmountGiven()
        {
            Car car = new Car("Toyota", "Corola", 5, 65);
            car.Refuel(5);

            Assert.That(car.FuelAmount, Is.EqualTo(5));
        }

        [Test]
        public void FuelAmountCanNotBeMoreThanFuelCapacity()
        {
            Car car = new Car("Toyota", "Corola", 5, 65);
            car.Refuel(66);

            Assert.That(car.FuelAmount, Is.EqualTo(car.FuelCapacity));
        }

        [TestCase(100)]
        [TestCase(200)]
        public void CanNotPassDistanceWithoutEnoughFuel(double distance)
        {
            Car car = new Car("Toyota", "Corola", 5, 65);
            Assert.Throws<InvalidOperationException>(() =>
            {
                car.Drive(distance);
            },
            "You don't have enough fuel to drive!");
        }

        [TestCase(100)]
        [TestCase(50)]
        public void DriveDecreasesFuelAmountWhenHavingEnoughFuelForTheDrive(double distance)
        {
            Car car = new Car("Toyota", "Corola", 5, 65);
            car.Refuel(5);
            double expectedResult = car.FuelAmount - (distance / 100 * car.FuelConsumption);
            car.Drive(distance);

            Assert.That(car.FuelAmount, Is.EqualTo(expectedResult));
        }
    }
}