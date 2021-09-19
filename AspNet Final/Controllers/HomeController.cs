using AspNet_Final.DAL;
using AspNet_Final.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            HomeVM homeVM = new HomeVM
            {
                Slides = await _context.Slides.ToListAsync(),
                Introduction = await _context.Introduction.FirstOrDefaultAsync(),
            Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync(),
         
            };
            return View(homeVM);
        }
    }
}
