namespace FightingArena.Tests
{
    using Microsoft.VisualBasic;
    using NUnit.Framework;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Xml.Linq;

    [TestFixture]
    public class ArenaTests
    {
        Arena arena = null;

        [SetUp]
        public void SetUp()
        {
            arena = new Arena();
        }

        [Test]
        public void SetConstructorWithListOfWarriors()
        {
            Assert.IsNotNull(arena.Warriors);
        }

        [Test]
        public void CountPropertyReturnCountOfWarriorsValid()
        {
            arena.Enroll(new Warrior("Yani", 120, 100));
            arena.Enroll(new Warrior("Yanito", 120, 100));
            arena.Enroll(new Warrior("Yanitt", 120, 100));

            int expectedOutput = 3;
            int actualOutput = arena.Count;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestCaseSource("ArrayOfWarriors")]
        public void EnrollWarriorsSuccesfull(Warrior[] warriors)
        {
            foreach (var warrior in warriors)
            {

                arena.Enroll(warrior);
            }

            Assert.AreEqual(warriors.Length, arena.Warriors.Count);
        }

        [TestCaseSource("ArrayOfWarriors")]
        public void EnrollWarriorAlreadyExistThrowsException(Warrior[] warriors)
        {

            foreach (var warrior in warriors)
            {

                arena.Enroll(warrior);
            }

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(new Warrior("Yani", 102, 105)), "Warrior is already enrolled for the fights!");
        }


        [Test]
        public void FightMethodWithValidWarriors()
        {
            var firstWarrior = new Warrior("Yani", 120, 150);
            var secondWarrior = new Warrior("Toni", 130, 100);

            // When firstWarrior attack Second if firstWarrior.Damage > secondWarrior.HP => seconWarrior.HP = 0 !!!

            arena.Enroll(firstWarrior);
            arena.Enroll(secondWarrior);

            arena.Fight(firstWarrior.Name, secondWarrior.Name);

            int expectedOutput = 0;

            Assert.AreEqual(expectedOutput, secondWarrior.HP);
        }

        [TestCaseSource("ArrayOfWarriors")]
        public void FigthMethodWithNonExistingAttacker(Warrior[] warriors)
        {
            var attacker = new Warrior("Gosho", 150, 200);

            Assert.Throws<InvalidOperationException>(() 
                => arena.Fight(attacker.Name, warriors[0].Name),
                $"There is no fighter with name {attacker.Name} enrolled for the fights!");
            
        }

        [TestCaseSource("ArrayOfWarriors")]
        public void FigthMethodWithNonExistingDefender(Warrior[] warriors)
        {
            var defender = new Warrior("Gosho", 90, 90);

            Assert.Throws<InvalidOperationException>(()
                => arena.Fight(warriors[0].Name, defender.Name),
                $"There is no fighter with name {defender.Name} enrolled for the fights!");

        }

        private static IEnumerable<TestCaseData> ArrayOfWarriors()
        {
            yield return new TestCaseData(
              new object[] 
              {
                    new Warrior[]
                    {
                         new Warrior("Yani",102,105),
                         new Warrior("Toni",1042,1605),
                         new Warrior("Yanito",1042,1055),
                         new Warrior("Miraya",1402,1605)

                    }
              }
            );
        }

    }
}
