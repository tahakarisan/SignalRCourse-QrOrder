using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.ViewComponents.LayoutComponents
{
    public class _LayoutSidebarPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
