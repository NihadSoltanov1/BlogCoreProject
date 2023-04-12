using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace BlogCoreProject.Models
{
    public class SingUpViewModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage ="Adınızı Daxil Edin.")]
        public string userSurname { get; set; }

        [Display(Name = "İstifadəçi Adı")]
        [Required(ErrorMessage = "İstifadəçi Adınızı Daxil Edin.")]
        public string userName { get; set; }

        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Mailinizi Daxil Edin.")]
        public string Mail { get; set; }

        [Display(Name = "Şifrə")]
        [Required(ErrorMessage = "Şifrənizi Daxil edin.")]
        public string Password { get; set; }


        [Display(Name = "Təkrar Şifrə")]
        [Compare("Password", ErrorMessage = "Şifrələr bir-biriylə uyğunlaşmır.")]
        public string ConfirmPassword { get; set; }

    }
}
