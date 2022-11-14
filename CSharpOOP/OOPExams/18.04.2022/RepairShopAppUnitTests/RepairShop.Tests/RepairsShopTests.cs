using NUnit.Framework;
using System;

namespace RepairShop.Tests
{
    public class Tests
    {
        [TestFixture]
        public class RepairsShopTests
        {
            // Tests for Garage.Name

            [Test]
            public void Name_IsSetWithCorrectData()
            {
                var garage = new Garage("TestName", 5);
                Assert.That(garage.Name, Is.EqualTo("TestName"));
            }

            [TestCase(null)]
            [TestCase("")]

            public void Name_ThrowsExceptionWhenSetToNullOrEmptyString(string name)
            {
                Assert.Throws<ArgumentNullException>(() =>
                {
                    var garage = new Garage(name, 5);
                },
                "Invalid garage name.");
            }

            // Tests for Garage.MechanicsAvailable

            [Test]
            public void MechanicsAvailable_IsSetWithCorrectData()
            {
                var garage = new Garage("TestName", 5);
                Assert.That(garage.MechanicsAvailable, Is.EqualTo(5));
            }

            [TestCase(0)]
            [TestCase(-5)]
            [TestCase(int.MinValue)]
            public void MechanicsAvailable_ThrowsExceptionWhenSetToZeroOrLess(int availableMechanics)
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    var garage = new Garage("TestName", availableMechanics);
                },
                "At least one mechanic must work in the garage.");
            }

            // Tests for Garage.CarsInGarage

            [Test]
            public void CarsInGarage_DefaultValueIsZero()
            {
                var garage = new Garage("TestName", 5);
                Assert.That(garage.CarsInGarage, Is.EqualTo(0));
            }

            [Test]
            public void CarsInGarage_IncreasesAfterAddingACar()
            {
                var garage = new Garage("TestName", 5);
                var car = new Car("TestModel", 2);
                garage.AddCar(car);

                Assert.That(garage.CarsInGarage, Is.EqualTo(1));
            }

            // Tests for Garage.AddCar()

            [Test]
            public void AddCar_ThrowsExceptionWhenMechanicsArentAvailable()
            {
                var garage = new Garage("TestName", 1);
                var car = new Car("TestModel", 2);
                var secondCar = new Car("TestModel", 2);
                garage.AddCar(car);

                Assert.Throws<InvalidOperationException>(() =>
                {
                    garage.AddCar(car);
                },
                "No mechanic available.");
            }

            // Tests for Garage.FixCar(string carModel)

            [Test]
            public void FixCar_IsFixingExistingCar()
            {
                var garage = new Garage("TestName", 1);
                var car = new Car("TestModel", 2);
                garage.AddCar(car);
                garage.FixCar("TestModel");

                Assert.That(car.NumberOfIssues, Is.EqualTo(0));
            }

            [Test]
            public void FixCar_ThrowsExceptionWhenCarIsNotExisting()
            {
                var garage = new Garage("TestName", 1);
                string carModel = "NonExistingModel";
                Assert.Throws<InvalidOperationException>(() =>
                {
                    garage.FixCar(carModel);

                },
                $"The car {carModel} doesn't exist.");
            }

            // Tests for Garage.RemoveFixedCar()

            [Test]
            public void RemoveFixedCar_IsRemovingFixedCars()
            {
                var garage = new Garage("TestName", 1);
                var car = new Car("TestMode", 0);
                garage.AddCar(car);

                Assert.That(garage.RemoveFixedCar(), Is.EqualTo(1));
            }

            [Test]
            public void RemoveFixedCar_ThrowsExceptionWhenThereArentFixedCars()
            {
                var garage = new Garage("TestName", 1);
                var car = new Car("TestMode", 1);
                garage.AddCar(car);

                Assert.Throws<InvalidOperationException>(() =>
                {
                    garage.RemoveFixedCar();
                },
                "No fixed cars available.");
            }

            // Tests for Garage.Report()

            [Test]
            public void Report_WorksCorrectlyWithOneUnfixedCar()
            {
                var garage = new Garage("TestName", 1);
                var car = new Car("TestMode", 1);
                garage.AddCar(car);

                string result = garage.Report();

                Assert.That(result,
                    Is.EqualTo($"There are {garage.CarsInGarage} which are not fixed: {car.CarModel}."));
            }
        }
    }
}