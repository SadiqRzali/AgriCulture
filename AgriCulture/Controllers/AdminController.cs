using BusinesLayer.Concrete;
using DataAcssesLayer.Abstract;
using DataAcssesLayer.Concrete;
using DataAcssesLayer.EntityFramvork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgriCulture.Controllers
{
    public class AdminController : Controller
    {
        AdminManager am = new AdminManager(new EFAdminDal());
        public IActionResult Index()
        {

            var value = am.GetListAll();
            return View(value);
        }

        public IActionResult DeleteAdmin(int id)
        {
            var value = am.GetByID(id);
            am.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAdmin(Admin p)
        {
            am.Insert(p);
            return RedirectToAction("Index");
        }


    }
}
