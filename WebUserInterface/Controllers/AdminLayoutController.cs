﻿using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
