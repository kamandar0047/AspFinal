using AspNet_Final.DAL;
using AspNet_Final.Extensions;
using AspNet_Final.Models;
using AspNet_Final.Utilites;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.Areas.AdminPanel.Controllers
{[Area("AdminPanel")]
    public class BlogsController : Controller
    {
        public AppDbContext _context { get; }
        private readonly IWebHostEnvironment _env;
        public BlogsController(AppDbContext context, IWebHostEnvironment env)
        {
            _env = env;
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Slides);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Create(Blogs blogs)
        {
            //if (!ModelState.IsValid) return View();
            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            if (!blogs.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Please select image format");
                return View();
            }

            if (blogs.Photo.ChekSize(200))
            {
                ModelState.AddModelError("Photo", "Image size less");
                return View();
            }


            string fileName = await blogs.Photo.SaveFile("img", _env.WebRootPath);
        if(fileName != null)
            {

                Blogs blogs1 = new Blogs
                {
                    Image = fileName
                };
                _context.Add(blogs1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ModelState.AddModelError("", "Some problem");
            return View();

        }
[HttpPost]
public async Task<IActionResult> Delete (int? id)
        {
            if (id == null) return NotFound();
            Blogs blogs = await _context.Blogs.FindAsync(id);
            if (blogs == null) return NotFound();
                     _context.Blogs.Remove(blogs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));    
        }
    } 
}

