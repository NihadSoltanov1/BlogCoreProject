using BlogCoreProject.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogCoreProject.Controllers
{
    [AllowAnonymous]
    public class IdentityRegisterController : Controller
    {
        public readonly UserManager<AppUser> _userManager;

        public IdentityRegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(SingUpViewModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Email = p.Mail,
                    UserName = p.userName,
                    NameSurname = p.userSurname
                };
                var result = await _userManager.CreateAsync(user, p.Password);
                if(result.Succeeded) return RedirectToAction("Index","Login");
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
            }
            }
           
           
            return View(p);
        }

        
    }
}
