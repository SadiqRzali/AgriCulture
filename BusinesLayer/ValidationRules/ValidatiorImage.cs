using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.ValidationRules
{
    public class ValidatiorImage : AbstractValidator<Image>
    {
        public ValidatiorImage()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Baslik hissesini bos kece bilmezsiniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Aciklama hissesini bos kece bilmezsiniz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Image hissesini bos kece bilmezsiniz");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Lutfen en fazla 20 karakter girin");
            RuleFor(x => x.Title).MinimumLength(2).WithMessage("Lutfen en az 2 karakter giriniz");
            RuleFor(x => x.Description).MinimumLength(30).WithMessage("Lutfen en cox 30 karakter giriniz");
            RuleFor(x => x.Description).MaximumLength(2).WithMessage("Lutfen en az 2 karakter giriniz");
        }
    }
}
