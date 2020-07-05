using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MybookWeb.Dtos;
using MybookWeb.Entities;
using MybookWeb.Enums;
using MybookWeb.Interface;
using MybookWeb.Models;

namespace MybookWeb.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IAccount _account;

        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(IAccount account, SignInManager<ApplicationUser> signInManager)
        {
            _account = account;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {   
                Alert("Login Unsuccesful!", NotificationType.error);
                ModelState.AddModelError("", "UserName/Password is incorrect");
                return View();
            }
            var signin = await _account.LoginIn(login);
            if (signin)
            {
                Alert("Login successful.", NotificationType.success);
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        //////////
        
        public async Task<IActionResult> SignUp(UserDto u)       
        {
            if (!ModelState.IsValid)
            {
                Alert("Sign Up Unsuccesful!", NotificationType.error);
                ModelState.AddModelError("", "UserName/Password is incorrect");
                return View();
            }
            ApplicationUser user = new ApplicationUser();
            
            user.UserName = u.Username;
            user.Email = u.Email;
            
            var signUp = await _account.Signupp(user, u.Password);

            if (signUp)
            {
                Alert("Account Created successfully.", NotificationType.success);
                return RedirectToAction("login", "Account");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {

            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
//var user = await _userManager.FindByEmailAsync(login.Email);

//if (user != null)
//{
//    var result = await _signInManager.PasswordSignInAsync(user, login.Password, false, false);
//    if (result.Succeeded)
//    {
//        return RedirectToAction("Index", "Home");
//    }
//}
//else
//{
//    return View();
//}

//ModelState.AddModelError("", "Email/password not found");
//return View(login);


//private readonly UserManager<ApplicationUser> _userManager;
//private readonly RoleManager<ApplicationRole> _roleManager;
//string Message = "";

//public AccountController(SignInManager<ApplicationUser> signInManager,
//    RoleManager<ApplicationRole> roleManager,
//    UserManager<ApplicationUser> userManager)
//{
//    _signInManager = signInManager;
//    _userManager = userManager;
//    _roleManager = roleManager;
//}