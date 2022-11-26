namespace FightingArena.Tests
{
    using Microsoft.VisualBasic;
    using NUnit.Framework;

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


    }
}
