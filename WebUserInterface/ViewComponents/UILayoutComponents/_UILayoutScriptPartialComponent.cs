using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.ViewComponents.UILayoutComponents
{
    public class _UILayoutScriptPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
