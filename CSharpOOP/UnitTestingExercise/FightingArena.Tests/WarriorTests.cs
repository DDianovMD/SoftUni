namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        [TestCase(null)]
        [TestCase("")]
        public void WarriorNameCanNotBeNullOrEmpty(string name)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, 50, 100);
            },
            "Name should not be empty or whitespace!");
        }

        [Test]
        public void WarriorNameIsSetWithCorrectlyGivenData()
        {
            Warrior warrior = new Warrior("TestName", 50, 100);

            Assert.That(warrior.Name, Is.EqualTo("TestName"));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(int.MinValue)]
        public void WarriorDamageCanNotBeLessThanOrZero(int damage)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior("TestName", damage, 100);
            },
            "Damage value should be positive!");
        }

        [Test]
        public void WarriorDamageIsSetWithCorrectlyGivenValueAboveZero()
        {
            Warrior warrior = new Warrior("TestName", 50, 100);

            Assert.That(warrior.Damage, Is.EqualTo(50));
        }

        [TestCase(-1)]
        [TestCase(int.MinValue)]
        public void WarriorHPCanNotBeLessThanZero(int hp)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior("TestName", 50, hp);
            },
            "HP should not be negative!");

        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(int.MaxValue)]
        public void WarriorHPIsSetWhenGivenValueIsZeroOrAbove(int hp)
        {
            Warrior warrior = new Warrior("TestName", 50, hp);

            Assert.That(warrior.HP, Is.EqualTo(hp));
        }

        [TestCase(30, 1)]
        [TestCase(30, 30)]
        public void AttackIsNotAllowedWhenHPIsLowerOrEqualThanMIN_ATTACK_HP(int minAttackHp, int hp)
        {
            Warrior testWarrior = new Warrior("TestName", 50, hp);
            Warrior dummy = new Warrior("Dummy", 50, 100);

            Assert.Throws<InvalidOperationException>(() =>
            {
                testWarrior.Attack(dummy);
            },
            "Your HP is too low in order to attack other warriors!");
        }

        [TestCase(30, 1)]
        [TestCase(30, 30)]
        public void AttackIsNotAllowedWhenEnemyHPIsLowerOrEqualThanMIN_ATTACK_HP(int minAttackHp, int hp)
        {
            Warrior testWarrior = new Warrior("TestName", 50, 100);
            Warrior dummy = new Warrior("Dummy", 50, hp);

            Assert.Throws<InvalidOperationException>(() =>
            {
                testWarrior.Attack(dummy);
            },
            $"Enemy HP must be greater than {minAttackHp} in order to attack him!");
        }

        [TestCase(1)]
        [TestCase(49)]
        public void ExceptionIsThrowedWhenAttackingStrongerEnemy(int hp)
        {
            Warrior testWarrior = new Warrior("TestName", 50, hp);
            Warrior enemyDummy = new Warrior("Dummy", 50, 100);

            Assert.Throws<InvalidOperationException>(() =>
            {
                testWarrior.Attack(enemyDummy);
            },
            "You are trying to attack too strong enemy");
        }

        [TestCase(100, 50)]
        [TestCase(51, 50)]
        public void AttackingEnemyIsReducingAttackerHPWithEnemyDamage(int ownHp, int enemyDamage)
        {
            Warrior testWarrior = new Warrior("TestName", 50, ownHp);
            Warrior enemyDummy = new Warrior("Dummy", enemyDamage, 100);

            testWarrior.Attack(enemyDummy);

            Assert.That(testWarrior.HP, Is.EqualTo(ownHp - enemyDamage));
        }

        [TestCase(50, 40)]
        [TestCase(50, 50)]
        public void EnemyIsDyingWhenAttackerDamageIsHigherOrEqualToEnemyHP(int attackerDamage, int enemyHp)
        {
            Warrior testWarrior = new Warrior("TestName", attackerDamage, 100);
            Warrior enemyDummy = new Warrior("Dummy", 50, enemyHp);

            testWarrior.Attack(enemyDummy);

            Assert.That(enemyDummy.HP, Is.EqualTo(0));
        }

        [Test]
        public void AttackingEnemyIsReducingEnemyHPWithAttackerDamageWhenNotEnoughToKillIt()
        {
            Warrior testWarrior = new Warrior("TestName", 50, 100);
            Warrior enemyDummy = new Warrior("Dummy", 50, 100);
            int expectedResult = enemyDummy.HP - testWarrior.Damage;
            testWarrior.Attack(enemyDummy);

            Assert.That(enemyDummy.HP, Is.EqualTo(expectedResult));
        }
    }
}