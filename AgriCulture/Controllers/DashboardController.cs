using DataAcssesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgriCulture.Controllers
{
    public class DashboardController : Controller
    {
        Context cm = new Context();
        public IActionResult Index()
        {
            var value = cm.iletisims.ToList();
            ViewBag.v1 = cm.Teams.Count();
            ViewBag.v2 = cm.Services.Count();
            ViewBag.v3 = cm.iletisims.Count();
            ViewBag.v4 = cm.Images.Count();
            ViewBag.v5 = cm.Teams.Where(x => x.Title == "Sut uretici").Select(y=>y.PersonName).FirstOrDefault();
            ViewBag.v6 = cm.Teams.Where(x => x.Title == "Urun Pazarlama").Select(x => x.PersonName).FirstOrDefault();
            ViewBag.v7 = cm.Teams.Where(x => x.Title == "Yigim").Select(x => x.PersonName).FirstOrDefault();
            ViewBag.v8 = cm.Teams.Where(x => x.Title == "Terevez").Select(x => x.PersonName).FirstOrDefault();
            return View(value);
        }
    }
}
