using System;
using System.Linq;

namespace Articles
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

        public void Edit(string content)
        {
            this.content = content;
        }

        public void ChangeAuthor(string author)
        {
            this.author = author;
        }

        public void Rename (string title)
        {
            this.title = title;
        }

        public void ToString()
        {
             Console.WriteLine($"{this.title} - {this.content}: {this.author}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] givenArticle = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Article article = new Article(givenArticle[0], givenArticle[1], givenArticle[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    article.Rename(command[1]);
                }
            }

            article.ToString();
        }
    }
}
