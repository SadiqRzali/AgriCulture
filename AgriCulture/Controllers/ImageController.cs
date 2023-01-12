using BusinesLayer.Concrete;
using BusinesLayer.ValidationRules;
using DataAcssesLayer.Abstract;
using DataAcssesLayer.EntityFramvork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace AgriCulture.Controllers
{
    public class ImageController : Controller
    {
        ImageManager cm = new ImageManager(new EFImageDal());
        public IActionResult Index()
        {
            var value = cm.GetListAll();
            return View(value);
        }


        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddImage(Image p)
        {


            cm.Insert(p);
            return RedirectToAction("Index");
         
           
           
        }


        public IActionResult DeleteImage(int id)
        {
            var value = cm.GetByID(id);
            cm.Delete(value);
            return RedirectToAction("Index");
        }


        [HttpGet]

        public IActionResult EditImage(int id)
        {
            var value=cm.GetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditImage(Image p)
        {
           
                cm.Update(p);
                return RedirectToAction("Index");
       

         
        }
    }
}
