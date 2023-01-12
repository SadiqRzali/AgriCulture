using BusinesLayer.Concrete;
using DataAcssesLayer.EntityFramvork;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulture.ViewComponents
{
	public class AdresView:ViewComponent
	{
		AdresManager am = new AdresManager(new EFAdresDal());
		public IViewComponentResult Invoke()
		{
			var value = am.GetListAll();
			return View(value);
		}
	}
}
