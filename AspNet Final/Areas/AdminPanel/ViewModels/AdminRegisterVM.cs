using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.Areas.AdminPanel.ViewModels
{
    [Area("AdminPanel")]
    public class AdminRegisterVM
    {
       
            [Required, StringLength(maximumLength: 20)]
            public string UserName { get; set; }
            [Required, DataType(DataType.EmailAddress)]
            public string Email { get; set; }
        public List<RoleVM> Roles { get; set; }
        public string Role { get; set; }
            [Required, DataType(DataType.Password)]
            public string Password { get; set; }
            [Required, DataType(DataType.Password), Compare(nameof(Password))]
            public string ConfirmPassword { get; set; }
        }
}
