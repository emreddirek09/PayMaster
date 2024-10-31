using FluentValidation;
using PayMasterProject.DtoLayer.Dtos.UserRegisterDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMasterProject.BusinessLayer.ValidationRules.UserValidationRules
{
    public class UserRegisterValidator : AbstractValidator<UserRegisterDto>
    {
        public UserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");  
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyad alanı boş geçilemez");    
            RuleFor(x => x.Email).NotEmpty().WithMessage("Eposta alanı boş geçilemez");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli eposta giriniz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Tekrar şifre alanı boş geçilemez");    
            RuleFor(x => x.ConfirmPassword).Equal(y=>y.Password).WithMessage("Şifre eşleşmiyor.");    
            
        }
    }
}
