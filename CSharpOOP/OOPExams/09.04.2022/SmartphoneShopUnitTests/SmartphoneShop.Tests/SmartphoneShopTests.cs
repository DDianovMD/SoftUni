using NUnit.Framework;
using System;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {
        [TestCase(0)]
        [TestCase(5)]
        [TestCase(100)]
        [TestCase(int.MaxValue)]
        public void Capacity_IsSetCorrectlyWithZeroAndPositiveNumbers(int capacity)
        {
            Shop shop = new Shop(capacity);
            Assert.That(shop.Capacity, Is.EqualTo(capacity));
        }

        [TestCase(-200)]
        [TestCase(int.MinValue)]
        public void Capacity_ThrowsExceptionWhenSetToNegativeNumber(int capacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Shop shop = new Shop(capacity);
            },
            "Invalid capacity.");
        }

        [Test]
        public void Count_DefaultValueIsZero()
        {
            Shop shop = new Shop(5);

            Assert.That(shop.Count, Is.EqualTo(0));
        }

        [Test]
        public void Count_IsIncreasingWhenAddingPhones()
        {
            Shop shop = new Shop(5);
            Smartphone testPhone = new Smartphone("TestName", 100);
            shop.Add(testPhone);

            Assert.That(shop.Count, Is.EqualTo(1));
        }

        [Test]
        public void Add_ThrowsExceptionWhenAddingAlreadyAddedPhone()
        {
            Shop shop = new Shop(5);
            Smartphone testPhone = new Smartphone("TestName", 100);
            shop.Add(testPhone);

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Add(testPhone);
            }
            , $"The phone model {testPhone.ModelName} already exist.");
        }

        [Test]
        public void Add_ThrowsExceptionWhenAddingInFullShop()
        {
            Shop shop = new Shop(1);
            Smartphone nokiaPhone = new Smartphone("Nokia", 100);
            Smartphone samsungPhone = new Smartphone("Samsung", 100);
            shop.Add(nokiaPhone);

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Add(samsungPhone);
            },
            "The shop is full.");
        }

        [TestCase("NonExisting")]
        public void Remove_ThrowsExceptionWhenPhoneDoesNotExist(string model)
        {
            Shop shop = new Shop(5);
            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Remove(model);
            },
            $"The phone model {model} doesn't exist.");
        }

        [Test]
        public void Remove_IsRemovingExistingPhones()
        {
            Shop shop = new Shop(1);
            Smartphone testPhone = new Smartphone("Nokia", 100);
            shop.Add(testPhone);

            shop.Remove("Nokia");
            Assert.That(shop.Count, Is.EqualTo(0));
        }

        [Test]
        public void TestPhone_ThrowsExceptionWhenPhoneModelDoesNotExist()
        {
            Shop shop = new Shop(1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.TestPhone(null, 20);
            },
            $"The phone model {null} doesn't exist.");
        }

        [Test]
        public void TestPhone_ThrowsExceptionWhenWhenBatteryChargeIsLowerThanBatteryUsage()
        {
            Shop shop = new Shop(1);
            Smartphone testPhone = new Smartphone("Nokia", 15);
            shop.Add(testPhone);

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.TestPhone("Nokia", 20);
            },
            $"The phone model {testPhone.ModelName} is low on batery.");
        }

        [Test]
        public void TestPhone_WorkingProperlyWhenBatterChargeIsHigherThanBatteryUsage()
        {
            Shop shop = new Shop(1);
            Smartphone testPhone = new Smartphone("Nokia", 50);
            shop.Add(testPhone);
            shop.TestPhone("Nokia", 20);

            Assert.That(testPhone.CurrentBateryCharge, Is.EqualTo(30));
        }

        [Test]
        public void ChargePhone_ThrowsExceptionWhenPhoneDoesNotExist()
        {
            Shop shop = new Shop(1);
            Smartphone phone = new Smartphone("Nokia", 50);
            shop.Add(phone);
            string nonExistingPhoneModel = "Huqwei";

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.ChargePhone("Samsung");
            },
            $"The phone model {nonExistingPhoneModel} doesn't exist.");
        }

        [Test]
        public void ChargePhone_WorksProperlyWithExistingPhones()
        {
            Shop shop = new Shop(1);
            Smartphone phone = new Smartphone("Nokia", 50);
            phone.CurrentBateryCharge = 1;
            shop.Add(phone);
            shop.ChargePhone(phone.ModelName);

            Assert.That(phone.CurrentBateryCharge, Is.EqualTo(phone.MaximumBatteryCharge));
        }
    }
}