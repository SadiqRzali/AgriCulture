using BusinesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulture.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            var values = _teamService.GetListAll();
            return View(values);
        }


        [HttpGet]

        public IActionResult AddTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTeam(Team p)
        {

            _teamService.Insert(p);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteTeam(int id)
        {
            var value = _teamService.GetByID(id);
            _teamService.Delete(value);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult EditTeam(int id)
        {
             var value= _teamService.GetByID(id);
            return View(value);
        }

        public IActionResult EditTeam(Team p)
        {
             _teamService.Update(p);
            return RedirectToAction("Index");
        }

    }
}
