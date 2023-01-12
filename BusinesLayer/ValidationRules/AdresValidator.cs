using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.ValidationRules
{
    public class AdresValidator : AbstractValidator<Adres>
    {
        public AdresValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Aciklamani bos kece bilmezsiniz");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Aciklamani bos kece bilmezsiniz");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Aciklamani bos kece bilmezsiniz");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Aciklamani bos kece bilmezsiniz");
        }
    }
}
