using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.Models
{
    public class Slide
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string Image { get; set; }
       

    }
}
