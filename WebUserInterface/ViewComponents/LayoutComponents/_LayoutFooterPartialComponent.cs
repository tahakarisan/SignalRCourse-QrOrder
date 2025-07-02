using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.ViewComponents.LayoutComponents
{
    public class _LayoutFooterPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
