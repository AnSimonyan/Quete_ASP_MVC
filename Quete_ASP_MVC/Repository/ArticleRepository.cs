using Microsoft.AspNetCore.Http.HttpResults;
using System.Security.Cryptography;
using Quete_ASP_MVC.Models;
using System.Xml.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Quete_ASP_MVC.Repository
{
    public static class ArticleRepository
    {
        private static List<Article> _articles = new List<Article>()
        { new Article()
        {
            Id = 1,
            Title = "Title 1",
            Content = "Title 1 Title 1 Title 1"

        },
            new Article()
            {
                Id = 2,
                Title = "Title 2",
                Content = "itle 2 Title 2"

            },
           new Article()
           {
               Id = 3,
               Title = "Title 3",
               Content = "Title 3 Title 3 Title 3"

           }
        };

        public static List<Article> GetArticlesList( ) => _articles;

        public static void AddArticle( string title, string content)
        {
            int newId = _articles.Max(s => s.Id) + 1;

            var newArticle = new Article()
            {
                Id = newId,
                Title = title,
                Content = content
            };
            _articles.Add(newArticle);

        }

        public static void DeleteArticleById(int idArticle)
        {
            _articles.RemoveAll(s => s.Id == idArticle);
            
        }

        public static Article GetArticleById(int idArticle)
        { 
            return _articles.Find(a=> a.Id ==  idArticle);
        }

    }
}
