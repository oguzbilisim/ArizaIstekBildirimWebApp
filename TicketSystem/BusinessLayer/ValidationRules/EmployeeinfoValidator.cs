using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class EmployeeinfoValidator: AbstractValidator<employeeinfo>
    {
        public EmployeeinfoValidator()
        {
            RuleFor(x => x.description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez!");
            RuleFor(x => x.name).NotEmpty().WithMessage("Ad Soyad boş geçilemez!");
            RuleFor(x => x.description).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz!");

        }
    }
}
