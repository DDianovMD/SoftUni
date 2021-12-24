using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
{
    public class Article
    {
        public string title { get; set; }
        public string content { get; set; }
        public string author { get; set; }

        public Article(string title, string content, string author)
        {
            this.title = title;
            this.content = content;
            this.author = author;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfCommands = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] givenArticle = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                Article article = new Article(givenArticle[0], givenArticle[1], givenArticle[2]);

                articles.Add(article);                
            }

            string orderCriteria = Console.ReadLine();

            if (orderCriteria.ToLower() == "title")
            {
                foreach (var article in articles.OrderBy(x => x.title))
                {
                    Console.WriteLine($"{article.title} - {article.content}: {article.author}");
                }
            }
            else if (orderCriteria.ToLower() == "content")
            {
                foreach (var article in articles.OrderBy(x => x.content))
                {
                    Console.WriteLine($"{article.title} - {article.content}: {article.author}");
                }
            }
            else if (orderCriteria.ToLower() == "author")
            {
                foreach (var article in articles.OrderBy(x => x.author))
                {
                    Console.WriteLine($"{article.title} - {article.content}: {article.author}");
                }
            }
        }
    }
}
