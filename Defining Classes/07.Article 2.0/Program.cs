using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace _06.Articles
{
    class Articles
    {
        public static object article { get; private set; }

        static void Main(string[] args)
        {
            int numArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();
            for (int i = 0; i < numArticles; i++)
            {
                string[] tokens = Console.ReadLine().Split(separator: ", ");
                Article article = new Article(tokens[0], tokens[1], tokens[2]);
                articles.Add(article);

            }
            string criteria = Console.ReadLine();

            switch (criteria)
            {
                case "title":
                    articles = articles.OrderBy(a => a.Title).ToList();
                    break;
                case "content":
                    articles = articles.OrderBy(a => a.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(a => a.Author).ToList();
                    break;
            }
            foreach (Article article in articles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Author = author;
            Content = content;
            Title = title;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            string result = $"{Title} - {Content}: {Author}";
            return result;
        }
    }
}