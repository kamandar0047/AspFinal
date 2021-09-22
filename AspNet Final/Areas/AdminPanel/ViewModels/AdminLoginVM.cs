using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.Areas.AdminPanel.ViewModels
{
    public class AdminLoginVM
    { 
        [Required, StringLength(maximumLength: 20)]
            public string UserName { get; set; }
        
            [Required, DataType(DataType.Password)]
            public string Password { get; set; }
     
          
        }
    }



