using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.ViewComponents.UILayoutComponents
{
    public class _UILayoutHeadPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
