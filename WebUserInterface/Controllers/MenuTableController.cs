using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUserInterface.Dtos;

namespace WebUserInterface.Controllers
{
    public class MenuTableController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public MenuTableController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
