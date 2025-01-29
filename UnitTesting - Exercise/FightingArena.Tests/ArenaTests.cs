namespace FightingArena.Tests
{
    using System;
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class ArenaTests
    {
        [Test]
        public void ConstructorShouldWork()
        {
            Arena arena = new Arena();
            Assert.That(arena, Is.Not.Null);
            Assert.That(arena.Count, Is.EqualTo(0));
        }

        [Test]
        public void EnrollShouldWork()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("warrior", 10, 100);
            arena.Enroll(warrior);
            Assert.That(arena.Count, Is.EqualTo(1));
            Assert.IsTrue(arena.Warriors.Contains(warrior));
        }

        [Test]
        public void EnrollThrowsException()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("warrior", 10, 100);
            arena.Enroll(warrior);
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(new Warrior("warrior", 10, 100)));
        }

        [Test]
        public void FightShouldWork()
        {
            Arena arena = new Arena();
            Warrior attacker = new Warrior("attacker", 10, 100);
            Warrior defender = new Warrior("defender", 10, 100);

            arena.Enroll(attacker);
            arena.Enroll(defender);
            arena.Fight(attacker.Name, defender.Name);

            Assert.That(defender.HP, Is.EqualTo(90));
        }

        [Test]
        public void FightThrowAnExceptionWhenAttackerIsNotEnrolled()
        {
            Arena arena = new Arena();
            Warrior attacker = new Warrior("attacker", 10, 100);
            Warrior defender = new Warrior("defender", 10, 100);

            arena.Enroll(defender);

            Assert.Throws<InvalidOperationException>(
                () => arena.Fight(attacker.Name, defender.Name));
        }

        [Test]
        public void FightThrowAnExceptionWhenDefenderIsNotEnrolled()
        {
            Arena arena = new Arena();
            Warrior attacker = new Warrior("attacker", 10, 100);
            Warrior defender = new Warrior("defender", 10, 100);

            arena.Enroll(attacker);

            Assert.Throws<InvalidOperationException>(
                () => arena.Fight(attacker.Name, defender.Name));
        }

        [Test]
        public void FightThrowAnExceptionWhenBothAreNotEnrolled()
        {
            Arena arena = new Arena();
            Warrior attacker = new Warrior("attacker", 10, 100);
            Warrior defender = new Warrior("defender", 10, 100);

            Assert.Throws<InvalidOperationException>(
                () => arena.Fight(attacker.Name, defender.Name));
        }

        [Test]
        public void DamageIsMoreThanHP()
        {
            Warrior attacker = new Warrior("attacker",300, 100);
            Warrior defender = new Warrior("defender", 100, 300-1);

            attacker.Attack(defender);
            
            Assert.IsTrue(defender.HP == 0);
        }
    }
}