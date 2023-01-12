using AgriCulture.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AgriCulture.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ProfileController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task <IActionResult> Index()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditModel userEditModel = new UserEditModel();
            userEditModel.Mail = value.Email;
            userEditModel.Phone = value.PhoneNumber;
            return View(userEditModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditModel p)
        {

            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            if(p.Password==p.ConfigrPassword)
            {
                value.Email = p.Mail;
                value.PhoneNumber = p.Phone;
                value.PasswordHash = _userManager.PasswordHasher.HashPassword(value, p.Password);
                var result = await _userManager.UpdateAsync(value);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
               
            }
            return View();

        }

    }
}
