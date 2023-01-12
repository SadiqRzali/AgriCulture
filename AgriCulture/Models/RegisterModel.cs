using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace AgriCulture.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Lutfen istifadeci adini yazin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lutfen Mail Alnini doldurun")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lutfen sifre alanini doldurun")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Lutfen sifreye tekrar girin")]
        [Compare("Password",ErrorMessage = "Sifreler uyumlu deyil")]
        public string PasswordConfigrm { get; set; }

    }
}
