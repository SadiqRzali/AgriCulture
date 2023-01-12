using BusinesLayer.Concrete;
using DataAcssesLayer.EntityFramvork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AgriCulture.Controllers
{
    public class AnnoucementController : Controller
    {
        AnnouncementMan cm = new AnnouncementMan(new EFAnnouncementDal());
        
        public IActionResult Index()
        {
            var value = cm.GetListAll();
            return View(value);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(Announcement p)
        {
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.Status = false;
            cm.Insert(p);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteAnnouncement(int id)
        {
            var value = cm.GetByID(id);
            cm.Delete(value);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult EditAnnouncement(int id)
        {

            var value = cm.GetByID(id);
            return View(value);
        }


        public IActionResult EditAnnouncement(Announcement p)
        {

            cm.Update(p);
            return RedirectToAction("Index");
        }


        public IActionResult ChangeTrue(int id)
        {
            cm.AnnounTrue(id);
            return RedirectToAction("Index");
        }


        public IActionResult ChangeFalse(int id)
        {
            cm.AnnounFalse(id);
            return RedirectToAction("Index");
        }
    }
}
