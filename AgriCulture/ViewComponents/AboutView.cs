using BusinesLayer.Concrete;
using DataAcssesLayer.Concrete;
using DataAcssesLayer.EntityFramvork;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulture.ViewComponents
{
	public class AboutView:ViewComponent
	{
		AboutManager am = new AboutManager(new EFAboutDal());
        public IViewComponentResult Invoke()
		{

			var value = am.GetListAll();
			
			return View(value);
		}
	}
}
