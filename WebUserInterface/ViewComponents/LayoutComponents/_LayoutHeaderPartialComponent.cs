﻿using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.ViewComponents.LayoutComponents
{
    public class _LayoutHeaderPartialComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
