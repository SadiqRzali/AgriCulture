using BusinesLayer.Concrete;
using DataAcssesLayer.Concrete;
using DataAcssesLayer.EntityFramvork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AgriCulture.Controllers
{
    public class DefaultController : Controller
    {
        iletisimManager cm = new iletisimManager(new EFiletisimDal());
      
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(iletisim p)
        {
          

            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            cm.Insert(p);
            return RedirectToAction("Index", "Default");
        }
    }
}
