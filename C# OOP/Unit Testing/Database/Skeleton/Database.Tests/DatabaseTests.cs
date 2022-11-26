namespace Database.Tests
{
    using NUnit.Framework;
    using System;
  

    [TestFixture]
    public class DatabaseTests
    {
        Database database;

        [SetUp]
        public void Setup()
        {
            database = new Database();
        }


        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void ConstructorInitializingWithCorrectData(int[] data)
        {
            database = new Database(data);

            Assert.AreEqual(database.Count, data.Length);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 })] // edge case
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 })] // main case
        public void ContructorShouldThrowWhenInitiliazeAbove16(int[] data)
        {

            Assert.Throws<InvalidOperationException>(() => database = new Database(data), "Array's capacity must be exactly 16 integers!");
        }


        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void AddCorrectDataInArrayViaConstructor(int[] data)
        {
            database = new Database(data);

            int[] expectedArray = data;
            int[] actualArray = database.Fetch();

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void CountCorrectReturn()
        {
            int expectedCount = 5;
            for (int i = 1; i <= expectedCount; i++)
            {

                database.Add(i);
            }
            int actualCount = database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void AddInCollectionWith16Elements()
        {

            for (int i = 1; i <= 16; i++)
            {
                database.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(17), "Array's capacity must be exactly 16 integers!");



        }

        [Test]
        public void AddingElementsShouldAddThemToDataCollection()
        {
            int[] expectedArray = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 1; i <= 5; i++)
            {
                database.Add(i);
            }

            int[] actualArray = database.Fetch();

            CollectionAssert.AreEqual(expectedArray, actualArray);

        }

        [Test]
        public void DecreasingCountWithRemovingElements()
        {
            int[] data = new int[] { 1, 2, 3, 4, 5 };
            database = new Database(data);

            int decreasingCount = 2;

            for (int i = 1; i <= decreasingCount; i++)
            {
                database.Remove();
            }

            Assert.AreEqual(data.Length - decreasingCount, database.Count);
        }
        [Test]
        public void ActualRemovingElementsFromArray()
        {
            int[] expectedData = new int[] { 1, 2, 3 };

            database = new Database(new int[] { 1, 2, 3, 4, 5 });

            int decreasingCount = 2;



            for (int i = 1; i <= decreasingCount; i++)
            {
                database.Remove();
            }

            int[] actualData = database.Fetch();

            CollectionAssert.AreEqual(expectedData, actualData);
        }

        [Test]
        public void RemoveShouldThrowExceptionWithZeroElements()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void FetchShouldReturnCollectionWithElementsInTheDb(int[] data)
        {
            Database db = new Database(data);

            int[] expectedData = data;
            int[] actualData = db.Fetch();

            CollectionAssert.AreEqual(expectedData, actualData);
        }
    }
}
