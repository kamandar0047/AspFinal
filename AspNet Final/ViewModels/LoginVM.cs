using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.ViewModels
{
    public class LoginVM
    {
       
        [Required,StringLength(maximumLength:20)]
        public string UserName { get; set; }
        [Required, EmailAddress, DataType(DataType.EmailAddress)]
      
        public string Password { get; set; }
        
    }
}
