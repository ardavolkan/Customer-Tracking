using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {    

            //RuleFor(P => P.ProductName).NotEmpty();

            //RuleFor(p => p.UnitPrice).NotEmpty();
            //RuleFor(p => p.UnitPrice).GreaterThan(0);

            //RuleFor(p => p.ProductExplanation).NotEmpty();
            //RuleFor(p => p.ProductExplanation).MaximumLength(50);

            //RuleFor(p => p.ProductBrand).NotEmpty();
            //RuleFor(p => p.ProductBrand).MinimumLength(2);

            //RuleFor(p => p.ProductModel).NotEmpty();           
        }

    }
}
