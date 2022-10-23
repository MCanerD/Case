using System.ComponentModel.DataAnnotations;

namespace JwtWeb
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Bayi adı gerekli!")]
        public string? BayiAdi { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email gerekli!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Şifre gerekli!")]
        public string? Password { get; set; }
    }
}
