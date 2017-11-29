using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Login.Models.VM
{
    public class LoginVM
    {
        [EmailAddress(ErrorMessage ="E-Posta formatında giriş yapınız")]
        [Required(ErrorMessage ="E-Posta Adresinizi Giriniz")]
        [DisplayName("E-posta")]
        public string Email { get; set; }

        [
            Required(ErrorMessage ="Paralonaızı Giriniz"),
            DisplayName("Parola")
        ]
        public string Password { get; set; }

        [DisplayName("Beni Hatırla")]
        public bool IsPersistant { get; set; }
    }
}