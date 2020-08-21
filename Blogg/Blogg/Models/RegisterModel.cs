using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blogg.Models
{
    public class RegisterModel
    {
        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Mail")]
        [EmailAddress(ErrorMessage = "Doğru Bir E mail adresi giriniz.")]
        public string Email { get; set; }
    }
}
