using Microsoft.AspNetCore.Mvc;

namespace Quete_ASP_MVC.Controllers
{
    public class AtelierController : Controller
    {
        public IActionResult Index(Int32 maxVal)
        {
             List<Int32> myList = new List<Int32>();

            for (int i = 0; i < maxVal; i++)
            {
                myList.Add(i);
            }
            return View(myList);
        }
    }
}
