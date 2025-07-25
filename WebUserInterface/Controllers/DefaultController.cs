using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
