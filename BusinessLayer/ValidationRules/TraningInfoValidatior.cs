using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TraningİnfoValidatior : AbstractValidator<Traningİnfo>
    {
        public TraningİnfoValidatior()
        {
            

            //RuleFor(x => x.CreateTime).NotEmpty().WithMessage("CreateTime boş giremezsin");

            //RuleFor(x => x.Traning.TraningName).NotEmpty().WithMessage("TraningName boş giremezsin");
            //RuleFor(x => x.Traning.TraningName).MinimumLength(5).WithMessage("TraningName 5 karakterden az giremezsin.");
            //RuleFor(x => x.Traning.TraningName).MaximumLength(30).WithMessage("TraningName 30 karakterden cok giremezsin");

            //RuleFor(x => x.UserData.AdSoyad).NotEmpty().WithMessage("AdSoyadı boş giremezsin");
            //RuleFor(x => x.UserData.AdSoyad).MinimumLength(8).WithMessage("Adsoyadı 8 karakterden az giremezsin.");
            //RuleFor(x => x.UserData.AdSoyad).MaximumLength(30).WithMessage("AdSoyadı 30 karakterden cok giremezsin");

            //RuleFor(x => x.Traning.TraningTypes.TraningTypee).NotEmpty().WithMessage("TraningType boş giremezsin");
            //RuleFor(x => x.Traning.TraningTypes.TraningTypee).MinimumLength(5).WithMessage("TraningType 5 karakterden az giremezsin.");
            //RuleFor(x => x.Traning.TraningTypes.TraningTypee).MaximumLength(30).WithMessage("TraningType 30 karakterden cok giremezsin");

            //RuleFor(x => x.Periyod.Ay).NotEmpty().WithMessage("Ay boş giremezsin");
            //RuleFor(x => x.Periyod.Ay).MinimumLength(3).WithMessage("Ay 3 karakterden az giremezsin.");
            //RuleFor(x => x.Periyod.Ay).MaximumLength(30).WithMessage("Ay 30 karakterden cok giremezsin");

            //RuleFor(x => x.Periyod.Yıl).NotEmpty().WithMessage("Yıl boş giremezsin");
            //RuleFor(x => x.Periyod.Yıl).MinimumLength(3).WithMessage("Yıl 3 karakterden az giremezsin.");
            //RuleFor(x => x.Periyod.Yıl).MaximumLength(5).WithMessage("Yıl 5 karakterden cok giremezsin");

            //RuleFor(x => x.Periyod.Hafta).NotEmpty().WithMessage("Hafta boş giremezsin");
            //RuleFor(x => x.Periyod.Hafta).MaximumLength(3).WithMessage("Hafta 3 karakterden cok giremezsin");



            

        }
        
    }
}
