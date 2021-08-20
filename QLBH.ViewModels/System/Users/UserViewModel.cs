using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QLBH.ViewModels.System.Users
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        [Display (Name ="Họ")]
        public string FirstName { get; set; }
        [Display(Name = "Tên")]
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }
        public DateTime Dob { get; set; }
    }
}
