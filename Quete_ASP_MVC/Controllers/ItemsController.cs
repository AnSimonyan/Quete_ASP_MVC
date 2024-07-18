using Microsoft.AspNetCore.Mvc;
using Quete_ASP_MVC.Models;
using System.Collections.Generic;

namespace Quete_ASP_MVC.Controllers
{
    public class ItemsController : Controller
    {
        private static List<Item> Items = new List<Item>
        {
            new Item { Id = 1, Name = "Home" },
            new Item { Id = 2, Name = "List of articles" }
            
        };

        public IActionResult Index()
        {
            return View(Items);
        }
    }
}