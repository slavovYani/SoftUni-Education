using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Article> articles = new List<Article>();
            int numberOfArticles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfArticles; i++)
            {
               string[] token = Console.ReadLine().Split(", ").ToArray();

                Article article = new Article(token[0], token[1], token[2]);
                
                articles.Add(article);


            }
            string type = Console.ReadLine();

            foreach (var article in articles)
            {

            Console.WriteLine(article);
            }
        }


    }
   public class Article
    {
        public Article(string title, string text, string author)
        {
            Title = title;
            Content = text;
            Author = author;
        }



        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
    

