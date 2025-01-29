namespace FightingArena.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class WarriorTests
    {
        private Warrior warrior=new Warrior("warrior", 10, 100);
        [Test]
        public void ConstructorShouldWork()
        {
            Warrior warrior = new Warrior("warrior", 10, 100);
            Assert.That(warrior.Name, Is.EqualTo("warrior"));
            Assert.That(warrior.Damage, Is.EqualTo(10));
            Assert.That(warrior.HP, Is.EqualTo(100));
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void NameShouldNotBeNullEmptyOrWhiteSpace(string name)
        {
            Assert.Throws<ArgumentException>(()=>new Warrior(name, 10,100));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void DamageShouldBePositive(int damage)
        {
            Assert.Throws<ArgumentException>(()=>new Warrior("name", damage, 100));
        }

       
        [TestCase(-1)]
        public void HPShouldBePositive(int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("name", 10, hp));
        }

        [Test]
        public void AttackShouldThrowExceptionIfHPIsBelowOrEquaTo30()
        {
            Assert.Throws<InvalidOperationException>(()=>warrior.Attack(new Warrior("name", 10, 30)));
        }

        [Test]
        public void AttackShouldThrowExceptionIfEnemyHPIsBelowOrEquaTo30()
        {
            Warrior enemy = new Warrior("name", 10, 30);
            Assert.Throws<InvalidOperationException>(() => new Warrior("name", 10, 30).Attack(enemy));
        }

        [Test]
        public void WarriorCannotAttackStrongerEnemies()
        {
            Assert.Throws<InvalidOperationException>
                (()=>new Warrior("name", 10, 100).Attack(new Warrior("name2", 110, 200)));
        }

        [Test]
        public void AttackShouldWork()
        {
            Warrior enemy = new Warrior("enemy", 10, 200);
            warrior.Attack(enemy);
            Assert.That(enemy.HP, Is.EqualTo(190));
        }
    }
}