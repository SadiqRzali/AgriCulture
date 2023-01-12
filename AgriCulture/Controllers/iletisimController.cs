using BusinesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulture.Controllers
{
    public class iletisimController : Controller
    {
        private readonly IiletisimService _iletisimservice;

        public iletisimController(IiletisimService iletisimservice)
        {
            _iletisimservice = iletisimservice;
        }

        public IActionResult Index()
        {
            var value = _iletisimservice.GetListAll();
            return View(value);
        }

        public IActionResult DeleteMesage(int id)
        {
            var value = _iletisimservice.GetByID(id);
            _iletisimservice.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult MesageDetails(int id)
        {
            var value = _iletisimservice.GetByID(id);
            return View(value);
        }
    }
}
