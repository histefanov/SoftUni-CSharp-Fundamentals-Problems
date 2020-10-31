using System;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleInfo = Console.ReadLine().Split(", ");
            Article article = new Article(articleInfo[0], articleInfo[1], articleInfo[2]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                string action = command[0];
                string replacement = command[1];

                switch (action)
                {
                    case "Edit": article.EditContent(replacement); break;
                    case "ChangeAuthor": article.ChangeAuthor(replacement); break;
                    case "Rename": article.Rename(replacement); break;
                }
            }

            article.PrintArticleInfo();
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title;
        public string Content;
        public string Author;

        public void EditContent(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public void PrintArticleInfo()
        {
            Console.WriteLine($"{this.Title} - {this.Content}: {this.Author}");
        }
    }
}
