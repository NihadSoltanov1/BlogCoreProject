using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotNull().WithMessage("Bu Hisseni Box Buraxmayin.");
            RuleFor(x => x.CategoryID).NotNull().WithMessage("Bu Hisseni Box Buraxmayin.");
            RuleFor(x => x.BlogContent).NotNull().WithMessage("Bu Hisseni Box Buraxmayin.");
        }
    }
}
