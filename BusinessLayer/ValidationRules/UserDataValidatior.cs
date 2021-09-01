using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using EntityLayer.Concrete;
using System.Security.Cryptography.Xml;

namespace BusinessLayer.ValidationRules
{
    public class UserDataValidatior: AbstractValidator<UserData>
    {
        public UserDataValidatior()
        {


            RuleFor(x => x.AdSoyad).NotEmpty().WithMessage("AdSoyadı boş giremezsin");
            RuleFor(x => x.AdSoyad).MinimumLength(8).WithMessage("Adsoyadı 8 karakterden az giremezsin.");
            RuleFor(x => x.AdSoyad).MaximumLength(30).WithMessage("AdSoyadı 30 karakterden cok giremezsin");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail boş giremezsin");
            RuleFor(x => x.Şifre).MaximumLength(30).WithMessage("Şifre 30 karakterden cok giremezsin");
            RuleFor(x => x.Şifre).MinimumLength(6).WithMessage("Şifre 6 karakterden az giremezsin");
            RuleFor(x => x.Şifre).NotEmpty().WithMessage("Şifre boş giremezsin");

        }

    }
}
