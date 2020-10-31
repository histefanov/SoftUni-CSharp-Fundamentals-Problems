using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] articleInfo = Console.ReadLine().Split(", ");
                string title = articleInfo[0];
                string content = articleInfo[1];
                string author = articleInfo[2];

                articles.Add(new Article(title, content, author));
            }

            string criteria = Console.ReadLine();
            PrintListSortedByGivenCriteria(articles, criteria);

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
           
            public void PrintArticleInfo()
            {
                Console.WriteLine($"{this.Title} - {this.Content}: {this.Author}");
            }
        }

        static void PrintListSortedByGivenCriteria(List<Article> articles, string criteria)
        {
            List<Article> sortedArticles = new List<Article>();

            switch (criteria)
            {           
                case "title":
                    sortedArticles = articles.OrderBy(a => a.Title).ToList();
                    break;
                case "content":
                    sortedArticles = articles.OrderBy(a => a.Content).ToList();
                    break;
                case "author":
                    sortedArticles = articles.OrderBy(a => a.Author).ToList();
                    break;
            }

            sortedArticles.ForEach(a => a.PrintArticleInfo());
        }
    }
}
