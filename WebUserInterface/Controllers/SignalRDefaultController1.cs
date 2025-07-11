using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.Controllers
{
    public class SignalRDefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
