using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.Models
{
    public class Theacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Profession { get; set; }
        public ICollection<TheacherImage> Images { get; set; }
        public int CategoryId { get; set; }
        public Nullable<DateTime> Deleted { get; set; }
       
        public Category Category { get; set; }
        
    }
}
