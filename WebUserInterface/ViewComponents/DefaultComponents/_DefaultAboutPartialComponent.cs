using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.ViewComponents.DefaultComponents
{
    public class _DefaultAboutPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
