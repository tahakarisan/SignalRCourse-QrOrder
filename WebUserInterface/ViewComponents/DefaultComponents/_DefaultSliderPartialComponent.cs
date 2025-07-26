using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.ViewComponents.DefaultComponents
{
    public class _DefaultSliderPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
