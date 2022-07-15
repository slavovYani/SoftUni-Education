using System;
using System.Linq;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(", ").ToArray();

            var article = new Article(token[0], token[1], token[2]);
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();


                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);

                        break;
                    case "ChangeAuthor":

                       article.EditAuthor(command[1]);
                        break;

                    case "Rename":
                        article.Rename(command[1]);
                        break;


                }
            }
                Console.WriteLine(article);
        }


    }
    class Article
    {
        public Article(string title,string text, string author)
        {
            Title = title;
            Content = text;
            Author = author;
        }



        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Rename(string title) => Title = title;
        public void Edit(string text) => Content = text;
        public void EditAuthor(string author) => Author = author;

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}

