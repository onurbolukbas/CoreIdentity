using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson.Entity;
using Lesson.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson.WebUI.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {

        
        
            private UserManager<ApplicationUser> userManager;
            private SignInManager<ApplicationUser> signinManager;

            public AccountController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signinManager)
            {
                userManager = _userManager;
                signinManager = _signinManager;
            }

            [AllowAnonymous]
            public IActionResult Login(string returnUrl)
            {
                ViewBag.returnUrl = returnUrl;
                return View();
            }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);

                if (user != null)
                {
                    await signinManager.SignOutAsync();
                    var result = await signinManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        return Redirect(returnUrl ?? "/");
                    }
                }
                ModelState.AddModelError("Email", "Invalid Email or Password");
            }

            return View(model);

        }
        public async Task<IActionResult> Logout()
        {
            await signinManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
