using System.ComponentModel.DataAnnotations;

namespace JwtWeb
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Bayi adı gerekli!")]
        public string? BayiAdi { get; set; }

        [Required(ErrorMessage = "Şifre gerekli")]
        public string? Password { get; set; }
    }
}
