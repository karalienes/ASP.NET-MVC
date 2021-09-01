using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TraningTypeValidatior : AbstractValidator<TraningType>
    {
        public TraningTypeValidatior()
        {


            RuleFor(x => x.TraningTypee).NotEmpty().WithMessage("TraningType boş giremezsin");
            RuleFor(x => x.TraningTypee).MinimumLength(5).WithMessage("TraningType 5 karakterden az giremezsin.");
            RuleFor(x => x.TraningTypee).MaximumLength(30).WithMessage("TraningType 30 karakterden cok giremezsin");

        }

    }
}
