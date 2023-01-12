using AgriCulture.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AgriCulture.Controllers
{

    [AllowAnonymous]
    public class LoginController : Controller
    {

        


        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task  <IActionResult> Index(LoginRegister p)
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, false);
                 
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        [HttpGet]
        
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
       
        public async Task<IActionResult> Signup(RegisterModel p)
        {
            IdentityUser identityUser = new IdentityUser()
            {
                Id = "1",
                UserName = p.UserName,
                Email = p.Mail

            };
            if(p.Password==p.PasswordConfigrm)
            {
                var result = await _userManager.CreateAsync(identityUser, p.Password);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }
    }
}
