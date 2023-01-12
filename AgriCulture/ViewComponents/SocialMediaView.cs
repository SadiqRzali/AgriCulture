using BusinesLayer.Concrete;
using DataAcssesLayer.EntityFramvork;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulture.ViewComponents
{
	public class SocialMediaView:ViewComponent
	{
		SosialMediaManager sm = new SosialMediaManager(new EFSosialMediaDal());
		public IViewComponentResult Invoke()
		{
			var value = sm.GetListAll();
			return View(value);
		}
	}
}
