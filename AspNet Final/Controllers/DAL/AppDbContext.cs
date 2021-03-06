using AspNet_Final.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Introduction> Introduction { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Theacher> Theachers { get; set; }
        public DbSet<TheacherImage>TheacherImages { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
    }
}
