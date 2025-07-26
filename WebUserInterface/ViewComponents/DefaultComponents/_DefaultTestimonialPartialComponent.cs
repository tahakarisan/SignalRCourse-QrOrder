using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.ViewComponents.DefaultComponents
{
    public class _DefaultTestimonialPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
