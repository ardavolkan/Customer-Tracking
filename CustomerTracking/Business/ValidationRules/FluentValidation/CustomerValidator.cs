using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
           
          //  RuleFor(p => p.Email).NotEmpty();
          // // RuleFor(p => p.Email).EmailAddress();

          //  RuleFor(p => p.PhoneNumber).NotEmpty();
          // // RuleFor(p => p.PhoneNumber).MinimumLength(10);
          ////  RuleFor(p => p.PhoneNumber).MaximumLength(11);

          //  RuleFor(p => p.CompanyTitle).NotEmpty();
           
          //  RuleFor(p => p.FirstName).NotEmpty();
          //  RuleFor(p => p.FirstName).MinimumLength(2);
            
          //  RuleFor(p => p.LastName).NotEmpty();
          //  RuleFor(p => p.LastName).MinimumLength(2);
        }

    }
}
