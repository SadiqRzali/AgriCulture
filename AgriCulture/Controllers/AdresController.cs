using BusinesLayer.Concrete;
using BusinesLayer.ValidationRules;
using DataAcssesLayer.Abstract;
using DataAcssesLayer.EntityFramvork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulture.Controllers
{
    public class AdresController : Controller
    {
        AdresManager am = new AdresManager(new EFAdresDal());
        public IActionResult Index()
        {
            var value = am.GetListAll();
            return View(value);
        }


        [HttpGet]
        public IActionResult EditAdres(int id)
        {
            var value = am.GetByID(id);
            return View(value);
        }

        [HttpPost]
        
        public IActionResult EditAdres(Adres adres)
        {
            AdresValidator validationRules = new AdresValidator();
            ValidationResult result = validationRules.Validate(adres);
            if (result.IsValid)
            {
                am.Update(adres);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}

