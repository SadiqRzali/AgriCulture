using System.ComponentModel.DataAnnotations;

namespace AgriCulture.Models
{
    public class LoginRegister
    {

        [Required(ErrorMessage ="kullanici adini doldurun")]
        public string username { get; set; }

        [Required(ErrorMessage ="sifre alanini doldurun")]
        public string password { get; set; }
    }
}
