using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            

            //RuleFor(o => o.LicenseTerm).NotEmpty();

            //RuleFor(o => o.Sellby).NotEmpty();

            //RuleFor(o => o.LicenseCode).NotEmpty();
            //RuleFor(o => o.LicenseCode).GreaterThan(0);

            //RuleFor(o => o.Customer).NotEmpty();
            //RuleFor(o => o.Customer).MinimumLength(2);

            //RuleFor(o => o.Product).NotEmpty();
            //RuleFor(o => o.Product).MinimumLength(2);

        }

    }
}
