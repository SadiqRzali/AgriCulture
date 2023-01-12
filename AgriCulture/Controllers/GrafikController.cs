using Microsoft.AspNetCore.Mvc;

namespace AgriCulture.Controllers
{
    public class GrafikController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
