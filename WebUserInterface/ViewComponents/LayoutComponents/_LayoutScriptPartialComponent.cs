﻿using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.ViewComponents.LayoutComponents
{
    public class _LayoutScriptPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
