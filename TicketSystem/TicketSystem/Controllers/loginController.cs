 using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TicketSystem.Controllers
{
    [AllowAnonymous]
    public class loginController : Controller
    {

        private readonly SignInManager<AppUser> _signInManager;


        Context c = new Context();

        public loginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "employeeinfo");
                }
                else
                {
                    return RedirectToAction("Index", "login");
                }
            }
            return View();

        }


        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "login");
        }






        //[HttpPost]
        //public async Task<IActionResult> Index(login p)
        //{
        //    var datavalue = c.logins.FirstOrDefault(x => x.LoginUserName == p.LoginUserName &&
        //    x.LoginPassword == p.LoginPassword);
        //    if(datavalue != null)
        //    {
        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name,datavalue.LoginID.ToString()),
        //        };
        //        var useridentity = new ClaimsIdentity(claims, "login");
        //        ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
        //        await HttpContext.SignInAsync(principal);
        //        return RedirectToAction("Index", "employeeinfo");




        //    }
        //    return View();
        //}

        //[HttpGet]
        //public async Task<IActionResult> Logout()
        //{
        //    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //    return RedirectToAction("Index", "login");
        //}
    }
}
