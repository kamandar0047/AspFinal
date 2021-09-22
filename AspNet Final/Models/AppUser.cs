using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.Models
{
    public class AppUser:IdentityUser

    {
        [Required,StringLength(200)]
        public string Name { get; set; }
    }
}
