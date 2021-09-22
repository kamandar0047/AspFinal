using AspNet_Final.Areas.AdminPanel.ViewModels;
using AspNet_Final.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.Areas.AdminPanel.Controllers
{[Area("AdminPanel")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public UserController( UserManager<AppUser> userManager)
        {
            _userManager = userManager;

        }
        public async Task<IActionResult> Index()
        {
            List<AppUser> users = _userManager.Users.ToList();
            List<UserVM> userVM = new List<UserVM>();
            foreach (AppUser user in users)
            {
                userVM.Add(new UserVM
                {
                    Username=user.UserName,
                    Email=user.Email,
                    Role=(await _userManager.GetRolesAsync(user))[0]
                });
            }
            return View(userVM);
        }
    }
}
