using System;
using System.Collections.Generic;

namespace _03._Articles_2._0
{

    class Program
    {
        static void Main(string[] args)
        {
            int countArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < countArticles; i++)
            {
                string[] currArticle = Console.ReadLine().Split(", ");
                var article = new Article(currArticle[0], currArticle[1], currArticle[2]);
                articles.Add(article);
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Author = author;
            Title = title;
            Content = content;

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

