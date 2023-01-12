using DataAcssesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgriCulture.ViewComponents
{
	public class MapPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			Context cm = new Context();
			var value = cm.Adres.Select(x => x.MapInfo).FirstOrDefault();
			ViewBag.v = value;
			return View();
		}
	}
}
