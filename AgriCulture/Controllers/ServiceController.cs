using BusinesLayer.Concrete;
using DataAcssesLayer.EntityFramvork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulture.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager cm = new ServiceManager(new EFServiceDal());
        public IActionResult Index()
        {
            var values = cm.GetListAll();
            return View(values);
        }


        [HttpGet]

        public IActionResult AddService()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddService(Service p)
        {
            if(!ModelState.IsValid)
            {
                return View("AddService");
            }

            cm.Insert(p);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteService(int id)
        {
            var value = cm.GetByID(id);
            cm.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            var value = cm.GetByID(id);
            return View(value);
        }



        [HttpPost]
        public IActionResult EditService(Service p)
        {
            cm.Update(p);
            return RedirectToAction("Index");
        }
    }
}
