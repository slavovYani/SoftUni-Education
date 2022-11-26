namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        Warrior warrior = null;
        [SetUp]
        public void SetUp()
        {
            warrior = new Warrior("Yani", 100, 120);

        }

        [Test]
        public void SetConstructorWithValidData()
        {
            
            Assert.That(warrior, Is.Not.Null);
            
        }

        [Test]
        public void NamePropertyWithValidData()
        {
            string expectedOutput = "Yani";
            Assert.AreEqual(expectedOutput, warrior.Name);
        }

        [Test]
        public void DamagePropertyWithValidData()
        {
            int expectedOutput = 100;
            Assert.AreEqual(expectedOutput, warrior.Damage);
        }
        [Test]
        public void HPPropertyWithValidData()
        {
            int expectedOutput = 120;
            Assert.AreEqual(expectedOutput, warrior.HP);
        }

        [Test]
        public void NamePropertyNullOrWhiteSpaceThrowsException()
        {

            Assert.Throws<ArgumentException>(() => warrior = new Warrior(" ", 100, 120), "Name should not be empty or whitespace!");
        }

        [TestCase(0)]
        [TestCase(-5)]
        public void DamagePropertyZeroOrNegativeThrowsException(int damage)
        {

            Assert.Throws<ArgumentException>(() => warrior = new Warrior("Yani", damage, 120), "Damage value should be positive!");
        }
        
        
        [TestCase(-5)]
        public void HPPropertyNegativeThrowsException(int hp)
        {

            Assert.Throws<ArgumentException>(() => warrior = new Warrior("Yani", 100, hp), "HP should not be negative!");
        }

        [Test]
        public void AttackMethodSuccesfullWithBiggerDamageOfAttackingWarrior()
        {
            var firstWarrior = new Warrior("Yani", 120, 150);
            var secondWarrior = new Warrior("Toni", 130, 100);
            // When firstWarrior attack Second if firstWarrior.Damage > secondWarrior.HP => seconWarrior.HP = 0 !!!

            firstWarrior.Attack(secondWarrior);

            int expectedOutput = 0;
            Assert.AreEqual(expectedOutput, secondWarrior.HP);

        }

        [TestCase(100)]
        [TestCase(90)]
        public void AttackMethodSuccesfullWithSmallerOrEqualDamageOfAttackingWarrior(int damage)
        {
         // When firstWarrior attack Second if firstWarrior.Damage <= secondWarrior.HP => seconWarrior.HP -=firstWarrior.Damage 
            var firstWarrior = new Warrior("Yani", damage, 140);
            var secondWarrior = new Warrior("Toni", 130, 100);

            int expectedOutput = secondWarrior.HP - firstWarrior.Damage;
            firstWarrior.Attack(secondWarrior);

            Assert.AreEqual(expectedOutput, secondWarrior.HP);
        }

        [TestCase(30)]
        [TestCase(29)]
        [TestCase(10)]
        public void AttackMethodBellowOrEqualMinimumHP_AttackingWarrior_ThrowsException(int hp)
        {
            var attackingWarrior = new Warrior("Tonkata", 110, hp);

            Assert.Throws<InvalidOperationException>(()=> attackingWarrior.Attack(warrior), "Your HP is too low in order to attack other warriors!");
        }

        [TestCase(30)]
        [TestCase(29)]
        [TestCase(10)]
        public void AttackMethodBellowOrEqualMinimuHP_AttackedWarrior_ThrowsException(int hp)
        {
            var attackingWarrior = new Warrior("Tonkata", 110, hp);

            Assert.Throws<InvalidOperationException>(() 
                => warrior.Attack(attackingWarrior), "Enemy HP must be greater than 30 in order to attack him!");

        }
        
        [TestCase(99)]
        [TestCase(50)]
        public void AttackMethodBellowOrEqualMinimuHPThrowsException(int hp)
        {
            var attackingWarrior = new Warrior("Tonkata", 110, hp);

            Assert.Throws<InvalidOperationException>(() 
                => attackingWarrior.Attack(warrior), "You are trying to attack too strong enemy");
        }





    }
}