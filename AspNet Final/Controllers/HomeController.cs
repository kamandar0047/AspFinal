using AspNet_Final.DAL;
using AspNet_Final.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AspNet_Final.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _context { get;}
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
                return View();
        }
        

        
    }
}
