using AspNet_Final.Migrations;
using AspNet_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.ViewModels
{
    public class HomeVM
    {
        public List<Slide> Slides { get; set; }
        public Introduction Introduction { get; set; }
        public List<Theacher> Theachers { get; set; }
        public List<Category> Categories { get; set; }
        public Blogs Blogs { get; set; } 
    }
}
