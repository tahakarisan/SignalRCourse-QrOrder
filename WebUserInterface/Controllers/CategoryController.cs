using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
