using NUnit.Framework;
using System;
using System.ComponentModel;

namespace PlanetWars.Tests
{
    public class Tests
    {
        [TestFixture]
        public class PlanetWarsTests
        {
            // Tests for Planet class
            // ----------------------------------------------
            // Tests for Name
            [Test]
            public void PlanetNameThrowsExceptionWhenSetToNull()
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    Planet TestPlanet = new Planet(null, 15);
                },"Invalid planet Name");
            }

            [Test]
            public void PlanetNameThrowsExceptionWhenSetToEmptyString()
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    Planet TestPlanet = new Planet(String.Empty, 15);
                },
                "Invalid planet Name");
            }

            [Test]
            public void PlanetNameSetWithProperName()
            {
                Planet TestPlanet = new Planet("TestName", 15);

                Assert.That(TestPlanet.Name, Is.EqualTo("TestName"));
            }

            // Tests for Budget
            [Test]
            public void BudgetThrowsArgumentExceptionWhenSetBelowZero()
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    Planet TestPlanet = new Planet("TestName", -1);
                },
                "Budget cannot drop below Zero!");
            }

            [Test]
            public void BudgetSetsWithProperValue()
            {
                Planet TestPlanet = new Planet("TestName", 1);

                Assert.That(TestPlanet.Budget, Is.EqualTo(1));
            }

            // Tests for Weapons
            [Test]
            public void WeaponsIsInitialized()
            {
                Planet testPlanet = new Planet("TestName", 1);
                Weapon testWeapon = new Weapon("TestWeapon", 1, 2);
                Assert.That(testPlanet.Weapons, Is.Not.Null);
            }

            // Tests for MilitaryPowerRatio
            [Test]
            public void MilitaryPowerRatioIsCalculatingProperly()
            {
                Planet testPlanet = new Planet("TestName", 1);
                Weapon testWeapon = new Weapon("TestWeapon", 1, 2);
                Weapon secondTestWeapon = new Weapon("SecondTestWeapon", 1, 3);
                testPlanet.AddWeapon(testWeapon);
                testPlanet.AddWeapon(secondTestWeapon);

                Assert.That(testPlanet.MilitaryPowerRatio, Is.EqualTo(5));
            }

            // Tests for Profit
            [Test]
            public void ProfitSetsBudgetAmountRight()
            {
                Planet TestPlanet = new Planet("TestName", 1);
                TestPlanet.Profit(2d);

                Assert.That(TestPlanet.Budget, Is.EqualTo(3));
            }

            // Test for SpendFunds
            [Test]
            public void SpendFundsThrowsInvalidOperationExceptionWhenAmountIsMoreThanBudget()
            {
                Planet TestPlanet = new Planet("TestName", 1);

                Assert.Throws<InvalidOperationException>(() =>
                {
                    TestPlanet.SpendFunds(2);

                },
                "Not enough funds to finalize the deal.");
            }

            [Test]
            public void SpendFundsSetBudgetCorrectlyWhenAmountIsLessThanBudget()
            {
                Planet TestPlanet = new Planet("TestName", 3);
                TestPlanet.SpendFunds(2d);

                Assert.That(TestPlanet.Budget, Is.EqualTo(1));
            }

            // Tests for AddWeapon
            [Test]
            public void AddWeaponWorksIfNotContainsGivenWeapon()
            {
                Planet TestPlanet = new Planet("TestName", 3);
                Weapon weapon = new Weapon("TestWeapon", 1, 2);
                TestPlanet.AddWeapon(weapon);

                Assert.That(TestPlanet.Weapons.Count, Is.EqualTo(1));
            }

            [Test]
            public void AddWeaponThrowsInvalidOperationExceptionWhenAddingAlreadyAddedWeapon()
            {
                Planet testPlanet = new Planet("TestName", 3);
                Weapon weapon = new Weapon("TestWeapon", 1, 2);
                testPlanet.AddWeapon(weapon);

                Assert.Throws<InvalidOperationException>(() =>
                {
                    testPlanet.AddWeapon(weapon);

                },
                $"There is already a {weapon.Name} weapon.");
            }

            // Tests for RemoveWeapon
            [Test]
            public void RemoveWeaponIsRemovingWeaponFromCollection()
            {
                Planet testPlanet = new Planet("TestName", 3);
                Weapon weapon = new Weapon("TestWeapon", 1, 2);
                testPlanet.AddWeapon(weapon);
                testPlanet.RemoveWeapon("TestWeapon");

                Assert.That(testPlanet.Weapons.Count, Is.EqualTo(0));
            }

            // Tests for UpgradeWeapon
            [Test]
            public void UpgradingWeaponThrowsExceptionWhenWeaponIsNotPresentInRepository()
            {
                Planet testPlanet = new Planet("TestName", 3);
                Weapon weapon = new Weapon("TestWeapon", 1, 2);
                testPlanet.AddWeapon(weapon);
                string invalidWeaponName = "TestWeapon2";

                Assert.Throws<InvalidOperationException>(() =>
                {
                    testPlanet.UpgradeWeapon(invalidWeaponName);
                },
                $"{invalidWeaponName} does not exist in the weapon repository of {testPlanet.Name}"
                );
            }

            [Test]
            public void UpgradingWeaponWorksProperlyWhenWeaponIsPresentInRepository()
            {
                Planet testPlanet = new Planet("TestName", 3);
                Weapon weapon = new Weapon("TestWeapon", 1, 2);
                testPlanet.AddWeapon(weapon);
                testPlanet.UpgradeWeapon(weapon.Name);

                Assert.That(weapon.DestructionLevel, Is.EqualTo(3));
            }

            // Tests for DestructOpponent
            [Test]
            public void DestructOpponentThrowsInvalidOperationExceptionWhenOpponentHasBiggerMilitaryPowerRatio()
            {
                Planet testPlanet = new Planet("TestName", 3);
                Weapon weapon = new Weapon("TestWeapon", 1, 2);
                Planet opponentPlanet = new Planet("TestName", 3);
                Weapon opponentWeapon = new Weapon("TestWeapon", 1, 3);

                Assert.Throws<InvalidOperationException>(() =>
                {
                    testPlanet.DestructOpponent(opponentPlanet);
                },
                $"{opponentPlanet.Name} is too strong to declare war to!");
            }

            [Test]
            public void DestructOpponentThrowsInvalidOperationExceptionWhenOpponentHasEqualMilitaryPowerRatio()
            {
                Planet testPlanet = new Planet("TestName", 3);
                Weapon testWeapon = new Weapon("TestWeapon", 1, 2);

                Planet opponentTestPlanet = new Planet("TestName", 3);
                Weapon opponentTestWeapon = new Weapon("TestWeapon", 1, 2);

                Assert.Throws<InvalidOperationException>(() =>
                {
                    testPlanet.DestructOpponent(opponentTestPlanet);
                },
                $"{opponentTestPlanet.Name} is too strong to declare war to!");
            }

            [Test]
            public void DestructOpponentDestroysWhenOpponentHasLowerMilitaryPowerRatio()
            {
                Planet testPlanet = new Planet("TestName", 3);
                Weapon testWeapon = new Weapon("TestWeapon", 1, 2);
                testPlanet.AddWeapon(testWeapon);

                Planet opponentTestPlanet = new Planet("TestName", 3);
                Weapon opponentTestWeapon = new Weapon("TestWeapon", 1, 1);
                opponentTestPlanet.AddWeapon(opponentTestWeapon);

                string result = testPlanet.DestructOpponent(opponentTestPlanet);

                Assert.That(result, Is.EqualTo($"{opponentTestPlanet.Name} is destructed!"));
            }

            // Tests for Weapon class
            // ---------------------------------------------
            // Tests for Name
            public void NameIsSetCorrectlyWhenInitialized()
            {
                Weapon testWeapon = new Weapon("TestWeapon", 3, 2);

                Assert.That(testWeapon.Name, Is.EqualTo("TestWeapon"));
            }

            // Tests for Price
            [Test]
            public void PriceWorksCorrectlyWhenHigherThanZero()
            {
                Weapon testWeapon = new Weapon("TestWeapon", 3, 2);

                Assert.That(testWeapon.Price, Is.EqualTo(3));
            }

            [Test]
            public void PriceThrowsArgumentExceptionWhenSetBelowZero()
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    Weapon testWeapon = new Weapon("TestWeapon", -1, 2);
                },
                "Price cannot be negative.");
            }

            // Tests for DestructionLevel
            [Test]
            public void DestructionLevelIsSetCorrectly()
            {
                Weapon testWeapon = new Weapon("TestWeapon", 3, 2);

                Assert.That(testWeapon.DestructionLevel, Is.EqualTo(2));
            }

            // Tests for IsNuclear
            [Test]
            public void IsNuclearIsTrueWhenDestructionLevelIsHigherThanTen()
            {
                Weapon testWeapon = new Weapon("TestWeapon", 3, 11);

                Assert.That(testWeapon.IsNuclear, Is.EqualTo(true));
            }

            [Test]
            public void IsNuclearChangesValueAccordingToDestructionLevel()
            {
                Weapon testWeapon = new Weapon("test", 2, 9);
                testWeapon.IncreaseDestructionLevel();

                Assert.That(testWeapon.IsNuclear, Is.EqualTo(true));
            }
        }
    }
}
