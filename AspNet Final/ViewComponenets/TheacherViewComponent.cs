using AspNet_Final.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.ViewComponenets
{
    public class TheacherViewComponent:ViewComponent
    {public AppDbContext _context { get; }
        public TheacherViewComponent( AppDbContext contex)
        {
            _context = contex;
        }
        public async Task<IViewComponentResult> InvokeAsync() {
            var model =  _context.Theachers.
Include(t => t.Images).Where(t => t.Deleted == null).OrderByDescending(t => t.Id).Skip(12).Take(8).ToListAsync();


            return View(await Task.FromResult(model));
        }
    }
}
