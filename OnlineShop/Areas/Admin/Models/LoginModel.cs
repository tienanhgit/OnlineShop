using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "{0} is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "pass null")]
        public string PassWord { get; set; }

        [Required(ErrorMessage = "pass null")]
        public bool RememberMe { get; set; }




    }
}