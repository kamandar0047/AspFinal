using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nagarersen Aye?"), StringLength(50, ErrorMessage = "Harua catmadi?")]
        public string Name { get; set; }
        public bool Deleted { get; set; }
        public Nullable<DateTime> IsDeleted{ get; set; }
        public ICollection<Theacher> Theachers { get; set; }
    }
}
