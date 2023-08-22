using Core.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Entities.Concrete
{
    public class Customer: IEntity
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? CompanyTitle { get; set; }
        public string? PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
