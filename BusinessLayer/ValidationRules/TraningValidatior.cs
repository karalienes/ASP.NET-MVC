using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TraningValidatior : AbstractValidator<Traning>
    {
        public TraningValidatior()
        {


            RuleFor(x => x.TraningName).NotEmpty().WithMessage("TraningName boş giremezsin");
            RuleFor(x => x.TraningName).MinimumLength(5).WithMessage("TraningName 5 karakterden az giremezsin.");
            RuleFor(x => x.TraningName).MaximumLength(30).WithMessage("TraningName 30 karakterden cok giremezsin");
           
        }

    }
}
