using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.ViewComponents.LayoutComponents
{
    public class _LayoutNavbarPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
