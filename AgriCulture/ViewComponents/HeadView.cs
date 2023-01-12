using Microsoft.AspNetCore.Mvc;

namespace AgriCulture.ViewComponents
{
	public class HeadView:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
