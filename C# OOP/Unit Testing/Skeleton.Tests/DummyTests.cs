using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private int attackPoints;
        private int health;
        private int experience;
        
        
        Dummy target;

        [SetUp]
        public void Setup()
        {
            health = 100;
            experience = 50;
            
            target = new Dummy(health, experience);

        }

        [Test]
        public void ConstructorSet()
        {
            Assert.AreEqual(health, target.Health);
           
        }

        [Test]
        public void DummyLosesHealthIfAttack()
        {
            attackPoints = 8;
            target.TakeAttack(attackPoints);

            Assert.AreEqual(health-attackPoints,target.Health);   
        }

        [Test]
        public void DeadDummyThrowsExceptionWithZeroHealth()
        {
            target = new Dummy(0, 100);
            
            Assert.Throws<InvalidOperationException>(() => target.TakeAttack(attackPoints));

        }
        [Test]
        public void DeadDummyThrowsExceptionWithNegativeHealth()
        {
            target = new Dummy(-5, 100);
            
            Assert.Throws<InvalidOperationException>(() => target.TakeAttack(attackPoints));

        }

        [Test]
        public void DeadDummyCanGiveExperience()
        {
            experience = 100;
            target = new Dummy(0, 100);

            Assert.AreEqual(experience, target.GiveExperience(),"Dummy is alive and cannot give experience!");

        }
        [Test]
        public void AliveDummyCantGiveExperience()
        {
            experience = 100;
            target = new Dummy(120, 150);

            Assert.Throws<InvalidOperationException>(()=> target.GiveExperience(),"Dummy is dead and cannot throw proper message!");

        }




    }
}