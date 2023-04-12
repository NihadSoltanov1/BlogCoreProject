using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotNull().WithMessage("Bu Hisseni Box Buraxmayin");
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Adınızı Boş Buraxmayın!");   
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mailinizi Boş Buraxmayın!");   
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifrənizi Boş Buraxmayın!");   
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Adınız 2 Simvoldan Çox Olmalıdır.");   
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Adınız 50 Simvoldan Çox Olmamalıdır.");   
            RuleFor(x => x.WriterPassword).MinimumLength(6).WithMessage("Şifrəniz 6 Simvoldan Çox Olmalıdır.");   
        }
    }
}
