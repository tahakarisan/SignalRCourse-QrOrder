using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
