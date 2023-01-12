using DataAcssesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgriCulture.ViewComponents
{
    public class TeamView:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            Context tm = new Context();
            var value = tm.Teams.ToList();
            return View(value);
        }

    }
}
