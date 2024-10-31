using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMasterProject.DtoLayer.Dtos.UserRegisterDtos
{
    public class UserRegisterDto
    {
        [Required(ErrorMessage ="Ad Alanı Zorunludur")]
        [Display(Name="İsim")]
        [MaxLength(30,ErrorMessage ="En fazla 30 karakter girebilirsiniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ad Alanı Zorunludur")]
        [Display(Name = "Soyisim")]
        [MaxLength(15, ErrorMessage = "En fazla 15 karakter girebilirsiniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Email Alanı Zorunludur")]
        [Display(Name = "E-Posta")]
        [MaxLength(100, ErrorMessage = "En fazla 100 karakter girebilirsiniz")]
        public string Email { get; set; } 
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
