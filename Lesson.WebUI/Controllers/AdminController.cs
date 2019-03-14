using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson.Entity;
using Lesson.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lesson.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        
        public AdminController(UserManager<ApplicationUser> _userManager)
        {
        userManager=_userManager;
        
        }
        [Authorize]
        public IActionResult Index()
        {
            return View(userManager.Users);
        }

        public IActionResult LessonCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);
            if(user!=null)
            {
                var result = await userManager.DeleteAsync(user);
                

                if(result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "user not found");
    
            }

            return View("Index",userManager.Users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = model.UserName;
                user.Email = model.Email;

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Update(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);

            if (user != null)
            {
                return View(user);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(string Id, string Email, string userName)
        {
            var user = await userManager.FindByIdAsync(Id);

            if (user != null)
            {
                user.Email = Email;
                user.UserName = userName;
                
                    var result = await userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                

            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }

            return View(user);
        }
    }
}