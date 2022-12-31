using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class RequestValidator : AbstractValidator<request>
    {
        public RequestValidator()
        {
            RuleFor(x => x.RequestDescription).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez!");
            RuleFor(x => x.RequestDescription).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz!");
            RuleFor(x => x.RequestRdoBtn).NotEmpty().WithMessage("Buton boş geçilemez!");
        }
    }
}
