using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PeriyodValidatior : AbstractValidator<Periyod>
    {
        public PeriyodValidatior()
        {


            RuleFor(x => x.Ay).NotEmpty().WithMessage("Ay boş giremezsin");
            RuleFor(x => x.Ay).MinimumLength(3).WithMessage("Ay 3 karakterden az giremezsin.");
            RuleFor(x => x.Ay).MaximumLength(30).WithMessage("Ay 30 karakterden cok giremezsin");

            RuleFor(x => x.Yıl).NotEmpty().WithMessage("Yıl boş giremezsin");
            RuleFor(x => x.Yıl).MinimumLength(3).WithMessage("Yıl 3 karakterden az giremezsin.");
            RuleFor(x => x.Yıl).MaximumLength(30).WithMessage("Yıl 30 karakterden cok giremezsin");

            RuleFor(x => x.Hafta).NotEmpty().WithMessage("Hafta boş giremezsin");
           // RuleFor(x => x.Hafta).MinimumLength(1).WithMessage("Hafta 1 karakterden az giremezsin.");
            RuleFor(x => x.Hafta).MaximumLength(30).WithMessage("Hafta 30 karakterden cok giremezsin");

            

        }

    }
}
