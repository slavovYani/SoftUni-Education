namespace DatabaseExtended.Tests
{
    using NUnit.Framework;
    using ExtendedDatabase;
    using System.Collections.Generic;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        public Database database;

        [SetUp]
        public void SetUp()
        {

            Database database = new Database();
        }

        [Test]
        public void SetConstructorWithCorrectData()
        {
            Person[] persons = new Person[16];


            for (int i = 0; i < persons.Length; i++)
            {
                Person person = new Person(i, $"user{i}");
                persons[i] = person;
            }

            database = new Database(persons);

            Assert.AreEqual(persons.Length, database.Count);
        }

        // Testing with Test Case Source :

        [TestCaseSource("ValidConstructorData")]
        public void SetConstructorWithValidCaseSourceData(Person[] people, int expectedCount)
        {
            database = new Database(people);

            Assert.AreEqual(expectedCount, database.Count);

        }
        // All valid cases - main and edge
        private static IEnumerable<TestCaseData> ValidConstructorData()
        {

            yield return new TestCaseData
                (new Person[]
                {
                new Person(4, "Yani"),
                new Person(6, "Yani2"),
                new Person(7, "Yani3"),
                }, 3

                );
            yield return new TestCaseData
                (new Person[]
                {
                }, 0

                );

            yield return new TestCaseData
                (new Person[]
                {
                new Person(1, "Yani"),
                new Person(2, "Yani2"),
                new Person(3, "Yani3"),
                new Person(4, "Yani34"),
                new Person(5, "Yani35"),
                new Person(6, "Yani36"),
                new Person(7, "Yani37"),
                new Person(38, "Yani38"),
                new Person(39, "Yani39"),
                new Person(11, "Yani30"),
                new Person(12, "Yani3we"),
                new Person(13, "Yani3le"),
                new Person(14, "Yani66"),
                new Person(15, "Yani388"),
                new Person(16, "Yani3644"),
                new Person(17, "Yani3356"),
                }, 16

                );

        }



        [TestCaseSource("InvalidDataSetConstructorThrowsException")]
        public void SetConstructorWithNonValidData(Person[] people)
        {
            // И двете решения работят!!

            Assert.Throws<ArgumentException>(() => database = new Database(people), "Provided data length should be in range [0..16]!");


            //Exception exception = null;

            //try
            //{
            //    database = new Database(people);
            //    //database.Add(new Person(2123, "Mother"));
            //}
            //catch (ArgumentException ae)
            //{
            //    exception = ae;

            //}

            //Assert.IsNotNull(exception);

        }

        private static IEnumerable<TestCaseData> InvalidDataSetConstructorThrowsException()
        {
            yield return new TestCaseData
              (
                new object[]
                {
                new Person[]
                {

                new Person(1, "Yani"),
                new Person(2, "Yani2"),
                new Person(3, "Yani3"),
                new Person(4, "Yani34"),
                new Person(5, "Yani35"),
                new Person(6, "Yani36"),
                new Person(7, "Yani37"),
                new Person(38, "Yani38"),
                new Person(39, "Yani39"),
                new Person(11, "Yani30"),
                new Person(12, "Yani3we"),
                new Person(13, "Yani3le"),
                new Person(14, "Yani66"),
                new Person(15, "Yani388"),
                new Person(16, "Yani3644"),
                new Person(17, "Yani3356"),
                new Person(17, "Yani335f6")
               }
                }

               );
        }

        [TestCaseSource("ThrowExceptionAfterFullArayViaAddMethod")]
        public void AddingPersonsAfterFullArray(Person[] people)
        {
            database = new Database(people);
            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(543, "Gosho")), "Array's capacity must be exactly 16 integers!");
        }

        private static IEnumerable<TestCaseData> ThrowExceptionAfterFullArayViaAddMethod()
        {
            yield return new TestCaseData(new object[]
            {
                new Person[]
              {
                new Person(1,"Yani"),
                new Person(2,"Yaggni"),
                new Person(3,"Yagni"),
                new Person(4,"Yavsdni"),
                new Person(5,"Yaggdni"),
                new Person(6,"Yascsni"),
                new Person(7,"Yaasadni"),
                new Person(8,"Yagbdhdfni"),
                new Person(9,"Ya7676ni"),
                new Person(10,"Yankkji"),
                new Person(11,"Ya222ni"),
                new Person(12,"44Ya"),
                new Person(13,"Yanr5422i"),
                new Person(41,"Yani22211"),
                new Person(15,"Ya114455ni"),
                new Person(16,"Ya6778876ni"),
              }
            }

            );
        }

        [Test]
        public void AddingPersonWithExistingUsername()
        {
            Person[] persons = new Person[] { new Person(5, "Yani") };
            database = new Database(persons);

            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(6, "Yani")), "There is already user with this username!");

        }
        [Test]
        public void AddingPersonWithExistingID()
        {
            Person[] persons = new Person[] { new Person(5, "Yani") };
            database = new Database(persons);

            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(5, "Yanko")), "There is already user with this Id!");

        }

        [TestCase(2)]
        public void IncreasingCountWithAddingPersons(int expectedOutput)
        {
            Person[] persons = new Person[]
            {

            };

            database = new Database(persons);

            database.Add(new Person(65, "Yani"));
            database.Add(new Person(78, "Toni"));


            Assert.AreEqual(expectedOutput, database.Count);
        }

        [TestCaseSource("AddingPersonsWithAddMethod")]
        public void RemovingPersonsValidCase(Person[] people, int expectedOutput)
        {
            database = new Database(people);
            database.Remove();

            Assert.AreEqual(expectedOutput, database.Count);
        }
        private static IEnumerable<TestCaseData> AddingPersonsWithAddMethod()
        {
            yield return new TestCaseData(
                new Person[]
            {
                new Person(5,"Yani"),
                new Person(6,"Yanite"),
                new Person(55,"Tonic"),
            }, 2
            );
        }

        [Test]
        public void RemovingPersonsWithZeroCountThrowsException()
        {
            Person[] people = new Person[]
            {
                new Person(5,"Yani"),
                new Person(56,"Yanirr"),
                new Person(57, "Yanit")
            };

            database = new Database(people);

            int removingPeople = 3;

            for (int i = 0; i < removingPeople; i++)
            {
                database.Remove();
            }

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void FindPersonByUserNameValidCase()
        {
            Person person = new Person(5, "Yani");
            database = new Database(person);

            var actualOutput = person;
            var expectedOutput = database.FindByUsername("Yani");

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void FindByUserNameWithNullOrEmptyInputThrowsException()
        {
            Person person = new Person(5, "Yani");
            database = new Database(person);

            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(""));
        }

        [Test]
        public void FindByUsernameNonExistingThrowsException()
        {
            Person person = new Person(5, "Yani");
            database = new Database(person);

            Assert.Throws<InvalidOperationException>(() => database.FindByUsername("Gosho"));
        }

        [Test]
        public void FindByIdValidCase()
        {
            Person person = new Person(5, "Yani");
            database = new Database(person);
            var expectedOutput = database.FindById(5);

            Assert.AreEqual(expectedOutput, person);
        }

        [Test]
        public void FindByIdNegativeNumberThrowsException()
        {
            Person person = new Person(5, "Yani");
            database = new Database(person);

            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(-3));
        }

        [Test]
        public void FindByIdNonExistingThrowsException()
        {
            Person person = new Person(5, "Yani");
            database = new Database(person);

            Assert.Throws<InvalidOperationException>(() => database.FindById(4));
        }

    }
}