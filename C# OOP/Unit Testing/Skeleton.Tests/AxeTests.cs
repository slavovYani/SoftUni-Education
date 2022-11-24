using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        Axe axe;
        Dummy target;

        [SetUp]
        public void Setup()
        {
            axe = new Axe(10, 15);
            target = new Dummy(100, 150);
        }

        [Test]
        public void SetConstructorCorrect()
        {
            Assert.AreEqual(10, axe.AttackPoints);
            Assert.AreEqual(15, axe.DurabilityPoints);
        }

        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            for (int i = 0; i < 5; i++)
            {

                axe.Attack(target);
            }

            Assert.AreEqual(10, axe.DurabilityPoints, "Axe durability doesn't change after attack!");
        }
        [Test]
        public void AttackWithBrokenAxeZero()
        {
            axe = new Axe(10, 0);
            Assert.Throws<InvalidOperationException>((() => axe.Attack(target)));

        }
        [Test]
        public void AttackWithBrokenAxeBellowZero()
        {
            axe = new Axe(10, -5);
            Assert.Throws<InvalidOperationException>((() => axe.Attack(target)));

        }
    }
}