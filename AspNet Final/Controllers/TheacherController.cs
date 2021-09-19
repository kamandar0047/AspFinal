using AspNet_Final.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.Controllers
{
    public class TheacherController : Controller
    {
        public AppDbContext _context { get; }
        public TheacherController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.TheacherSlary = _context.Theachers.Where(t => t.Deleted == null).FirstOrDefault();
            return View(await _context.Theachers.Include(t => t.Images).ToListAsync());
        }
        public async Task<IActionResult> LoadMore(int take=8, int skip=12)
        {
            var model = await _context.Theachers.Include(t=>t.Images).Where(t=>t.Deleted==null).OrderByDescending(t=>t.Id).Skip(12).Take(8).ToListAsync();
            return PartialView("_theacherPartial", model);
           
        }
    }
}
