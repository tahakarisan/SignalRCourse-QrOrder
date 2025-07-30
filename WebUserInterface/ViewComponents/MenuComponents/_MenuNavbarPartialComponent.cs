using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.ViewComponents.MenuComponents
{
    public class _MenuNavbarPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
