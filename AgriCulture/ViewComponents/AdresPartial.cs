using DataAcssesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgriCulture.ViewComponents
{
    public class AdresPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context cm = new Context();
            var value = cm.Adres.ToList();
            return View(value);
            

        }
    }
}
