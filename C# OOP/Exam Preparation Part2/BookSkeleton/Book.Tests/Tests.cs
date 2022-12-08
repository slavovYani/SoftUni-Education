namespace Book.Tests
{
    using System;

    using NUnit.Framework;
    using static System.Net.Mime.MediaTypeNames;

    public class Tests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void SetValidBookViaConstructor()
        {
            Book book = new Book("Roman", "Yani");
            Assert.IsNotNull(book);
        }

        [Test]
        public void SetValidPropertiesViaConstructor()
        {
            Book book = new Book("Roman", "Yani");

            Assert.AreEqual("Roman", book.BookName);
            Assert.AreEqual("Yani", book.Author);
        }

        [Test]
        public void InitiliazingFootnoteViaConstructor()
        {
            Book book = new Book("Roman", "Yani");

            Assert.AreEqual(0, book.FootnoteCount);
        }

        [Test]
        public void FootnoteCountReturnValidData()
        {
            int expectedOutput = 2;

            Book book = new Book("Roman", "Yani");

            book.AddFootnote(5, "Gogo");
            book.AddFootnote(6, "Mitko");

            Assert.AreEqual(expectedOutput, book.FootnoteCount);
        }

        [Test]
        public void BookNamePropertyReturnValidData()
        {
            Book book = new Book("Roman", "Yani");

            Assert.AreEqual("Roman", book.BookName);

            // same test as consutctor test
        }

        [Test]
        public void BookNamePropertyNullOrEmptyThrowsException()
        {
            string bookName = "";
            Assert.Throws<ArgumentException>(() => new Book(bookName, "Yani"), $"Invalid {nameof(Book.BookName)}!");
            //here for checking the message
        }

        [Test]
        public void AuthorPropertyReturnValidData()
        {
            Book book = new Book("Roman", "Yani");

            Assert.AreEqual("Yani", book.Author);

            // same test as consutctor test
        }

        [Test]
        public void AuthorPropertyNullOrEmptyThrowsException()
        {
            string author = "";
            Assert.Throws<ArgumentException>(() => new Book("roman", author), $"Invalid {nameof(Book.Author)}!");
            //here for checking the message
        }

        [Test]
        public void AddFootnoteWithValidData()
        {
            Book book1 = new Book("Roman", "Yani");
            //Book book2 = new Book("All", "Toni");
            //Book book3 = new Book("Manage", "Miraya");

            book1.AddFootnote(4, "Mitko");
            book1.AddFootnote(5, "Gosho");
            book1.AddFootnote(6, "Mitko");

            int expectedOutput = 3;

            Assert.AreEqual(expectedOutput, book1.FootnoteCount);

        }

        [Test]
        public void AddFootnoteWithAlreadyExistThrowsExceptio()
        {
            Book book1 = new Book("Roman", "Yani");
            book1.AddFootnote(4, "Mitko");

            Assert.Throws<InvalidOperationException>(() => book1.AddFootnote(4, "Toaonoa"), "Footnote already exists!");

        }

        [Test]
        public void FindFootnoteValid()
        {
            Book book1 = new Book("Roman", "Yani");
            book1.AddFootnote(4, "Mitko");

            string exptectedOutput = $"Footnote #4: Mitko";
            string actualOutput = book1.FindFootnote(4);

            Assert.AreEqual(exptectedOutput, actualOutput);

        }

        [Test]
        public void FindFootnoteWithNotExistNumberThrowsException()
        {
            Book book1 = new Book("Roman", "Yani");
            book1.AddFootnote(4, "Mitko");

            Assert.Throws<InvalidOperationException>(() => book1.FindFootnote(5), "Footnote doesn't exists!");

        }

        [Test]
        public void AlterFoodnoteWithValidData()
        {
            Book book1 = new Book("Roman", "Yani");
            book1.AddFootnote(4, "Mitko");

            book1.AlterFootnote(4, "BlaBlaBla");

            string exptectedOutput = $"Footnote #4: BlaBlaBla";
            string actualOutput = book1.FindFootnote(4);

            Assert.AreEqual(exptectedOutput, actualOutput);

        }

        [Test]
        public void AlterFootnoteWithNotExistNumberThrowsException()
        {
            Book book1 = new Book("Roman", "Yani");
            book1.AddFootnote(4, "Mitko");

            Assert.Throws<InvalidOperationException>(() => book1.AlterFootnote(5, "BlaBlaBla"), "Footnote does not exists!");

        }

    }
}