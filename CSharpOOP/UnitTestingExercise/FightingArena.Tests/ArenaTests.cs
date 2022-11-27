namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ArenaTests
    {
        [Test]
        public void DefaultWarriorsCountInTheArenaIsZero()
        {
            Arena arena = new Arena();

            Assert.That(arena.Count, Is.EqualTo(0));
        }

        [Test]
        public void EnrollIsAddingWarrior()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("TestName", 50, 100);

            arena.Enroll(warrior);

            Assert.That(arena.Count, Is.EqualTo(1));
        }

        [Test]
        public void EnrollingSameWarriorTwiceIsThrowingException()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("TestName", 50, 100);
            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Enroll(warrior);
            },
            "Warrior is already enrolled for the fights!");
        }

        [TestCase("InvisibleAttacker", "White Defender")]
        [TestCase("Black Knight", "InvisibleDeffender")]
        public void FightIsNotPossibleWithMissingAttackerOrDefender(string attackerName, string defenderName)
        {
            Arena arena = new Arena();
            Warrior attacker = new Warrior("Black Knight", 50, 100);
            Warrior defender = new Warrior("White Defender", 50, 100);
            arena.Enroll(attacker);
            arena.Enroll(defender);
            string missingName = string.Empty;

            if (attackerName == null)
            {
                missingName = defenderName;
            }
            else if (defenderName == null)
            {
                missingName = attackerName;
            }

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight(attackerName, defenderName);
            },
            $"There is no fighter with name {missingName} enrolled for the fights!");
        }

        [Test]
        public void FightIsHappeningWithValidWarriorNames()
        {
            Arena arena = new Arena();
            Warrior attacker = new Warrior("Black Knight", 50, 100);
            Warrior defender = new Warrior("White Defender", 50, 100);
            arena.Enroll(attacker);
            arena.Enroll(defender);

            arena.Fight(attacker.Name, defender.Name);

            Assert.That(defender.HP, Is.EqualTo(100 - attacker.Damage));
        }
    }
}
