using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Quete_ASP_MVC.Models;
using Quete_ASP_MVC.Repository;


namespace Quete_ASP_MVC.Controllers
{
    public class ArticleController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListOfArticles()
        {
            var listArticles = ArticleRepository.GetArticlesList();
            ViewData["Message"] = "List of articles";
            return View(listArticles);
        }
        

        [HttpGet]
        public IActionResult EditArticles(int idArticle)
        {
            var listArticles = ArticleRepository.GetArticleById(idArticle);
            ViewData["Message"] = "Edit article";
            return View(listArticles);
        }

        [HttpPost]
        public IActionResult EditArticles(int idArticle, Article article)
        {
            if (!ModelState.IsValid)return View();
                

            var listArticles = ArticleRepository.GetArticleById(idArticle);
            listArticles.Title = article.Title;
            listArticles.Content = article.Content;
            return RedirectToAction(actionName: "ListOfArticles", controllerName: "Article");
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewData["Message"] = "Add article";
            return View();
        }

        [HttpPost]
        public IActionResult Add( Article article)
        {
            if(!ModelState.IsValid) 

            
            {
                //return RedirectToAction(actionName: "ErrorInData", controllerName: "Article", new { message = "Title can no be empty!" });
                return View("Add", article);
            }
            else
            { 
            ArticleRepository.AddArticle(article.Title, article.Content);
            
            return RedirectToAction(actionName: "ListOfArticles", controllerName: "Article");
            }
        }

        public IActionResult Delete()
        {
            ViewData["Message"] = "Delete article";
            return View();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            ArticleRepository.DeleteArticleById(id);
            return Ok ();
        }
    }
}
