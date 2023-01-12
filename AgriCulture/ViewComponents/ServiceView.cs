using DataAcssesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgriCulture.ViewComponents
{
    public class ServiceView:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            Context cm = new Context();
            var value = cm.Services.ToList();
        
            return View(value);
        }



    }
}
//var deger1 = db.KITABs.Count();
//var deger2 = db.UYELERs.Count();
//var deger3 = db.CEZALARs.Sum(x => x.PARA);
//var deger4 = db.KITABs.Where(x => x.DURUM == false).Count();
//var deger5 = db.KATEGORIs.Count();
//var deger6 = db.EnCoxOxunanKitab().FirstOrDefault();
//var deger8 = db.EnFazlaKitabYazar().FirstOrDefault();
//var deger9 = db.KITABs.GroupBy(x => x.YAYINEVI).OrderByDescending(x => x.Count()).Select(y => new { y.Key }).FirstOrDefault();

//var deger11 = db.iletisims.Count();
//ViewBag.dgr1 = deger1;
//ViewBag.dgr2 = deger2;
//ViewBag.dgr3 = deger3;
//ViewBag.dgr4 = deger4;
//ViewBag.dgr5 = deger5;
//ViewBag.dgr6 = deger6;
//ViewBag.dgr8 = deger8;
//ViewBag.dgr9 = deger9;

//ViewBag.dgr11 = deger11;
//return View();