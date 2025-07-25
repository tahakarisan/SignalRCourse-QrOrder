using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.ViewComponents.UILayoutComponents
{
    public class _UILayoutFooterPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
