using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.ViewComponents.DefaultComponents
{
    public class _DefaultOfferPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
