using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.ViewModels
{
    public class RegisterVM
    {
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required, StringLength(maximumLength:20)]
        public string UserName { get; set; }
        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, EmailAddress, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, EmailAddress, DataType(DataType.Password),Compare(nameof(Password),ErrorMessage ="Check Password and Password do not match" )]
        public string CheckPassword { get; set; }
    }
}
