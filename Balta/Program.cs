using Balta.ContentContext;
using System;
using System.Collections.Generic;

namespace Balta
{
    public class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("texto", "texto"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
                Console.ReadKey();
            }


        }
    }
}
