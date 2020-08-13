using System;
using System.Globalization;

namespace _06.Articles
{
    class Articles
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(separator: ", ");
            Article article = new Article(tokens[0], tokens[1], tokens[2]);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(separator: ":");
                string command = commands[0];
                string argument = commands[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
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

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            string result = $"{ Title} - {Content}:{Author}";
            return result;
        }

    }
}
