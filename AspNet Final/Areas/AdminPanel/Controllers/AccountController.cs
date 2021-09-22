using AspNet_Final.Areas.AdminPanel.ViewModels;
using AspNet_Final.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace AspNet_Final.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AccountController : Controller

    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public readonly SignInManager<AppUser> _signInManager;
        public readonly UserManager<AppUser> _userManager;
        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
            _roleManager = roleManager;
            _userManager = userManager;    
        }
        public IActionResult Register()
        {
            AdminRegisterVM vm = new AdminRegisterVM();
            vm.Roles = new List<RoleVM>();
            foreach (var role in Enum.GetNames(typeof(Helper.Helper.Roles)))
            {
                vm.Roles.Add(new RoleVM { Name=role});
            }
            return View(vm);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(AdminRegisterVM register)
        {
            AdminRegisterVM vm = new AdminRegisterVM();
            vm.Roles = new List<RoleVM>();
            foreach (var role in Enum.GetNames(typeof(Helper.Helper.Roles)))
            {
                vm.Roles.Add(new RoleVM { Name = role });
            }
            if (!ModelState.IsValid) return View(vm);

            AppUser user = new AppUser
            {
                UserName = register.UserName,
                Email = register.Email
            };
            IdentityResult result = await _userManager.CreateAsync(user, register.Password);
            if (!result.Succeeded)
            {
                foreach (IdentityError error  in result.Errors)
                {
                    ModelState.AddModelError("",error.Description);
                    return View(vm);
                }
            }
            await _userManager.AddToRoleAsync(user, register.Role);
            return RedirectToAction("Index","Home",new {area = "" });
        }
        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Login(AdminLoginVM login)
        {
            if (!ModelState.IsValid) return View(login);

            AppUser user = await _userManager.FindByNameAsync(login.UserName);

            if (user == null)
            {
                ModelState.AddModelError("", "UserName or Passowrd is not correct");
                return View(login);
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, login.Password, false, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "UserName or Passowrd is not correct");
                return View(login);
            }
            return RedirectToAction("Index", "Home");
        }
       

}            
        }
    