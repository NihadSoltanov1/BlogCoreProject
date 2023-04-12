using EntityLayer.Concrete;
using FluentValidation;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public  class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotNull().WithMessage("Bu Hisseni Box Buraxmayin.");
            RuleFor(x => x.CategoryDescription).NotNull().WithMessage("Bu Hisseni Box Buraxmayin.");
            
        }
    }
}
