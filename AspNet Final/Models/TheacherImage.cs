using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.Models
{
    public class TheacherImage
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int TeacherId { get; set; }
        public Theacher Theacher { get; set; }


    }
}
