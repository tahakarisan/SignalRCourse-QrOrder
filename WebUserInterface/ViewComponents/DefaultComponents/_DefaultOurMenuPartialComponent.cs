using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.ViewComponents.DefaultComponents
{
    public class _DefaultOurMenuPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
