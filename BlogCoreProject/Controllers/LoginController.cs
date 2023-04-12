﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogCoreProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Writer p)
        {
            Context c = new Context();
            var valuedate = c.Writers.FirstOrDefault(x => x.WriterMail
            == p.WriterMail && x.WriterPassword == p.WriterPassword);
            if (valuedate != null)
            {
                var claim = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,p.WriterMail)
                };
                 var useridentity = new ClaimsIdentity(claim, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "WriterDashboard");
            }
            else
            {
                return View();
            }
        }
    }
}
