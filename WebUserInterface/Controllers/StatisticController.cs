using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
