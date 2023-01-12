using Microsoft.AspNetCore.Mvc;

namespace AgriCulture.ViewComponents
{
    public class NavbarView:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
